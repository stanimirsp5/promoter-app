<template>
    <div id="home1">
        <v-card
            flat
            height="200px"
            tile
        >
            <v-toolbar dense
                color="teal lighten-4">
            <v-app-bar-nav-icon></v-app-bar-nav-icon>

            <v-toolbar-title>Promotersapp</v-toolbar-title>

            <v-spacer></v-spacer>

            <v-btn icon>
                <v-icon>mdi-magnify</v-icon>
            </v-btn>

            <v-btn icon>
                <v-icon>mdi-heart</v-icon>
            </v-btn>

            <v-btn icon>
                <v-icon>mdi-dots-vertical</v-icon>
            </v-btn>
            </v-toolbar>
        </v-card>
        
        <v-card
            class="mx-auto"
            max-width="744"
            outlined
        >
            <v-list-item three-line>
            <v-list-item-content>
                <div class="overline mb-4">
                    Welcome
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
        </v-card>

    </div>
</template>
<script>

    import Login from './Login.vue';

    export default {
        name: "home-componenst",
        components: {
            "login": Login,
        },
        data () {
            return {
                dialog: false,
            }
        },
        methods: {
            GetAxios(){
                return this.$parent.$parent.axios;
            }
        }
    };
</script>