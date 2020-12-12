<template>
  <v-card width="auto" flat tile>
    <v-toolbar dense color="blue lighten-3">
      <v-toolbar-title>Promotersapp</v-toolbar-title>
      <div class="toolbar-btn pl-4">
        <v-btn depressed dark text> For us </v-btn>
        <v-btn depressed dark text> How it works </v-btn>
        <v-btn depressed dark text> Subscription </v-btn>
      </div>
      <v-spacer />
      <v-btn
        class="mr-4"
        small
        dense
        icon
        @click="$vuetify.theme.dark = !$vuetify.theme.dark"
      >
        <v-icon>mdi-theme-light-dark</v-icon>
      </v-btn>
      <v-btn small color="primary" dark> Login </v-btn>
    </v-toolbar>
  </v-card>
</template>
<style>
.toolbar-btn .v-btn:before {
  display: none;
}
</style>