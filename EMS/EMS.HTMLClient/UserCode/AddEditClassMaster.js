/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditClassMaster.Delete_execute = function (screen) {
    screen.ClassMaster.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};