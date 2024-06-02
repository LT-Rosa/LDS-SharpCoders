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
            view.CarregaFicheiro();
        }

        private void BtnBeforePage_Click(object sender, EventArgs e)
        {
            view.MostrarPaginaAnterior();
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            view.MostrarPaginaSeguinte();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            view.BotaoSubmeterClicado();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {

            this.lblRevenue.Visible = true;
            this.txtBoxRevenue.Visible = true;
            this.lblExpenses.Visible = true;
            this.txtBoxExpenses.Visible = true;
            this.btnSubmit.Visible = true;
            this.btnCancel.Visible = true;
            this.btnAnalisar.Visible = false;
            this.btnBeforePage.Enabled = false;
            this.btnNextPage.Enabled = false;
            this.btnOpen.Enabled = false;
            this.dataGridView1.Visible = false;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.lblRevenue.Visible = false;
            this.txtBoxRevenue.Visible = false;
            this.lblExpenses.Visible = false;
            this.txtBoxExpenses.Visible = false;
            this.btnSubmit.Visible = false;
            this.btnCancel.Visible = false;
            this.btnAnalisar.Visible = true;
            if (view.paginaatual>1)
                this.btnBeforePage.Enabled = true;
            if (view.paginaatual < view.totalpaginas)
                this.btnNextPage.Enabled = true;
            this.btnOpen.Enabled = true;
            this.dataGridView1.Visible = true;
        }
    }

}
