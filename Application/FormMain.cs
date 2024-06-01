using System;
using System.Windows.Forms;

namespace Application
{
    public partial class FormMain : Form
    {
        private View view;

        public FormMain(View v)
        {
            view = v;
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            view.OpenFile();
        }

        private void BtnBeforePage_Click(object sender, EventArgs e)
        {
            view.MostrarPaginaAnterior();
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            view.MostrarPaginaSeguinte();
        }

    }

}
