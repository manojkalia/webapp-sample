﻿app.controller('ConsultantCtrl', ['$scope', '$location', '$state', 'CommonFactory', 'ConsultantFactory', function ($scope, $location, $state, CommonFactory, ConsultantFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Consultants";
    $scope.Title = "Consultants - list";

    // Calling consultants list
    ConsultantFactory.query(function (response) {

        $scope.consultants = response;
    });

    // edit Conslutant object
    $scope.addEditConsultant = function (consultant) {
        $scope.isConsultantShow = true;
        $scope.ConsultantDetail = {};
        $scope.ConsultantDetail.Id = consultant.Id;
        $scope.ConsultantDetail.Name = consultant.Name;
        
    }

    $scope.addUpdateConsultant = function (consultant) {
       // consultant.ProviderId = $scope.ProviderDetail.Id;
        ConsultantFactory.save(consultant, function (response) {
            $scope.isConsultantShow = false;
            ConsultantFactory.query(function (response) {

                $scope.consultants = response;
            });
        });
    }


    //delete Provider object
    $scope.deleteConsultant = function (consultantId) {

        var conf = confirm("Are you sure you want to delete this Consultant?");
        if (conf) {
            ConsultantFactory.remove({ key: consultantId }, function (response) {
                ConsultantFactory.query(function (response) {

                    $scope.consultants = response;
                });
            });
        }
    }

}])
