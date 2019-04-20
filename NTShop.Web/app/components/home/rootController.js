(function (app) {
    app.controller('rootController', rootController);

    rootController.$inject = ['$state', 'authData', 'loginService', '$scope', 'authenticationService'];

    function rootController($state, authData, loginService, $scope, authenticationService) {
        $scope.logOut = function () {
            loginService.logOut();
            $state.go('login');
        }
        $scope.authentication = authData.authenticationData;

        authenticationService.validateRequest();
    }
})(angular.module('ntshop'));
/*$state như kiểu điều hướng trang muốn đến khi để trang cần đến vào hai dấu nháy đơn*/