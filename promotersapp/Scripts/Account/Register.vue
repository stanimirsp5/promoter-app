<template>
    <v-card style="margin: 5% 30% 30% 30%"
            elevation="2">
        <v-card flat>
            <v-card style="padding: 10% 10%">
                <v-row>
                    <v-col lg="12" md="12" sm="12"  style="text-align:center;">
                        <h2 class="blue--text text--lighten-1">Създавана на безплатен акаунт</h2>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col lg="12" md="12" sm="12">
                        <v-radio-group v-model="row"
                                       row>
                            <v-col lg="6" md="6" sm="6">
                                <v-icon style="display:flex; font-size:5vh;"
                                        dark
                                        color="blue"
                                        right>
                                    mdi-account-circle
                                </v-icon>
                                <fieldset style="text-align:center;">
                                    <div style="margin: auto;">
                                        <v-radio value="radioPromoter">
                                        </v-radio>
                                        <div style="margin: auto;">
                                            <v-radio value="radioFirm">
                                            </v-radio>
                                        </div>
                                    </div>
                                </fieldset>
                                <div style="text-align:center;">
                                    Промоутър
                                </div>
                            </v-col>
                            <v-col lg="6" md="6" sm="6">
                                <v-icon style="display:flex; font-size:5vh;"
                                        dark
                                        color="blue"
                                        right>
                                    mdi-account-circle
                                </v-icon>
                                <fieldset style="text-align:center;">
                                    <div style="margin: auto;">
                                        <v-radio value="radioFirm">
                                        </v-radio>
                                    </div>
                                </fieldset>
                                <div style="text-align:center;">
                                    Фирма
                                </div>
                            </v-col>
                        </v-radio-group>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col lg="12" md="12" sm="12">
                        <v-text-field v-model="Form.name"
                                      label="Име"
                                      outlined
                                      clearable>

                        </v-text-field>
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
                    <v-col lg="12" md="12" sm="12">
                        <div style="text-align:center;">
                            <v-btn block
                                   color="primary"
                                   elevation="1"
                                   large
                                   raised>Регистриране</v-btn>
                        </div>
                    </v-col>
                </v-row>
            </v-card>
        </v-card>
    </v-card>
</template>
<script>

    export default {
        name: "register-component",
        data () {
            return {
                dialog: false,
                radioPromoter: 'promoter',
                radioFirm: 'firm',
                Form: {
                    userType: 0,
                    name: null,
                    email: null,
                    password: null
                }
            }
        },
        methods: {
        }
    };
</script>