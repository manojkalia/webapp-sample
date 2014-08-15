app.controller('ManageCategoryCtrl', ['$scope', '$location', '$state', 'CommonFactory', 'CategoryFactory', function ($scope, $location, $state, CommonFactory, CategoryFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Category";
    $scope.Title = "Tube-Category-List";

    // Calling categories list
    CategoryFactory.get(function (response) {
        $scope.categories = response.value;
    });

    // edit category object
    $scope.editCategory = function (categoryId) {
        $state.go('category-detail', { "key": categoryId });
        // $location.path('/category-detail/?' + categoryId);
    }

    // delete category object
    $scope.deleteCategory = function (categoryId) {
        CategoryFactory.remove({ key: categoryId }, function (response) {
            CategoryFactory.get(function (response) {
                $scope.categories = response.value;
            });
        });
    }

}])
app.controller('CategoryCreationCtrl', ['$scope', '$location', 'CommonFactory', 'CategoryFactory', function ($scope, $location, CommonFactory, CategoryFactory) {
    // create new category object
    $scope.category = {};
    $scope.createNewCategory = function (category) {
        CategoryFactory.save(category, function (response) {
            $location.path('/category-list');
        });
    }
}])
app.controller('CategoryDetailCtrl', ['$scope', '$location', '$stateParams', 'CommonFactory', 'CategoryFactory', function ($scope, $location, $stateParams, CommonFactory, CategoryFactory) {
    CategoryFactory.query({ key: $stateParams.key }, function (response) {
        $scope.categoryDetail = response.value[0];
    });
    $scope.goToHome = function () {
        $location.path('/tube-home');
    }
    $scope.updateCategory = function (category) {
        CategoryFactory.update({ key: category.CategoryID }, category, function (response) {
            $location.path('/category-list');
        });
    }
}]);