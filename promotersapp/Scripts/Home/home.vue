<template>
  <div id="home1">
    <v-card width="auto" flat tile>
      <v-toolbar dense color="teal lighten-4">
        <v-toolbar-title>testq17 Promotersapp</v-toolbar-title>

        <v-spacer></v-spacer>

        <v-btn icon>
          <v-icon>mdi-magnify</v-icon>
        </v-btn>

        <v-btn icon>
          <v-icon>mdi-heart</v-icon>
        </v-btn>

        <v-switch
          @change="$vuetify.theme.dark = !$vuetify.theme.dark"
          :label="`Dark mode ${$vuetify.theme.dark}`"
        ></v-switch>

        <v-btn icon>
          <v-icon>mdi-dots-vertical</v-icon>
        </v-btn>
      </v-toolbar>
    </v-card>

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
  </div>
</template>
<script>
import findPromoters from "./findPromoters.vue";
import promoterCompany from "./promoterCompany.vue";

export default {
  name: "home-componenst",
  components: {
    "find-promoters": findPromoters,
    "promoter-company": promoterCompany,
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