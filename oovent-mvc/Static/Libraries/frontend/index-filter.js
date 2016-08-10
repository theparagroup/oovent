
$(document).ready(function ()
{ 
    $(".filter-type").data("data-type", "happening").click(function()
    {
        alert("CLICKED");
        $.ajax({
            type: 'GET',
            url: "LoadEvents",
            data: data,
            async: false,
            beforeSend: function (xhr) {
                if (xhr && xhr.overrideMimeType) {
                    xhr.overrideMimeType('application/json;charset=utf-8');
                }
            },
            dataType: 'json',
            success: function (data) {
                alert("Ajaxed");
            }
        });
    });

        //if ($(".filter-type").data("data-type", "happening"))
        //{
        //    if ($(".filter-type").data("data-type", "happening").is(":checked"))
        //    {
        //        $(".event-type-1").css("display", "inline");
        //    }
        //    else
        //    {
        //        $(".event-type-1").css("display", "none");
        //    }
        //}
        //else if ($(".filter-type").data("data-type", "discount"))
        //{
        //    $(".event-type-2").toggle(300);
        //}
        //else if ($(".filter-type").data("data-type", "foodtruck"))
        //{
        //    $(".event-type-3").toggle(300);
        //}
});