(function (app) {
    app.controller('revenueStatisticController', revenueStatisticController);

    revenueStatisticController.$inject = ['$scope','apiService','notificationService','$filter'];

    function revenueStatisticController($scope, apiService, notificationService, $filter) {
        $scope.data = [];

        $scope.labels = [];
        $scope.series = ['Doanh Số', 'Lợi Nhuận'];

        $scope.chartdata = [];

        function getStatistic() {
            var config = {
                param: {
                    fromDate: '01/01/2019',
                    toDate:'01/01/2020'
                }
            }
            apiService.get('/api/statistic/getrevenue?fromDate=' + config.param.fromDate + "&toDate=" + config.param.toDate,null, function (response) {
                $scope.data = response.data;

                var labels = [];
                var chartdata = [];
                var revenues = [];
                var benefit = [];
                $.each(response.data, function (i, item) {
                    labels.push($filter('date')(item.Date,'dd/MM/yyyy'));
                    revenues.push(item.Revenues);
                    benefit.push(item.Benefit);

                });
                chartdata.push(revenues);
                chartdata.push(benefit);

                $scope.chartdata = chartdata;
                $scope.labels = labels;
            }, function (response) {
                notificationService.displayError('Không thể tải dữ liệu.');
            });
        }
        getStatistic();
    }

})(angular.module('ntshop.statistics'));