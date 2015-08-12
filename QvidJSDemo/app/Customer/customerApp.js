var mainApp = angular.module('mainApp', [
  'ngRoute',
  'customerControllers'
]);

mainApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider.
        when('/', {
            templateUrl: '/app/Customer/customerList.html',
            controller: 'customerListViewModel'
        }).
        when('/customers', {
            templateUrl: '/app/Customer/customerList.html',
            controller: 'customerListViewModel'
        }).
        when('/customer/details/:Id', {
            templateUrl: '/app/Customer/customerDetails.html',
            controller: 'customerDetailsViewModel'
        }).
        otherwise({
            redirectTo: '/'
        });

      $locationProvider.html5Mode({
          enabled: true,
          requireBase: false
      });
}]);

mainApp.factory('Customers', function () {
    return {};
});

var customerControllers = angular.module('customerControllers', []);