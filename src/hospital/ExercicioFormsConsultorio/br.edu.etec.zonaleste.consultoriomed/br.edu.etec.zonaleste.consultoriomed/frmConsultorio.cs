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
    public partial class frmConsultorio : Form
    {
        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void cadastroDeAgendaMédicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadAgendaMedica fCadAgendaMedica = new frmCadAgendaMedica();
            fCadAgendaMedica.MdiParent = this;
            fCadAgendaMedica.Show();
        }

        private void frmConsultorio_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data : " + DateTime.Now.ToString("dd/MM/yyyy");
            /*public void tipoMedico(){
            cadastroDeMédicosToolStripMenuItem.Visible = false;
            }*/
        }

        private void cadastroDeMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeMédicosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadMed fCadMed = new frmCadMed();
            fCadMed.MdiParent = this;
            fCadMed.Show();
        }

        private void cadastroDeAtendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadAtendente fCadAtendente = new frmCadAtendente();
            fCadAtendente.MdiParent = this;
            fCadAtendente.Show();
        }

        private void cadastrosDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUsuario fCadUsuario = new frmCadUsuario();
            fCadUsuario.MdiParent = this;
            fCadUsuario.Show();
        }

        private void cadastroDeEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadEspecialidadeMed fCadEspe = new frmCadEspecialidadeMed();
            fCadEspe.MdiParent = this;
            fCadEspe.Show();
        }

        private void cadastroDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPaciente fCadPaciente = new frmCadPaciente();
            fCadPaciente.MdiParent = this;
            fCadPaciente.Show();
        }

        private void agendarConsultaMédicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgendamentoConsultas fAgConsultas = new frmAgendamentoConsultas();
            fAgConsultas.MdiParent = this;
            fAgConsultas.Show();
        }

        private void consultaAgendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAgendamentos fConConsultas = new frmConsultaAgendamentos();
            fConConsultas.MdiParent = this;
            fConConsultas.Show();
        }

        private void históricoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistorico fHistorico = new frmHistorico();
            fHistorico.MdiParent = this;
            fHistorico.Show();
        }

        private void frmConsultorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            else
            {
                e.Cancel = true;
            }

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultaAgendamentos fConConsultas = new frmConsultaAgendamentos();
            fConConsultas.MdiParent = this;
            fConConsultas.Show();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgendamentoConsultas fAgConsultas = new frmAgendamentoConsultas();
            fAgConsultas.MdiParent = this;
            fAgConsultas.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
