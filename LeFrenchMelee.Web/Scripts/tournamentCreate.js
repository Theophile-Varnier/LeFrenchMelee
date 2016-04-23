$(function () {
    $("#StartDate").datepicker();
    $("#EndDate").datepicker();
    $("#accordion").accordion();

    $("#additionalFields").on("click", ".add-field", function (e, obj) {
        if ($(this).hasClass("btn-primary")) {
            var content = $("#templateField").html();
            $("#additionalFields").append(content);
            $(this).removeClass("btn-primary")
                .addClass("btn-danger")
                .find(".glyphicon-plus").removeClass(".glyphicon-plus").addClass("glyphicon-minus");
        } else {
            $(this).closest(".additional-field").remove();
        }
    });

    $("#createForm").on("submit", function (e, obj) {
        $("#additionalFields .additional-field").each(function (index, elem) {
            var key = $(elem).find("input").val();
            var value = $(elem).find("option:selected").val();
            if(key && value){
                $("<input>").attr("type", "hidden")
                .attr("name", "AdditionalFields[" + index + "].Key")
                .attr("value", key)
                .appendTo("#createForm");

                $("<input>").attr("type", "hidden")
                .attr("name", "AdditionalFields[" + index + "].Value")
                .attr("value", value)
                .appendTo("#createForm");
            }
        });
    });
});