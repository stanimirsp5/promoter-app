<template>
  <v-main id="inspire">
    <v-app-bar app color="lightgrey" flat>
      <v-container class="py-0 fill-height">
        <v-avatar class="mr-10" color="grey darken-1" size="32"></v-avatar>

        <v-btn v-for="link in links" :key="link" text>
          {{ link }}
        </v-btn>

        <v-spacer></v-spacer>

        <v-responsive max-width="260">
          <v-text-field
            dense
            flat
            hide-details
            rounded
            solo-inverted
          ></v-text-field>
        </v-responsive>
      </v-container>
    </v-app-bar>

    <v-main class="lighten-3">
      <v-container>
        <v-row>
          <v-col>
            <v-sheet min-height="70vh" rounded="lg">
              <!--  -->
            </v-sheet>
          </v-col>
        </v-row>
      </v-container>
    </v-main>
  </v-main>
</template>
<script>
export default {
  name: "search-component",
  data: () => ({
    links: ["Начало", "За нас", "Цени"],
  }),
  methods: {
    GetAxios() {
      return this.$parent.$parent.axios;
    },
  },
};
</script>