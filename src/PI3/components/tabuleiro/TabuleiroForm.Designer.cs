namespace PI3.components.tabuleiro
{
    partial class TabuleiroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabuleiroForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmJogada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posOrigem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPlayersLobby = new System.Windows.Forms.ListBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.pnlFaca = new System.Windows.Forms.Button();
            this.pnlEsqueleto = new System.Windows.Forms.Button();
            this.pnlChave = new System.Windows.Forms.Button();
            this.pnlTricornio = new System.Windows.Forms.Button();
            this.pnlPistola = new System.Windows.Forms.Button();
            this.pnlGarrafa = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 64);
            this.label1.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(783, 604);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(174, 50);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(963, 604);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(181, 50);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Automático";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJogador,
            this.nmJogada,
            this.simbolo,
            this.posOrigem,
            this.posDestino});
            this.dataGridView1.Location = new System.Drawing.Point(783, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(361, 267);
            this.dataGridView1.TabIndex = 3;
            // 
            // idJogador
            // 
            this.idJogador.HeaderText = "Id Jogador";
            this.idJogador.Name = "idJogador";
            this.idJogador.ReadOnly = true;
            this.idJogador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idJogador.Width = 63;
            // 
            // nmJogada
            // 
            this.nmJogada.HeaderText = "Nº Jogada";
            this.nmJogada.Name = "nmJogada";
            this.nmJogada.ReadOnly = true;
            this.nmJogada.Width = 60;
            // 
            // simbolo
            // 
            this.simbolo.HeaderText = "Simbolo";
            this.simbolo.Name = "simbolo";
            this.simbolo.ReadOnly = true;
            this.simbolo.Width = 55;
            // 
            // posOrigem
            // 
            this.posOrigem.HeaderText = "Posição de Origem";
            this.posOrigem.Name = "posOrigem";
            this.posOrigem.ReadOnly = true;
            this.posOrigem.Width = 70;
            // 
            // posDestino
            // 
            this.posDestino.HeaderText = "Posição de Destino";
            this.posDestino.Name = "posDestino";
            this.posDestino.ReadOnly = true;
            this.posDestino.Width = 70;
            // 
            // lstPlayersLobby
            // 
            this.lstPlayersLobby.FormattingEnabled = true;
            this.lstPlayersLobby.Location = new System.Drawing.Point(494, 235);
            this.lstPlayersLobby.Name = "lstPlayersLobby";
            this.lstPlayersLobby.Size = new System.Drawing.Size(174, 160);
            this.lstPlayersLobby.TabIndex = 4;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(494, 401);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(174, 50);
            this.btnIniciarPartida.TabIndex = 5;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // pnlFaca
            // 
            this.pnlFaca.BackColor = System.Drawing.Color.Transparent;
            this.pnlFaca.BackgroundImage = global::PI3.Properties.Resources.Faca;
            this.pnlFaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFaca.FlatAppearance.BorderSize = 0;
            this.pnlFaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlFaca.Location = new System.Drawing.Point(1045, 295);
            this.pnlFaca.Name = "pnlFaca";
            this.pnlFaca.Size = new System.Drawing.Size(99, 135);
            this.pnlFaca.TabIndex = 8;
            this.pnlFaca.Tag = "F";
            this.pnlFaca.UseVisualStyleBackColor = false;
            this.pnlFaca.MouseLeave += new System.EventHandler(this.setDefault);
            this.pnlFaca.MouseHover += new System.EventHandler(this.showQtd);
            // 
            // pnlEsqueleto
            // 
            this.pnlEsqueleto.BackColor = System.Drawing.Color.Transparent;
            this.pnlEsqueleto.BackgroundImage = global::PI3.Properties.Resources.Esqueleto;
            this.pnlEsqueleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEsqueleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEsqueleto.FlatAppearance.BorderSize = 0;
            this.pnlEsqueleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlEsqueleto.Location = new System.Drawing.Point(914, 295);
            this.pnlEsqueleto.Name = "pnlEsqueleto";
            this.pnlEsqueleto.Size = new System.Drawing.Size(99, 135);
            this.pnlEsqueleto.TabIndex = 7;
            this.pnlEsqueleto.Tag = "E";
            this.pnlEsqueleto.UseVisualStyleBackColor = false;
            this.pnlEsqueleto.MouseLeave += new System.EventHandler(this.setDefault);
            this.pnlEsqueleto.MouseHover += new System.EventHandler(this.showQtd);
            // 
            // pnlChave
            // 
            this.pnlChave.BackColor = System.Drawing.Color.Transparent;
            this.pnlChave.BackgroundImage = global::PI3.Properties.Resources.Chave;
            this.pnlChave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlChave.FlatAppearance.BorderSize = 0;
            this.pnlChave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlChave.Location = new System.Drawing.Point(783, 295);
            this.pnlChave.Name = "pnlChave";
            this.pnlChave.Size = new System.Drawing.Size(99, 135);
            this.pnlChave.TabIndex = 6;
            this.pnlChave.Tag = "C";
            this.pnlChave.UseVisualStyleBackColor = false;
            this.pnlChave.MouseLeave += new System.EventHandler(this.setDefault);
            this.pnlChave.MouseHover += new System.EventHandler(this.showQtd);
            // 
            // pnlTricornio
            // 
            this.pnlTricornio.BackColor = System.Drawing.Color.Transparent;
            this.pnlTricornio.BackgroundImage = global::PI3.Properties.Resources.Tricornio;
            this.pnlTricornio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTricornio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTricornio.FlatAppearance.BorderSize = 0;
            this.pnlTricornio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlTricornio.Location = new System.Drawing.Point(1045, 453);
            this.pnlTricornio.Name = "pnlTricornio";
            this.pnlTricornio.Size = new System.Drawing.Size(99, 135);
            this.pnlTricornio.TabIndex = 11;
            this.pnlTricornio.Tag = "T";
            this.pnlTricornio.UseVisualStyleBackColor = false;
            this.pnlTricornio.MouseLeave += new System.EventHandler(this.setDefault);
            this.pnlTricornio.MouseHover += new System.EventHandler(this.showQtd);
            // 
            // pnlPistola
            // 
            this.pnlPistola.BackColor = System.Drawing.Color.Transparent;
            this.pnlPistola.BackgroundImage = global::PI3.Properties.Resources.Pistola;
            this.pnlPistola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPistola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPistola.FlatAppearance.BorderSize = 0;
            this.pnlPistola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlPistola.Location = new System.Drawing.Point(914, 453);
            this.pnlPistola.Name = "pnlPistola";
            this.pnlPistola.Size = new System.Drawing.Size(99, 135);
            this.pnlPistola.TabIndex = 10;
            this.pnlPistola.Tag = "P";
            this.pnlPistola.UseVisualStyleBackColor = false;
            this.pnlPistola.MouseLeave += new System.EventHandler(this.setDefault);
            this.pnlPistola.MouseHover += new System.EventHandler(this.showQtd);
            // 
            // pnlGarrafa
            // 
            this.pnlGarrafa.BackColor = System.Drawing.Color.Transparent;
            this.pnlGarrafa.BackgroundImage = global::PI3.Properties.Resources.Garrafa;
            this.pnlGarrafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGarrafa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGarrafa.FlatAppearance.BorderSize = 0;
            this.pnlGarrafa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlGarrafa.Location = new System.Drawing.Point(783, 453);
            this.pnlGarrafa.Name = "pnlGarrafa";
            this.pnlGarrafa.Size = new System.Drawing.Size(99, 135);
            this.pnlGarrafa.TabIndex = 9;
            this.pnlGarrafa.Tag = "G";
            this.pnlGarrafa.UseVisualStyleBackColor = false;
            this.pnlGarrafa.MouseLeave += new System.EventHandler(this.setDefault);
            this.pnlGarrafa.MouseHover += new System.EventHandler(this.showQtd);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.Location = new System.Drawing.Point(1034, 239);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(110, 40);
            this.btnHistorico.TabIndex = 12;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // TabuleiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 666);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.pnlTricornio);
            this.Controls.Add(this.pnlFaca);
            this.Controls.Add(this.pnlPistola);
            this.Controls.Add(this.pnlEsqueleto);
            this.Controls.Add(this.pnlGarrafa);
            this.Controls.Add(this.pnlChave);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lstPlayersLobby);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1172, 705);
            this.Name = "TabuleiroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstPlayersLobby;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button pnlFaca;
        private System.Windows.Forms.Button pnlEsqueleto;
        private System.Windows.Forms.Button pnlChave;
        private System.Windows.Forms.Button pnlTricornio;
        private System.Windows.Forms.Button pnlPistola;
        private System.Windows.Forms.Button pnlGarrafa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmJogada;
        private System.Windows.Forms.DataGridViewTextBoxColumn simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn posOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDestino;
        private System.Windows.Forms.Button btnHistorico;
    }
}
