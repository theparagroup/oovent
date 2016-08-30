
$(document).ready(function()
{ 
    $("#filter-type-checkbox-event".change(function ()
    {
        $(".event-render").load('/GetEvents', 1);
    }));
});