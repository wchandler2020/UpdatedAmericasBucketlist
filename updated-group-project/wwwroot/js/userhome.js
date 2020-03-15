
//jquery for select list
$(function () {

    $('body').on('click', '.list-group .list-group-item', function () {
        $(this).toggleClass('active');
    });
    $('.list-arrows button').click(function () {
        var $button = $(this), actives = '';
        if ($button.hasClass('move-left')) {
            actives = $('.list-right ul li.active');
            actives.clone().appendTo('.list-left ul');
            actives.remove();
        } else if ($button.hasClass('move-right')) {
            actives = $('.list-left ul li.active');
            actives.clone().appendTo('.list-right ul');
            actives.remove();
        }
    });
    $('.dual-list .selector').click(function () {
        var $checkBox = $(this);
        if (!$checkBox.hasClass('selected')) {
            $checkBox.addClass('selected').closest('.well').find('ul li:not(.active)').addClass('active');
            $checkBox.children('i').removeClass('glyphicon-unchecked').addClass('glyphicon-check');
        } else {
            $checkBox.removeClass('selected').closest('.well').find('ul li.active').removeClass('active');
            $checkBox.children('i').removeClass('glyphicon-check').addClass('glyphicon-unchecked');
        }
    });
    $('[name="SearchDualList"]').keyup(function (e) {
        var code = e.keyCode || e.which;
        if (code == '9') return;
        if (code == '27') $(this).val(null);
        var $rows = $(this).closest('.dual-list').find('.list-group li');
        var val = $.trim($(this).val()).replace(/ +/g, ' ').toLowerCase();
        $rows.show().filter(function () {
            var text = $(this).text().replace(/\s+/g, ' ').toLowerCase();
            return !~text.indexOf(val);
        }).hide();
    });
});

var city = $('#city').val();

$.getJSON("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=imperial&APPID=1e5820fdfe73e01b9d8e5a82bdf9528a";
    function (data) {
        console.log(data);

        var icon = "http://openweathermap.org/img/w/" + data.weather[0].icon + ".png";

        var temp = Math.floor(data.main.temp);

        var weather = data.weather[0].main;

        $('.icon').attr('src', icon);
        $('.weather').append(weather);
        $('.temp').append(temp);
    });

function getWeather() {
    $('.weatherResponse').html('');
    var city = $('#city').val();
    var apiCall = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=imperial&APPID=1e5820fdfe73e01b9d8e5a82bdf9528a";

    $.getJSON(apiCall, weatherCallback);

    function weatherCallback(weatherData) {
        var city = weatherData.name;
        var temp = Math.floor(weatherData.main.temp);
        var description = weatherData.weather[0].description;
        $('.weatherResponse').append("The weather in " + city + " is currently " + temp + " degrees and " + description + ".");
        console.log(city, temp, description);
    }
}