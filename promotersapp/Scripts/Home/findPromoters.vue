<template>
  <v-card width="auto" outlined color="secondary">
    <v-row>
      <v-col class="mx-3" cols="11" lg="5" md="7">
        <v-list-item three-line>
          <v-list-item-content>
            <span class="headline font-weight-medium textColor--text">
              Find promoters
            </span>
            <span class="pt-3 textColor--text">
              Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc
              sapien quam, pretium sed interdum quis, elementum quis nibh.
              Vivamus sodales elit lacinia magna dignissim aliquam
            </span>
          </v-list-item-content>
        </v-list-item>
      </v-col>
    </v-row>

    <v-row>
      <v-col class="ml-6" cols="10" lg="7" md="9">
        <v-card elevation="1">
          <v-card-actions class="mx-6 mb-6" width="auto">
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
                    <v-btn text color="primary" @click="datepickerMenu = false">
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
              <v-col cols="12" lg="2" md="3">
                <v-btn depressed dense color="primary"> Search </v-btn>
              </v-col>
            </v-row>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-card>
</template>
<script>
export default {
  name: "find-promoters",
  components: {},
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
  methods: {},
};
</script>
<style>
</style>