function initMap() {
    //map..
    var map = new google.maps.Map(document.getElementById('myMap'), {
        center: {
            lat: 10.9968683,
            lng: 76.00882
        },
        zoom: 15
    });
    //marker..
    var marker = new google.maps.Marker({
        position: {
            lat: 10.9968683,
            lng: 76.00882
        },
        map: map,
        draggable: true
    });

    //dragend event of marker
    google.maps.event.addListener(marker, 'dragend', function () {
        var Lats = marker.getPosition().lat();
        var Longs = marker.getPosition().lng();
        $('#Lat').val(Lats);
        $('#Long').val(Longs);
    });
}

