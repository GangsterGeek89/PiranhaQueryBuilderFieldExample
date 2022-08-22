Vue.component("query-builder-field", {
    props: ["uid", "toolbar", "model", "meta"],
    //mounted: function () {
    //    new Vue({
    //        el: '#app',
    //        data: { rules: [] },
    //        components: { VueQueryBuilder: window.VueQueryBuilder }
    //    });
    //},
    data() {
        rules: []
        if (this.model == null || this.model.rules == null) {
            return {
                rules: []
            }
        }
        else {
            return {
                rules: this.model.rules
            }
        }
        
    },
    components: { VueQueryBuilder: window.VueQueryBuilder },
    template:
        "<div id='#app'>" +
        "<vue-query-builder :rules='rules'></vue-query-builder>" +
        "</div>"
});