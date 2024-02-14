<template>
  <!-- Main template for the Cadastro component -->
  <v-text align="center">
    <h1>Cadastro de Aluno</h1>
    <!-- Display the route name in uppercase -->
  </v-text>

  <form>
    <v-text-field
      v-model="name"
      :counter="10"
      label="Name"
      required
    ></v-text-field>
    <!-- Input for user's name -->

    <v-text-field v-model="email" label="E-mail" required></v-text-field>

    <!-- Input for user's academic registration -->
    <v-text-field
      v-model="registroAcademico"
      label="RA"
      required
    ></v-text-field>

    <!-- Input for user's CPF -->
    <v-text-field v-model="CPF" label="CPF" required> </v-text-field>

    <!-- Button to submit the form -->
    <v-btn color="success" class="mr-4" @click="submit"> Salvar </v-btn>

    <!-- Button to clear the form and go to the list route -->
    <v-btn color="red" class="mr-4" to="/list"> Cancelar </v-btn>
  </form>

  <v-dialog v-model="alert" max-width="300">
    <v-card color="green" width="300">
      <!-- Display an alert message -->
      <h3>Salvo com sucesso! <v-icon>mdi-check</v-icon></h3>
    </v-card>
  </v-dialog>

</template>


<script>
// Importing axios
import axios from "axios";

export default {
  name: "Cadastro", // Component name
  data() {
    return {
      name: "", // User's name
      email: "", // User's email
      RA: "", // User's academic registration
      CPF: "", // User's CPF
      items: [], // List of items
      alert: false,
    };
  },
  methods: {
    saved() {
      this.alert = true;
      console.log("Cadastrado com sucesso");
    },

    /**
     * Function to submit the form
     */
    submit() {
      // Display an alert message
      this.saved();
      axios
        .post("http://localhost:5089/api/estudantes", {
          name: this.name,
          email: this.email,
          RA: this.ra,
          CPF: this.CPF,
        }).then(() => {
          setTimeout(() => {
            this.$router.push({ path: "/list" });
          },3000)
        })
    },
  },
};
</script>

<style>
</style>