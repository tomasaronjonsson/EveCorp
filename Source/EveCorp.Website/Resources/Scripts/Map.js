


$(document).ready(function () {

    //svo hægt er að draga kortin
    $(".draggable").draggable({
        containment: "#map-container",
        scroll: false,
        stop: function(event, ui) {
            var pos_x = ui.offset.left;
            var pos_y = ui.offset.top;
            var id = ui.id;

            $http.get("/Umbraco/Api/Map/UpdateSolarsystemLocation", {
                params: { name: id, x: pos_x, y: pos_y }
            });
        }
    });

    //til að sýna tooltipið með upplýsingum um skipið
    $('[data-toggle="tooltip"]').tooltip();


   
});
