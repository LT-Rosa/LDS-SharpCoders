using Application.MainController;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Application
{
    public class Model : IModel
    {
        // Define o modelo de dados de saída
        public class FinancialDataPrediction
        {
            [ColumnName("Score")]
            public float Profit { get; set; }
        }

        public delegate void ProcessarDadosApiEventHandler(List<string> Dados);
        public event ProcessarDadosApiEventHandler ProcessarDadosApiResult;

        private ITransformer _trainedModel;
        private PredictionEngine<FinancialData, FinancialDataPrediction> _predictionEngine;

        public Model()
        {
            _mlContext = new MLContext();
        }

        public void RecolherDadosFicheiro(List<FinancialData> dados)
        {
            Console.WriteLine("Recuperando dados do arquivo...");
            //var resultado = new List<string> { "Dados do arquivo" };
            //ProcessarDadosAPI(resultado);
            try
                {
                TrainModel(dados);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao treinar o modelo: " + ex.Message);
            }
        }

        private void ProcessarDadosAPI(List<string> dados)
        {
            Console.WriteLine("Processando dados pela API...");
            ProcessarDadosApiResult?.Invoke(dados);
        }

        public void TrainModel(List<FinancialData> dataList)
        {
            MLContext _mlContext = new MLContext();
            IDataView dataView = _mlContext.Data.LoadFromEnumerable(dataList);

            // Define the training pipeline
            var pipeline = _mlContext.Transforms.Conversion.MapValueToKey("Lucro")
                .Append(_mlContext.Transforms.Concatenate("Features", nameof(FinancialData.Revenue), nameof(FinancialData.Expenses)))
                .Append(_mlContext.Regression.Trainers.LbfgsPoissonRegression());

            // Train the model
            _trainedModel = pipeline.Fit(dataView);

            // Create prediction engine
            _predictionEngine = _mlContext.Model.CreatePredictionEngine<FinancialData, FinancialDataPrediction>(_trainedModel);

            Console.WriteLine("Model training complete.");
        }

        public FinancialDataPrediction Predict(FinancialData input)
        {
            return _predictionEngine.Predict(input);
        }
    }


}