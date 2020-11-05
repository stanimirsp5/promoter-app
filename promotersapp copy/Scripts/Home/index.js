import Vue from 'vue';
import HomeComponent from './home.vue';
import ContaCtomponent from './contact.vue';
import AboutComponent from './about.vue';

new Vue({
    el: "app",
    components: {
        "home-component" : HomeComponent,
        "conta-ctomponent":ContaCtomponent,
        "about-component":AboutComponent
    }
})