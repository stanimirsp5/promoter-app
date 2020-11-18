<template>
    <div id="about">
        <h1>About Us -test Vue</h1>
    </div>

</template>
<script>
    export default {
        name: "about-component",
        methods: {
            GetAxios() {
                return this.$parent.$parent.axios;
            }
        }
    };
</script>