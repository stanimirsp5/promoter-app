<template>
    <div id="contact">
        <h1>Contact hhehe-test Vue</h1>
    </div>

</template>
<script>
    export default {
        name: "contact-component",
        methods: {
            GetAxios() {
                return this.$parent.$parent.axios;
            }
        }
    };
</script>