/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditBloodGroup.Delete_execute = function (screen) {
    screen.BloodGroup.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });
};