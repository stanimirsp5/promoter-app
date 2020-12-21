<template>
  <v-row>
    <v-col cols="12" lg="6">
      <v-card class="pl-2" elevation="0" width="auto">
        <v-list-item three-line>
          <v-list-item-content>
            <v-list-item-title
              class="headline font-weight-medium textColor--text"
            >
              Made for promoters
            </v-list-item-title>
            <v-list-item-title
              class="headline font-weight-medium textColor--text"
            >
              - 4 easy steps
            </v-list-item-title>
            <span class="pt-3 textColor--text">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc
              sapien quam, pretium sed interdum quis, elementum quis nibh.
              Vivamus sodales elit lacinia magna dignissim aliquam Lorem ipsum
              dolor sit amet, consectetur adipiscing elit. Nunc sapien quam,
              pretium sed interdum quis, elementum quis nibh. Vivamus sodales
              elit lacinia magna dignissim aliquam
            </span>
          </v-list-item-content>
        </v-list-item>
        <v-card-actions>
          <v-btn class="ml-1" depressed dense color="primary">
            Become promoter
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-col>
    <v-col cols="12" lg="6">
      <v-row>
        <v-col
          v-for="(item, index) in cards"
          :key="index"
          cols="12"
          lg="6"
          md="6"
          sm="6"
        >
          <v-card align="center" elevation="0" color="secondary" width="auto">
            <v-list-item-avatar
              tile
              size="40"
              class="rounded-circle"
              color="primary"
            ></v-list-item-avatar>
            <v-list-item three-line>
              <v-list-item-content>
                <v-list-item-title
                  class="font-weight-medium text-lg-h6 text-md-h6 text-sm-h6 textColor--text"
                >
                  {{ item.title }}
                </v-list-item-title>
                <span class="pt-3 textColor--text">
                  {{ item.body }}
                </span>
              </v-list-item-content>
            </v-list-item>
          </v-card>
        </v-col>
      </v-row>
    </v-col>
  </v-row>
</template>
<script>
export default {
  name: "promoter-component",
  components: {},
  data() {
    return {
      cards: [
        {
          title: "Make your account",
          body:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nuncsapien quam, pretium sed interdum quis, elementum quis nibh.",
        },
        {
          title: "Introduce yourself",
          body:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nuncsapien quam, pretium sed interdum quis, elementum quis nibh.",
        },
        {
          title: "Мake a work schedule",
          body:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nuncsapien quam, pretium sed interdum quis, elementum quis nibh.",
        },
        {
          title: "Receive inquiries",
          body:
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nuncsapien quam, pretium sed interdum quis, elementum quis nibh.",
        },
      ],
    };
  },
  computed: {},
  created() {},
  methods: {},
};
</script>
<style>
</style>