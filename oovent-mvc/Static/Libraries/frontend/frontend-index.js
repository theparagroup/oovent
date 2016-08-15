/**
* This javascript interacts with the frontend cshtml document Index.cshtml
**/

window.onload = function () 
{
    //Javascript for the login modal in Index.cshtml

    var modal = document.getElementById('login-modal');
    var btn = document.getElementById("login-button");
    var span = document.getElementsByClassName("close")[0];

    btn.onclick = function modalOpen()
    {
        modal.style.display = "block";
    }

    span.onclick = function modalClose()
    {
        modal.style.display = "none";
    }

    //Javascript for the filter box format changes

    document.getElementById("filter-type-checkbox-event").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('filter-format-discount').style.display = "none";
            document.getElementById('filter-format-foodtruck').style.display = "none";
            document.getElementById('filter-format-event').style.display = "block";
        }
    }

    document.getElementById("filter-type-checkbox-discount").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('filter-format-foodtruck').style.display = "none";
            document.getElementById('filter-format-event').style.display = "none";
            document.getElementById('filter-format-discount').style.display = "block";
        }
    }

    document.getElementById("filter-type-checkbox-foodtruck").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('filter-format-discount').style.display = "none";
            document.getElementById('filter-format-event').style.display = "none";
            document.getElementById('filter-format-foodtruck').style.display = "block";
        }
    }

    //Javascript for the date filter in Index.cshtml

    if (document.getElementById('date-dropdown').value == 1)
    {
        document.getElementById('date-info-text-month').style.display = "none";
        document.getElementById('date-info-text-week').style.display = "none";
        document.getElementById('date-info-text-day').style.display = "block";
    } 
    else if (document.getElementById('date-dropdown').value == 2)
    {
        document.getElementById('date-info-text-month').style.display = "none";
        document.getElementById('date-info-text-day').style.display = "none";
        document.getElementById('date-info-text-week').style.display = "block";
    }
    else if (document.getElementById('date-dropdown').value == 3)
    {
        document.getElementById('date-info-text-day').style.display = "none";
        document.getElementById('date-info-text-week').style.display = "none";
        document.getElementById('date-info-text-month').style.display = "block";
    }

    //Javascript for the event modal in Index.cshtml


    for (i = 1; i < 500; i++)
    {
        var eventModal = document.getElementById('event-modal-' + i);
        var eventBtn = document.getElementById("event-modal-btn-" + i);
        var eventSpan = document.getElementsByClassName("event-close-" + i)[0];

        eventBtn.onclick = function eventModalOpen()
        {
            eventModal.style.display = "block";
        }

        eventSpan.onclick = function eventModalClose()
        {
            eventModal.style.display = "none";
        }

        window.onclick = function eventModalCloseOuter(event)
        {
            if (event.target == eventModal)
            {
                eventModal.style.display = "none";
            }
            if (event.target == modal)
            {
                modal.style.display = "none";
            }
        }
    }
}