(function () {
    angular.module('ntshop.about', ['ntshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('about', {
                url: "/about",
                parent: 'base',
                templateUrl: "/app/shared/about/aboutListView.html",
                controller: "aboutListController"
            }).state('about_add', {
                url: "/about_add",
                parent: 'base',
                templateUrl: "/app/shared/about/aboutAddView.html",
                controller: "aboutAddController"
            }).state('about_edit', {
                url: "/about_edit/:id",
                parent: 'base',
                templateUrl: "/app/shared/about/aboutEditView.html",
                controller: "aboutEditController"
            });
    }
})();/*ở đây parent : base để kế thừa từ trang base view nếu không kế thừa từ base view thì mặc định sẽ hiện mỗi trang đó không hiện navigation bar và MAIN NAVIGATION*/