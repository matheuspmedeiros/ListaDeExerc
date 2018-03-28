using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace br.edu.etec.zonaleste.consultoriomed
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login;

            login = txbLogin.Text;

            if (login == "Admin")
            {
                frmConsultorio fconsultorio = new frmConsultorio();
                fconsultorio.Show();
                this.Visible = false;
            }
        }
    }
}
