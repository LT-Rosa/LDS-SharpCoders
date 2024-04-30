using System;

namespace Application
{
    namespace MainController
    {
  
        // Controller
        class Controller
        {
            readonly View view;
            readonly Model model;

            public void IniciarPrograma()
            {
                view.AcionarInterface();
                view.ApresentarJanela();
            }


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

            // Envio do ficheiro para Model
            public void SubmeterFicheiro()
            {
                var dados = model.RecolherDadosFicheiro();
                var dadosProcessados = model.ProcessarDadosAPI(dados);
                view.OutputDados(dadosProcessados);
            }

            // Fecho do programa
            public void AcionarFim()
            {
                view.MensagemSaida();
            }

        }
    }
}