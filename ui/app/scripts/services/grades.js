'use strict';

/**
 * @ngdoc service
 * @name gftApp.grades
 * @description
 * # grades
 * Factory in the gftApp.
 */
angular.module('gftApp')
  .factory('grades', ['$http','appSettings',function ($http, appSettings) {
    var _url = appSettings.GradeAPI + '/grades';
    
    var _get = function(query){
      var _queryUrl = _url;
      if (query) { _queryUrl = _queryUrl + '/' + query; }
      return $http.get(_queryUrl)
        .then(function(resultados){ return resultados; })
        .catch(function(erro){});
    }

    return {
      get: _get
    };
  }]);
