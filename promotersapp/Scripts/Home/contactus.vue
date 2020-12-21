<template>
    <div id="contact">
        <h1>Contact test hhehe-test Vue</h1>

        <v-btn class="mx-2"
               fab
               dark
               large
               @click="getCities"
               color="purple">
            <v-icon dark>
                mdi-android
            </v-icon>
        </v-btn>
        <div>{{allCities}}</div>

        <v-btn class="mx-2"
               fab
               dark
               large
               @click="getOneCity"
               color="green">
            get one city
        </v-btn>
        <div>{{city}}</div>

        <v-btn class="mx-2"
               dark
               large
               @click="getPromoters"
               color="blue">
            promoters
        </v-btn>
        <div>{{promoters}}</div>
    </div>

</template>
<script>
    export default {
        name: "contact-component",
        data: () => ({
            allCities: [],
            promoters: [],
            city: null
        }),

        methods: {
            getCities() {
                this.$axios.get('/Home/GetCities', null)
                    .then(res => {
                         this.allCities = res.data
                    })
                    .catch(err => {
                        console.log(err)
                    })
            },
            getOneCity() {
                this.$axios.get('/Home/GetOne', { params: { id: 1 } })
                    .then(res => {
                        this.city = res.data
                    })
                    .catch(err => {
                        console.log(err)
                    })
            },
            getPromoters() {
                this.$axios.get('/Home/GetPromoters')
                    .then(res => {
                        this.promoters = res.data
                    })
                    .catch(err => {
                        console.log(err)
                    })
            },
        }
    };
</script>