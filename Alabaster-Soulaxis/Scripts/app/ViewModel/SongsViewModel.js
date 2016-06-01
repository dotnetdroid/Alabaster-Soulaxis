var SongsViewModel = function () {
    var self = this;
    this.CurrentLineup = ko.observable();
    this.Favorites = ko.observable();
    this.SongList = ko.observable();
    this.LoadData = function () {
        $.ajax({
            url: "/api/song/GetSongs",
            contentType: 'application/json',
            success: function (result) {
                self.SongList(result);
            },
            beforeSend: function () {
                //$("#loadingPanel").fadeIn();
            },
            error: function (err) {
                //$("#loadingPanel").fadeOut();
            }

        });
        $.ajax({
            url: "/api/song/GetCurrentLineup",
            contentType: 'application/json',
            success: function (result) {
                self.CurrentLineup(result);
            },
            beforeSend: function () {
                //$("#loadingPanel").fadeIn();
            },
            error: function (err) {
                //$("#loadingPanel").fadeOut();
            }
        });
        $.ajax({
            url: "/api/song/GetFavorites",
            contentType: 'application/json',
            success: function (result) {
                self.Favorites(result);
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