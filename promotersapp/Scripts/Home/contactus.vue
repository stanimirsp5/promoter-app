<template>
    <div id="contact">
        <h1>Contact hhehe-test Vue</h1>

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

    </div>

</template>
<script>
    export default {
        name: "contact-component",
        data: () => ({
            allCities: []
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
            }
        }
    };
</script>