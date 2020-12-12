import axios from 'axios';
import Vue from 'vue';
import vuetify from '../plugins/vuetify'

import App from '../App.vue';
const opts = {}


new Vue({
    vuetify,
    data: {
        message: "Test Vue test",
        axios: axios
    },
    components: {
        "app-component": App,
    },
    created() {
       Vue.prototype.$axios = this.axios;
    }

}).$mount('#app')