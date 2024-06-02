using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static Application.View;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            void FalhaCarregarFicheiro();
            void PrevisualizarFicheiro(List<FinancialData> dados, int totalregistros);
            void MostraPagina(List<FinancialData> dados);
            void BotaoSubmeterClicado(String strRevenue, String strExpenses);
            void OutputDados(List<string> dadosProcessados);
            void CarregaFicheiro();
            void MostrarPaginaAnterior();
            void MostrarPaginaSeguinte();
        }

        public interface IModel
        {
            // Define o modelo de dados de saída
            void RecolherDadosFicheiro(List<FinancialData> datalist, List<FinancialData> dataToAnalyse); // Recolhe os dados do ficheiro
            void ProcessarDadosAPI(List<FinancialData> dataList, List<FinancialData> dataToAnalyse);
           
        }

    }
}
