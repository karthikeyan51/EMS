/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditAcademicYearSetup.Delete_execute = function (screen) {
    screen.AcademicYearSetup.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};