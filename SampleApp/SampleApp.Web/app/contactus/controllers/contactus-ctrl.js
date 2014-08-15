app.controller('ContactUsCtrl', ['$scope', '$location', 'CommonFactory', function ($scope, $location, CommonFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Contact Us";

}]);