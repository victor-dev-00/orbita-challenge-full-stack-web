import * as Vue from 'vue'
import * as Router from 'vue-router'
import List from './views/List.vue'  // Import the List component
import Home from './views/Home.vue'  // Import the Home component
import Cadastro from './views/Cadastro.vue'  // Import the Cadastro  component

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
        path: '/',
        name: 'home',
        component: Home
    },
    {
        path: '/list',
        name: 'list',
        component: List
    },
    {
        path: '/cadastro',
        name: 'cadastro',
        component: Cadastro
    },
]

const router = Router.createRouter({
    history: Router.createWebHistory(),
    routes
})

/**
 * Export the routes for the Vue Router
 */
export default router;