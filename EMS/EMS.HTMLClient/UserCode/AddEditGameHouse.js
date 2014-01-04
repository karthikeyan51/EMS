/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditGameHouse.Delete_execute = function (screen) {
    screen.GameHouse.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });
};