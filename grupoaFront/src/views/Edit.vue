<template>

<v-text align="center">
    <h1>Editar Aluno</h1> <!-- Display the route name in uppercase -->
  </v-text>

  <v-form>
    <v-text-field v-model="name" :counter="10" label="Name" required ></v-text-field>
    <v-text-field v-model="email" label="E-mail" required ></v-text-field>
    <v-text-field v-model="RA" label="RA" required ></v-text-field>
    <v-text-field v-model="CPF" label="CPF" required ></v-text-field>
  </v-form>
  <v-btn color="success" class="mr-4" @click="submit">
    Salvar
  </v-btn>
  <v-btn color="red" class="mr-4" to="/list">
    Cancelar
  </v-btn>

  
  <v-dialog v-model="alert" max-width="300">
    <v-card color="green" width="300">
      <!-- Display an alert message -->
      <h3>Salvo com sucesso! <v-icon>mdi-check</v-icon></h3>
    </v-card>
  </v-dialog>
</template>

<script>
import axios from 'axios'
export default {
name: 'Edit',
data() {
    return {
        name: '',
        email: '',
        RA: '',
        CPF: '',
        alert: false
    }
},
methods: {
    fetchItem() {
        const ra = this.$route.params.id
        axios.get(`http://localhost:5089/api/estudante/${ra}`).then((response) => {
            this.name = response.data.name
            this.email = response.data.email
            this.CPF = response.data.cpf
        })
    },

    saved() {
      this.alert = true;
      console.log("Cadastrado com sucesso");
    },
    submit() {
        this.saved()
        const ra = this.$route.params.id
        axios.put(`http://localhost:5089/api/estudante/${ra}`, {
            name: this.name,
            email: this.email,
        }).then(() => {
            setTimeout(() => {
                this.$router.push({ path: '/list' })
            },3000)
        })
    }
},
mounted() {
    this.fetchItem()
}
}
</script>

<style>

</style>