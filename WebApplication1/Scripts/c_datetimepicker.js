
/**
 * Bootstrap datetimepicker with Vue.js method
 * @param {any} addId
 * @param {any} dateId
 */
function c_datetimepicker(addId, dateId) {
    var app = new Vue({
        el: '#' + addId,
        data: {
            id: dateId,
            format: 'YYYY-MM-DD HH:mm:ss',
            SelectDate: null
        },
        methods: {
            initDatetimepicker: function () {
                var option = {
                    format: this.format,
                    minDate: '2017-01-01',
                    maxDate: '2018-02-01',
                    sideBySide: false,
                    showClear: true
                };


                var date = $('#' + this.id);
                date.datetimepicker(option);
                var $this = this;
                date.on('dp.change', function (e) {
                    $this.SelectDate = moment(e.date).format($this.format);
                });


                return date;
            },
            setDate: function (value) {
                $('#' + this.id).data("DateTimePicker").date(value);//获取
            }
        }
    });
    app.initDatetimepicker();
    return app;
};
