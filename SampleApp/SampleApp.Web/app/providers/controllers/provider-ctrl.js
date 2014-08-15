app.controller('ProviderCtrl', ['$scope', '$location', 'CommonFactory', function ($scope, $location, CommonFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Provider";

}]);