let ecValidation = {

    inputsRequired: null,
    inputsEmail: null,
    
    init: function () {

        ecValidation.inputsRequired =
            document.querySelectorAll("[data-validation-required]");

        for (var i = 0; i < ecValidation.inputsRequired.length; i++) {

            ecValidation.inputsRequired[i].addEventListener("blur", function () {

                ecValidation.requiredValidade(this);

            });
        }


        ecValidation.inputsEmail =
            document.querySelectorAll("[data-validation-email]");

        for (var i = 0; i < ecValidation.inputsEmail.length; i++) {

            ecValidation.inputsEmail[i].addEventListener("blur", function () {

                ecValidation.emailValidade(this);
            });
        }


    },

    requiredValidade: function (input) {

        var msg = input.getAttribute("data-validation-required");

        if (input.value.trim() == "") {
            ecValidation.showSummary(input, msg);
            return false;
        }
        else {
            ecValidation.hideSummary(input, msg);
            return true;
        }
    },

    emailValidade: function (input) {

        var msg = input.getAttribute("data-validation-email");

        if (input.value.length > 0 &&
            input.value.indexOf("@") == -1) {
            ecValidation.showSummary(input, msg);
            return false;
        }
        else {
            ecValidation.hideSummary(input, msg);
            return true;
        }

    },

    showSummary: function (input, msg) {

        if (input == null)
            return;

        let idSummary = input.getAttribute("data-validation-summary");

        if (idSummary == null || idSummary == "")
            return;

        let summary = document.getElementById(idSummary);
        summary.innerHTML = msg;
        summary.classList.add("invalid");
    },

    hideSummary: function(input, msg){

        if (input == null)
            return;

        let idSummary = input.getAttribute("data-validation-summary");

        if (idSummary == null || idSummary == "")
            return;

        let summary = document.getElementById(idSummary);

        if (summary.innerHTML == msg) {
            summary.classList.remove("invalid");
            summary.innerHTML = "";
        }

    }, 

    formIsValid: function () {

        let valid = true;

        for (var i = 0; i < ecValidation.inputsRequired.length; i++) {
            let ok = ecValidation.requiredValidade(ecValidation.inputsRequired[i]);

            if (!ok)
                valid = false;
        }


        for (var i = 0; i < ecValidation.inputsEmail.length; i++) {
            let ok = ecValidation.emailValidade(ecValidation.inputsEmail[i]);

            if (!ok)
                valid = false;
        }

        return valid;
    }
}


ecValidation.init();

