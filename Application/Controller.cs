namespace Application.Controller
{
    public class Model { };
    public class View { };
    // Controller
    public class Controller
    {
        readonly View view = new();
        readonly Model model = new();

        public void IniciarPrograma()
        {
            view.AcionarInterface();
            view.ApresentarJanela();
        }

        public void CarregaFicheiro()
        {
            // Simulação de carregar o arquivo
            bool carregouComSucesso = true; // Simulação de sucesso ao carregar o arquivo

            if (carregouComSucesso)
            {
                view.JanelaCarregarFicheiro();
                view.ApresentaMensagemAguardar();

                var dados = model.RecolherDadosFicheiro();
                view.PrevisualizarFicheiro(dados);
            }
            else
            {
                view.FalhaCarregarFicheiro();
            }
        }

        public void NavegarPaginaAnterior()
        {
            view.MostraPagina("Página anterior");
        }

        public void NavegarProximaPagina()
        {
            view.MostraPagina("Próxima página");
        }

        public void SubmeterFicheiro()
        {
            var dados = model.RecolherDadosFicheiro();
            var dadosProcessados = model.ProcessarDadosAPI(dados);
            view.OutputDados(dadosProcessados);
        }

        public void AcionarFim()
        {
            view.MensagemSaida();
        }

        public class Model
        {
        }
    }
}