/**
 * main.js
 *
 * Bootstraps Vuetify and other plugins then mounts the App`
 */

// Plugins
import { registerPlugins } from '@/plugins'
// Components
import App from './App.vue'

// Composables
import { createApp } from 'vue'
import * as router from './router.js'
import VueResource from 'vue-resource'




const app = createApp(App)



registerPlugins(app)

app.use(router)
app.mount('#app')
