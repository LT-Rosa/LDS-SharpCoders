using System;
using System.Collections.Generic;

namespace Application.Controller
{

    // Controller
    public class Controller
    {
        private readonly Model model;
        private readonly View view;
        public class Model { };
        public class View { };

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void IniciarPrograma()
        {
            view.AcinarInterface();
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
    }
}