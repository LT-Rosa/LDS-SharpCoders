﻿using Application.MainController;
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;

namespace Application
{
    public class Model : IModel
    {
        public delegate void LongOperationStartedHandler();
        public delegate void LongOperationEndedHandler();
        public delegate void ProcessDataCompletedHandler(List<FinancialData> processedData);
        public delegate void ProcessarDadosApiEventHandler(List<string> Dados);
        public event LongOperationStartedHandler LongOperationStarted;
        public event LongOperationEndedHandler LongOperationEnded;
        public event ProcessDataCompletedHandler ProcessDataCompleted;
        public event ProcessarDadosApiEventHandler ProcessarDadosApiResult;

        // Define o modelo de dados de saída
        public class FinancialDataPrediction
        {
            [ColumnName("Score")]
            public float Profit { get; set; }
        }

        public Model() { }

        public void RecolherDadosFicheiro(List<FinancialData> dados, List<FinancialData> dataToAnalyse)
        {
            // Simulação de carregar o arquivo
            Console.WriteLine("Recuperando dados do arquivo...");
            try
            {
                ProcessarDadosAPI(dados, dataToAnalyse); // Chama o método para processar os dados
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao treinar o modelo: " + ex.Message);
            }
        }

        // Processa os dados na API
        public void ProcessarDadosAPI(List<FinancialData> dataList, List<FinancialData> dataToAnalyse)
        {
            LongOperationStarted?.Invoke();
            MLContext _mlContext = new MLContext();
            IDataView _dataView = _mlContext.Data.LoadFromEnumerable(dataList);

            // Define a pipeline de treino do modelo
            var _pipeline = _mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "Profit")
                .Append(_mlContext.Transforms.Concatenate("Features", "Revenue", "Expenses"))
                .Append(_mlContext.Regression.Trainers.Sdca());

            var _model = _pipeline.Fit(_dataView);
            var _predictionEngine = _mlContext.Model.CreatePredictionEngine<FinancialData, FinancialDataPrediction>(_model);

            // Processa os dados de entrada e exibe o resultado
            List<FinancialData> dataoutput = new List<FinancialData>();
            foreach (var data in dataToAnalyse)
            {
                var prediction = _predictionEngine.Predict(data);
                dataoutput.Add(new FinancialData { Revenue = data.Revenue, Expenses = data.Expenses, Profit = prediction.Profit });
                Console.WriteLine($"Revenue: {data.Revenue}, Expenses: {data.Expenses} => Profit: {prediction.Profit}");
            }
            LongOperationEnded?.Invoke();
            ProcessDataCompleted?.Invoke(dataoutput);
            Console.WriteLine("Model training complete.");
        }

    }
}