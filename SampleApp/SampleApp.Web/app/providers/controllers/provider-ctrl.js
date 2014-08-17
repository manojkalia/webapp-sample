app.controller('ProviderCtrl', ['$scope', '$location', '$state', 'CommonFactory', 'ProviderFactory', function ($scope, $location, $state, CommonFactory, ProviderFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Providers";
    $scope.Title = "Providers - list";

    // Calling categories list
    ProviderFactory.query(function (response) {

        $scope.providers = response;
    });

    // edit Provider object
    $scope.addEditProvider = function (providerId) {
        $state.go('provider-detail', { "key": providerId });
        // $location.path('/category-detail/?' + categoryId);
    }



    //delete Provider object
    $scope.deleteProvider = function (providerId) {

        var conf = confirm("Are you sure you want to delete this Provider?");
        if (conf) {
            ProviderFactory.remove({ key: providerId }, function (response) {
                ProviderFactory.query(function (response) {

                    $scope.providers = response;
                });
            });
        }
    }

}])

app.controller('ProviderDetailCtrl', ['$scope', '$location', '$stateParams', 'CommonFactory', 'ProviderFactory', 'ContractFactory', 'SiteLocationFactory', function ($scope, $location, $stateParams, CommonFactory, ProviderFactory, ContractFactory, SiteLocationFactory) {
    ProviderFactory.get({ key: $stateParams.key }, function (response) {
        console.log(response);
        $scope.ProviderDetail = response;
        $scope.isAdd = !($scope.ProviderDetail.Name) ? true : false;

    });
    $scope.goToHome = function () {
        $location.path('/providers');
    }
    $scope.updateProvider = function (provider) {
        ProviderFactory.update({ key: provider.Id }, provider, function (response) {
            $location.path('/providers');
        });
    }

    $scope.createNewProvider = function (provider) {
        console.log(provider);
        ProviderFactory.save(provider, function (response) {
            $location.path('/providers');
        });
    }

    $scope.isContractShow = false;

    //-------------------------#Region Contracts-------------------------------------------


    // edit Contract object
    $scope.addEditContract = function (contract) {
        $scope.isContractShow = true;
        $scope.ContractDetail = {};
        $scope.ContractDetail.Id = contract.Id;
        $scope.ContractDetail.Number = contract.Number;
        $scope.ContractDetail.Code = contract.Code;
    }

    $scope.Cancel = function (contract) {
        $scope.isContractShow = false;
    }

    $scope.addUpdateContract = function (contract) {
        contract.ProviderId = $scope.ProviderDetail.Id;
        ContractFactory.save(contract, function (response) {
            $scope.isContractShow = false;
            ProviderFactory.get({ key: $scope.ProviderDetail.Id }, function (response) {
                console.log(response);

                $scope.ProviderDetail.Contracts = response.Contracts;

            });
        });
    }


    //delete Contract object
    $scope.deleteContract = function (contractId) {

        var conf = confirm("Are you sure you want to delete this Contract?");
        if (conf) {
            ContractFactory.remove({ key: contractId }, function (response) {
                ProviderFactory.get({ key: $scope.ProviderDetail.Id }, function (response) {
                    console.log(response);

                    $scope.ProviderDetail.Contracts = response.Contracts;

                });
            });
        }
    }

    //-------------------------End Region--------------------------------------------------

    //-------------------------#Region SiteLocation-------------------------------------------
    // edit Contract object
    $scope.addEditSiteLocation = function (siteLocation) {
        $scope.isSiteLocationShow = true;
        $scope.siteLocationDetail = {};
        $scope.siteLocationDetail.Id = siteLocation.Id;
        $scope.siteLocationDetail.Address = siteLocation.Address;
        $scope.siteLocationDetail.NPI = siteLocation.NPI;
        $scope.siteLocationDetail.HFS = siteLocation.HFS;
    }

    $scope.addUpdateSiteLocation = function (siteLocation) {
        siteLocation.ProviderId = $scope.ProviderDetail.Id;
        SiteLocationFactory.save(siteLocation, function (response) {
            $scope.isSiteLocationShow = false;
            ProviderFactory.get({ key: $scope.ProviderDetail.Id }, function (response) {
                console.log(response);

                $scope.ProviderDetail.SiteLocations = response.SiteLocations;

            });
        });
    }


    //delete Contract object
    $scope.deleteSiteLocation = function (siteLocationId) {

        var conf = confirm("Are you sure you want to delete this SiteLocation?");
        if (conf) {
            SiteLocationFactory.remove({ key: siteLocationId }, function (response) {
                ProviderFactory.get({ key: $scope.ProviderDetail.Id }, function (response) {
                    console.log(response);

                    $scope.ProviderDetail.SiteLocations = response.SiteLocations;

                });
            });
        }
    }
    //-------------------------End Region--------------------------------------------------


}]);