app.controller('ActivityCtrl', ['$scope', '$location', '$state', 'CommonFactory', 'ActivityFactory', function ($scope, $location, $state, CommonFactory, ActivityFactory) {
    $scope.common = CommonFactory;
    $scope.pageTitle = "Activities";
    $scope.Title = "Activities - list";

    // Calling consultants list
    ActivityFactory.query(function (response) {

        $scope.activities = response;
    });

    // edit Conslutant object
    $scope.addEditActivity = function (activity) {
        $scope.isActivityShow = true;
        $scope.ActivityDetail = {};
        $scope.ActivityDetail.Id = activity.Id;
        $scope.ActivityDetail.Name = activity.Name;
        $scope.ActivityDetail.DeskReview = activity.DeskReview;
        $scope.ActivityDetail.OnsiteReview = activity.OnsiteReview;
      
    }

    $scope.addUpdateActivity = function (activity) {
        // consultant.ProviderId = $scope.ProviderDetail.Id;
        ActivityFactory.save(activity, function (response) {
            $scope.isActivityShow = false;
            ActivityFactory.query(function (response) {

                $scope.activities = response;
            });
        });
    }


    //delete Provider object
    $scope.deleteActivity = function (activityId) {

        var conf = confirm("Are you sure you want to delete this Activity?");
        if (conf) {
            ActivityFactory.remove({ key: activityId }, function (response) {
                ActivityFactory.query(function (response) {

                    $scope.activities = response;
                });
            });
        }
    }

}])

