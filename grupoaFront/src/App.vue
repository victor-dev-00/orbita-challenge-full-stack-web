<template>
  <!-- Main app container -->
  <v-app>
    <!-- Main content area -->
    <v-main>
      <!-- Main navigation drawer -->
      <v-navigation-drawer elevation="2" v-model="drawer" >
        <v-list>
          <!-- Logo -->
          <img src="./assets/grupoa.png" alt="logo escrito grupoa educação" width="200"
            style="margin-left: auto; margin-right: auto; display: block" />
          <!-- Home link -->
          <v-list-item prepend-icon="mdi-home" title="Modulo Academico" link to="/"></v-list-item>
        </v-list>

        <v-divider></v-divider>

        <v-list density="compact" nav>
          <!-- List link -->
          <v-list-item prepend-icon="mdi-account-group" title="Consulta de Alunos" link to="/list"></v-list-item>

          <v-list-item prepend-icon="mdi-account-plus" title="Cadastrar Aluno" link to="/cadastro"></v-list-item>
        </v-list>
      </v-navigation-drawer>

      <!-- Main navigation bar -->
      <v-app-bar app color="primary" >
        <v-app-bar-nav-icon @click="toggleDrawer()"></v-app-bar-nav-icon>
        <v-text class="ml-2"></v-text>
      </v-app-bar>

      <!-- Style for the content -->
      <div style="
          border: 1px solid black;
          height: 100%;
          padding: 10px;
          margin: 10px;
        ">
        <!-- Router view -->
        <router-view></router-view>
      </div>
    </v-main>
  </v-app>
</template>

<script setup>
/**
 * Import necessary Vue modules and define variables
 */

import { ref } from "vue";

/**
 * Define a reactive variable for controlling the drawer visibility
 */
const drawer = ref(true);

/**
 * Toggle the visibility of the drawer
 */
const toggleDrawer = () => {
  drawer.value = !drawer.value;
};
</script>