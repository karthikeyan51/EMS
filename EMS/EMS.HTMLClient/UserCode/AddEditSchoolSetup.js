/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditSchoolSetup.Delete_execute = function (screen) {
    screen.SchoolSetup.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};