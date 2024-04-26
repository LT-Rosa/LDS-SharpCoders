using System;

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


    }
}
