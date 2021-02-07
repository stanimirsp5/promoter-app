<template>
  <v-expansion-panel class="my-3">
    <v-expansion-panel-header>
      <v-container>
        <v-row align="center" class="spacer" no-gutters>
          <v-col cols="12" md="6" class="d-flex align-center mb-6">
            <v-avatar rounded size="62" color="primary" class="pa-4">
              <span class="white--text headline">
                {{ promoter.firstName[0] }}{{ promoter.surname[0] }}
              </span>
            </v-avatar>
            <div class="mx-4 my-0 d-flex flex-column justify-center">
              <h3 class="mb-4">
                  {{ promoter.firstName }} {{ promoter.surname }}
              </h3>
              <p class="text--secondary ma-0">
                {{ calculateAge(new Date(promoter.dateOfBirth)) }} Години
              </p>
            </div>
          </v-col>
        </v-row>

        <v-row>
          <v-col cols="12" md="3">
            <p class="font-weight-regular">Град:</p>
            <p class="font-weight-bold">
              {{ promoter.city }}
            </p>
          </v-col>
          <v-col cols="12" md="3">
            <p class="font-weight-regular">Езици:</p>
            <p class="font-weight-bold">
              {{ getKnownLangauges() }}
            </p>
          </v-col>
          <v-col cols="12" md="3">
            <p class="font-weight-regular">Личен автомобил:</p>
            <p class="font-weight-bold">
              {{ getPerks("Шофьорска книжка") ? "Да" : "Не" }}
            </p>
          </v-col>
          <v-col cols="12" md="3">
            <p class="font-weight-regular">Здравна книжка:</p>
            <p class="font-weight-bold">
              {{ getPerks("Здравна книжка") ? "Да" : "Не" }}
            </p>
          </v-col>
        </v-row>
      </v-container>

      <template v-slot:actions>
        <v-btn color="primary" text> Детайли </v-btn>
      </template>
    </v-expansion-panel-header>
    <v-expansion-panel-content>
      <v-card-text>
        <promoter-details></promoter-details>
      </v-card-text>
    </v-expansion-panel-content>
  </v-expansion-panel>
</template>

<script>
import promoterDetails from "./promoterDetails";
export default {
  name: "promoter-card",
  props: {
    promoter: Object,
  },
  components: {
    "promoter-details": promoterDetails
  },
  data() {
    return {};
  },
  computed: {},
  created() {},
  methods: {
    showDetails() {
      console.info("Show details");
    },
    getPerks(perkType) {
      let perks = this.promoter.perks;
      return (
        !!perks.length &&
        !!perks.filter((perk) => perk.perkName === perkType).length
      );
    },
    getKnownLangauges() {
      let personalDetails = this.promoter.personalDetails[0];
      if (personalDetails) {
        let motherLanguage = `${personalDetails.motherLanguage} |` || "";
        let flt = ["Английски", "Френски"];
        let foreignLanguages = personalDetails.foreignLanguages
          ? personalDetails.foreignLanguages.reduce(
              (acc, val) => (acc += ` | ${val}`),
              ""
            )
          : "";

        return `${motherLanguage}${foreignLanguages}`;
      } else {
        return "Няма данни";
      }
    },
    calculateAge(birthday) {
      let ageDifMs = Date.now() - birthday.getTime();
      let ageDate = new Date(ageDifMs); // miliseconds from epoch
      return Math.abs(ageDate.getUTCFullYear() - 1970);
    },
  },
};
</script>

<style>
</style>