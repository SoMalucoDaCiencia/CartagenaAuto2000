namespace PI3
{
    partial class Menu
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
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.SeaShell;
            this.btnCriarPartida.FlatAppearance.BorderSize = 0;
            this.btnCriarPartida.Location = new System.Drawing.Point(229, 253);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(246, 42);
            this.btnCriarPartida.TabIndex = 22;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.SeaShell;
            this.btnEntrarPartida.Location = new System.Drawing.Point(229, 313);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(246, 41);
            this.btnEntrarPartida.TabIndex = 28;
            this.btnEntrarPartida.Text = "Entrar em Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.SeaShell;
            this.btnSair.Location = new System.Drawing.Point(229, 370);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(246, 41);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 51);
            this.label1.TabIndex = 30;
            this.label1.Text = "Bem Vindo ao Cartagena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "na cidade de Bucaramanga";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI3.Properties.Resources._2799ec3847ca53eb8a3f0631b9cf07ce;
            this.ClientSize = new System.Drawing.Size(736, 542);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.MinimumSize = new System.Drawing.Size(752, 581);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
