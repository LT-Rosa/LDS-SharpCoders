using System;
using System.Collections.Generic;

namespace Application
{
    public class View
    {
        readonly Model model;

        public delegate void SubmeterFicheiroEventHandler(List<string> Dados); // Delegado para submeter o arquivo
        public event SubmeterFicheiroEventHandler SubmeterFicheiro; // Evento para submeter o arquivo

        List<string> Dados;

        public View(Model _model)
        {
            // Inicializa o model
            model = _model;
            model.ProcessarDadosApiResult += OutputDados; // Delegado para processar os dados
        }

        public void AcionarInterface()
        {
            // Simulação de acionar a interface
            Console.WriteLine("Acionando interface...");
        }

        public void ApresentarJanela()
        {
            // Simulação de apresentar a janela
            Console.WriteLine("Apresentando janela...");
        }

        public void FalhaCarregarFicheiro()
        {
            // Simulação de falha ao carregar o arquivo
            Console.WriteLine("Falha ao carregar o arquivo!");
        }

        public void JanelaCarregarFicheiro()
        {
            // Simulação de janela de carregar arquivo
            Console.WriteLine("Janela de carregar arquivo aberta...");
        }

        public void ApresentaMensagemAguardar()
        {
            // Simulação de mensagem de aguardar
            Console.WriteLine("Aguarde enquanto o arquivo é carregado...");
        }

        public void PrevisualizarFicheiro(List<string> dados)
        {
            // Simulação de pré-visualização do arquivo
            Console.WriteLine("Pré-visualizando arquivo:");
            foreach (var dado in dados)
            {
                Console.WriteLine(dado);
            }
        }

        public void MostraPagina(string pagina)
        {
            // Simulação de mostrar a página
            Console.WriteLine($"Mostrando página: {pagina}");
        }


        public void BotaoSubmeterClicado()
        {
            SubmeterFicheiro?.Invoke(Dados);
        }


        public void OutputDados(List<string> dadosProcessados)
        {
            try
            {
                if (dadosProcessados != null && dadosProcessados.Count > 0)
                {
                    Console.WriteLine("Output dos dados processados:");
                    //mostraJanelaLista(lista);
                }
                else
                {
                    Console.WriteLine("Erro: Lista vazia");
                    //mostraJanelaDeErro();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: Lista vazia");
               // mostraJanelaDeErro();
            }


            // Simulação de saída dos dados processados
            /*
            Console.WriteLine("Output dos dados processados:");
            foreach (var dado in dadosProcessados)
            {
                Console.WriteLine(dado);
            }*/
        }

        public void MensagemSaida()
        {
            // Simulação de mensagem de saída
            Console.WriteLine("Encerrando o programa...");
        }

    }
}
