namespace Application
{
    public class Model : ModelBase
    {
    };
    public class View : ViewBase
    {
    };
    public class Controller : ControllerBase
    {
        public Controller(Model model, View view) { }
    };
    public class Program
    {
        public static void Main(string[] args)
        {
            Model model = new();
            View view = new();
            Controller controller = new(model, view);

            controller.IniciarPrograma();
            controller.CarregaFicheiro();
            controller.NavegarPaginaAnterior();
            controller.NavegarProximaPagina();
            controller.SubmeterFicheiro();
            controller.AcionarFim();
        }
    }

}
