var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.service('ValidatorService', ValidatorService);
myApp.directive('ntShopDirective', ntShopDirective);

schoolController.$inject = ['$scope', 'ValidatorService'];

//declare
function schoolController($scope, ValidatorService) {
    $scope.checkNumber = function () {
        $scope.message = ValidatorService.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function ValidatorService() {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return "This is even";
        }
        else
            return "This is odd";
    }
}

function ntShopDirective() {
    return {
        template: "<h1>This is my first custom Directive<h1/>"
    }
}