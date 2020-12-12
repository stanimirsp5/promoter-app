<template>
  <v-main id="inspire">
    <v-app-bar app color="lightgrey" flat>
      <v-container class="py-0 fill-height">
        <v-avatar class="mr-10" color="grey darken-1" size="32"></v-avatar>

        <v-btn v-for="link in links" :key="link" text>
          {{ link }}
        </v-btn>

        <!-- <v-spacer></v-spacer>

        <v-responsive max-width="260">
          <v-text-field
            dense
            flat
            hide-details
            rounded
            solo-inverted
          ></v-text-field> -->
        <!-- </v-responsive> -->
      </v-container>
    </v-app-bar>

    <v-main class="lighten-3">
      <v-container>
        <v-sheet>
          <v-row>
            <v-col cols="12">
              <h2 class="text--primary">Търсене за:</h2>
            </v-col>
          </v-row>
          <v-row>
            <!-- Select City: -->
            <v-col cols="12" md="3">
              <v-select
                v-model="citySelect"
                :hint="`${citySelect.cityName}`"
                :items="cities"
                item-text="cityName"
                item-value="id"
                label="Select"
                persistent-hint
                return-object
                single-line
              ></v-select>
            </v-col>
            <v-spacer></v-spacer>
            <!-- Select date: -->
            <v-col cols="12" md="3">
              <v-menu
                v-model="menuSelectDate"
                :close-on-content-click="false"
                transition="scale-transition"
              >
                <template v-slot:activator="{ on, attrs }">
                  <v-text-field
                    v-model="date"
                    readonly
                    v-bind="attrs"
                    v-on="on"
                  ></v-text-field>
                </template>
                <v-date-picker
                  v-model="date"
                  @input="menuSelectDate = false"
                ></v-date-picker>
              </v-menu>
            </v-col>
            <v-spacer></v-spacer>
            <!-- Select time - From: -->
            <!-- 12 mob., 3 after md breakpoint -->
            <v-col cols="12" md="3">
              <v-row>
                <v-col cols="12" md="6" class="py-0">
                  <v-menu
                    ref="menuFromHR"
                    v-model="menuFromHR"
                    :close-on-content-click="false"
                    :return-value.sync="timeFromHR"
                    transition="scale-transition"
                    max-width="290px"
                    min-width="290px"
                  >
                    <template v-slot:activator="{ on, attrs }">
                      <v-text-field
                        v-model="timeFromHR"
                        label="Промоцията започва от"
                        readonly
                        v-bind="attrs"
                        v-on="on"
                      ></v-text-field>
                    </template>
                    <v-time-picker
                      format="24hr"
                      v-if="menuFromHR"
                      v-model="timeFromHR"
                      full-width
                      @click:minute="$refs.menuFromHR.save(timeFromHR)"
                    ></v-time-picker>
                  </v-menu>
                </v-col>
                <!-- Select time - To: -->
                <v-col cols="12" md="6" class="py-0">
                  <v-menu
                    ref="menuToHR"
                    v-model="menuToHR"
                    :close-on-content-click="false"
                    :return-value.sync="timeToHR"
                    transition="scale-transition"
                    max-width="290px"
                    min-width="290px"
                  >
                    <template v-slot:activator="{ on, attrs }">
                      <v-text-field
                        v-model="timeToHR"
                        label="Промоцията завършва до"
                        readonly
                        v-bind="attrs"
                        v-on="on"
                      ></v-text-field>
                    </template>
                    <v-time-picker
                      format="24hr"
                      v-if="menuToHR"
                      v-model="timeToHR"
                      full-width
                      @click:minute="$refs.menuToHR.save(timeToHR)"
                    ></v-time-picker>
                  </v-menu>
                </v-col>
              </v-row>
            </v-col>
            <v-spacer></v-spacer>
            <!-- Submit Query: -->
            <v-col cols="12" md="3">
              <v-btn depressed block color="primary" v-on:click="findPromoter">
                Търси
              </v-btn>
            </v-col>
          </v-row>
          <!-- Additional Filters -->
          <v-row>
            <v-col cols="12">
              <h4 class="text--secondary">Допълнителни изисквания:</h4>
            </v-col>
          </v-row>
          <!-- Filters: -->
          <v-row>
            <v-col cols="12" md="3">
              <v-checkbox
                v-model="healthInsurance"
                :label="`Здравна книжка`"
              ></v-checkbox>
            </v-col>
            <v-col cols="12" md="3">
              <v-checkbox
                v-model="personalCar"
                :label="`Личен автомобил`"
              ></v-checkbox>
            </v-col>
            <v-col cols="12" md="3">
              <v-select
                :items="['Мъж', 'Жена']"
                label="Изберете пол"
              ></v-select>
            </v-col>
            <v-col cols="12" md="3">
              <v-combobox
                v-model="languageSelect"
                :items="languages"
                label="Говорими езици"
                multiple
                outlined
              ></v-combobox>
            </v-col>
          </v-row>
        </v-sheet>
      </v-container>

      <v-container v-if="promotersList">
        <h4 class="text--secondary">Намерени:</h4>
        <template v-for="promoter in promotersList">
          <promoter-card
            :promoter="promoter"
            :key="promoter.id"
          ></promoter-card>
        </template>
      </v-container>
    </v-main>
  </v-main>
</template>
<script>
import promoterCard from "./Search/promoterCard";
import PromoterCard from "./Search/promoterCard.vue";
export default {
  name: "search-component",
  components: {
    "promoter-card": promoterCard,
  },
  data: () => ({
    // Form Data:
    timeFromHR: null,
    menuFromHR: false,
    timeToHR: null,
    menuToHR: false,
    date: new Date().toISOString().substr(0, 10),
    menuSelectDate: null,
    links: ["Начало", "За нас", "Цени"],
    // Filters:
    healthInsurance: false,
    personalCar: false,
    languageSelect: [],
    promotersList: null,
    cities: [],
    citySelect: { cityName: "Батановци", id: 15 },
    languages: ["Английски", "Немски", "Испански", "Руски"],
  }),
  created() {
    this.getCities();
  },
  methods: {
    GetAxios() {
      return this.$parent.$parent.axios;
    },
    getCities() {
      this.$axios
        .get("/Search/GetCities", null)
        .then((res) => {
          this.cities = res.data;
        })
        .catch((err) => {
          console.log(err);
        });
    },
    findPromoter() {
      this.promotersList = [];
      var parsedobj = JSON.parse(JSON.stringify(this.citySelect));
      this.$axios
        .get("/Search/FindPromoter", { params: { cityID: parsedobj.id } })
        .then((res) => {
          this.promotersList = res.data.map((p) =>
            Object.assign(p, { city: parsedobj.cityName })
          );
        })
        .catch((err) => {
          console.log(err);
        });
    },
  },
};
</script>