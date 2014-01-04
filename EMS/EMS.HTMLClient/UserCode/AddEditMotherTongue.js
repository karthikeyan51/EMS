/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditMotherTongue.Delete_execute = function (screen) {
    screen.MotherTongue.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });
};