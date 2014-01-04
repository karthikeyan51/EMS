/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditDocument.Delete_execute = function (screen) {
    screen.Document.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};