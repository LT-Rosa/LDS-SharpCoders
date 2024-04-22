using System;
using System.Collections.Generic;
using static Application.Controller.Controller;

namespace Application.Controller
{

    // Controller
    public class Controller
    {
        public class Model { };
        public class View { 
            public void AcionarInterface() { }
            public void ApresentarJanela() { }
        };

        public Controller(Model model, View view)
        {
            model = model;
            view = view;
        }

        public void IniciarPrograma()
        {
            View.AcionarInterface();
            View.ApresentarJanela();
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