'use strict';

/**
 * @ngdoc service
 * @name gftApp.Lancamentos
 * @description
 * # Lancamentos
 * Factory in the gftApp.
 */
angular.module('gftApp')
  .factory('Lancamentos', ['$http','appSettings',function ($http, appSettings) {
    
    var _url = appSettings.LancamentoAPI + '/lancamentos';
    
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