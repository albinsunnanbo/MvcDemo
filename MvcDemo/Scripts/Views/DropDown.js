$(function () {
    "use strict";

    $("#County").change(function () {
        var placeholder = $("#municipality-placeholder");
        placeholder.html("Laddar...");
        var url = placeholder.data("url");
        $.post(url, $(this).closest("form").serialize(), function (data, textStatus, jqXHR) {
            // When server returns ajax response, replace the placeholder content with the new dropdown
            placeholder.html(data);
        });
    });
});