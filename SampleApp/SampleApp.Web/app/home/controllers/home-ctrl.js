app.controller('HomeCtrl', ['$scope', '$location', 'CommonFactory', function ($scope, $location, CommonFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Home";

}]);