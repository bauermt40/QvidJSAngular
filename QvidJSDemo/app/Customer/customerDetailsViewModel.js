customerControllers.controller('customerDetailsViewModel', ['$scope', '$routeParams', '$http',
    function ($scope, $routeParams, $http) {
        var _url = '/Home/GetCustomerDetails/' + $routeParams.Id;
        $http.get(_url).then(function (result) {
            $scope.Customer = result.data;
            $scope.pageHeading = 'Details for ' + result.data.FirstName + ' ' + result.data.LastName;
        });

        $scope.updateCustomerData = function () {
            var data = JSON.stringify($scope.Customer);
            $http.post("/Home/UpdateCustomerData/", data).success(function (result, status) {
                sessionStorage['Customers'] = JSON.stringify(result.Customers);
                $scope.resultMessage = result.ResultMessage;
            })
        };
    }
]);