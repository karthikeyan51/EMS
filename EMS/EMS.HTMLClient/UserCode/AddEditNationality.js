/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditNationality.Delete_execute = function (screen) {
    screen.Nationality.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};