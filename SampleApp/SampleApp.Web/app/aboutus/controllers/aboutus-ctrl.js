app.controller('AboutUsCtrl', ['$scope', '$location', 'CommonFactory', function ($scope, $location, CommonFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "About Us";

}]);