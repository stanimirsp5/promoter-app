<template>
    <v-card style="margin: 5% 5% 5% 5%"
            elevation="2">
        <v-tabs v-model="tab"
                fixed-tabs>
            <v-tabs-slider color="blue"></v-tabs-slider>
            <v-tab v-for="item in tabs"
                   :key="item">
                {{ item }}
            </v-tab>
        </v-tabs>

        <v-tabs-items v-model="tab">
            <v-tab-item>
                <v-card flat>
                    <v-card-text>График</v-card-text>
                </v-card>
                <v-container>
                    <v-row>
                        <v-col lg="2" md="2" sm="2" style="padding:10%;">

                        </v-col>
                    </v-row>
                </v-container>
            </v-tab-item>
            <v-tab-item>
                <v-card flat>
                    <v-card style="padding: 5% 10%">
                        <v-row>
                            <v-col lg="2" md="2" sm="2">
                                <div style="height:100%; width:100%;">
                                    <v-icon style="font-size:15vh;"
                                            dark
                                            color="blue"
                                            right>
                                        mdi-account-circle
                                    </v-icon>
                                </div>
                            </v-col>
                            <v-col lg="6" md="6" sm="6">
                                <v-row style="height:60%;">
                                    <v-btn class="pa-2"
                                           color="primary"
                                           elevation="1"
                                           large
                                           raised>Качи снимка</v-btn>
                                    <v-btn class="pa-2"
                                           color="primary"
                                           elevation="1"
                                           large
                                           outlined>Изтрий снимка</v-btn>
                                </v-row>
                                <v-row>
                                    <p>
                                        Максимален размер: <b>5МБ</b>
                                    </p>
                                </v-row>
                                <v-row>
                                    <p>
                                        Допустими: <b>.jpg | .png | .bmp</b>
                                    </p>
                                </v-row>
                            </v-col>
                            <v-spacer></v-spacer>
                        </v-row>
                        <v-row>
                            <v-col lg="5" md="5" sm="5">
                                <v-text-field v-model="Form.name"
                                              outlined
                                              label="Име"
                                              clearable>

                                </v-text-field>
                            </v-col>
                            <v-spacer></v-spacer>
                            <v-col lg="5" md="5" sm="5">
                                <v-text-field v-model="Form.surname"
                                              outlined
                                              label="Фамилия"
                                              clearable>

                                </v-text-field>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col lg="5" md="5" sm="5">
                                <v-text-field v-model="Form.phone"
                                              outlined
                                              label="Телефон"
                                              clearable>

                                </v-text-field>
                            </v-col>
                            <v-spacer></v-spacer>
                            <v-col lg="5" md="5" sm="5">
                                <v-text-field v-model="Form.city"
                                              outlined
                                              label="Град"
                                              clearable>

                                </v-text-field>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col lg="12" md="12" sm="12">
                                <v-textarea v-model="Form.description"
                                            outlined
                                            label="Описание"
                                            clearable>

                                </v-textarea>
                            </v-col>
                        </v-row>
                        <v-row>
                            <v-col lg="12" md="12" sm="12" style=" text-align: right;">
                                <v-btn color="primary"
                                       elevation="1"
                                       large
                                       raised>Запази</v-btn>
                            </v-col>
                        </v-row>
                    </v-card>
                </v-card>
            </v-tab-item>
            <v-tab-item>
                <v-card flat>
                    <v-card-text>Сигурност</v-card-text>
                    <v-container>
                        <v-row>
                            <v-col lg="12" md="6" sm="3">
                                test3
                            </v-col>
                        </v-row>
                    </v-container>
                </v-card>
            </v-tab-item>
            <v-tab-item>
                <v-card flat>
                    <v-card-text>Съобщения</v-card-text>
                    <v-container>
                        <v-row>
                            <v-col lg="12" md="6" sm="3">
                                test4
                            </v-col>
                        </v-row>
                    </v-container>
                </v-card>
            </v-tab-item>
        </v-tabs-items>
    </v-card>
</template>

<script>
    export default {
        name: "dashboard-promoter-component",
        data() {
            return {
                tab: null,
                tabs: ['График', 'Профил', 'Сигурност', 'Съобщения'],
                dialog: false,
                Form: {
                    name: 'Станимир',
                    surname: 'Петров',
                    phone: '+3594736476',
                    city: 'София',
                    description: 'Нямам никаква представа какво да пиша тук.'
                }
            }
        },
        methods: {
        }
    };
</script>