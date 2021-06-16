
namespace TinDev
{
    partial class FrmMenuPrincipal
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
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPerfilUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMenuPrincipalContratante = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVisualizarInteressados = new System.Windows.Forms.Button();
            this.btnCadastrarVaga = new System.Windows.Forms.Button();
            this.pnlMenuPrincipalDev = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNotificacoes = new System.Windows.Forms.Button();
            this.btnVisualizarVagasDisponíveis = new System.Windows.Forms.Button();
            this.pnlGeral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlMenuPrincipalContratante.SuspendLayout();
            this.pnlMenuPrincipalDev.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeral
            // 
            this.pnlGeral.Controls.Add(this.panel1);
            this.pnlGeral.Controls.Add(this.pnlMenuPrincipalContratante);
            this.pnlGeral.Controls.Add(this.pnlMenuPrincipalDev);
            this.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeral.Location = new System.Drawing.Point(0, 0);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(1060, 739);
            this.pnlGeral.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPerfilUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 708);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 31);
            this.panel1.TabIndex = 2;
            // 
            // lblPerfilUsuario
            // 
            this.lblPerfilUsuario.AutoSize = true;
            this.lblPerfilUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPerfilUsuario.Location = new System.Drawing.Point(815, 6);
            this.lblPerfilUsuario.Name = "lblPerfilUsuario";
            this.lblPerfilUsuario.Size = new System.Drawing.Size(40, 15);
            this.lblPerfilUsuario.TabIndex = 3;
            this.lblPerfilUsuario.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário logado:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(109, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário logado:";
            // 
            // pnlMenuPrincipalContratante
            // 
            this.pnlMenuPrincipalContratante.Controls.Add(this.button2);
            this.pnlMenuPrincipalContratante.Controls.Add(this.btnVisualizarInteressados);
            this.pnlMenuPrincipalContratante.Controls.Add(this.btnCadastrarVaga);
            this.pnlMenuPrincipalContratante.Location = new System.Drawing.Point(21, 348);
            this.pnlMenuPrincipalContratante.Name = "pnlMenuPrincipalContratante";
            this.pnlMenuPrincipalContratante.Size = new System.Drawing.Size(975, 300);
            this.pnlMenuPrincipalContratante.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVisualizarInteressados
            // 
            this.btnVisualizarInteressados.Location = new System.Drawing.Point(381, 92);
            this.btnVisualizarInteressados.Name = "btnVisualizarInteressados";
            this.btnVisualizarInteressados.Size = new System.Drawing.Size(175, 99);
            this.btnVisualizarInteressados.TabIndex = 1;
            this.btnVisualizarInteressados.Text = "Visualizar interessados";
            this.btnVisualizarInteressados.UseVisualStyleBackColor = true;
            this.btnVisualizarInteressados.Click += new System.EventHandler(this.btnVisualizarInteressados_Click);
            // 
            // btnCadastrarVaga
            // 
            this.btnCadastrarVaga.Location = new System.Drawing.Point(65, 92);
            this.btnCadastrarVaga.Name = "btnCadastrarVaga";
            this.btnCadastrarVaga.Size = new System.Drawing.Size(175, 99);
            this.btnCadastrarVaga.TabIndex = 0;
            this.btnCadastrarVaga.Text = "Cadastrar solicitação";
            this.btnCadastrarVaga.UseVisualStyleBackColor = true;
            this.btnCadastrarVaga.Click += new System.EventHandler(this.btnCadastrarVaga_Click);
            // 
            // pnlMenuPrincipalDev
            // 
            this.pnlMenuPrincipalDev.Controls.Add(this.button1);
            this.pnlMenuPrincipalDev.Controls.Add(this.btnNotificacoes);
            this.pnlMenuPrincipalDev.Controls.Add(this.btnVisualizarVagasDisponíveis);
            this.pnlMenuPrincipalDev.Location = new System.Drawing.Point(21, 23);
            this.pnlMenuPrincipalDev.Name = "pnlMenuPrincipalDev";
            this.pnlMenuPrincipalDev.Size = new System.Drawing.Size(975, 300);
            this.pnlMenuPrincipalDev.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 99);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNotificacoes
            // 
            this.btnNotificacoes.Location = new System.Drawing.Point(400, 101);
            this.btnNotificacoes.Name = "btnNotificacoes";
            this.btnNotificacoes.Size = new System.Drawing.Size(175, 99);
            this.btnNotificacoes.TabIndex = 4;
            this.btnNotificacoes.Text = "Notificações";
            this.btnNotificacoes.UseVisualStyleBackColor = true;
            this.btnNotificacoes.Click += new System.EventHandler(this.btnNotificacoes_Click);
            // 
            // btnVisualizarVagasDisponíveis
            // 
            this.btnVisualizarVagasDisponíveis.Location = new System.Drawing.Point(84, 101);
            this.btnVisualizarVagasDisponíveis.Name = "btnVisualizarVagasDisponíveis";
            this.btnVisualizarVagasDisponíveis.Size = new System.Drawing.Size(175, 99);
            this.btnVisualizarVagasDisponíveis.TabIndex = 3;
            this.btnVisualizarVagasDisponíveis.Text = "Visualizar Vagas disponíveis";
            this.btnVisualizarVagasDisponíveis.UseVisualStyleBackColor = true;
            this.btnVisualizarVagasDisponíveis.Click += new System.EventHandler(this.btnVisualizarVagasDisponíveis_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 739);
            this.Controls.Add(this.pnlGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.Shown += new System.EventHandler(this.FrmMenuPrincipal_Shown);
            this.pnlGeral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMenuPrincipalContratante.ResumeLayout(false);
            this.pnlMenuPrincipalDev.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.Panel pnlMenuPrincipalContratante;
        private System.Windows.Forms.Panel pnlMenuPrincipalDev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPerfilUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVisualizarInteressados;
        private System.Windows.Forms.Button btnCadastrarVaga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNotificacoes;
        private System.Windows.Forms.Button btnVisualizarVagasDisponíveis;
    }
}