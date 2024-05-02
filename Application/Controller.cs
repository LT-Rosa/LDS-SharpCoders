using System;

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
                    view.JanelaCarregarFicheiro();
                    view.ApresentaMensagemAguardar();

                    var dados = model.RecolherDadosFicheiro();
                    view.PrevisualizarFicheiro(dados);
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
            public void SubmeterFicheiro()
            {
                var dados = model.RecolherDadosFicheiro();
                var dadosProcessados = model.ProcessarDadosAPI(dados);
                view.OutputDados(dadosProcessados);
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