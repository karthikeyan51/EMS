/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditDivisionMaster.Delete_execute = function (screen) {
    screen.DivisionMaster.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};