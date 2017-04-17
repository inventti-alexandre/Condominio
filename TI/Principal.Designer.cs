namespace TI
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Morador = new System.Windows.Forms.Button();
            this.Residência = new System.Windows.Forms.Button();
            this.Financeiro = new System.Windows.Forms.Button();
            this.Pagamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Morador
            // 
            this.Morador.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Morador.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Morador.Location = new System.Drawing.Point(696, 133);
            this.Morador.Name = "Morador";
            this.Morador.Size = new System.Drawing.Size(128, 23);
            this.Morador.TabIndex = 1;
            this.Morador.Text = "MORADOR";
            this.Morador.UseVisualStyleBackColor = false;
            this.Morador.Click += new System.EventHandler(this.Morador_Click);
            // 
            // Residência
            // 
            this.Residência.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Residência.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Residência.Location = new System.Drawing.Point(696, 193);
            this.Residência.Name = "Residência";
            this.Residência.Size = new System.Drawing.Size(128, 23);
            this.Residência.TabIndex = 2;
            this.Residência.Text = "RESIDÊNCIA";
            this.Residência.UseVisualStyleBackColor = false;
            this.Residência.Click += new System.EventHandler(this.Residência_Click);
            // 
            // Financeiro
            // 
            this.Financeiro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Financeiro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Financeiro.Location = new System.Drawing.Point(696, 253);
            this.Financeiro.Name = "Financeiro";
            this.Financeiro.Size = new System.Drawing.Size(128, 23);
            this.Financeiro.TabIndex = 3;
            this.Financeiro.Text = "FINANCEIRO";
            this.Financeiro.UseVisualStyleBackColor = false;
            this.Financeiro.Click += new System.EventHandler(this.Financeiro_Click);
            // 
            // Pagamento
            // 
            this.Pagamento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Pagamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pagamento.Location = new System.Drawing.Point(696, 308);
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.Size = new System.Drawing.Size(128, 23);
            this.Pagamento.TabIndex = 5;
            this.Pagamento.Text = "RELATORIOS";
            this.Pagamento.UseVisualStyleBackColor = false;
            this.Pagamento.Click += new System.EventHandler(this.Pagamento_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 390);
            this.Controls.Add(this.Pagamento);
            this.Controls.Add(this.Financeiro);
            this.Controls.Add(this.Residência);
            this.Controls.Add(this.Morador);
            this.Name = "Principal";
            this.Text = "SAdCon";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Morador;
        private System.Windows.Forms.Button Residência;
        private System.Windows.Forms.Button Financeiro;
        private System.Windows.Forms.Button Pagamento;
    }
}