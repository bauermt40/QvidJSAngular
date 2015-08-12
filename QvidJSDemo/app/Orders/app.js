var mainApp = angular.module('mainApp', [
  'ngRoute',
  'orderControllers'
]);

mainApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider.
        when('/Orders/', {
            templateUrl: '/app/Orders/customerlist.html',
            controller: 'customerdetailsviewmodel'
        }).
        when('/customer/details/:Id', {
            templateUrl: '/app/Home/customerdetails.html',
            controller: 'customerdetailsviewmodel'
        }).
        otherwise({
            redirectTo: '/'
        });

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
}]);

mainApp.factory('Orders', function () {
    return {};
});

var orderControllers = angular.module('orderControllers', []);