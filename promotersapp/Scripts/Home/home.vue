<template>
  <div id="home1">
    <v-container>
      <v-row dense class="px-4">
        <v-col cols="12">
          <find-promoters></find-promoters>
        </v-col>
      </v-row>

      <v-row dense class="px-4">
        <v-col cols="12">
          <promoter-company></promoter-company>
        </v-col>
      </v-row>

      <v-row dense class="px-4">
        <v-col cols="12">
          <companies></companies>
        </v-col>
      </v-row>

      <v-row dense class="px-4">
        <v-col cols="12">
          <price></price>
        </v-col>
      </v-row>
    </v-container>
  </div>
</template>
<script>
import findPromoters from "./findPromoters.vue";
import promoterCompany from "./promoterCompany.vue";
import companies from "./companies.vue";
import price from "./price.vue";

export default {
  name: "home-componenst",
  components: {
    "find-promoters": findPromoters,
    "promoter-company": promoterCompany,
    companies: companies,
    price: price,
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