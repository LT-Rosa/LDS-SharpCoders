using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            view.OpenFile();
        }

        
    }

}
