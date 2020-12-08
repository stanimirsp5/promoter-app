<template>
  <v-row>
    <v-col cols="12">
      <!-- <v-card class="pb-2 pl-4" elevation="0" height="auto" width="auto">
        <span class="headline font-weight-medium textColor--text"> Price </span>
      </v-card> -->

      <v-card color="secondary" elevation="0" height="auto" width="auto">
        <v-list-item three-line>
          <v-list-item-content class="py-0 pl-2">
            <span class="headline font-weight-medium textColor--text">
              Price
            </span>
          </v-list-item-content>
        </v-list-item>
        <v-row align="center">
          <v-col align="center" cols="12" lg="4" md="4">
            <span class="pt-3 textColor--text"> personal </span>
            <div
              style="
                width: 80px;
                height: 80px;
                -webkit-border-radius: 25px;
                -moz-border-radius: 25px;
                border-radius: 50px;
                background: lightblue;
              "
            ></div>
          </v-col>

          <v-col align="center" cols="12" lg="4" md="4">
            <v-row>
              <v-col cols="12">
                <span class="headline font-weight-medium textColor--text">
                  USD 40.00
                </span>
              </v-col>
            </v-row>
            <span class="pt-3 textColor--text"> per month </span>
          </v-col>

          <v-col align="center" offset-lg="1" cols="12" lg="3" md="4">
            <v-col cols="12">
              <!-- st÷yle="list-style-position: inside; text-align: center" -->
              <span class="pt-3 textColor--text">
                <ul>
                  <li>Coffee</li>
                  <li>Tea</li>
                  <li>Milk</li>
                  <li>Lorem ipsum dolor</li>
                  <li>Lorem ipsum dolor</li>
                </ul>
              </span>

              <!-- <v-list dense color="secondary">
                <v-list-item>
                  <v-list-item-content>
                    <v-list-item-subtitle>
                      Single-line item
                    </v-list-item-subtitle>
                    <v-list-item-subtitle>
                      Lorem ipsum dolor
                    </v-list-item-subtitle>
                    <v-list-item-subtitle>
                      Lorem ipsum dolor
                    </v-list-item-subtitle>
                    <v-list-item-subtitle>Milk</v-list-item-subtitle>
                  </v-list-item-content>
                </v-list-item>
              </v-list> -->
            </v-col>
          </v-col>
          <v-col align="center" cols="12">
            <v-btn depressed dense color="primary"> Subscribe </v-btn>
          </v-col>
        </v-row>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
export default {
  name: "price",
  components: {},
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