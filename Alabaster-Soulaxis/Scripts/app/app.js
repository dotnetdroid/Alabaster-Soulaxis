var App = function () {
    var self = this;
    var schedule = new ScheduleViewModel();
    var song = new SongsViewModel();

    ko.applyBindings(schedule, $("#page_schedule")[0]);
    ko.applyBindings(song, $("#page_songs")[0]);

    var routing = $.sammy(".main", function () {

        this.before(function () {
        });

        this.get("#/schedule", function (context) {
            $(".page").hide();
            schedule.LoadData();
            $("#page_schedule").fadeIn();
        });

        this.get("#/songs", function (context) {
            $(".page").hide();
            song.LoadData();
            $("#page_songs").fadeIn();
        });

        this.get(/#.*/, function () {
            location.hash = "#/schedule";
        });

        this._checkFormSubmission = function (form) {
            return (false);
        };

    });

    this.init = function () {
        routing.run();
    }
};