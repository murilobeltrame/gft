'use strict';

describe('Service: Lancamentos', function () {

  // load the service's module
  beforeEach(module('gftApp'));

  // instantiate service
  var Lancamentos;
  beforeEach(inject(function (_Lancamentos_) {
    Lancamentos = _Lancamentos_;
  }));

  it('should do something', function () {
    expect(!!Lancamentos).toBe(true);
  });

});
