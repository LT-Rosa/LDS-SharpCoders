﻿using Application.MainController;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application
{
    public class View
    {
        readonly Model model;
        Controller controller;
        FormMain formMain;

        public delegate void SubmeterFicheiroEventHandler(List<string> Dados); // Delegado para submeter o arquivo
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

        public void JanelaCarregarFicheiro()
        {
            // Simulação de janela de carregar arquivo
            // Console.WriteLine("Janela de carregar arquivo aberta...");
            OpenFile();
        }

        public void ApresentaMensagemAguardar()
        {
            // Simulação de mensagem de aguardar
            Console.WriteLine("Aguarde enquanto o arquivo é carregado...");
        }

        public void PrevisualizarFicheiro(List<FinancialData> dados)
        {
            // Simulação de pré-visualização do arquivo
            // Console.WriteLine("Pré-visualizando arquivo:");
            // formMain.
            // foreach (var dado in dados)
            // {
            //     Console.WriteLine(dado);
            // }
            formMain.dataGridView1.Columns.Add("Revenue", "Revenue");
            formMain.dataGridView1.Columns.Add("Expenses", "Expenses");
            formMain.dataGridView1.Columns.Add("Profit", "Profit");
            foreach (var dado in dados)
            {
                formMain.dataGridView1.Rows.Add(dado.Revenue, dado.Expenses, dado.Profit);
            }          

        }

        public void MostraPagina(string pagina)
        {
            // Simulação de mostrar a página
            Console.WriteLine($"Mostrando página: {pagina}");
        }


        public void BotaoSubmeterClicado()
        {
            SubmeterFicheiro?.Invoke(new List<string>());
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

        internal void BotaoLerFicheiroClicado()
        {
            JanelaCarregarFicheiro();
        }

        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = openFileDialog.FileName;
                    List<FinancialData> dataList = new List<FinancialData>();

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        bool isFirstLine = true; // Add this line
                        var data =new FinancialData();
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (isFirstLine) // Add this block
                            {
                                isFirstLine = false;
                                continue;
                            }
                            var values = line.Split(';');
                            try { 
                                data = new FinancialData
                                {
                                    Revenue = float.Parse(values[0]),
                                    Expenses = float.Parse(values[1]),
                                    Profit = float.Parse(values[2])
                                };
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Erro ao processar linha: " + e.Message);
                            }
                            dataList.Add(data);
                        }
                    }

                    PrevisualizarFicheiro(dataList);
                }
            }
        }
    }
}
