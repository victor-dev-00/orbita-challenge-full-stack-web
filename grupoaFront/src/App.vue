<template>
  <!-- Main app container -->
  <v-app>
    <!-- Main content area -->
    <v-main>
      
        <v-navigation-drawer>
          <v-list>
            <!-- Logo and title -->
            <v-list-item height="auto">
              <div >
                <!-- Logo image -->
                <img style="display:block; margin-left:auto; margin-right:auto" src="./assets/grupoa.png" alt="" width="150px">
              </div>
              <!-- Title -->
              <v-list-item-title align="center">Modulo Academico</v-list-item-title>
            </v-list-item>
          </v-list>
          <v-divider></v-divider>
          <!-- Navigation link -->
          <v-list-item link="true">
            <router-link to="/list">Alunos</router-link>
          </v-list-item>
        </v-navigation-drawer>
        <!-- App bar -->
        <div style="; margin-top:auto; margin-bottom:auto; height: 50px;">
          <v-app-bar flat="true">
            <v-toolbar-title align="center" ><v-text>Consulta de
                Alunos</v-text></v-toolbar-title>
          </v-app-bar>
        </div>

      <v-divider></v-divider>
        <router-view >
          <!-- Router view -->
          <list />
        </router-view>

    </v-main>
  </v-app>
</template>

<script setup>
/**
 * Import necessary modules and define variables
 **/
import CadastroAlunoVue from "./components/CadastroAluno.vue";
import HomeVue from "./components/Home.vue";
import List from "./components/List.vue";

components: {
  CadastroAlunoVue, // Component for student registration
  HomeVue, // Home component
  List // List component
}




</script>