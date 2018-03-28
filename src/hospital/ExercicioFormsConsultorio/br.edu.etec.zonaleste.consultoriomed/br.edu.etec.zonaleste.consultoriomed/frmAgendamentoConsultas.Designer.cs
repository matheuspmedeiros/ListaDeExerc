namespace br.edu.etec.zonaleste.consultoriomed
{
    partial class frmAgendamentoConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxDadosPaciente = new System.Windows.Forms.GroupBox();
            this.gboxDadosDoMedico = new System.Windows.Forms.GroupBox();
            this.lblIDMedico = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnPesqMedico = new System.Windows.Forms.Button();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.lblIdPaciente = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnPesquisarPaciente = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnExibirAgMedico = new System.Windows.Forms.Button();
            this.lblDataConsulta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gboxDadosPaciente.SuspendLayout();
            this.gboxDadosDoMedico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxDadosPaciente
            // 
            this.gboxDadosPaciente.Controls.Add(this.btnPesquisarPaciente);
            this.gboxDadosPaciente.Controls.Add(this.textBox3);
            this.gboxDadosPaciente.Controls.Add(this.textBox2);
            this.gboxDadosPaciente.Controls.Add(this.textBox1);
            this.gboxDadosPaciente.Controls.Add(this.lblNomePaciente);
            this.gboxDadosPaciente.Controls.Add(this.lblIdPaciente);
            this.gboxDadosPaciente.Controls.Add(this.lblIdConsulta);
            this.gboxDadosPaciente.Location = new System.Drawing.Point(23, 12);
            this.gboxDadosPaciente.Name = "gboxDadosPaciente";
            this.gboxDadosPaciente.Size = new System.Drawing.Size(709, 142);
            this.gboxDadosPaciente.TabIndex = 6;
            this.gboxDadosPaciente.TabStop = false;
            this.gboxDadosPaciente.Text = "Dados do Paciente:";
            // 
            // gboxDadosDoMedico
            // 
            this.gboxDadosDoMedico.Controls.Add(this.btnExibirAgMedico);
            this.gboxDadosDoMedico.Controls.Add(this.btnPesqMedico);
            this.gboxDadosDoMedico.Controls.Add(this.textBox6);
            this.gboxDadosDoMedico.Controls.Add(this.textBox5);
            this.gboxDadosDoMedico.Controls.Add(this.textBox4);
            this.gboxDadosDoMedico.Controls.Add(this.lblNomeMedico);
            this.gboxDadosDoMedico.Controls.Add(this.lblCRM);
            this.gboxDadosDoMedico.Controls.Add(this.lblIDMedico);
            this.gboxDadosDoMedico.Location = new System.Drawing.Point(23, 160);
            this.gboxDadosDoMedico.Name = "gboxDadosDoMedico";
            this.gboxDadosDoMedico.Size = new System.Drawing.Size(709, 124);
            this.gboxDadosDoMedico.TabIndex = 7;
            this.gboxDadosDoMedico.TabStop = false;
            this.gboxDadosDoMedico.Text = "Dados do Médico:";
            // 
            // lblIDMedico
            // 
            this.lblIDMedico.AutoSize = true;
            this.lblIDMedico.Location = new System.Drawing.Point(17, 27);
            this.lblIDMedico.Name = "lblIDMedico";
            this.lblIDMedico.Size = new System.Drawing.Size(59, 13);
            this.lblIDMedico.TabIndex = 0;
            this.lblIDMedico.Text = "ID Médico:";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(127, 27);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 1;
            this.lblCRM.Text = "CRM:";
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.Location = new System.Drawing.Point(239, 27);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(91, 13);
            this.lblNomeMedico.TabIndex = 2;
            this.lblNomeMedico.Text = "Nome do Médico:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, 43);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(130, 43);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(242, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(454, 20);
            this.textBox6.TabIndex = 6;
            // 
            // btnPesqMedico
            // 
            this.btnPesqMedico.Location = new System.Drawing.Point(20, 79);
            this.btnPesqMedico.Name = "btnPesqMedico";
            this.btnPesqMedico.Size = new System.Drawing.Size(109, 23);
            this.btnPesqMedico.TabIndex = 8;
            this.btnPesqMedico.Text = "Pesquisar Médico";
            this.btnPesqMedico.UseVisualStyleBackColor = true;
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Location = new System.Drawing.Point(13, 28);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(65, 13);
            this.lblIdConsulta.TabIndex = 6;
            this.lblIdConsulta.Text = "ID Consulta:";
            // 
            // lblIdPaciente
            // 
            this.lblIdPaciente.AutoSize = true;
            this.lblIdPaciente.Location = new System.Drawing.Point(127, 28);
            this.lblIdPaciente.Name = "lblIdPaciente";
            this.lblIdPaciente.Size = new System.Drawing.Size(66, 13);
            this.lblIdPaciente.TabIndex = 7;
            this.lblIdPaciente.Text = "ID Paciente:";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(239, 28);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(98, 13);
            this.lblNomePaciente.TabIndex = 8;
            this.lblNomePaciente.Text = "Nome do Paciente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(454, 20);
            this.textBox3.TabIndex = 11;
            // 
            // btnPesquisarPaciente
            // 
            this.btnPesquisarPaciente.Location = new System.Drawing.Point(16, 94);
            this.btnPesquisarPaciente.Name = "btnPesquisarPaciente";
            this.btnPesquisarPaciente.Size = new System.Drawing.Size(113, 23);
            this.btnPesquisarPaciente.TabIndex = 12;
            this.btnPesquisarPaciente.Text = "Pesquisar Paciente";
            this.btnPesquisarPaciente.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(23, 355);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(709, 169);
            this.checkedListBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Location = new System.Drawing.Point(40, 289);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(76, 13);
            this.lblEspecialidade.TabIndex = 9;
            this.lblEspecialidade.Text = "Especialidade:";
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoSize = true;
            this.lblAgenda.Location = new System.Drawing.Point(20, 339);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(85, 13);
            this.lblAgenda.TabIndex = 11;
            this.lblAgenda.Text = "Agenda Médica:";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(100, 546);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(116, 23);
            this.btnAgendar.TabIndex = 12;
            this.btnAgendar.Text = "Agendar Consulta";
            this.btnAgendar.UseVisualStyleBackColor = true;
            // 
            // btnExibirAgMedico
            // 
            this.btnExibirAgMedico.Location = new System.Drawing.Point(155, 79);
            this.btnExibirAgMedico.Name = "btnExibirAgMedico";
            this.btnExibirAgMedico.Size = new System.Drawing.Size(149, 23);
            this.btnExibirAgMedico.TabIndex = 9;
            this.btnExibirAgMedico.Text = "Exibir Agenda do Médico";
            this.btnExibirAgMedico.UseVisualStyleBackColor = true;
            // 
            // lblDataConsulta
            // 
            this.lblDataConsulta.AutoSize = true;
            this.lblDataConsulta.Location = new System.Drawing.Point(516, 289);
            this.lblDataConsulta.Name = "lblDataConsulta";
            this.lblDataConsulta.Size = new System.Drawing.Size(117, 13);
            this.lblDataConsulta.TabIndex = 14;
            this.lblDataConsulta.Text = "Data de Agendamento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 306);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // frmAgendamentoConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 590);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDataConsulta);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEspecialidade);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.gboxDadosDoMedico);
            this.Controls.Add(this.gboxDadosPaciente);
            this.Name = "frmAgendamentoConsultas";
            this.Text = "Agendamento de Consultas";
            this.gboxDadosPaciente.ResumeLayout(false);
            this.gboxDadosPaciente.PerformLayout();
            this.gboxDadosDoMedico.ResumeLayout(false);
            this.gboxDadosDoMedico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxDadosPaciente;
        private System.Windows.Forms.Button btnPesquisarPaciente;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblIdPaciente;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.GroupBox gboxDadosDoMedico;
        private System.Windows.Forms.Button btnExibirAgMedico;
        private System.Windows.Forms.Button btnPesqMedico;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.Label lblIDMedico;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label lblDataConsulta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

    }
}