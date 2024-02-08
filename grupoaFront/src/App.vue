<template>
  <!-- Main app container -->
  <v-app>
    <!-- Main content area -->
    <v-main>
      
        <v-navigation-drawer>
          <v-list>
            <v-list-item height="auto">
              <div >
                <img style="display:block; margin-left:auto; margin-right:auto" src="./assets/grupoa.png" alt="" width="150px">
              </div>
              <v-list-item-title align="center">Modulo Academico</v-list-item-title>
            </v-list-item>
          </v-list>
          <v-divider></v-divider>
          <v-list-item link="true">
            Alunos
          </v-list-item>
        </v-navigation-drawer>
        <div style="; margin-top:auto; margin-bottom:auto; height: 50px;">
          <v-app-bar flat="true">
            <v-toolbar-title align="center" ><v-text>Consulta de
                Alunos</v-text></v-toolbar-title>
          </v-app-bar>
        </div>

      <v-divider></v-divider>
      <List />
    </v-main>
  </v-app>
</template>

<script setup>
/**
 * Import necessary modules and define variables
 **/
import List from "./components/List.vue";

components: {
  List
}
computed: [{
  title() {
    return this.$route.name
  }
}]
</script>