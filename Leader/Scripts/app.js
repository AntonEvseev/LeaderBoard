var app = angular.module('app', []);
app.controller('AppController', function ($scope, $http, GamersService, GamesService) {

    $scope.onId = false;
    $scope.onTable = false;
    $scope.gamers = null;
    $scope.filters = {};
      
    $scope.sort = function (value) {
        $scope.onTable = true;
        $scope.filters = value;
    }
   
    GamersService.GetAllRecords().then(function (d) {
        $scope.gamers = d.data;
    }, function () {
        alert('Ошибка соединения с базой данных !!!');
    });

    GamesService.GetAllGames().then(function (d) {
        $scope.games = d.data;
    }, function () {
        alert('Ошибка соединения с базой данных !!!');
    });
    
});


app.factory('GamersService', function ($http) {
    var fac = {};
    fac.GetAllRecords = function () {
        return $http.get('/api/Leader/');
    }
    return fac;
});

app.factory('GamesService', function ($http) {
    var fac = {};
    fac.GetAllGames = function () {
        return $http.get('/api/game/');
    }
    return fac;
});