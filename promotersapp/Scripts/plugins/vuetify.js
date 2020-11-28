// src/plugins/vuetify.js

import Vue from 'vue'
import Vuetify from 'vuetify'
import 'vuetify/dist/vuetify.min.css'

import colors from 'vuetify/lib/util/colors'

Vue.use(Vuetify)

const opts = {
    theme: { 
        themes: {
            light: {
                primary: colors.blue.lighten1,
                secondary: colors.blue.lighten5,
                accent: '#8c9eff',
                error: '#b71c1c',
            },
            dark: {
                primary: colors.blue.lighten3,
            },
        }    
    }
}

export default new Vuetify(opts)