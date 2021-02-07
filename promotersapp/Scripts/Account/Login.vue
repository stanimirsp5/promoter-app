<template>
    <v-card style="margin: 5% 40% 30% 40%"
            elevation="2">
        <v-card flat>
            <v-card style="padding: 15% 15%">
                <v-row>
                    <v-col lg="12" md="12" sm="12">
                        <b class="blue--text text--lighten-1">Вход в системата</b>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col lg="12" md="12" sm="12">
                        <v-text-field v-model="Form.email"
                                      label="Електронна поща"
                                      outlined
                                      clearable>

                        </v-text-field>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col lg="12" md="12" sm="12">
                        <v-text-field v-model="Form.password"
                                      label="Парола"
                                      outlined
                                      clearable>

                        </v-text-field>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col lg="5" md="5" sm="5">
                        <v-checkbox style="margin-top:0px;" v-model="Form.remember"
                                    label="Запомни">

                        </v-checkbox>
                    </v-col>
                    <v-spacer></v-spacer>
                    <v-col lg="5" md="5" sm="5">
                        <a>Регистрация</a>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col lg="12" md="12" sm="12">
                        <div style="text-align:center;">
                            <v-btn color="primary"
                                   elevation="1"
                                   large
                                   raised>Влез</v-btn>
                        </div>
                    </v-col>
                </v-row>
            </v-card>
        </v-card>
    </v-card>
</template>
<script>

    export default {
        name: "login-component",
        data () {
            return {
                dialog: false,
                Form: {
                    email: null,
                    password: null,
                    remember: false
                }
            }
        },
        methods: {
        }
    };
</script>