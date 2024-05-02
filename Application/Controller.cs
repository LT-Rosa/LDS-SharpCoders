using System;
using System.Collections.Generic;

namespace Application
{
    namespace MainController
    {

        // Controller

        // Delegado para nagevação entre páginas
        public delegate void NavigationHandler(string message);

        class Controller
        {
            readonly View view;
            readonly Model model;

            // Eventos do delegado
            public event NavigationHandler OnPreviousPage;
            public event NavigationHandler OnNextPage;

            public Controller()
            {
                model = new Model();
                view = new View(model);
            }


            // START DO PROGRAMA
            public void IniciarPrograma()
            {
                view.AcionarInterface();
                view.ApresentarJanela();
            }


            //CARREGAMENTO DOS DADOS DO FICHEIRO
            public void CarregaFicheiro()
            {
                // Simulação de carregar o arquivo
                bool carregouComSucesso = true; // Simulação de sucesso ao carregar o arquivo

                if (carregouComSucesso)
                {
                    //  view.JanelaCarregarFicheiro();
                    //   view.ApresentaMensagemAguardar();

                    SubmeterFicheiro(new List<string> { "Dados do arquivo" });
                }
                else
                {
                    view.FalhaCarregarFicheiro();
                }
            }

            // DELEGADOS
            private void RaisePreviousPage()
            {
                // Disparando o evento de página anterior
                OnPreviousPage?.Invoke("Página anterior");
            }

            private void RaiseNextPage()
            {
                // Disparando o evento de próxima página
                OnNextPage?.Invoke("Próxima página");
            }

            // NAVEGAÇÃO NAS PÁGINAS
            //Envio de mensagem de página anterior para view
            public void NavegarPaginaAnterior()
            {
                view.MostraPagina("Página anterior");
            }

            //Envio de mensagem de proxima página para view
            public void NavegarProximaPagina()
            {
                view.MostraPagina("Próxima página");
            }

            // SUBMIÇÃO DE FICHEIRO -> MODEL
            // Envio do ficheiro para Model
            public void SubmeterFicheiro(List<string> dados)
            {
                // var dados = model.RecolherDadosFicheiro();
                model.RecolherDadosFicheiro(dados);
                //  view.OutputDados(dadosProcessados);
            }

            // FIM DO PROGRAMA
            // Fecho do programa
            public void AcionarFim()
            {
                view.MensagemSaida();
            }

        }
    }
}