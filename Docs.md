# Documentação da Arquitetura de Solução - Modelo MVC

> ### Visão Geral
> - O sistema Acadêmico eletrônico utiliza a arquitetura Modelo-Visão-Controle (MVC) para separar as preocupações de apresentação, lógica de negócios e manipulação de dados.

> ### Requisitos
   > Funcionais:
   > - Cadastro de Alunos
   > - Edição de Alunos
   > - Atualização de Alunos

> ### Arquitetura MVC
> - Model:
>   - Student
> - Views:
>   - Interface do Usuário (Vue)
> - Controle:
>   - StudentController
> - Tecnologias
>   - Vue (View)
>   - C# (Controladores e Modelos)
>   - MySql (Banco de Dados)
> - Modelo de Dados
>   - Students: Ra, Nome, Email, Cpf.

![MVC](/diagram.png)