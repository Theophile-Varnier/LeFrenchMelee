$(function () {
    $.ajax({
        url: url
    })
    .success(function (res) {
        var datas = [];
        for (var i = 0; i < res.length; i++) {
            datas.push({
                title: res[i].Name,
                start: res[i].StartDate,
                end: res[i].EndDate,
                allDay: true
            });
        }
        $("#calendar").fullCalendar({
            events: datas,
            lang: 'fr'
        });
    });
});