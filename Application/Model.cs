using System;
using System.Collections.Generic;


namespace Application
{
    // Model
    public class Model
    {
        //Events + Handlers
        //public event EventHandler NotificaDadosFicheiroRecolhidos;
        //public event EventHandler NotficaDadosAPIProcessados;

        public delegate void ProcessarDadosApiEventHandler(List<string> Dados);
        public event ProcessarDadosApiEventHandler ProcessarDadosApiResult;

        public Model()
        {
            //  ProcessarDadosApiEventHandler ProcessarDadosApiResult = new ProcessarDadosApiEventHandler(dados);
        }


        public void RecolherDadosFicheiro(List<string> dados)
        {
            // Simulação da recolha de dados do ficheiro
            Console.WriteLine("Recuperando dados do arquivo...");
            var resultado = new List<string> { "Dados do arquivo" };

            ProcessarDadosAPI(resultado);
        }


        private void ProcessarDadosAPI(List<string> dados)
        {
            // Simulação do processamento dos dados pela API
            Console.WriteLine("Processando dados pela API...");

            ProcessarDadosApiResult?.Invoke(dados);
            //return dados;
        }
    }
}