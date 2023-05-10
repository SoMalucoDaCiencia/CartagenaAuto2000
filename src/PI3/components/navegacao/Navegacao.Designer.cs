namespace PI3
{
    partial class Navegacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navegacao));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lstListarPartidas = new System.Windows.Forms.ListBox();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Snow;
            this.btnVoltar.Location = new System.Drawing.Point(686, 514);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 35);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstListarPartidas.FormattingEnabled = true;
            this.lstListarPartidas.Location = new System.Drawing.Point(129, 181);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.Size = new System.Drawing.Size(167, 290);
            this.lstListarPartidas.TabIndex = 1;
            this.lstListarPartidas.SelectedIndexChanged += new System.EventHandler(this.lstListarPartidas_SelectedIndexChanged);
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(230, 110);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(75, 23);
            this.btnListarPartidas.TabIndex = 2;
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // Navegacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI3.Properties.Resources.MainBackground;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.lstListarPartidas);
            this.Controls.Add(this.btnVoltar);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Navegacao";
            this.Text = "Navegacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox lstListarPartidas;
        private System.Windows.Forms.Button btnListarPartidas;
    }
}