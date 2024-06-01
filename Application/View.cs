using Application.MainController;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Application
{
    public class View
    {
        readonly Model model;

        FormMain formMain;
        public int paginaatual = 1;
        public int totalpaginas = 0;

        public int numeroregistrosporpagina = 20;
        List<FinancialData> dataList = new();
        public delegate void SubmeterFicheiroEventHandler(List<FinancialData> datalist); // Delegado para submeter o arquivo
        public event SubmeterFicheiroEventHandler SubmeterFicheiro; // Evento para submeter o arquivo

        public View(Model _model)
        {
            // Inicializa o model
            model = _model;
            model.ProcessarDadosApiResult += OutputDados; // Delegado para processar os dados
        }

        public void AcionarInterface()
        {
            // Simulação de acionar a interface
            // Console.WriteLine("Acionando interface...");
            formMain = new FormMain(this);
        }

        public void ApresentarJanela()
        {
            // Simulação de apresentar a janela
            // Console.WriteLine("Apresentando janela...");
            System.Windows.Forms.Application.Run(formMain);
        }

        public void FalhaCarregarFicheiro()
        {
            // Simulação de falha ao carregar o arquivo
            Console.WriteLine("Falha ao carregar o arquivo!");
        }

        //public void JanelaCarregarFicheiro()
        //{
        //    // Simulação de janela de carregar arquivo
        //    // Console.WriteLine("Janela de carregar arquivo aberta...");
        //    OpenFile();
        //}

        //public void ApresentaMensagemAguardar()
        //{
        //    // Simulação de mensagem de aguardar
        //    Console.WriteLine("Aguarde enquanto o arquivo é carregado...");
        //}

        public void PrevisualizarFicheiro(List<FinancialData> dados, int totalregistros)
        {
            // Simulação de pré-visualização do arquivo
            // Console.WriteLine("Pré-visualizando arquivo:");
            // formMain.
            // foreach (var dado in dados)
            // {
            //     Console.WriteLine(dado);
            // }
            formMain.BtnBeforePage.Enabled = false;
            totalpaginas = totalregistros / numeroregistrosporpagina;
            if (totalregistros % numeroregistrosporpagina > 0)
                totalpaginas++;
            if (totalpaginas > 1)
                formMain.BtnNextPage.Enabled = true;
            formMain.dataGridView1.Rows.Clear();
            formMain.dataGridView1.Columns.Clear();
            paginaatual = 1;

            formMain.dataGridView1.Columns.Add("Revenue", "Revenue");
            formMain.dataGridView1.Columns.Add("Expenses", "Expenses");
            formMain.dataGridView1.Columns.Add("Profit", "Profit");

            MostraPagina(dados);

        }

        public void MostraPagina(List<FinancialData> dados)
        {
            // Simulação de mostrar a página
            Console.WriteLine($"Mostrando página: {paginaatual}");
            formMain.dataGridView1.Rows.Clear();
            AtualizaPagina();
            foreach (var dado in dados)
            {
                if (dados.IndexOf(dado) >= (paginaatual - 1) * numeroregistrosporpagina && dados.IndexOf(dado) < paginaatual * numeroregistrosporpagina)
                    formMain.dataGridView1.Rows.Add(dado.Revenue.ToString("0.00"), dado.Expenses.ToString("0.00"), dado.Profit.ToString("0.00"));

            }
        }


        public void BotaoSubmeterClicado()
        {
            SubmeterFicheiro?.Invoke(dataList);
        }


        public void OutputDados(List<string> dadosProcessados)
        {
            try
            {
                if (dadosProcessados != null && dadosProcessados.Count > 0)
                {
                    Console.WriteLine("Output dos dados processados:");
                    //mostraJanelaLista(lista);
                }
                else
                {
                    Console.WriteLine("Erro: Lista vazia");
                    //mostraJanelaDeErro();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro: Lista vazia");
                //traJanelaDeErro();
            }
        }

        public void MensagemSaida()
        {
            // Simulação de mensagem de saída
            Console.WriteLine("Encerrando o programa...");
        }

        //internal void BotaoLerFicheiroClicado()
        //{
        //    JanelaCarregarFicheiro();
        //}

        public void OpenFile()
        {

            int totalregistros = 0;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    dataList = new List<FinancialData>();

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        bool isFirstLine = true; // Add this line
                        var data = new FinancialData();
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (isFirstLine) // Add this block
                            {
                                isFirstLine = false;
                                continue;
                            }
                            var values = line.Split(',');
                            try
                            {
                                data = new FinancialData
                                {
                                    Revenue = float.Parse(values[0].Replace(".", ",")),
                                    Expenses = float.Parse(values[1].Replace(".", ",")),
                                    Profit = float.Parse(values[2].Replace(".", ","))
                                };
                                totalregistros++;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Erro ao processar linha: " + e.Message);
                            }
                            dataList.Add(data);
                        }
                    }
                    PrevisualizarFicheiro(dataList, totalregistros);
                }
            }
        }

        public void TrainAndPredictModel(List<FinancialData> dados)
        {
            model.TrainModel(dados);

            foreach (var data in dados)
            {
                var prediction = model.Predict(data);
                Console.WriteLine($"Revenue: {data.Revenue}, Expenses: {data.Expenses}, Predicted Profit: {prediction.Profit}");
            }
        }

        public void MostrarPaginaAnterior()
        {
            if (paginaatual > 0)
                paginaatual--;

            //MostraPagina();
            if (paginaatual == 1)
                formMain.BtnBeforePage.Enabled = false;
            formMain.BtnNextPage.Enabled = true;
            MostraPagina(dataList);
            // Simulação de clique no botão de página anterior
            Console.WriteLine("Botão de página anterior clicado...");
        }
        public void MostrarPaginaSeguinte()
        {
            if (paginaatual < totalpaginas)
            {
                paginaatual++;

            }
            if (paginaatual == totalpaginas)
                formMain.BtnNextPage.Enabled = false;
            formMain.BtnBeforePage.Enabled = true;
            MostraPagina(dataList);
            // Simulação de clique no botão de página anterior
            Console.WriteLine("Botão de página anterior clicado...");
        }

        private void AtualizaPagina()
        {
            // Simulação de atualizar a página
            formMain.lblPages.Text = "Página \n" + paginaatual + "/" + totalpaginas;
            Console.WriteLine("Atualizando página...");
        }
    }
}
