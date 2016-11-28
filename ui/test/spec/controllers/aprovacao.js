'use strict';

describe('Controller: AprovacaoCtrl', function () {

  // load the controller's module
  beforeEach(module('gftApp'));

  var AprovacaoCtrl,
    scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    AprovacaoCtrl = $controller('AprovacaoCtrl', {
      $scope: scope
      // place here mocked dependencies
    });
  }));

  it('should attach a list of awesomeThings to the scope', function () {
    expect(AprovacaoCtrl.awesomeThings.length).toBe(3);
  });
});
