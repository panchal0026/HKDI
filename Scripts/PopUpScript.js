function Func_PopUp() {
    //pop();

    $('.modal, .modal-backdrop').fadeIn('slow');
    e.preventDefault();

    modalPosition();
    $(window).resize(function () {
        modalPosition();
    });
}

$(pop = function () {
    modalPosition();
    $(window).resize(function () {
        modalPosition();
    });

    $('.close-modal').click(function (e) {
        alert("hi");
        $('.modal, .modal-backdrop').fadeOut('fast');
    });
});
function modalPosition() {
    var width = $('.modal').width();
    var pageWidth = $(window).width();
    var x = (pageWidth / 2) - (width / 2);
    $('.modal').css({ left: x + "px" });
}