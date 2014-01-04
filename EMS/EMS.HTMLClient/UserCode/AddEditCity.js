/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditCity.Delete_execute = function (screen) {
    screen.City.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};