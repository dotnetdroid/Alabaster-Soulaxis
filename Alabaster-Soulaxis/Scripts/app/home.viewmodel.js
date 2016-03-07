function HomeViewModel(app, dataModel) {
    var self = this;

    self.myHometown = ko.observable("");
    return self;
}

app.addViewModel({
    name: "Home",
    bindingMemberName: "home",
    factory: HomeViewModel
});
