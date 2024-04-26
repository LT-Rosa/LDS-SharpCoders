using System;
using System.Collections.Generic;


namespace Application
{
    // View
    public class View
    {
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

        public void OutputDados(List<string> dadosProcessados)
        {
            // Simulação de saída dos dados processados
            Console.WriteLine("Output dos dados processados:");
            foreach (var dado in dadosProcessados)
            {
                Console.WriteLine(dado);
            }
        }

        public void MensagemSaida()
        {
            // Simulação de mensagem de saída
            Console.WriteLine("Encerrando o programa...");
        }
    }
}