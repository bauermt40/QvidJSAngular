appMainModule.controller('OrdersController', ['$scope', function ($scope) {

    $scope.init = function (data) {
        //This function is sort of private constructor for controller
        $scope.CustomerName = data.CustomerName;
        $scope.Orders = data.Orders;
    };

    $scope.pageHeading = "This is the page heading for Orders";

}]);