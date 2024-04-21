using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(model, view);

            controller.IniciarPrograma();
            controller.CarregaFicheiro();
            controller.NavegarPaginaAnterior();
            controller.NavegarProximaPagina();
            controller.SubmeterFicheiro();
            controller.AcionarFim();
        }
    }

}
