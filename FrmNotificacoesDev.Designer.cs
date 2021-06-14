
namespace TinDev
{
    partial class FrmNotificacoesDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificacoesDev));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnNotificacoes = new System.Windows.Forms.Button();
            this.dtgNotificacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificacao)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnNotificacoes
            // 
            this.btnNotificacoes.Location = new System.Drawing.Point(312, 40);
            this.btnNotificacoes.Name = "btnNotificacoes";
            this.btnNotificacoes.Size = new System.Drawing.Size(148, 33);
            this.btnNotificacoes.TabIndex = 0;
            this.btnNotificacoes.Text = "Atualizar Notificações";
            this.btnNotificacoes.UseVisualStyleBackColor = true;
            this.btnNotificacoes.Click += new System.EventHandler(this.Atualizar_Notificacoes);
            // 
            // dtgNotificacao
            // 
            this.dtgNotificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNotificacao.Location = new System.Drawing.Point(48, 79);
            this.dtgNotificacao.Name = "dtgNotificacao";
            this.dtgNotificacao.RowTemplate.Height = 25;
            this.dtgNotificacao.Size = new System.Drawing.Size(709, 223);
            this.dtgNotificacao.TabIndex = 1;
            this.dtgNotificacao.Visible = false;
            // 
            // FrmNotificacoesDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgNotificacao);
            this.Controls.Add(this.btnNotificacoes);
            this.Name = "FrmNotificacoesDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificações";
            this.Resize += new System.EventHandler(this.FrmNotificacoesDev_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnNotificacoes;
        private System.Windows.Forms.DataGridView dtgNotificacao;
    }
}