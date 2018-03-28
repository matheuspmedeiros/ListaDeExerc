namespace br.edu.etec.zonaleste.consultoriomed
{
    partial class frmConsultorio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultorio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMédicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAtendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAgendaMédicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarConsultaMédicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaAgendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.observaçõesMédicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnConsulta = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAgenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendamentosToolStripMenuItem,
            this.observaçõesMédicasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMédicosToolStripMenuItem,
            this.cadastroDeAtendentesToolStripMenuItem,
            this.cadastrosDeUsuáriosToolStripMenuItem,
            this.cadastroDeEspecialidadesToolStripMenuItem,
            this.cadastroDePacientesToolStripMenuItem,
            this.cadastroDeAgendaMédicaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeMédicosToolStripMenuItem
            // 
            this.cadastroDeMédicosToolStripMenuItem.Name = "cadastroDeMédicosToolStripMenuItem";
            this.cadastroDeMédicosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cadastroDeMédicosToolStripMenuItem.Text = "Cadastro de Médicos";
            this.cadastroDeMédicosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMédicosToolStripMenuItem_Click_1);
            // 
            // cadastroDeAtendentesToolStripMenuItem
            // 
            this.cadastroDeAtendentesToolStripMenuItem.Name = "cadastroDeAtendentesToolStripMenuItem";
            this.cadastroDeAtendentesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cadastroDeAtendentesToolStripMenuItem.Text = "Cadastro de Atendentes";
            this.cadastroDeAtendentesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAtendentesToolStripMenuItem_Click);
            // 
            // cadastrosDeUsuáriosToolStripMenuItem
            // 
            this.cadastrosDeUsuáriosToolStripMenuItem.Name = "cadastrosDeUsuáriosToolStripMenuItem";
            this.cadastrosDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cadastrosDeUsuáriosToolStripMenuItem.Text = "Cadastros de Usuários";
            this.cadastrosDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosDeUsuáriosToolStripMenuItem_Click);
            // 
            // cadastroDeEspecialidadesToolStripMenuItem
            // 
            this.cadastroDeEspecialidadesToolStripMenuItem.Name = "cadastroDeEspecialidadesToolStripMenuItem";
            this.cadastroDeEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cadastroDeEspecialidadesToolStripMenuItem.Text = "Cadastro de Especialidades Médicas";
            this.cadastroDeEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeEspecialidadesToolStripMenuItem_Click);
            // 
            // cadastroDePacientesToolStripMenuItem
            // 
            this.cadastroDePacientesToolStripMenuItem.Name = "cadastroDePacientesToolStripMenuItem";
            this.cadastroDePacientesToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cadastroDePacientesToolStripMenuItem.Text = "Cadastro de Pacientes";
            this.cadastroDePacientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePacientesToolStripMenuItem_Click);
            // 
            // cadastroDeAgendaMédicaToolStripMenuItem
            // 
            this.cadastroDeAgendaMédicaToolStripMenuItem.Name = "cadastroDeAgendaMédicaToolStripMenuItem";
            this.cadastroDeAgendaMédicaToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cadastroDeAgendaMédicaToolStripMenuItem.Text = "Cadastro de Agenda Médica";
            this.cadastroDeAgendaMédicaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAgendaMédicaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarConsultaMédicaToolStripMenuItem,
            this.consultaAgendamentosToolStripMenuItem});
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // agendarConsultaMédicaToolStripMenuItem
            // 
            this.agendarConsultaMédicaToolStripMenuItem.Name = "agendarConsultaMédicaToolStripMenuItem";
            this.agendarConsultaMédicaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.agendarConsultaMédicaToolStripMenuItem.Text = "Agendar Consulta Médica";
            this.agendarConsultaMédicaToolStripMenuItem.Click += new System.EventHandler(this.agendarConsultaMédicaToolStripMenuItem_Click);
            // 
            // consultaAgendamentosToolStripMenuItem
            // 
            this.consultaAgendamentosToolStripMenuItem.Name = "consultaAgendamentosToolStripMenuItem";
            this.consultaAgendamentosToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.consultaAgendamentosToolStripMenuItem.Text = "Consultar Agendamentos";
            this.consultaAgendamentosToolStripMenuItem.Click += new System.EventHandler(this.consultaAgendamentosToolStripMenuItem_Click);
            // 
            // observaçõesMédicasToolStripMenuItem
            // 
            this.observaçõesMédicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.históricoDePacientesToolStripMenuItem});
            this.observaçõesMédicasToolStripMenuItem.Name = "observaçõesMédicasToolStripMenuItem";
            this.observaçõesMédicasToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.observaçõesMédicasToolStripMenuItem.Text = "Observações Médicas";
            // 
            // históricoDePacientesToolStripMenuItem
            // 
            this.históricoDePacientesToolStripMenuItem.Name = "históricoDePacientesToolStripMenuItem";
            this.históricoDePacientesToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.históricoDePacientesToolStripMenuItem.Text = "Histórico de Pacientes";
            this.históricoDePacientesToolStripMenuItem.Click += new System.EventHandler(this.históricoDePacientesToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(37, 17);
            this.lblData.Text = "Data: ";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 17);
            this.lblHora.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConsulta,
            this.toolStripSeparator1,
            this.btnAgenda,
            this.toolStripSeparator2,
            this.btnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnConsulta
            // 
            this.btnConsulta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(23, 22);
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAgenda
            // 
            this.btnAgenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgenda.Image = ((System.Drawing.Image)(resources.GetObject("btnAgenda.Image")));
            this.btnAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(23, 22);
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFechar
            // 
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 22);
            this.btnFechar.Text = "fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(974, 582);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConsultorio";
            this.Text = "Consultório Médico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultorio_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultorio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMédicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAtendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAgendaMédicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarConsultaMédicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaAgendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem observaçõesMédicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConsulta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAgenda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnFechar;
    }
}

