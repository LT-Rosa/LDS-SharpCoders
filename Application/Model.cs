using System;
using System.Collections.Generic;


namespace Application
{
    // Model
    public class Model
    {
        public List<string> RecolherDadosFicheiro()
        {
            // Simulação da recolha de dados do ficheiro
            Console.WriteLine("Recuperando dados do arquivo...");
            return new List<string> { "Dados do arquivo" };
        }

        public List<string> ProcessarDadosAPI(List<string> dados)
        {
            // Simulação do processamento dos dados pela API
            Console.WriteLine("Processando dados pela API...");
            return dados;
        }
    }
}