'use strict';

/**
 * @ngdoc overview
 * @name gftApp
 * @description
 * # gftApp
 *
 * Main module of the application.
 */
angular
  .module('gftApp', [
    'ngAnimate',
    'ngAria',
    'ngCookies',
    'ngMessages',
    'ngResource',
    'ngRoute',
    'ngSanitize',
    'ngTouch',
    'ui.bootstrap'
  ])
  .config(function ($routeProvider) {
    $routeProvider
      .when('/', {
        templateUrl: 'views/aprovacao.html',
        controller: 'AprovacaoCtrl',
        controllerAs: 'ctrl'
      })
      .otherwise({
        redirectTo: '/'
      });
  });
