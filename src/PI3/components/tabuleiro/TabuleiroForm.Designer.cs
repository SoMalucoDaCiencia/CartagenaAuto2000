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
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.HistoricoGrid = new System.Windows.Forms.DataGridView();
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
            this.lblChave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGrid)).BeginInit();
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
            // btnJogar
            // 
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.Font = new System.Drawing.Font("Berserker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.Location = new System.Drawing.Point(783, 604);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(174, 50);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(963, 604);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(181, 50);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Automático";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // HistoricoGrid
            // 
            this.HistoricoGrid.AllowUserToAddRows = false;
            this.HistoricoGrid.AllowUserToDeleteRows = false;
            this.HistoricoGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.HistoricoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoricoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJogador,
            this.nmJogada,
            this.simbolo,
            this.posOrigem,
            this.posDestino});
            this.HistoricoGrid.Location = new System.Drawing.Point(783, 12);
            this.HistoricoGrid.Name = "HistoricoGrid";
            this.HistoricoGrid.ReadOnly = true;
            this.HistoricoGrid.Size = new System.Drawing.Size(361, 267);
            this.HistoricoGrid.TabIndex = 3;
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
            this.btnIniciarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnHistorico.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.Font = new System.Drawing.Font("Berserker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.Location = new System.Drawing.Point(1021, 239);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(123, 40);
            this.btnHistorico.TabIndex = 12;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // lblChave
            // 
            this.lblChave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChave.AutoSize = true;
            this.lblChave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblChave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChave.Font = new System.Drawing.Font("Palatino Linotype", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChave.Location = new System.Drawing.Point(795, 309);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(85, 107);
            this.lblChave.TabIndex = 13;
            this.lblChave.Text = "0";
            this.lblChave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(926, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 107);
            this.label2.TabIndex = 14;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1056, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 107);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(793, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 107);
            this.label4.TabIndex = 16;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(924, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 107);
            this.label5.TabIndex = 17;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1056, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 107);
            this.label6.TabIndex = 18;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TabuleiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 666);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.pnlTricornio);
            this.Controls.Add(this.pnlFaca);
            this.Controls.Add(this.pnlPistola);
            this.Controls.Add(this.pnlEsqueleto);
            this.Controls.Add(this.pnlGarrafa);
            this.Controls.Add(this.pnlChave);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lstPlayersLobby);
            this.Controls.Add(this.HistoricoGrid);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(1172, 705);
            this.Name = "TabuleiroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.DataGridView HistoricoGrid;
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
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
