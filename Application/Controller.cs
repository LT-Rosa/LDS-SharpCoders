using System.Collections.Generic;

namespace Application
{
    namespace MainController
    {

        // Controller

        // Delegado para nagevação entre páginas
        //public delegate void NavigationHandler(string message);

        public class FinancialData
        {
            public float Revenue { get; set; }
            public float Expenses { get; set; }
            public float Profit { get; set; }
        }

        class Controller : IController
        {
            readonly View view;
            readonly Model model;

            // Eventos do delegado
            //public event NavigationHandler OnPreviousPage;
            //public event NavigationHandler OnNextPage;

            public Controller()
            {
                model = new Model();
                view = new View(model);
                this.view.SubmeterFicheiro += SubmeterFicheiro;
            }


            // START DO PROGRAMA
            public void IniciarPrograma()
            {
                view.AcionarInterface();
                view.ApresentarJanela();
            }

            private void SubmeterFicheiro(List<FinancialData> datalist, List<FinancialData> dataToAnalyse)
            {
                model.RecolherDadosFicheiro(datalist, dataToAnalyse);
            }
            //CARREGAMENTO DOS DADOS DO FICHEIRO
            //public void CarregaFicheiro()
            //{
            //    // Simulação de carregar o arquivo
            //    bool carregouComSucesso = true; // Simulação de sucesso ao carregar o arquivo

            //    // Leitura do ficheiro completo (caso se venha a apliar a seccionação do ficheiro requer adaptação)
            //    string line;
            //    List<string> dadosFicheiro = new List<string>(); // Inicializar a lista corretamente
            //    try
            //    {
            //        // Passar a localização do ficheiro para o StreamReader
            //        StreamReader sr = new StreamReader("C:\\Sample.txt");
            //        // Ler a primeira linha do ficheiro
            //        line = sr.ReadLine();
            //        // Ler linha a linha até terminar o ficheiro
            //        while (line != null)
            //        {
            //            // Adicionar a linha à lista dadosFicheiro
            //            dadosFicheiro.Add(line);
            //            // Ler a próxima linha
            //            line = sr.ReadLine();
            //        }
            //        // Fechar o ficheiro
            //        sr.Close();
            //        //  ----------------------- DEBUG ---------------------------
            //        foreach (string s in dadosFicheiro)
            //        {
            //            Console.WriteLine(s);
            //        }
            //        // ----------------------------------------------------------
            //        Console.ReadLine();

            //        // Acionar a View
            //        //  view.JanelaCarregarFicheiro();
            //        //   view.ApresentaMensagemAguardar();

            //        SubmeterFicheiro(dadosFicheiro);// new List<string> { "Dados do arquivo" }

            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Falha ao carregar o ficheiro: " + e.Message);
            //    }

            //    /*  OLD
            //    if (carregouComSucesso)
            //    {
            //        //  view.JanelaCarregarFicheiro();
            //        //   view.ApresentaMensagemAguardar();

            //        SubmeterFicheiro(new List<string> { "Dados do arquivo" });
            //    }
            //    else
            //    {
            //        view.FalhaCarregarFicheiro();
            //    }
            //    */
            //}

            //// DELEGADOS
            //private void RaisePreviousPage()
            //{
            //    // Disparando o evento de página anterior
            //    OnPreviousPage?.Invoke("Página anterior");
            //}

            //private void RaiseNextPage()
            //{
            //    // Disparando o evento de próxima página
            //    OnNextPage?.Invoke("Próxima página");
            //}

            // SUBMIÇÃO DE FICHEIRO -> MODEL
            // Envio do ficheiro para Model


            // FIM DO PROGRAMA
            // Fecho do programa
            public void AcionarFim()
            {
                view.MensagemSaida();
            }

        }

    }
}