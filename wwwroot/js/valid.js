/* Validerar Kontaktuppgifter;   */

function validateForm() {

    // Första bokstav skall vara en versal, följd av gemener;
    var Letters = /^[ A-Za-zåäöÅÄÖ-]+$/;

    var epost = /^[A-Za-z0-9._-]+@[A-Za-z0-9.-]+\.[a-z]{2,6}$/;
    var first = document.forms["frm"]["firstname"].value;
    var last = document.forms["frm"]["lastname"].value;
    var mejl = document.forms["frm"]["epost"].value;
    var subject = document.forms["frm"]["subject"].value;

    if (first === null || first === "") {
        alert("Ange Ditt förnamn!");
        return false;
    }

    if (last === null || last === "") {
        alert("Ange Ditt efternamn!");
        return false;
    }

    if (mejl === null || mejl === "") {
        alert("Ange Din E-postadress!!!");
        return false;
    }

    if (subject === null || subject === "") {
        alert("Skriv ett meddelande!!!");
        return false;
    }

    if (!first.match(Letters)) {
        alert("Felaktiga bokstäver i förnamnet!");
        return false;
    }

    if (!last.match(Letters)) {
        alert("Felaktiga bokstäver i efternamnet!");
        return false;
    }

    if (!mejl.match(epost)) {
        alert("Fel i E-postadressen!");
        return false;
    }
}