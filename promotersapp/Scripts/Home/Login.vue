<template>
  <v-row class="pl-2" justify="start">
    <v-dialog
      v-model="dialog"
      persistent
      max-width="290"
    >
      <template v-slot:activator="{ on, attrs }">
        <v-btn
          color="primary"
          outlined
                rounded
          v-bind="attrs"
          v-on="on"
        >
          Login
        </v-btn>
      </template>
      <v-card>
        <v-card-title class="headline">
          Login
        </v-card-title>
        <v-card-text>
            <v-row>
                <v-col
                cols="12"
                >
                <v-text-field
                    label="email"
                ></v-text-field>
                </v-col>

                <v-col
                cols="12"
                >
                <v-text-field
                    label="password"
                ></v-text-field>
                </v-col>
            </v-row>
        </v-card-text>

        <v-card-actions>
          <v-spacer></v-spacer>

          <v-btn
            color="green darken-1"
            text
            @click="dialog = false"
          >
            Close
          </v-btn>
          <v-btn
            color="green darken-1"
            @click="dialog = false"
          >
            Login
          </v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-row>
</template>
<script>

    export default {
        name: "login-component",
        data () {
            return {
                dialog: false,
            }
        },
        methods: {
        }
    };
</script>