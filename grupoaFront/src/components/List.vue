<template>
  <v-data-table :headers="headers" :items="alunos" :sort-by="[{ key: 'Nome', order: 'asc' }]" :search="search">
    <template v-slot:top>
      <v-toolbar flat color="white">
        <v-text-field clearable label="Pesquisar Aluno" single-line hide-details="auto" v-model="search"></v-text-field>
        <v-btn color="black-darken-1" dark class="mb-2"><v-icon>mdi-magnify</v-icon>Pesquisar</v-btn>

        <v-dialog v-model="dialog" max-width="500px">
          <template v-slot:activator="{ props }">
            <v-btn color="green-darken-1" dark class="mb-2" v-bind="props">
              <v-icon>mdi-plus-thick</v-icon> Cadastrar Aluno
            </v-btn>
          </template>
          <v-card>
            <v-card-title>
              <span class="text-h5">{{ formTitle }}</span>
            </v-card-title>

            <v-card-text>
              <v-container>
                <v-row>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.registroAcademico" label="Registro Academico"></v-text-field>
                  </v-col>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.nome" label="Nome"></v-text-field>
                  </v-col>
                  <v-col cols="12" sm="6" md="4">
                    <v-text-field v-model="editedItem.cpf" label="CPF"></v-text-field>
                  </v-col>
                </v-row>
              </v-container>
            </v-card-text>

            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="blue-darken-1" variant="text" @click="close">
                Cancel
              </v-btn>
              <v-btn color="blue-darken-1" variant="text" @click="save">
                Save
              </v-btn>
            </v-card-actions>
          </v-card>
        </v-dialog>

        <v-dialog v-model="dialogDelete" max-width="500px">
          <v-card>
            <v-card-title class="text-h5">Are you sure you want to delete this item?</v-card-title>
            <v-card-actions>
              <v-spacer></v-spacer>
              <v-btn color="primary" variant="text" @click="closeDelete">Cancel</v-btn>
              <v-btn color="red-darken-1" variant="text" @click="deleteItemConfirm">OK</v-btn>
              <v-spacer></v-spacer>
            </v-card-actions>
          </v-card>
        </v-dialog>
      </v-toolbar>
    </template>
    <template v-slot:item.actions="{ item }">
      <v-icon size="small" class="me-2" @click="editItem(item)" color="primary">
        mdi-pencil
      </v-icon>
      <v-icon size="small" @click="deleteItem(item)" color="red-darken-1"> mdi-delete </v-icon>
    </template>
    <template v-slot:no-data>
      <v-btn color="primary" @click="initialize"> Reset </v-btn>
    </template>
  </v-data-table>
</template>

<script>
export default {
  name: "List",
  data: () => ({
    dialog: false,
    dialogDelete: false,
    headers: [
      {
        title: "Registro Academico",
        align: "start",
        sortable: false,
        key: "registroAcademico",
      },
      { title: "Nome", key: "Nome" },
      { title: "CPF", key: "CPF" },
      { title: "Actions", key: "actions", sortable: false },
    ],
    alunos: [],
    editedIndex: -1,
    editedItem: {
      registroAcademico: 0,
      Nome: "",
      CPF: "",
    },
    defaultItem: {
      registroAcademico: 0,
      Nome: "",
      CPF: 0,
    },
  }),

  computed: {
    formTitle() {
      return this.editedIndex === -1 ? "New Item" : "Edit Item";
    },
  },

  watch: {
    dialog(val) {
      val || this.close();
    },
    dialogDelete(val) {
      val || this.closeDelete();
    },
  },

  created() {
    this.initialize();
  },

  methods: {
    initialize() {
      this.alunos = [
        {
          registroAcademico: 1,
          Nome: "Frozen Yogurt",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico: 237,
          Nome: "Ice cream sandwich",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico: 54,
          Nome: "Eclair",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico: 305,
          Nome: "Cupcake",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico: 356,
          Nome: "Gingerbread",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico: 375 ,
          Nome: "Jelly bean",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico: 309,
          Nome: "Lollipop",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico: 408 ,
          Nome: "Honeycomb",
          CPF: "000.000.000-00",
        },
        {
          registroAcademico:493 ,
          Nome: "Donut",
          CPF: " 000.000.000-00",
        },
        {
          registroAcademico: 518,
          Nome: "KitKat",
          CPF:  "000.000.000-00",
        },
      ];
    },

    editItem(item) {
      this.editedIndex = this.alunos.indexOf(item);
      this.editedItem = Object.assign({}, item);
      this.dialog = true;
    },

    deleteItem(item) {
      this.editedIndex = this.alunos.indexOf(item);
      this.editedItem = Object.assign({}, item);
      this.dialogDelete = true;
    },

    deleteItemConfirm() {
      this.alunos.splice(this.editedIndex, 1);
      this.closeDelete();
    },

    close() {
      this.dialog = false;
      this.$nextTick(() => {
        this.editedItem = Object.assign({}, this.defaultItem);
        this.editedIndex = -1;
      });
    },

    closeDelete() {
      this.dialogDelete = false;
      this.$nextTick(() => {
        this.editedItem = Object.assign({}, this.defaultItem);
        this.editedIndex = -1;
      });
    },

    save() {
      if (this.editedIndex > -1) {
        Object.assign(this.alunos[this.editedIndex], this.editedItem);
      } else {
        this.alunos.push(this.editedItem);
      }
      this.close();
    },
  },
};
</script>

<style></style>