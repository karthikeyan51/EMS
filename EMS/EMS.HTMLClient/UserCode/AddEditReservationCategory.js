/// <reference path="../GeneratedArtifacts/viewModel.js" />

myapp.AddEditReservationCategory.Delete_execute = function (screen) {
    screen.ReservationCategory.deleteEntity();
    return myapp.commitChanges().then(null, function fail(e) {
        myapp.cancelChanges();
        throw e;
    });

};