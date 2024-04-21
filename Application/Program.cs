using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Application
{
    public class Model : ModelBase
    {
    };
    public class View : ViewBase
    {
    };
    public class Controller { 
        public Controller(Model model, View view) { }
        public void IniciarPrograma() { }
        public void CarregaFicheiro() { }
        public void NavegarPaginaAnterior() { }
        public void NavegarProximaPagina() { }
        public void SubmeterFicheiro() { }
        public void AcionarFim() { }
       
    };
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
