using System.Collections.Generic;

namespace Application
{
    public class ViewBase
    {
        public void AcionarInterface() { }
        public void ApresentaMensagemAguardar() { }
        public void ApresentarJanela() { }
        public void FalhaCarregarFicheiro() { }
        public void JanelaCarregarFicheiro() { }
        public void MostraPagina(string pagina) { }
        public void OutputDados(List<string> dadosProcessados) { }
        public void PrevisualizarFicheiro(List<string> dados) { }
    }
}