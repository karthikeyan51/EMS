/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditRelievingType.Delete_execute = function (screen) {
    screen.RelievingType.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });
};