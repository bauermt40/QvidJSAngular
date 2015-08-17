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
        when('/customer/orders/:Id', {
            templateUrl: '/app/Customer/customerOrdersList.html',
            controller: 'customerOrdersViewModel'
        });

      $locationProvider.html5Mode({
          enabled: true,
          requireBase: false
      });
}]);

mainApp.service("currentCustomer", function () {
    var currentCustomer = this;
});

var customerControllers = angular.module('customerControllers', []);