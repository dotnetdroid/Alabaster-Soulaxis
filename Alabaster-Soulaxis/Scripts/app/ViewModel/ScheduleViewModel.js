var ScheduleViewModel = function () {
    var self = this;
    this.Lineup = ko.observable();
    this.Schedules = ko.observable();
    this.Band = ko.observable();
    this.Singers = ko.observable();
    this.Schedule = ko.observable();
    this.LoadData = function () {
        $.ajax({
            url: "/api/schedule/GetSchedules",
            contentType: 'application/json',
            success: function (result) {
                self.Schedules(result);
            },
            beforeSend: function () {
                //$("#loadingPanel").fadeIn();
            },
            error: function (err) {
                //$("#loadingPanel").fadeOut();
            }

        });
        $.ajax({
            url: "/api/schedule/getdetails?scheduleId=test",
            contentType: 'application/json',
            success: function (result) {
                self.Lineup(result.lineup);
                self.Band(result.band);
                self.Singers(result.singers);
                self.Schedule(result.schedule);
            },
            beforeSend: function () {
                //$("#loadingPanel").fadeIn();
            },
            error: function (err) {
                //$("#loadingPanel").fadeOut();
            }
        });
    }
}