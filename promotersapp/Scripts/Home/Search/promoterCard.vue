<template>
  <v-row>
    <v-col>
      <!-- <h3>{{ promoter.firstName }}</h3> -->
      <v-card>
        <v-card-title>
          {{ promoter.firstName }} {{ promoter.surname }}
        </v-card-title>
        <v-card-subtitle>
          Пол, {{ _calculateAge(new Date(promoter.dateOfBirth)) }} Години
        </v-card-subtitle>
        <v-card-text>
          <v-row>
            <v-col cols="12" md="6">
              <p class="font-weight-regular">Град:</p>
              <p class="font-weight-bold">
                {{ promoter.city }}
              </p>
            </v-col>
          </v-row>
        </v-card-text>
        <v-card-actions>
          <v-btn color="primary" text @click="showDetails"> Детайли </v-btn>
        </v-card-actions>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
export default {
  name: "promoter-card",
  props: {
    promoter: Object,
  },
  components: {},
  data() {
    return {};
  },
  computed: {},
  created() {},
  methods: {
    showDetails() {
      console.info("Show details");
    },
    _calculateAge(birthday) {
      var ageDifMs = Date.now() - birthday.getTime();
      var ageDate = new Date(ageDifMs); // miliseconds from epoch
      return Math.abs(ageDate.getUTCFullYear() - 1970);
    },
  },
};
</script>

<style>
</style>