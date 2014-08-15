app.controller('ProviderCtrl', ['$scope', '$location', '$state', 'CommonFactory', 'ProviderFactory', function ($scope, $location, $state, CommonFactory, ProviderFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Providers";
    $scope.Title = "Providers - list";

    // Calling categories list
    ProviderFactory.get(function (response) {
        console.log(response.value);
        $scope.providers = response.value;
    });

    //// edit category object
    //$scope.editCategory = function (categoryId) {
    //    $state.go('category-detail', { "key": categoryId });
    //    // $location.path('/category-detail/?' + categoryId);
    //}

    // delete category object
    //$scope.deleteCategory = function (categoryId) {
    //    CategoryFactory.remove({ key: categoryId }, function (response) {
    //        CategoryFactory.get(function (response) {
    //            $scope.categories = response.value;
    //        });
    //    });
    //}

}])