import axios from 'axios';
import Vue from 'vue';
import vuetify from '../plugins/vuetify'

import HomeComponent from './home.vue';
import ContactComponent from './contactus.vue';
import AboutComponent from './aboutus.vue';

const opts = {}


new Vue({
    vuetify,
    //el: "#app",
    data: {
        message: "Test Vue test",
        axios: axios
    },
    components: {
        "home-component-home":HomeComponent,
        "contact-component":ContactComponent,
        "about-component":AboutComponent
    }
}).$mount('#app')