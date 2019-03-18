(function () {
    angular.module('ntshop.products', ['ntshop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider
            .state('products', {
                url: "/products",
                parent:'base',
                templateUrl: "/app/components/products/productListView.html",
                controller: "productListController"
            }).state('products_add', {
                url: "/products_add",
                parent: 'base',
                templateUrl: "/app/components/products/productAddView.html",
                controller: "productAddController"
            }).state('products_edit', {
                url: "/products_edit/:id",
                parent: 'base',
                templateUrl: "/app/components/products/productEditView.html",
                controller: "productEditController"
            });
    }
})();/*ở đây parent : base để kế thừa từ trang base view nếu không kế thừa từ base view thì mặc định sẽ hiện mỗi trang đó không hiện navigation bar và MAIN NAVIGATION*/