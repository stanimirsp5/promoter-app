import Vue from 'vue';
import HomeComponent from './home.vue';
import ContactComponent from './contactus.vue';
import AboutComponent from './aboutus.vue';

new Vue({
    el: "#app",
    components: {
        "home-component-home":HomeComponent,
        "contact-component":ContactComponent,
        "about-component":AboutComponent
    }
})