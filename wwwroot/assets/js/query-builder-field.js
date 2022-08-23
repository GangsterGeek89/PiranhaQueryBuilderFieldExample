Vue.component("query-builder-field", {
    props: ["uid", "toolbar", "model", "meta"],
    //data() {
    //    return {
    //        rules: this.model.rules,
    //        query: this.model.query
    //    };
    //},
    components: { VueQueryBuilder: window.VueQueryBuilder },
    template:
        "<div>" +
        "<vue-query-builder :rules='model.rules' v-model='model.query'></vue-query-builder>" +
        "</div>"
});