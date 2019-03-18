(function (app) {
    app.controller('rootController', rootController);
    rootController.$inject = ['$scope','$state']
    function rootController($scope, $state) {
        $scope.logout = function () {
            $state.go('login');
        }
    }
})(angular.module('ntshop'));
/*$state như kiểu điều hướng trang muốn đến khi để trang cần đến vào hai dấu nháy đơn*/