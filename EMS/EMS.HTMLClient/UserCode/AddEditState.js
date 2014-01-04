/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditState.Delete_execute = function (screen) {
    screen.State.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};