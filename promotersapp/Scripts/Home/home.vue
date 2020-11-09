<template>
    <div id="home1">

        <h1>Vue</h1>
        <h1>9999 test Vue</h1>
        <h1>Home d Vue</h1>
        <h1>111 d Vue</h1>

        <v-btn color="red">
            Primary
        </v-btn>

        <v-card elevation="2">test</v-card>
        <div class="text-center">
            <v-btn class="mx-2"
                   fab
                   dark
                   small
                   color="primary">
                <v-icon dark>
                    mdi-minus
                </v-icon>
            </v-btn>

            <v-btn class="mx-2"
                   fab
                   dark
                   small
                   color="pink">
                <v-icon dark>
                    mdi-heart
                </v-icon>
            </v-btn>

            <v-btn class="mx-2"
                   fab
                   dark
                   color="indigo">
                <v-icon dark>
                    mdi-plus
                </v-icon>
            </v-btn>

            <v-btn class="mx-2"
                   fab
                   dark
                   color="teal">
                <v-icon dark>
                    mdi-format-list-bulleted-square
                </v-icon>
            </v-btn>

            <v-btn class="mx-2"
                   fab
                   dark
                   large
                   color="cyan">
                <v-icon dark>
                    mdi-pencil
                </v-icon>
            </v-btn>

            <v-btn class="mx-2"
                   fab
                   dark
                   large
                   color="purple">
                <v-icon dark>
                    mdi-android
                </v-icon>
            </v-btn>
        </div>

    </div>
</template>
<script>
    export default {
        name: "home-componenst"
    };
</script>