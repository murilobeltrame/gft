'use strict';

/**
 * @ngdoc service
 * @name gftApp.Lancamentos
 * @description
 * # Lancamentos
 * Factory in the gftApp.
 */
angular.module('gftApp')
  .factory('Lancamentos', function () {
    // Service logic
    // ...

    var meaningOfLife = 42;

    // Public API here
    return {
      someMethod: function () {
        return meaningOfLife;
      }
    };
  });
