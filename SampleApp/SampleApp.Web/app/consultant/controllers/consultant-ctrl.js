app.controller('ConsultantCtrl', ['$scope', '$location', '$state', 'CommonFactory', 'ConsultantFactory', 'ProviderFactory', function ($scope, $location, $state, CommonFactory, ConsultantFactory, ProviderFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Consultants";
    $scope.Title = "Consultants - list";

    // Calling consultants list
    ConsultantFactory.query(function (response) {

        $scope.consultants = response;
    });

    ProviderFactory.query(function (response) {

        $scope.Allproviders = response;
    });

    // edit Conslutant object
    $scope.addEditConsultant = function (consultant) {

        $scope.isConsultantShow = true;
        $scope.ConsultantDetail = {};
        if (consultant != undefined) {
            $scope.ConsultantDetail.Id = consultant.Id;
            $scope.ConsultantDetail.Name = consultant.Name;
            $scope.ConsultantDetail.ConsultantProviderIds = consultant.ConsultantProviderIds;
            angular.forEach($scope.Allproviders, function (value, key) {
                value.IsChecked = false;
                if ($scope.ConsultantDetail.ConsultantProviderIds.indexOf(value.Id) >= 0) {
                    value.IsChecked = true;
                }


            });
        }
        else {
            
            angular.forEach($scope.Allproviders, function (value, key) {


                value.IsChecked = false;



            });

        }


    }

    $scope.checkboxChange = function (providerId, isChecked) {

        if ($scope.ConsultantDetail.ConsultantProviderIds == undefined)
        {
            $scope.ConsultantDetail.ConsultantProviderIds = [];
        }
        var index = $scope.ConsultantDetail.ConsultantProviderIds.indexOf(providerId);
        if (!isChecked) {

            if (index < 0)
                $scope.ConsultantDetail.ConsultantProviderIds.push(providerId);
            console.log($scope.ConsultantDetail.ConsultantProviderIds);

        }
        else {

            $scope.ConsultantDetail.ConsultantProviderIds.splice(index, 1);
            console.log($scope.ConsultantDetail.ConsultantProviderIds);
        }




        $scope.removeItem = function (index) {
            $scope.items.splice(index, 1);
        }
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

