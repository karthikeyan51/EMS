/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditCountry.Delete_execute = function (screen) {
    screen.Country.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });
};