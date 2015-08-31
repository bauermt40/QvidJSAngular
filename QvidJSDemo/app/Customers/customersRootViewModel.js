customersControllers.controller('customersRootViewModel', ['$scope', function ($scope) {

    $scope.init = function (data) {
        //This function is sort of private constructor for controller
        
        if (sessionStorage.Customers == undefined) {
            $scope.Customers = data.Customers;
        } else {
            $scope.Customers = JSON.parse(sessionStorage['Customers']);
        }
    };

}]);