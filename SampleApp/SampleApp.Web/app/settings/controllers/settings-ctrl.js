app.controller('SettingsCtrl', ['$scope', '$location', 'CommonFactory', function ($scope, $location, CommonFactory) {
    $scope.common = CommonFactory;
    $scope.Title = "settings";

}]);