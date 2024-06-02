using System;
using static Application.View;
using System.Collections.Generic;

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
                control = new Controller();
                control.IniciarPrograma();
            }

        }
        public interface IController
        {
            void IniciarPrograma();
            void AcionarFim();
        }

        public interface IView
        {
            void AcionarInterface();
            void ApresentarJanela();
            void MensagemSaida();
            event SubmeterFicheiroEventHandler SubmeterFicheiro;
        }

        public interface IModel
        {
            void RecolherDadosFicheiro(List<FinancialData> datalist, String strRevenue, String strExpenses);
        }

    }
}
