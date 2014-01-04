/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditReligion.Delete_execute = function (screen) {
    screen.Religion.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};