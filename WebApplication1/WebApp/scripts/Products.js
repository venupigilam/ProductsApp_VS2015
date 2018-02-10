var uri = 'http://localhost:7061/api/Products';

$(document).ready(function () {
    $.getJSON(uri).done(function (data) {
        $.each(data, function (key, item) {
            $('<li>', { text: formatItem(item) }).appendTo($('#Products'));
        });
    });

    function formatItem(item) {
        return item.name + " - " + item.Price;
    }

    //function GetProduct(id) {
    //    var id = $('#productid').val;
    //    $.getJSON(url + '/' + id).done(function (data) {
    //        $(data).appendTo($('#ProductDetails'));
    //    });
    //}

    $('#filter').click(function () {
        var id = $('#prodId').val();
        $.getJSON(uri + '/' + id)
            .done(function (data) {
                $('#product').text(formatItem(data));
            })
            .fail(function (jqXHR, textStatus, err) {
                $('#product').text("Error:" + err);
            });
    });


});