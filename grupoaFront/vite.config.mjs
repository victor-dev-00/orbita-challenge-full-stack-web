// Import Vite plugins
import Components from 'unplugin-vue-components/vite' // Import the unplugin-vue-components Vite plugin
import Vue from '@vitejs/plugin-vue' // Import the Vite Vue plugin
import Vuetify, { transformAssetUrls } from 'vite-plugin-vuetify' // Import the vite-plugin-vuetify Vuetify plugin
import ViteFonts from 'unplugin-fonts/vite' // Import the unplugin-fonts Vite plugin

// Import Vite utilities
import { defineConfig } from 'vite' // Import the defineConfig function from Vite
import { fileURLToPath, URL } from 'node:url' // Import fileURLToPath and URL from the node:url module

// Export the Vite configuration
export default defineConfig({
  plugins: [
    Vue({
      template: { transformAssetUrls } // Use the transformAssetUrls function in the Vue plugin template
    }),
    Vuetify(), // Initialize the Vuetify plugin
    Components(), // Initialize the Components plugin
    ViteFonts({ // Initialize the ViteFonts plugin with Google fonts
      google: {
        families: [{
          name: 'Roboto', // Set the font family name to Roboto
          styles: 'wght@100;300;400;500;700;900', // Set the font styles
        }],
      },
    }),
  ],
  define: { 'process.env': {} }, // Define an empty process.env object
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url)) // Set the alias for the src directory
    },
    extensions: [
      '.js',
      '.json',
      '.jsx',
      '.mjs',
      '.ts',
      '.tsx',
      '.vue',
    ],
  },
  server: {
    port: 3000, // Set the server port to 3000
  },
})