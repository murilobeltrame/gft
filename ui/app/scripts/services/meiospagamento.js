'use strict';

/**
 * @ngdoc service
 * @name gftApp.meiospagamento
 * @description
 * # meiospagamento
 * Factory in the gftApp.
 */
angular.module('gftApp')
  .factory('meiospagamento', ['$http','appSettings',function ($http, appSettings) {
    var _url = appSettings.MeiosPagamentoAPI + '/meiospagamento';
    
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
