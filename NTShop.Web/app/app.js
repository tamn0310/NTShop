(function () {
    angular.module('ntshop', ['ntshop.products','ntshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller:"homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();