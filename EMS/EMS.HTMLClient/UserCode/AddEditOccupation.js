/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditOccupation.Delete_execute = function (screen) {
    screen.Occupation.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};