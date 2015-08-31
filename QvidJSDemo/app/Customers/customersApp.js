var mainApp = angular.module('mainApp', [
  'ngRoute',
  'customersControllers'
]);

mainApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider.
        when('/', {
            templateUrl: '/app/Customers/customersList.html',
            controller: 'customersListViewModel'
        }).
        when('/customers', {
            templateUrl: '/app/Customers/customersList.html',
            controller: 'customersListViewModel'
        }).
        when('/customers/details/:Id', {
            templateUrl: '/app/Customers/customersDetails.html',
            controller: 'customersDetailsViewModel'
        }).
        when('/customers/orders/:Id', {
            templateUrl: '/app/Customers/customersOrdersList.html',
            controller: 'customersOrdersViewModel'
        });

      $locationProvider.html5Mode({
          enabled: true,
          requireBase: false
      });
}]);

mainApp.service("currentCustomer", function () {
    var currentCustomer = this;
});

var customersControllers = angular.module('customersControllers', []);