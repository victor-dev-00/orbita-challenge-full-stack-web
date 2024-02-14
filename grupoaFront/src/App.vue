<template>
  <!-- Main app container -->
  <v-app>
    <!-- Main content area -->
    <v-main>
      <!-- Main navigation drawer -->
      <v-navigation-drawer elevation="2" v-model="drawer">
        <v-list>
          <!-- Logo -->
          <img
            src="./assets/grupoa.png"
            alt="logo escrito grupoa educação"
            width="200"
            style="margin-left: auto; margin-right: auto; display: block"
          />
          <!-- Home link -->
        </v-list>

        <v-divider></v-divider>

        <v-list density="compact" nav>
          <!-- List link -->
          <v-list-item
            prepend-icon="mdi-account-group"
            title="Consulta de Alunos"
            link
            to="/list"
          ></v-list-item>
        </v-list>
      </v-navigation-drawer>

      <!-- Main navigation bar -->
      <v-app-bar app color="primary">
        <v-app-bar-nav-icon @click="toggleDrawer()"></v-app-bar-nav-icon>

        <v-toolbar-title align="center"
          >Órbita challenge full stack web 😎</v-toolbar-title
        >
      </v-app-bar>

      <!-- Style for the content -->
      <div

      >
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