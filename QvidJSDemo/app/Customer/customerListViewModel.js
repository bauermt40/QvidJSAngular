customerControllers.controller('customerListViewModel', ['$scope', function ($scope) {

    $scope.pageHeading = "Customer List";

    $scope.addNewCustomer = function () {
        $scope.Customers.push({ 'FirstName': $scope.firstName, 'LastName': $scope.lastName, 'Address': $scope.address, 'City': $scope.city });
        $scope.firstName = '';
        $scope.lastName = '';
        $scope.address = '';
        $scope.city = '';
    };

}]);