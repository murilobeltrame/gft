'use strict';

describe('Service: meiospagamento', function () {

  // load the service's module
  beforeEach(module('gftApp'));

  // instantiate service
  var meiospagamento;
  beforeEach(inject(function (_meiospagamento_) {
    meiospagamento = _meiospagamento_;
  }));

  it('should do something', function () {
    expect(!!meiospagamento).toBe(true);
  });

});
