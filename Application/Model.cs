using Application.MainController;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public Model() { }

        public void RecolherDadosFicheiro(List<FinancialData> dados, System.String strRevenue, System.String strExpenses)
        {
            Console.WriteLine("Recuperando dados do arquivo...");
            //var resultado = new List<string> { "Dados do arquivo" };
            //ProcessarDadosAPI(resultado);
            try
            {
                ProcessarDadosAPI(dados);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao treinar o modelo: " + ex.Message);
            }
        }

        public void ProcessarDadosAPI(List<FinancialData> dataList)
        {
            MLContext _mlContext = new MLContext();
            IDataView _dataView = _mlContext.Data.LoadFromEnumerable(dataList);

            // Define the training pipeline
            //var pipeline = _mlContext.Transforms.Conversion.MapValueToKey("Lucro")
            //    .Append(_mlContext.Transforms.Concatenate("Features", nameof(FinancialData.Revenue), nameof(FinancialData.Expenses)))
            //    .Append(_mlContext.Regression.Trainers.LbfgsPoissonRegression());
            var _pipeline = _mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "Profit")
                .Append(_mlContext.Transforms.Concatenate("Output", "Revenue", "Expenses"))
                .Append(_mlContext.Regression.Trainers.Sdca());


            var _model = _pipeline.Fit(_dataView);
            var _predictionEngine = _mlContext.Model.CreatePredictionEngine<FinancialData, FinancialDataPrediction>(_model);

            Console.WriteLine("Model training complete.");
        }

        public FinancialDataPrediction Predict(FinancialData input)
        {
            return _predictionEngine.Predict(input);
        }
    }
}