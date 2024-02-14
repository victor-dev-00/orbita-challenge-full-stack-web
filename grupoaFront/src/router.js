import * as Vue from 'vue'
import * as Router from 'vue-router'
import List from './views/List.vue'  // Import the List component
import Register from './views/Register.vue'  // Import the Cadastro  component
import Edit from './views/Edit.vue'  // Import the Cadastro  component

/**
 * Register Vue Router plugins
 * @param {object} app - The Vue application
 */
const registerPlugins = (app) => {
    app.use(Router) // Register the Vue Router
}

/**
 * Create a new Vue Router instance
 */
const routes = [

    {
        path: '/list',
        name: 'list',
        component: List
    },
    {
        path: '/register',
        name: 'register',
        component: Register
    },
    {
        path: '/edit/:id',
        name: 'edit',
        component: Edit
    }
]

const router = Router.createRouter({
    history: Router.createWebHistory(),
    routes
})

/**
 * Export the routes for the Vue Router
 */
export default router;