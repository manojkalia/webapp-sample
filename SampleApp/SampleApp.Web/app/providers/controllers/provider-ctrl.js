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

app.controller('ProviderDetailCtrl', ['$scope', '$location', '$stateParams', 'CommonFactory', 'ProviderFactory', function ($scope, $location, $stateParams, CommonFactory, ProviderFactory) {
    ProviderFactory.get({ key: $stateParams.key }, function (response) {
       
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
}]);