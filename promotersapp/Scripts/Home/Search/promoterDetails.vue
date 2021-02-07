<template>
  <v-container>
    <v-row>
      <v-col cols="12">
        <h3>Описание:</h3>
        <p class="font-weight-regular">
          "Sed ut perspiciatis unde omnis iste natus error sit voluptatem
          accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae
          ab illo inventore veritatis et quasi architecto beatae vitae dicta
          sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit
          aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos
          qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui
          dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed
          quia non numquam eius modi tempora incidunt ut labore et dolore magnam
          aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum
          exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex
          ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in
          ea voluptate velit esse quam nihil molestiae consequatur, vel illum
          qui dolorem eum fugiat quo voluptas nulla pariatur?"
        </p>
      </v-col>
    </v-row>
    <v-row>
      <v-col cols="12">
        <h3>График:</h3>
        <v-sheet height="800">
          <v-calendar
            ref="calendar"
            :now="today"
            :value="today"
            :events="events"
            color="primary"
            type="week"
          ></v-calendar>
        </v-sheet>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  name: "promoter-details",
  props: {
    details: Object,
  },
  components: {},
  data() {
    return {
      today: "2021-02-07",
      events: [
        {
          name: "Фантастико 23",
          start: "2021-02-07 10:00",
          end: "2021-02-07 14:00",
        },
        {
          name: `Почивен`,
          start: "2021-02-10",
        },
        {
          name: "DM - The Mall",
          start: "2021-02-09 16:00",
          end: "2021-02-09 20:00",
        },
      ],
    };
  },
  computed: {},
  mounted() {
    this.$refs.calendar.scrollToTime("08:00");
  },
  created() {},
  methods: {},
};
</script>

<style scoped>
.my-event {
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  border-radius: 2px;
  background-color: #1867c0;
  color: #ffffff;
  border: 1px solid #1867c0;
  font-size: 12px;
  padding: 3px;
  cursor: pointer;
  margin-bottom: 1px;
  left: 4px;
  margin-right: 8px;
  position: relative;
}

.my-event.with-time {
  position: absolute;
  right: 4px;
  margin-right: 0px;
}
</style>