// 'use strict';

// /**
//  * @ngdoc function
//  * @name gftApp.controller:AprovacaoCtrl
//  * @description
//  * # AprovacaoCtrl
//  * Controller of the gftApp
//  */
// angular.module('gftApp')
//   .controller('AprovacaoCtrl', function () {
//     this.awesomeThings = [
//       'HTML5 Boilerplate',
//       'AngularJS',
//       'Karma'
//     ];
//   });

(function (angular) {

    'use strict';

    /**
     * @ngdoc function
     * @name gftApp.controller:AprovacaoCtrl
     * @description
     * # AprovacaoCtrl
     * Controller of the gftApp
     */
    angular
        .module('gftApp')
        .controller('AprovacaoCtrl', AprovacaoController)
        .controller('ConfirmarAprovacaoCtrl', ConfirmarAprovacaoController)
        .controller('ConfirmarReprovacaoCtrl', ConfirmarReprovacaoController)
        .controller('SolicitarExcedenteCtrl', SolicitarExcedenteController);

    AprovacaoController.$inject = ['$uibModal', 'grades', 'lancamentos'];

    function AprovacaoController($uibModal, grades, lancamentos) {

        var _vm = this;

        _vm.PeriodoAtual = {
            Inicio: new Date(2016, 2, 1),
            Fim: new Date(2016, 2, 31)
        };
        _vm.Grades = [];
        _vm.TodosSelecionados = false;
        _vm.Consultorias = [
            { Nome: '3Com' },
            { Nome: 'Sismat' },
            { Nome: 'Essence' },
            { Nome: 'BlendIT' },
            { Nome: 'Accenture' }
        ];
        _vm.Terceiros = [
            { Nome: 'Carolina Jacob dos Santos' },
            { Nome: 'Fabio Contatto' },
            { Nome: 'Allan Ricardo de Morais' },
            { Nome: 'Vinicius Trivinho Rodrigues Silva' },
            { Nome: 'Luiz Gabriel Gasparelli' },
            { Nome: 'Osvaldo Domingos Costa Junior' },
            { Nome: 'Vania Aparecida Marques' },
            { Nome: 'Claudia Cristiane Oriani Pezzato' },
        ];
        _vm.Responsaveis = [
            { Nome: 'Tiago Gomes Fernandez' },
            { Nome: 'Bruno Roberto Terossi' },
            { Nome: 'Regina Helena Moretti' },
            { Nome: 'Sergio Adolfo Catto' },
        ];
        _vm.Unidades = [
            { Nome: 'Barra São Paulo - Raizen Energia S.A.' },
            { Nome: 'Base de Jaraguá do Sul - Raizen MIME Combust S.A.' },
            { Nome: 'Benalcool - Raizen Energia S.A.' },
            { Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc' },
        ];
        _vm.Periodos = [
            { Inicio: new Date(2016, 0, 1), Fim: new Date(2016, 0, 31) },
            { Inicio: new Date(2016, 1, 1), Fim: new Date(2016, 1, 28) },
            { Inicio: new Date(2016, 2, 1), Fim: new Date(2016, 2, 31) },
            { Inicio: new Date(2016, 3, 1), Fim: new Date(2016, 3, 30) },
            { Inicio: new Date(2016, 4, 1), Fim: new Date(2016, 4, 31) },
            { Inicio: new Date(2016, 5, 1), Fim: new Date(2016, 5, 30) },
            { Inicio: new Date(2016, 6, 1), Fim: new Date(2016, 6, 31) },
            { Inicio: new Date(2016, 7, 1), Fim: new Date(2016, 7, 31) },
            { Inicio: new Date(2016, 8, 1), Fim: new Date(2016, 8, 30) },
            { Inicio: new Date(2016, 9, 1), Fim: new Date(2016, 9, 31) },
            { Inicio: new Date(2016, 10, 1), Fim: new Date(2016, 10, 30) },
            { Inicio: new Date(2016, 11, 1), Fim: new Date(2016, 11, 31) }
        ];
        _vm.Status = [
            { Descricao: 'Em Aprovação' },
            { Descricao: 'Aprovado' },
            { Descricao: 'Enviado para Faturamento' },
            { Descricao: 'NF Recebida > PT&P' },
            { Descricao: 'Organização Não Atendida' },
            { Descricao: 'Reprovado' }
        ];
        _vm.Lancamentos = [
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Murilo Beltrame Correia',
                    Email: 'murilo.correia@terceirizadoraizen.com'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero:15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP:'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grades:['IF0']
                },
                Data: new Date(2016, 0, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                },
                Grade: 'IF0',
                Erro: {
                    Data: new Date(),
                    Mensagem: 'Solicitações sobre contrato 6000002836 não possíveis, porque contr.não liberado'
                }
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Murilo Beltrame Correia'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 1, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                }
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Murilo Beltrame Correia'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 1, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                }
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Murilo Beltrame Correia'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 2, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                }
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Murilo Beltrame Correia'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 2, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                }
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Murilo Beltrame Correia'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 2, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                }
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Murilo Beltrame Correia'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 2, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                },
                Excedente:true
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'ABCDEF GHIJKL MNOPQRSTUV XYZ ABCDEF GHIJKL MNOPQRSTUV XYZ'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'ABCDEF GHIJKL MNOPQRSTUV XYZ ABCDEF GHIJKL MNOPQRSTUV XYZ',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 2, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                },
                Excedente: true
            },
            {
                Consultoria: {
                    Nome: 'Sismat'
                },
                Terceiro: {
                    Nome: 'Leandro Morelato'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 2, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                }
            },
            {
                Consultoria: {
                    Nome: '3CON CONSULTORIA E SISTEMAS LTDA'
                },
                Terceiro: {
                    Nome: 'Carolina Jacob dos Santos'
                },
                Tipo: {
                    Descricao: 'Demandas TI Nova Versao'
                },
                Requisicao: {
                    Numero: 15950,
                    Descricao: 'Pentágono'
                },
                Unidade: {
                    Nome: 'Araraquara-SP - Raízen Araraquara Ac. Alc',
                    SAP: 'EAB'
                },
                CentroCusto: 'M-027-1516-0025.01',
                Responsavel: {
                    Nome: 'Bruno Chieregato Maniglia',
                    Grade: 'IF0'
                },
                Data: new Date(2016, 2, 1, 8, 0),
                Status: {
                    Descricao: 'NF Recebida > PT&P'
                }
            }
        ];
        _vm.CentrosCusto = [
            { Codigo: 'M-027-1516-0025.01', Unidade: { Nome: 'Piracicaba', SAP: 'EAB' } },
            { Codigo: 'M-027-1516-0025.02', Unidade: { Nome: 'COPI', SAP: 'P72' } },
            { Codigo: 'Z-111-2222-3333.X', Unidade: { Nome: 'CAR', SAP: 'ZZZ' } },
            { Codigo: '1234-4567', Unidade: { Nome: 'CAR', SAP: 'ZYX' } },
            { Codigo: 'Z123', Unidade: { Nome: 'Araraquara', SAP: 'XPTO' } }
        ];
        
        _vm.Algum = algum;
        _vm.SelecionarTodos = selecionarTodos;
        _vm.LancamentosConsolidados = lancamentosConsolidados;
        _vm.AjustarSelecao = ajustarSelecao;
        _vm.NoPeriodo = noPeriodo;
        _vm.Aprovar = aprovar;
        _vm.Reprovar = reprovar;
        _vm.SolicitarExcedentes = solicitarExcedentes;
        _vm.CentroCustoValido = centroCustoValido;

        run();

        function run(){
            // Lancamentos.get().then(function(resultado){
            //     _vm.Lancamentos = resultado.data;
            // });
            obterGrades();
        }

        function obterGrades(){
            grades.get().then(function(resultado){
                _vm.Grades = resultado.data;
            });
        }

        function centroCustoValido(centroCusto, Unidade) {
            return false;
        }

        function noPeriodo(lancamento, periodo) {
            var _periodo = periodo;
            //if(!_periodo) _periodo = {
            //    Inicio = new Date
            //}
            return lancamento.Data >= _periodo.Inicio && lancamento.Data <= _periodo.Fim;
        }

        function selecionarTodos(lancamentos, selecionado)
        {
            for (var _i = 0; _i < lancamentos.length; _i++) {
                lancamentos[_i].Selecionado = selecionado;
            }
            _vm.Lancamentos = lancamentos;
        }

        function algum(lancamentos, status)
        {
            var _status = status;
            if (_status === undefined) _status = true;
            return lancamentos.some(function (item) { return item.Selecionado === _status });
        }

        function ajustarSelecao(lancamentos, selecionado)
        {
            if (!selecionado)
                _vm.TodosSelecionados = false;
            else
                _vm.TodosSelecionados = !algum(lancamentos, false);
        }

        function lancamentosConsolidados(lancamentos) {

        }

        function aprovar(lancamento) {
            var _modal = $uibModal.open({
                animation: true,
                templateUrl: 'views/aprovacao.view.confirmaraprovacao.html',
                controller: 'ConfirmarAprovacaoCtrl',
                controllerAs: 'ctrl',
                resolve: {
                    lancamento: function () {
                        return lancamento;
                    }
                }
            }).result.then(confirmado, dispensado);

            function confirmado(resultado) { }

            function dispensado() { }
        }

        function reprovar(lancamento) {
            var _modal = $uibModal.open({
                animation: true,
                templateUrl: 'views/aprovacao.view.confirmarreprovacao.html',
                controller: 'ConfirmarReprovacaoCtrl',
                controllerAs: 'ctrl',
                resolve: {
                    lancamento: function () {
                        return lancamento;
                    }
                }
            }).result.then(confirmado, dispensado);

            function confirmado(resultado) { }

            function dispensado() { }
        }

        function solicitarExcedentes(lancamento, responsaveis) {
            
            var _modal = $uibModal.open({
                animation: true,
                templateUrl: 'views/aprovacao.view.solicitarexcedentes.html',
                controller: 'SolicitarExcedenteCtrl',
                controllerAs: 'ctrl',
                resolve: {
                    lancamento: function () {
                        return lancamento;
                    },
                    responsaveis: function () {
                        return responsaveis;
                    }
                }
            }).result.then(confirmado, dispensado);

            function confirmado(resultado) { }

            function dispensado() { }
        }
    }

    ConfirmarAprovacaoController.$inject = ['$uibModalInstance','lancamento'];

    function ConfirmarAprovacaoController($uibModalInstance, lancamento) {

        var _vm = this;

        _vm.Lancamento = lancamento;

        _vm.Ok = ok;
        _vm.Cancelar = cancelar;

        function ok() {
            $uibModalInstance.close(true);
        };

        function cancelar() {
            $uibModalInstance.dismiss(false);
        };

    }

    ConfirmarReprovacaoController.$inject = ['$uibModalInstance', 'lancamento'];

    function ConfirmarReprovacaoController($uibModalInstance, lancamento) {

        var _vm = this;

        _vm.Lancamento = lancamento;

        _vm.Ok = ok;
        _vm.Cancelar = cancelar;

        function ok() {
            $uibModalInstance.close(true);
        };

        function cancelar() {
            $uibModalInstance.dismiss(false);
        };
    }

    SolicitarExcedenteController.$inject = ['$uibModalInstance', 'lancamento', 'responsaveis'];

    function SolicitarExcedenteController($uibModalInstance, lancamento, responsaveis) {

        var _vm = this;

        _vm.Solicitacao = {Lancamento:lancamento};
        _vm.Responsaveis = responsaveis;

    }

}(window.angular));