customerControllers.controller('customerOrdersViewModel', ['$scope',
    function ($scope) {

        $scope.customerName = currentCustomer.FirstName + " " + currentCustomer.LastName;
        $scope.Orders = currentCustomer.Orders;

    }
]);