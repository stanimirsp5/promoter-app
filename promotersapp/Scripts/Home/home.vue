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
        <v-card width="auto" outlined color="secondary">
          <v-row>
            <v-col class="mx-3" cols="9" lg="5" md="7">
              <v-list-item three-line>
                <v-list-item-content>
                  <v-list-item-title class="headline mb-1" color="secondary">
                    Find promoters
                  </v-list-item-title>
                  <span>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                    Nunc sapien quam, pretium sed interdum quis, elementum quis
                    nibh. Vivamus sodales elit lacinia magna dignissim aliquam
                  </span>
                </v-list-item-content>
              </v-list-item>
            </v-col>
          </v-row>

          <v-row>
            <v-col cols="12" lg="7" md="9">
              <v-card-actions
                id="card-action-border"
                class="mx-6 mb-6"
                width="auto"
              >
                <!-- <v-row style="background-color: white; width: 20%"> -->
                <v-row>
                  <v-col cols="12" lg="3" md="3">
                    <v-autocomplete
                      prepend-icon="mdi-city"
                      v-model="value"
                      :items="items"
                      dense
                      label="City"
                    ></v-autocomplete>
                  </v-col>
                  <v-col cols="12" lg="3" md="3">
                    <v-menu
                      ref="datepickerMenu"
                      v-model="datepickerMenu"
                      :close-on-content-click="false"
                      :return-value.sync="date"
                      transition="scale-transition"
                      offset-y
                      min-width="290px"
                    >
                      <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                          dense
                          v-model="date"
                          label="Picker in menu"
                          prepend-icon="mdi-calendar"
                          readonly
                          v-bind="attrs"
                          v-on="on"
                        ></v-text-field>
                      </template>
                      <v-date-picker v-model="date" no-title scrollable>
                        <v-spacer></v-spacer>
                        <v-btn
                          text
                          color="primary"
                          @click="datepickerMenu = false"
                        >
                          Cancel
                        </v-btn>
                        <v-btn
                          text
                          color="primary"
                          @click="$refs.datepickerMenu.save(date)"
                          >OK
                        </v-btn>
                      </v-date-picker>
                    </v-menu>
                  </v-col>
                  <v-col cols="12" lg="3" md="3">
                    <v-menu
                      ref="menu"
                      v-model="timepickerMenu"
                      :close-on-content-click="false"
                      :nudge-right="40"
                      :return-value.sync="time"
                      transition="scale-transition"
                      offset-y
                      max-width="290px"
                      min-width="290px"
                    >
                      <template v-slot:activator="{ on, attrs }">
                        <v-text-field
                          dense
                          v-model="time"
                          label="Hour"
                          prepend-icon="mdi-clock"
                          readonly
                          v-bind="attrs"
                          v-on="on"
                        ></v-text-field>
                      </template>
                      <v-time-picker
                        v-if="timepickerMenu"
                        v-model="time"
                        format="24hr"
                        full-width
                        @click:minute="$refs.menu.save(time)"
                      ></v-time-picker>
                    </v-menu>
                  </v-col>
                  <v-row justify="center">
                    <v-col cols="12" lg="5" md="9">
                      <v-btn depressed dense color="primary"> Search </v-btn>
                    </v-col>
                  </v-row>
                </v-row>
              </v-card-actions>
            </v-col>
          </v-row>
        </v-card>

        <!-- <v-card
             width="auto"
            outlined
        >
            <v-list-item three-line>
            <v-list-item-content>
                <div class="overline mb-4">
                    Welcome test s
                </div>
                      <v-list-item-title class="headline mb-1">
                Find promoters
                </v-list-item-title>
                <v-list-item-subtitle>Best promoters searching platform</v-list-item-subtitle>
            </v-list-item-content>
            </v-list-item>

            <v-card-actions>
                <login></login>

            <v-spacer/>
            <v-btn
                outlined
                rounded
                color="green"
            >
                Register
            </v-btn>
            </v-card-actions>
        </v-card> -->
      </v-col>
    </v-row>
  </div>
</template>
<script>
import Login from "./Login.vue";

export default {
  name: "home-componenst",
  components: {
    login: Login,
  },
  data() {
    return {
      dialog: false,
      //autocomplete
      items: ["foo", "bar", "fizz", "buzz"],
      values: ["foo", "bar"],
      value: null,
      // datepicker
      date: new Date().toISOString().substr(0, 10),
      datepickerMenu: false,
      //timepicker
      time: "09:42",
      timepickerMenu: false,
    };
  },
  computed: {
    dateRangeText() {
      return this.dates.join(" ~ ");
    },
  },
  created() {},
  methods: {
    testf() {
      debugger;
      this.$vuetify.theme.dark = !this.$vuetify.theme.dark;
    },
  },
};
</script>
<style>
#card-action-border {
  background-color: white;
  border-color: lightgrey;
  /* border-color: grey lighten-5; */

  border-style: solid;
  border-width: 1px;
}
</style>