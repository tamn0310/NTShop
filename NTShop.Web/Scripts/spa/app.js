
var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);

//declare
function schoolController($scope) {
    $scope.message = "Announcement from school";
}
function studentController($scope) {
    $scope.message = "This is my message from student";
}
function teacherController($scope) {
    $scope.message = "This is my message from teacher";
}
