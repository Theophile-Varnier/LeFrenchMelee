$(function () {
    $("#StartDate").datepicker();
    $("#EndDate").datepicker();
    $("#accordion").accordion();

    $("#additionalFields").on("click", ".add-field", function (e, obj) {
        $("#additionalFields").append('<div class="form-group">'
            + '<div class="col-xs-2">'
            + '<input type="text" class="form-control" placeholder="Nom du champ..." />'
            + '</div>'
            + '<div class="col-xs-3">'
            + '<div class="input-group">'
            + '<select class="form-control">'
            + '<option value="" disabled selected>Type de champ</option>'
            + '<option value="Texte">Texte</option>'
            + '<option value="Nombre">Nombre</option>'
            + '</select>'
            + '<span class="input-group-btn">'
            + '<button type="button" class="btn btn-primary add-field"><span class="glyphicon glyphicon-plus"></span></button>'
            + '</span>'
            + '</div>'
            + '</div>'
            + '</div>');
    });
});