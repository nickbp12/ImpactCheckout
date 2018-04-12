$(document).on("click", ".checkout_box_radio-button", function () {
    $(this).find("input[type='radio']").prop("checked", true);
    $(this).addClass("checkout_box_radio-button--checked");
    $(this).siblings().removeClass("checkout_box_radio-button--checked");
});

