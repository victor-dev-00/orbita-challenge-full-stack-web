<template>
  <!-- Data table component with headers and items -->
  <v-data-table :headers="headers" :items="items">
    <template v-slot:top>
      <!-- Toolbar with a button to open a dialog -->
      <v-toolbar flat>
        <v-spacer></v-spacer>
        <v-btn to="/register" color="primary">Cadastro de Aluno</v-btn>
        <v-dialog v-model="dialogDelete" max-width="500px">
          <v-card>
            <v-card-title class="text-h5"
              >Are you sure you want to delete this item?</v-card-title
            >
            <v-card-actions>
              <v-spacer></v-spacer>
              <!-- Buttons for canceling or confirming item deletion -->
              <v-btn color="blue-darken-1" variant="text" @click="closeDelete"
                >Cancel</v-btn
              >
              <v-btn
                color="blue-darken-1"
                variant="text"
                @click="deleteItemConfirm"
                >OK</v-btn
              >
              <v-spacer></v-spacer>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
    </template>
    <template v-slot:item.actions="{ item }">
      <!-- Icons for editing and deleting items -->
      <v-icon class="me-2" @click="$router.push(`/edit/${item.ra}`)" color="primary">
        mdi-pencil
      </v-icon>
      <v-icon @click="openDelete(item)" color="red"> mdi-delete </v-icon>
    </template>
  </v-data-table>


</template>

<script>
import axios from "axios";
export default {
  name: "List",
  data() {
    return {
      dialogDelete: false,
      headers: [
        { title: 'Ra',key: 'ra',},
        { title: 'Nome', key: 'name' },
        { title: 'Cpf', key: 'cpf' },
        { title: 'Ações', key: 'actions', sortable: false },
      ],
      items: [],
      editedIndex: -1,
      editedItem: {
        ra: "",
        name: "",
        email: "",
        CPF: "",
      },
    };
  },
  methods: {
    // Fetch items from the API
    fetchItems() {
      axios.get("http://localhost:5089/api/estudantes").then((response) => {
        this.items = response.data;
      });
    },
    
    deleteItem(ra) {
      axios.delete(`http://localhost:5089/api/estudante/${ra}`);
    },
    initialize() {
      this.fetchItems();
    },
    // Open the delete dialog
    openDelete(item) {
      this.editedIndex = this.items.indexOf(item);
      this.editedItem = Object.assign({}, item);
      this.dialogDelete = true;
    },
    // Close the delete dialog
    closeDelete() {
      this.dialogDelete = false;
      this.$nextTick(() => {
        this.editedItem = Object.assign({}, this.defaultItem);
        this.editedIndex = -1;
        this.initialize();
      })
    },

    // Confirm the deletion of an item
    deleteItemConfirm() {
      this.closeDelete();
      this.deleteItem(this.editedItem.ra);  

      this.editedIndex = -1;
      this.editedItem = Object.assign({}, this.defaultItem);
      this.initialize();
    },


  },
  mounted() {
    this.initialize();
  },
};
</script>