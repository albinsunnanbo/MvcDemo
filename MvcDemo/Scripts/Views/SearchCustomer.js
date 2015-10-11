$(function () {
    "use strict";
    var request;
    $("#CustomerName").keyup(function () {
        var searchString = $(this).val();
        if (request) {
            request.abort();
        }
        request = $.post($("form").attr('action'), $("form").serialize(), function (data, status, jqXHR) {
            $("#result-list").empty();
            $("#result-list").append($(data));
            request = undefined;
        });
    });
});