var mainApp = angular.module('mainApp', [
  'ngRoute',
  'invoicesControllers'
]);

mainApp.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {

    $routeProvider.
        when('/invoices', {
            templateUrl: '/app/Invoices/invoicesList.html',
            controller: 'invoicesListViewModel'
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

var invoicesControllers = angular.module('invoicesControllers', []);