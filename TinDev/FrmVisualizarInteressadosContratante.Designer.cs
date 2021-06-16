
namespace TinDev
{
    partial class FrmVisualizarInteressadosContratante
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
            this.Vagas = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.ClVagas = new System.Windows.Forms.Panel();
            this.Proximo = new System.Windows.Forms.Button();
            this.TelaVagas = new System.Windows.Forms.DataGridView();
            this.CInteressados = new System.Windows.Forms.Panel();
            this.Interessado = new System.Windows.Forms.Button();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CanditadosInteressados = new System.Windows.Forms.Label();
            this.PeDev = new System.Windows.Forms.Panel();
            this.Confirma = new System.Windows.Forms.Button();
            this.BtVoltar2 = new System.Windows.Forms.Button();
            this.Apresentacao = new System.Windows.Forms.Label();
            this.JobsFinalizados = new System.Windows.Forms.Label();
            this.EmailDev = new System.Windows.Forms.Label();
            this.TelefoneDev = new System.Windows.Forms.Label();
            this.NomeDev = new System.Windows.Forms.Label();
            this.PerfilDoDev = new System.Windows.Forms.Label();
            this.MostraVagas = new System.Windows.Forms.Button();
            this.ClVagas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelaVagas)).BeginInit();
            this.CInteressados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PeDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vagas
            // 
            this.Vagas.AutoSize = true;
            this.Vagas.Location = new System.Drawing.Point(106, 10);
            this.Vagas.Name = "Vagas";
            this.Vagas.Size = new System.Drawing.Size(37, 15);
            this.Vagas.TabIndex = 1;
            this.Vagas.Text = "Vagas";
            // 
            // Voltar
            // 
            this.Voltar.AccessibleName = "";
            this.Voltar.Location = new System.Drawing.Point(21, 343);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(75, 31);
            this.Voltar.TabIndex = 2;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClVagas
            // 
            this.ClVagas.Controls.Add(this.Proximo);
            this.ClVagas.Controls.Add(this.Vagas);
            this.ClVagas.Controls.Add(this.Voltar);
            this.ClVagas.Controls.Add(this.TelaVagas);
            this.ClVagas.Location = new System.Drawing.Point(12, 93);
            this.ClVagas.Name = "ClVagas";
            this.ClVagas.Size = new System.Drawing.Size(293, 391);
            this.ClVagas.TabIndex = 3;
            this.ClVagas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Proximo
            // 
            this.Proximo.Location = new System.Drawing.Point(177, 343);
            this.Proximo.Name = "Proximo";
            this.Proximo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Proximo.Size = new System.Drawing.Size(88, 31);
            this.Proximo.TabIndex = 3;
            this.Proximo.Text = "Proximo";
            this.Proximo.UseVisualStyleBackColor = true;
            this.Proximo.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // TelaVagas
            // 
            this.TelaVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelaVagas.Location = new System.Drawing.Point(11, 39);
            this.TelaVagas.Name = "TelaVagas";
            this.TelaVagas.RowTemplate.Height = 25;
            this.TelaVagas.Size = new System.Drawing.Size(271, 272);
            this.TelaVagas.TabIndex = 0;
            this.TelaVagas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TelaVagas_CellContentClick);
            // 
            // CInteressados
            // 
            this.CInteressados.Controls.Add(this.Interessado);
            this.CInteressados.Controls.Add(this.BtVoltar);
            this.CInteressados.Controls.Add(this.dataGridView1);
            this.CInteressados.Controls.Add(this.CanditadosInteressados);
            this.CInteressados.Location = new System.Drawing.Point(336, 93);
            this.CInteressados.Name = "CInteressados";
            this.CInteressados.Size = new System.Drawing.Size(282, 391);
            this.CInteressados.TabIndex = 4;
            this.CInteressados.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Interessado
            // 
            this.Interessado.Location = new System.Drawing.Point(170, 343);
            this.Interessado.Name = "Interessado";
            this.Interessado.Size = new System.Drawing.Size(89, 31);
            this.Interessado.TabIndex = 3;
            this.Interessado.Text = "Interessado";
            this.Interessado.UseVisualStyleBackColor = true;
            this.Interessado.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtVoltar
            // 
            this.BtVoltar.Location = new System.Drawing.Point(19, 343);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(84, 31);
            this.BtVoltar.TabIndex = 2;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = true;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 272);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CanditadosInteressados
            // 
            this.CanditadosInteressados.AutoSize = true;
            this.CanditadosInteressados.Location = new System.Drawing.Point(75, 10);
            this.CanditadosInteressados.Name = "CanditadosInteressados";
            this.CanditadosInteressados.Size = new System.Drawing.Size(135, 15);
            this.CanditadosInteressados.TabIndex = 0;
            this.CanditadosInteressados.Text = "Canditados Interessados";
            this.CanditadosInteressados.Click += new System.EventHandler(this.label1_Click);
            // 
            // PeDev
            // 
            this.PeDev.Controls.Add(this.Confirma);
            this.PeDev.Controls.Add(this.BtVoltar2);
            this.PeDev.Controls.Add(this.Apresentacao);
            this.PeDev.Controls.Add(this.JobsFinalizados);
            this.PeDev.Controls.Add(this.EmailDev);
            this.PeDev.Controls.Add(this.TelefoneDev);
            this.PeDev.Controls.Add(this.NomeDev);
            this.PeDev.Controls.Add(this.PerfilDoDev);
            this.PeDev.Location = new System.Drawing.Point(663, 93);
            this.PeDev.Name = "PeDev";
            this.PeDev.Size = new System.Drawing.Size(257, 391);
            this.PeDev.TabIndex = 5;
            this.PeDev.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Confirma
            // 
            this.Confirma.Location = new System.Drawing.Point(147, 265);
            this.Confirma.Name = "Confirma";
            this.Confirma.Size = new System.Drawing.Size(91, 31);
            this.Confirma.TabIndex = 7;
            this.Confirma.Text = "Confirma";
            this.Confirma.UseVisualStyleBackColor = true;
            this.Confirma.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // BtVoltar2
            // 
            this.BtVoltar2.Location = new System.Drawing.Point(22, 265);
            this.BtVoltar2.Name = "BtVoltar2";
            this.BtVoltar2.Size = new System.Drawing.Size(84, 30);
            this.BtVoltar2.TabIndex = 6;
            this.BtVoltar2.Text = "Voltar";
            this.BtVoltar2.UseVisualStyleBackColor = true;
            this.BtVoltar2.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Apresentacao
            // 
            this.Apresentacao.AutoSize = true;
            this.Apresentacao.Location = new System.Drawing.Point(22, 177);
            this.Apresentacao.Name = "Apresentacao";
            this.Apresentacao.Size = new System.Drawing.Size(79, 15);
            this.Apresentacao.TabIndex = 5;
            this.Apresentacao.Text = "Apresentação";
            this.Apresentacao.Click += new System.EventHandler(this.Apresentacao_Click);
            // 
            // JobsFinalizados
            // 
            this.JobsFinalizados.AutoSize = true;
            this.JobsFinalizados.Location = new System.Drawing.Point(147, 83);
            this.JobsFinalizados.Name = "JobsFinalizados";
            this.JobsFinalizados.Size = new System.Drawing.Size(91, 15);
            this.JobsFinalizados.TabIndex = 4;
            this.JobsFinalizados.Text = "Jobs Finalizados";
            // 
            // EmailDev
            // 
            this.EmailDev.AutoSize = true;
            this.EmailDev.Location = new System.Drawing.Point(22, 115);
            this.EmailDev.Name = "EmailDev";
            this.EmailDev.Size = new System.Drawing.Size(36, 15);
            this.EmailDev.TabIndex = 3;
            this.EmailDev.Text = "Email";
            this.EmailDev.Click += new System.EventHandler(this.EmailDev_Click);
            // 
            // TelefoneDev
            // 
            this.TelefoneDev.AutoSize = true;
            this.TelefoneDev.Location = new System.Drawing.Point(22, 83);
            this.TelefoneDev.Name = "TelefoneDev";
            this.TelefoneDev.Size = new System.Drawing.Size(51, 15);
            this.TelefoneDev.TabIndex = 2;
            this.TelefoneDev.Text = "Telefone";
            // 
            // NomeDev
            // 
            this.NomeDev.AutoSize = true;
            this.NomeDev.Location = new System.Drawing.Point(104, 39);
            this.NomeDev.Name = "NomeDev";
            this.NomeDev.Size = new System.Drawing.Size(40, 15);
            this.NomeDev.TabIndex = 1;
            this.NomeDev.Text = "Nome";
            this.NomeDev.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PerfilDoDev
            // 
            this.PerfilDoDev.AutoSize = true;
            this.PerfilDoDev.Location = new System.Drawing.Point(89, 10);
            this.PerfilDoDev.Name = "PerfilDoDev";
            this.PerfilDoDev.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PerfilDoDev.Size = new System.Drawing.Size(75, 15);
            this.PerfilDoDev.TabIndex = 0;
            this.PerfilDoDev.Text = "Perfil Do Dev";
            this.PerfilDoDev.Click += new System.EventHandler(this.label2_Click);
            // 
            // MostraVagas
            // 
            this.MostraVagas.Location = new System.Drawing.Point(33, 27);
            this.MostraVagas.Name = "MostraVagas";
            this.MostraVagas.Size = new System.Drawing.Size(104, 23);
            this.MostraVagas.TabIndex = 6;
            this.MostraVagas.Text = "Mostra Vagas";
            this.MostraVagas.UseVisualStyleBackColor = true;
            this.MostraVagas.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // FrmVisualizarInteressadosContratante
            // 
            this.AccessibleName = "BtVoltar";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 496);
            this.Controls.Add(this.MostraVagas);
            this.Controls.Add(this.PeDev);
            this.Controls.Add(this.CInteressados);
            this.Controls.Add(this.ClVagas);
            this.Name = "FrmVisualizarInteressadosContratante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volta";
            this.Load += new System.EventHandler(this.FrmVisualizarInteressadosContratante_Load);
            this.ClVagas.ResumeLayout(false);
            this.ClVagas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TelaVagas)).EndInit();
            this.CInteressados.ResumeLayout(false);
            this.CInteressados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PeDev.ResumeLayout(false);
            this.PeDev.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Vagas;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Panel ClVagas;
        private System.Windows.Forms.Button Proximo;
        private System.Windows.Forms.Panel CInteressados;
        private System.Windows.Forms.Label CanditadosInteressados;
        private System.Windows.Forms.Button Interessado;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel PeDev;
        private System.Windows.Forms.Label PerfilDoDev;
        private System.Windows.Forms.Label NomeDev;
        private System.Windows.Forms.Label Apresentacao;
        private System.Windows.Forms.Label JobsFinalizados;
        private System.Windows.Forms.Label EmailDev;
        private System.Windows.Forms.Label TelefoneDev;
        private System.Windows.Forms.Button BtVoltar2;
        private System.Windows.Forms.Button Confirma;
        private System.Windows.Forms.Button MostraVagas;
        private System.Windows.Forms.DataGridView TelaVagas;
    }
}