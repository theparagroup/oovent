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

    //Javascript for the event modal in Index.cshtml

    var eventModal = document.getElementById('event-modal');
    var eventBtn = document.getElementById("event-modal-btn");
    var eventSpan = document.getElementsByClassName("event-close")[0];

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