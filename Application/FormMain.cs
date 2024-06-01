using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            view.BotaoLerFicheiroClicado();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnBeforePage_Click(object sender, EventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }
    }
}
