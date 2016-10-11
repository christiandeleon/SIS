function init() {
    if ($(".dateformat, .date").length > 0) {
        $(".dateformat, .date").focus(function () {
            $(this).inputmask("dd/mm/yyyy", { "clearIncomplete": true, "clearMaskOnLostFocus": true });
        }).blur(function () {
            $(this).inputmask("dd/mm/yyyy", { "clearIncomplete": true, "clearMaskOnLostFocus": true });
        });
    }

    if ($(".number").length > 0) {
        $('.number').keypress(function (e) {
            if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                return false;
            }
        });
    }

    if ($(".bsb").length > 0) {
        $(".bsb").inputmask("[999-999]");
    }
    if ($(".account").length > 0) {
        $(".account").inputmask("[9999-9999]");
    }
}