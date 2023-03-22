namespace teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCliqueAqui = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCliqueAqui
            // 
            this.btnCliqueAqui.Location = new System.Drawing.Point(283, 165);
            this.btnCliqueAqui.Name = "btnCliqueAqui";
            this.btnCliqueAqui.Size = new System.Drawing.Size(149, 65);
            this.btnCliqueAqui.TabIndex = 0;
            this.btnCliqueAqui.Text = "Clique aqui";
            this.btnCliqueAqui.UseVisualStyleBackColor = true;
            this.btnCliqueAqui.Click += new System.EventHandler(this.btnCliqueAqui_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(280, 126);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(36, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "valor2";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(322, 82);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(129, 20);
            this.txtValor1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "valor1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(181, 148);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(50, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "resultado";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(322, 123);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(129, 20);
            this.txtValor2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 447);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCliqueAqui);
            this.Name = "Form1";
            this.Text = "Projeto Integrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCliqueAqui;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtValor2;
    }
}

