<template>
  <v-app>
    <header-bar></header-bar>

    <component v-bind:is="componentName"></component>

    <footer-bar></footer-bar>
  </v-app>
</template>

<script>
import HomeComponent from "./Home/Home";
import SearchComponent from "./Home/Search/search";
import PromoterComponent from "./User/Promoter.vue";
import LoginComponent from "./Account/Login.vue";
import RegisterComponent from "./Account/Register.vue";
import PromoterDashboard from "./User/PromoterDashboard.vue";

import ContactComponent from "./Home/contactus.vue";
import AboutComponent from "./Home/aboutus.vue";

import headerBar from "./widgets/headerBar";
import footerBar from "./widgets/footerBar";

export default {
  name: "price",
  components: {
    "home-component": HomeComponent,
    "search-component": SearchComponent,
    "promoter-component": PromoterComponent,
    "login-component": LoginComponent,
    "register-component": RegisterComponent,
    "dashboard-promoter-component": PromoterDashboard,

    "contact-component": ContactComponent,
    "about-component": AboutComponent,

    "header-bar": headerBar,
    "footer-bar": footerBar,
  },
  props: {
    componentName: {
      type: String,
      default: "no-component",
    },
  },
  data() {
    return {};
  },
  computed: {},
  created() {},
  methods: {},
};
</script>
<style>
</style>