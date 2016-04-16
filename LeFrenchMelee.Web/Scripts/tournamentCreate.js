$(function () {
    $("#StartDate").datepicker();
    $("#EndDate").datepicker();
    $("#accordion").accordion();

    $("#additionalFields").on("click", ".add-field", function (e, obj) {
        if ($(this).hasClass("btn-primary")) {
            var content = $("#templateField").html();
            //var regex = "/AdditionalFields([^\d]+)0([^\d\.]+)/gm";
            var regex = new RegExp("AdditionalFields([^\d]+)0([^\d\.\"]+)", "gm");
            var newString = content.replace(regex, "AdditionalFields$1" + ($(".additional-field").length - 1) + "$2");
            $("#additionalFields").append(newString);
            $(this).removeClass("btn-primary")
                .addClass("btn-danger")
                .find(".glyphicon-plus").removeClass(".glyphicon-plus").addClass("glyphicon-minus");
        } else {
            $(this).closest(".additional-field").remove();
        }
    });
});