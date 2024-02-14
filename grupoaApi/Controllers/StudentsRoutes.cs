using grupoaApi.Context;
using Microsoft.EntityFrameworkCore;


public static class StudentsRoutes
{
    public static void Student(this WebApplication app)
    {
        // This endpoint adds a new student to the database
        app.MapPost("api/estudantes", async (Student student, AppDbContext dbContext) =>
        {
            // Add the student object to the dbContext
            dbContext.Add(student);
            // Asynchronously save the changes made to the dbContext
            await dbContext.SaveChangesAsync();
            // Return a 201 Created status code along with the URL of the created resource and the student object
            return Results.Created($"api/estudantes/{student.Ra}", student);
        });

        // Endpoint for retrieving all students
        app.MapGet("api/estudantes", async (AppDbContext dbContext) =>
            await dbContext.Students.ToListAsync());

        // MapGet method to handle GET requests for "/estudantes/{ra}"
        app.MapGet("api/estudante/{ra}", async (int ra, AppDbContext dbContext) =>
        {
            // Asynchronously find a student with the given registration number in the database
            var student = await dbContext.Students.FindAsync(ra);

            // If a student with the given registration number is found, return OK with the student object
            // Otherwise, return a 404 Not Found result
            return student is Student ? Results.Ok(student) : Results.NotFound();
        });

        // Delete endpoint for deleting a student by their registration number
        app.MapDelete("api/estudante/{ra}", async (int ra, AppDbContext dbContext) =>
        {
            // Find the student by registration number
            var student = await dbContext.Students.FindAsync(ra);
            // If the student exists
            if (student is not null)
            {
                // Remove the student from the database
                dbContext.Students.Remove(student);
                // Save changes to the database
                await dbContext.SaveChangesAsync();
                // Return a successful response with the deleted student
                return Results.Ok(student);
            }
            // If the student does not exist, return a not found response
            return Results.NotFound();
        });

        // This endpoint updates a student by their registration number
        app.MapPut("api/estudante/{ra}", async (int ra, Student student, AppDbContext dbContext) =>
        {
            // Find the student by registration number
            var existingStudent = await dbContext.Students.FindAsync(ra);
            // If the student exists
            if (existingStudent is not null)
            {
                // Update the student with the new information
                existingStudent.Email = student.Email;
                existingStudent.Name = student.Name;
                // Save changes to the database
                await dbContext.SaveChangesAsync();
                // Return a successful response with the updated student
                return Results.Ok(existingStudent);
            }
            // If the student does not exist, return a not found response
            return Results.NotFound();
        });
    }
}
