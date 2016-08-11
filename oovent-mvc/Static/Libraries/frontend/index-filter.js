
$(document).ready(function ()
{ 
    $(".filter-type").click(function(){
        $.ajax(
        {
            method: "POST",
            url: "LoadEvents"
        })
        .done(function (data)
        {
            alert(data);
        });
    })
});