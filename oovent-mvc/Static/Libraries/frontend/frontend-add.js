/**
* This javascript interacts with the frontend cshtml document Add.cshtml
**/



window.onload = function ()
{
    //Javascript for form type selection in Add.cshtml

    document.getElementById("create-type-button-event").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-form').style.display = "none";
            document.getElementById('create-discount-form').style.display = "none";
            document.getElementById('create-event-form').style.display = "block";
        }
    }
    document.getElementById("create-type-button-discount").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-form').style.display = "none";
            document.getElementById('create-foodtruck-form').style.display = "none";
            document.getElementById('create-discount-form').style.display = "block";
        }
    }
    document.getElementById("create-type-button-foodtruck").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-form').style.display = "none";
            document.getElementById('create-event-form').style.display = "none";
            document.getElementById('create-foodtruck-form').style.display = "block";
        }
    }

    //Javascript for responsive form type selection in Index.cshtmnl

    document.getElementById("create-type-button-event-compact").onclick = function () {
        if (this.checked) {
            document.getElementById('create-foodtruck-form').style.display = "none";
            document.getElementById('create-discount-form').style.display = "none";
            document.getElementById('create-event-form').style.display = "block";
        }
    }
    document.getElementById("create-type-button-discount-compact").onclick = function () {
        if (this.checked) {
            document.getElementById('create-event-form').style.display = "none";
            document.getElementById('create-foodtruck-form').style.display = "none";
            document.getElementById('create-discount-form').style.display = "block";
        }
    }
    document.getElementById("create-type-button-foodtruck-compact").onclick = function () {
        if (this.checked) {
            document.getElementById('create-discount-form').style.display = "none";
            document.getElementById('create-event-form').style.display = "none";
            document.getElementById('create-foodtruck-form').style.display = "block";
        }
    }

    //Javascript for event recurring or onetime selection in Add.cshtml

    document.getElementById("create-event-button-recurring").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-when-onetime').style.display = "none";
            document.getElementById('create-event-when-recurring').style.display = "block";
        }
    }
    document.getElementById("create-event-button-onetime").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-when-recurring').style.display = "none";
            document.getElementById('create-event-when-onetime').style.display = "block";
        }
    }

    //Javascript for event recurring daily, weekly, or monthly selection in Add.cshtml

    document.getElementById("create-event-button-daily").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-when-reccuring-monthly').style.display = "none";
            document.getElementById('create-event-when-reccuring-weekly').style.display = "none";
            document.getElementById('create-event-when-reccuring-daily').style.display = "block";
        }
    }
    document.getElementById("create-event-button-weekly").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-when-reccuring-monthly').style.display = "none";
            document.getElementById('create-event-when-reccuring-daily').style.display = "none";
            document.getElementById('create-event-when-reccuring-weekly').style.display = "block";
        }
    }
    document.getElementById("create-event-button-monthly").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-when-reccuring-weekly').style.display = "none";
            document.getElementById('create-event-when-reccuring-daily').style.display = "none";
            document.getElementById('create-event-when-reccuring-monthly').style.display = "block";
        }
    }

    //Javascript for event link selection in Add.cshtml

    document.getElementById("create-event-button-website").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-input-link-twitter').style.display = "none";
            document.getElementById('create-event-input-link-facebook').style.display = "none";
            document.getElementById('create-event-input-link-instagram').style.display = "none";
            document.getElementById('create-event-input-link-pintrest').style.display = "none";
            document.getElementById('create-event-input-link-youtube').style.display = "none";
            document.getElementById('create-event-input-link-website').style.display = "block";
        }
    }
    document.getElementById("create-event-button-twitter").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-input-link-website').style.display = "none";
            document.getElementById('create-event-input-link-facebook').style.display = "none";
            document.getElementById('create-event-input-link-instagram').style.display = "none";
            document.getElementById('create-event-input-link-pintrest').style.display = "none";
            document.getElementById('create-event-input-link-youtube').style.display = "none";
            document.getElementById('create-event-input-link-twitter').style.display = "block";
        }
    }
    document.getElementById("create-event-button-facebook").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-input-link-twitter').style.display = "none";
            document.getElementById('create-event-input-link-website').style.display = "none";
            document.getElementById('create-event-input-link-instagram').style.display = "none";
            document.getElementById('create-event-input-link-pintrest').style.display = "none";
            document.getElementById('create-event-input-link-youtube').style.display = "none";
            document.getElementById('create-event-input-link-facebook').style.display = "block";
        }
    }
    document.getElementById("create-event-button-instagram").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-input-link-twitter').style.display = "none";
            document.getElementById('create-event-input-link-facebook').style.display = "none";
            document.getElementById('create-event-input-link-website').style.display = "none";
            document.getElementById('create-event-input-link-pintrest').style.display = "none";
            document.getElementById('create-event-input-link-youtube').style.display = "none";
            document.getElementById('create-event-input-link-instagram').style.display = "block";
        }
    }
    document.getElementById("create-event-button-pintrest").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-input-link-twitter').style.display = "none";
            document.getElementById('create-event-input-link-facebook').style.display = "none";
            document.getElementById('create-event-input-link-instagram').style.display = "none";
            document.getElementById('create-event-input-link-website').style.display = "none";
            document.getElementById('create-event-input-link-youtube').style.display = "none";
            document.getElementById('create-event-input-link-pintrest').style.display = "block";
        }
    }
    document.getElementById("create-event-button-youtube").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-event-input-link-twitter').style.display = "none";
            document.getElementById('create-event-input-link-facebook').style.display = "none";
            document.getElementById('create-event-input-link-instagram').style.display = "none";
            document.getElementById('create-event-input-link-pintrest').style.display = "none";
            document.getElementById('create-event-input-link-website').style.display = "none";
            document.getElementById('create-event-input-link-youtube').style.display = "block";
        }
    }

    //Javascript for discount onetime or recurring selection in Add.cshtml

    document.getElementById("create-discount-button-recurring").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-when-onetime').style.display = "none";
            document.getElementById('create-discount-when-recurring').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-onetime").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-when-recurring').style.display = "none";
            document.getElementById('create-discount-when-onetime').style.display = "block";
        }
    }

    //Javascript for discount recurring daily, weekly, or monthly selection in Add.cshtml

    document.getElementById("create-discount-button-daily").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-when-reccuring-monthly').style.display = "none";
            document.getElementById('create-discount-when-reccuring-weekly').style.display = "none";
            document.getElementById('create-discount-when-reccuring-daily').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-weekly").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-when-reccuring-monthly').style.display = "none";
            document.getElementById('create-discount-when-reccuring-daily').style.display = "none";
            document.getElementById('create-discount-when-reccuring-weekly').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-monthly").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-when-reccuring-weekly').style.display = "none";
            document.getElementById('create-discount-when-reccuring-daily').style.display = "none";
            document.getElementById('create-discount-when-reccuring-monthly').style.display = "block";
        }
    }

    //Javascript for discount link selection in Add.cshtml

    document.getElementById("create-discount-button-website").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-input-link-twitter').style.display = "none";
            document.getElementById('create-discount-input-link-facebook').style.display = "none";
            document.getElementById('create-discount-input-link-instagram').style.display = "none";
            document.getElementById('create-discount-input-link-pintrest').style.display = "none";
            document.getElementById('create-discount-input-link-youtube').style.display = "none";
            document.getElementById('create-discount-input-link-website').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-twitter").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-input-link-website').style.display = "none";
            document.getElementById('create-discount-input-link-facebook').style.display = "none";
            document.getElementById('create-discount-input-link-instagram').style.display = "none";
            document.getElementById('create-discount-input-link-pintrest').style.display = "none";
            document.getElementById('create-discount-input-link-youtube').style.display = "none";
            document.getElementById('create-discount-input-link-twitter').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-facebook").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-input-link-twitter').style.display = "none";
            document.getElementById('create-discount-input-link-website').style.display = "none";
            document.getElementById('create-discount-input-link-instagram').style.display = "none";
            document.getElementById('create-discount-input-link-pintrest').style.display = "none";
            document.getElementById('create-discount-input-link-youtube').style.display = "none";
            document.getElementById('create-discount-input-link-facebook').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-instagram").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-input-link-twitter').style.display = "none";
            document.getElementById('create-discount-input-link-facebook').style.display = "none";
            document.getElementById('create-discount-input-link-website').style.display = "none";
            document.getElementById('create-discount-input-link-pintrest').style.display = "none";
            document.getElementById('create-discount-input-link-youtube').style.display = "none";
            document.getElementById('create-discount-input-link-instagram').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-pintrest").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-input-link-twitter').style.display = "none";
            document.getElementById('create-discount-input-link-facebook').style.display = "none";
            document.getElementById('create-discount-input-link-instagram').style.display = "none";
            document.getElementById('create-discount-input-link-website').style.display = "none";
            document.getElementById('create-discount-input-link-youtube').style.display = "none";
            document.getElementById('create-discount-input-link-pintrest').style.display = "block";
        }
    }
    document.getElementById("create-discount-button-youtube").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-discount-input-link-twitter').style.display = "none";
            document.getElementById('create-discount-input-link-facebook').style.display = "none";
            document.getElementById('create-discount-input-link-instagram').style.display = "none";
            document.getElementById('create-discount-input-link-pintrest').style.display = "none";
            document.getElementById('create-discount-input-link-website').style.display = "none";
            document.getElementById('create-discount-input-link-youtube').style.display = "block";
        }
    }

    //Javascript for foodtruck recurring or onetime selection in Add.cshtml

    document.getElementById("create-foodtruck-button-recurring").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-when-onetime').style.display = "none";
            document.getElementById('create-foodtruck-when-recurring').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-onetime").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-when-recurring').style.display = "none";
            document.getElementById('create-foodtruck-when-onetime').style.display = "block";
        }
    }

    //Javascript for foodtruck recurring daily, weekly, or monthly selection in Add.cshtml

    document.getElementById("create-foodtruck-button-daily").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-when-reccuring-monthly').style.display = "none";
            document.getElementById('create-foodtruck-when-reccuring-weekly').style.display = "none";
            document.getElementById('create-foodtruck-when-reccuring-daily').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-weekly").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-when-reccuring-monthly').style.display = "none";
            document.getElementById('create-foodtruck-when-reccuring-daily').style.display = "none";
            document.getElementById('create-foodtruck-when-reccuring-weekly').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-monthly").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-when-reccuring-weekly').style.display = "none";
            document.getElementById('create-foodtruck-when-reccuring-daily').style.display = "none";
            document.getElementById('create-foodtruck-when-reccuring-monthly').style.display = "block";
        }
    }

    //Javascript for foodtruck link selection in Add.cshtml

    document.getElementById("create-foodtruck-button-website").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-input-link-twitter').style.display = "none";
            document.getElementById('create-foodtruck-input-link-facebook').style.display = "none";
            document.getElementById('create-foodtruck-input-link-instagram').style.display = "none";
            document.getElementById('create-foodtruck-input-link-pintrest').style.display = "none";
            document.getElementById('create-foodtruck-input-link-youtube').style.display = "none";
            document.getElementById('create-foodtruck-input-link-website').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-twitter").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-input-link-website').style.display = "none";
            document.getElementById('create-foodtruck-input-link-facebook').style.display = "none";
            document.getElementById('create-foodtruck-input-link-instagram').style.display = "none";
            document.getElementById('create-foodtruck-input-link-pintrest').style.display = "none";
            document.getElementById('create-foodtruck-input-link-youtube').style.display = "none";
            document.getElementById('create-foodtruck-input-link-twitter').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-facebook").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-input-link-twitter').style.display = "none";
            document.getElementById('create-foodtruck-input-link-website').style.display = "none";
            document.getElementById('create-foodtruck-input-link-instagram').style.display = "none";
            document.getElementById('create-foodtruck-input-link-pintrest').style.display = "none";
            document.getElementById('create-foodtruck-input-link-youtube').style.display = "none";
            document.getElementById('create-foodtruck-input-link-facebook').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-instagram").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-input-link-twitter').style.display = "none";
            document.getElementById('create-foodtruck-input-link-facebook').style.display = "none";
            document.getElementById('create-foodtruck-input-link-website').style.display = "none";
            document.getElementById('create-foodtruck-input-link-pintrest').style.display = "none";
            document.getElementById('create-foodtruck-input-link-youtube').style.display = "none";
            document.getElementById('create-foodtruck-input-link-instagram').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-pintrest").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-input-link-twitter').style.display = "none";
            document.getElementById('create-foodtruck-input-link-facebook').style.display = "none";
            document.getElementById('create-foodtruck-input-link-instagram').style.display = "none";
            document.getElementById('create-foodtruck-input-link-website').style.display = "none";
            document.getElementById('create-foodtruck-input-link-youtube').style.display = "none";
            document.getElementById('create-foodtruck-input-link-pintrest').style.display = "block";
        }
    }
    document.getElementById("create-foodtruck-button-youtube").onclick = function ()
    {
        if (this.checked)
        {
            document.getElementById('create-foodtruck-input-link-twitter').style.display = "none";
            document.getElementById('create-foodtruck-input-link-facebook').style.display = "none";
            document.getElementById('create-foodtruck-input-link-instagram').style.display = "none";
            document.getElementById('create-foodtruck-input-link-pintrest').style.display = "none";
            document.getElementById('create-foodtruck-input-link-website').style.display = "none";
            document.getElementById('create-foodtruck-input-link-youtube').style.display = "block";
        }
    }
}