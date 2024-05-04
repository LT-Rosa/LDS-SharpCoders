using System;
using System.Collections.Generic;
using System.IO;

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

                // Leitura do ficheiro completo (caso se venha a apliar a seccionação do ficheiro requer adaptação)
                string line;
                List<string> dadosFicheiro = new List<string>(); // Inicializar a lista corretamente
                try
                {
                    // Passar a localização do ficheiro para o StreamReader
                    StreamReader sr = new StreamReader("C:\\Sample.txt");
                    // Ler a primeira linha do ficheiro
                    line = sr.ReadLine();
                    // Ler linha a linha até terminar o ficheiro
                    while (line != null)
                    {
                        // Adicionar a linha à lista dadosFicheiro
                        dadosFicheiro.Add(line);
                        // Ler a próxima linha
                        line = sr.ReadLine();
                    }
                    // Fechar o ficheiro
                    sr.Close();
                    //  ----------------------- DEBUG ---------------------------
                    foreach (string s in dadosFicheiro)
                    {
                        Console.WriteLine(s);
                    }
                    // ----------------------------------------------------------
                    Console.ReadLine();

                    // Acionar a View
                    //  view.JanelaCarregarFicheiro();
                    //   view.ApresentaMensagemAguardar();

                    SubmeterFicheiro(dadosFicheiro);// new List<string> { "Dados do arquivo" }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Falha ao carregar o ficheiro: " + e.Message);
                }

                /*  OLD
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
                */
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

            // FECHAR PROGRAMA
            public void AcionarFim()
            {
                view.MensagemSaida();
            }

        }
    }
}