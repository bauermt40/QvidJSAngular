invoicesControllers.controller('invoicesRootViewModel', ['$scope', function ($scope) {

    $scope.init = function (data) {
        //This function is sort of private constructor for controller

        $scope.Invoices = data.Invoices;
    };

}]);