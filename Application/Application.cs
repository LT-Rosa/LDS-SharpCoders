using System;
using System.Collections.Generic;
using static Application.View;

namespace Application
{
    namespace MainController
    {
        static class Application
        {
            static MainController.Controller control;

            [STAThread]
            static void Main()
            {
                // Inicializa o controlador
                control = new Controller();
                control.IniciarPrograma();
            }

        }
        public interface IController
        {
            // Define a interface de entrada
            void IniciarPrograma(); // Inicia o programa
            void AcionarFim(); // Aciona o fim do programa
        }

        public interface IView
        {
            // Define a interface de saída
            void AcionarInterface(); // Aciona a interface
            void ApresentarJanela(); // Apresenta a janela
            void MensagemSaida(); // Mensagem de saída
            event SubmeterFicheiroEventHandler SubmeterFicheiro;
        }

        public interface IModel
        {
            // Define o modelo de dados de saída
            void RecolherDadosFicheiro(List<FinancialData> datalist, List<FinancialData> dataToAnalyse); // Recolhe os dados do ficheiro
            void ProcessarDadosAPI(List<FinancialData> dataList, List<FinancialData> dataToAnalyse); // Processa os dados na API
        }

    }
}
