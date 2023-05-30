using PI3.View;
using System.Reflection;
using System.Windows.Forms;

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
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lstListarPartidas = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lstListarPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarPartidas.FlatAppearance.BorderSize = 0;
            this.btnListarPartidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnListarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarPartidas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnListarPartidas.Location = new System.Drawing.Point(56, 479);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(156, 34);
            this.btnListarPartidas.TabIndex = 2;
            this.btnListarPartidas.Text = "Atualizar";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lstListarPartidas
            // 
            this.lstListarPartidas.AllowUserToAddRows = false;
            this.lstListarPartidas.AllowUserToDeleteRows = false;
            this.lstListarPartidas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.lstListarPartidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lstListarPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstListarPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomeSala,
            this.createdAt});
            this.lstListarPartidas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(86)))));
            this.lstListarPartidas.Location = new System.Drawing.Point(56, 31);
            this.lstListarPartidas.Name = "lstListarPartidas";
            this.lstListarPartidas.ReadOnly = true;
            this.lstListarPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstListarPartidas.Size = new System.Drawing.Size(310, 428);
            this.lstListarPartidas.TabIndex = 3;
            this.lstListarPartidas.Tag = "not";
            this.lstListarPartidas.Click += new System.EventHandler(this.enableGrid);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nomeSala
            // 
            this.nomeSala.HeaderText = "Nome da sala";
            this.nomeSala.Name = "nomeSala";
            this.nomeSala.ReadOnly = true;
            this.nomeSala.Width = 125;
            // 
            // createdAt
            // 
            this.createdAt.HeaderText = "Data criação";
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            this.createdAt.Width = 91;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Location = new System.Drawing.Point(227, 479);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(139, 34);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Navegacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI3.Properties.Resources.FundoNav;
            this.ClientSize = new System.Drawing.Size(419, 534);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lstListarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(435, 573);
            this.MinimumSize = new System.Drawing.Size(435, 558);
            this.Name = "Navegacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Navegacao";
            this.Load += new System.EventHandler(this.Navegacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstListarPartidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.DataGridView lstListarPartidas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
    }
}
