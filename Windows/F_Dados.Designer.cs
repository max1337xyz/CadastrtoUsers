namespace RegistradorDeUsuarios.Windows
{
    partial class F_Dados
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
            this.ll_users = new System.Windows.Forms.ListBox();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ll_users
            // 
            this.ll_users.FormattingEnabled = true;
            this.ll_users.Location = new System.Drawing.Point(12, 12);
            this.ll_users.Name = "ll_users";
            this.ll_users.Size = new System.Drawing.Size(120, 368);
            this.ll_users.TabIndex = 0;
            // 
            // btn_Remover
            // 
            this.btn_Remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.Location = new System.Drawing.Point(138, 12);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(97, 35);
            this.btn_Remover.TabIndex = 1;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_exibir
            // 
            this.btn_exibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exibir.Location = new System.Drawing.Point(138, 63);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(97, 35);
            this.btn_exibir.TabIndex = 2;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // F_Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 382);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.ll_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Usúarios";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_exibir;
        public System.Windows.Forms.ListBox ll_users;
    }
}