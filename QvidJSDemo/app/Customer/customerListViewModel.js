customerControllers.controller('customerListViewModel', ['$scope', '$http', '$location',
    function ($scope, $http, $location) {

        $scope.pageHeading = "Customer List";

        $scope.addNewCustomer = function () {

            $scope.Customer.Orders = [];
            var data = JSON.stringify($scope.Customer);
            $http.post("/Home/AddNewCustomer/", data).success(function (result, status) {
                //Update $scope.Customers
                $scope.Customers = result.Customers;

                //Persist the data for this session
                sessionStorage['Customers'] = JSON.stringify(result.Customers);

                $scope.resultMessage = result.ResultMessage;

                //Clear the form
                $scope.Customer.firstName = '';
                $scope.Customer.lastName = '';
                $scope.Customer.address = '';
                $scope.Customer.city = '';
            });
        };

        $scope.removeCustomer = function () {

            var data = JSON.stringify($scope.Customer);
            $http.post("/Home/DeleteCustomer/", data).success(function (result, status) {

                //Update $scope.Customers
                $scope.Customers = result.Customers;

                //Persist the data for this session
                sessionStorage['Customers'] = JSON.stringify(result.Customers);
            });
        };

        $scope.showCustomerOrders = function (customer) {
            currentCustomer = customer;
            $location.path('/customer/orders/' + customer.Id);
        };
    }
]);