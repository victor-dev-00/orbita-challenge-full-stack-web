import * as Vue from 'vue'
import * as Router from 'vue-router'
import List from './components/List.vue'  // Import the List component
import Home from './components/Home.vue'  // Import the Home component
import CadastroAluno from './components/CadastroAluno.vue'  // Import the CadastroAluno component

const app = Vue.createApp({})

/**
 * Create a new Vue Router instance
 */
app.use(Router)

/**
 * Export the routes for the Vue Router
 */
export default ({
    routes: [
        {
            path: '/',  // Define the path for the Home component
            name: 'Home',  // Define the name for the Home component
            component: Home  // Set the Home component as the route component
        },
        {
            path: '/list',  // Define the path for the List component
            name: 'List',  // Define the name for the List component
            component: List  // Set the List component as the route component
        },
        {
            path: '/cadastro',  // Define the path for the CadastroAluno component
            name: 'CadastroAluno',  // Define the name for the CadastroAluno component
            component: CadastroAluno  // Set the CadastroAluno component as the route component
        }
    ],
    
})