


$(document).ready(function () {

    //svo hægt er að draga kortin
    $(".draggable").draggable({
        containment: "#map-container",
        scroll: false,
        stop: function (event, ui) {
            positions[this.id] = ui.position;
            localStorage.positions = JSON.stringify(positions);
        }
    });

    //til að sýna tooltipið með upplýsingum um skipið
    $('[data-toggle="tooltip"]').tooltip();


   
});
