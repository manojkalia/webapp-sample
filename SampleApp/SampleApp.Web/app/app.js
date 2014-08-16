var app = angular.module("DemoSite", ['ui.router', 'app.filters', 'app.services', 'app.directives']);

app.config(['$locationProvider', '$stateProvider', '$urlRouterProvider', function ($locationProvider, $stateProvider, $urlRouterProvider) {
    $locationProvider.html5Mode(true);
    $urlRouterProvider.otherwise('/providers');

    $urlRouterProvider.rule(function ($injector, $location) {
        var path = $location.path();
        var normalized = path.toLowerCase();
        if (path != normalized) {
            $location.replace().path(normalized);
        }
    });


    $stateProvider
            .state('providers', {
                url: '/providers',
                templateUrl: 'app/providers/views/provider.html',
                controller: 'ProviderCtrl'
            })

    $stateProvider
            .state('provider-detail', {
                url: '/provider-detail/:key',
                templateUrl: 'app/providers/views/provider-detail.html',
                controller: 'ProviderDetailCtrl'
            })

    $stateProvider
            .state('home', {
                url: '/home',
                templateUrl: 'app/home/views/home.html',
                controller: 'HomeCtrl'
            })


    $stateProvider
            .state('contact-us', {
                url: '/contactus',
                templateUrl: 'app/contactus/views/contactus.html',
                controller: 'ContactUsCtrl'
            })

    $stateProvider
            .state('about-us', {
                url: '/aboutus',
                templateUrl: 'app/aboutus/views/aboutus.html',
                controller: 'AboutUsCtrl'
            })
            


}]);