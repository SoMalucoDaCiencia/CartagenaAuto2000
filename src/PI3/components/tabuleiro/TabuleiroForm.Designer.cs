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
            this.btnHistorico = new System.Windows.Forms.Button();
            this.lblComunicacao = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCartaSelecionada = new System.Windows.Forms.Label();
            this.pnlMadeira = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTricornio = new System.Windows.Forms.Label();
            this.lblPistola = new System.Windows.Forms.Label();
            this.lblGarrafa = new System.Windows.Forms.Label();
            this.lblFaca = new System.Windows.Forms.Label();
            this.lblEsqueleto = new System.Windows.Forms.Label();
            this.lblPosicaoSelecionada = new System.Windows.Forms.Label();
            this.lblChave = new System.Windows.Forms.Label();
            this.pnlPistola = new System.Windows.Forms.Panel();
            this.pnlGarrafa = new System.Windows.Forms.Panel();
            this.pnlFaca = new System.Windows.Forms.Panel();
            this.pnlEsqueleto = new System.Windows.Forms.Panel();
            this.pnlChave = new System.Windows.Forms.Panel();
            this.pnlTricornio = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGrid)).BeginInit();
            this.pnlMadeira.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.SystemColors.Control;
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJogar.Location = new System.Drawing.Point(118, 298);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(90, 50);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAuto.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.SystemColors.Control;
            this.btnHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.Location = new System.Drawing.Point(1021, 239);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(123, 40);
            this.btnHistorico.TabIndex = 12;
            this.btnHistorico.Text = "Historico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // lblComunicacao
            // 
            this.lblComunicacao.AutoSize = true;
            this.lblComunicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunicacao.Location = new System.Drawing.Point(62, 166);
            this.lblComunicacao.Name = "lblComunicacao";
            this.lblComunicacao.Size = new System.Drawing.Size(0, 24);
            this.lblComunicacao.TabIndex = 13;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Control;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.Location = new System.Drawing.Point(22, 298);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 50);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCartaSelecionada
            // 
            this.lblCartaSelecionada.AutoSize = true;
            this.lblCartaSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartaSelecionada.Location = new System.Drawing.Point(219, 247);
            this.lblCartaSelecionada.Name = "lblCartaSelecionada";
            this.lblCartaSelecionada.Size = new System.Drawing.Size(20, 24);
            this.lblCartaSelecionada.TabIndex = 15;
            this.lblCartaSelecionada.Text = "x";
            // 
            // pnlMadeira
            // 
            this.pnlMadeira.BackColor = System.Drawing.Color.Transparent;
            this.pnlMadeira.BackgroundImage = global::PI3.Properties.Resources.madeiraFundo;
            this.pnlMadeira.Controls.Add(this.label2);
            this.pnlMadeira.Controls.Add(this.label1);
            this.pnlMadeira.Controls.Add(this.lblComunicacao);
            this.pnlMadeira.Controls.Add(this.lblTricornio);
            this.pnlMadeira.Controls.Add(this.lblPistola);
            this.pnlMadeira.Controls.Add(this.lblGarrafa);
            this.pnlMadeira.Controls.Add(this.lblFaca);
            this.pnlMadeira.Controls.Add(this.lblEsqueleto);
            this.pnlMadeira.Controls.Add(this.lblPosicaoSelecionada);
            this.pnlMadeira.Controls.Add(this.lblChave);
            this.pnlMadeira.Controls.Add(this.pnlPistola);
            this.pnlMadeira.Controls.Add(this.pnlGarrafa);
            this.pnlMadeira.Controls.Add(this.pnlFaca);
            this.pnlMadeira.Controls.Add(this.pnlEsqueleto);
            this.pnlMadeira.Controls.Add(this.pnlChave);
            this.pnlMadeira.Controls.Add(this.lblCartaSelecionada);
            this.pnlMadeira.Controls.Add(this.pnlTricornio);
            this.pnlMadeira.Controls.Add(this.btnVoltar);
            this.pnlMadeira.Controls.Add(this.btnJogar);
            this.pnlMadeira.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlMadeira.Location = new System.Drawing.Point(747, 306);
            this.pnlMadeira.Name = "pnlMadeira";
            this.pnlMadeira.Size = new System.Drawing.Size(409, 361);
            this.pnlMadeira.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Carta selecionada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Posição selecionada:";
            // 
            // lblTricornio
            // 
            this.lblTricornio.AutoSize = true;
            this.lblTricornio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTricornio.Location = new System.Drawing.Point(356, 92);
            this.lblTricornio.Name = "lblTricornio";
            this.lblTricornio.Size = new System.Drawing.Size(20, 24);
            this.lblTricornio.TabIndex = 22;
            this.lblTricornio.Text = "0";
            // 
            // lblPistola
            // 
            this.lblPistola.AutoSize = true;
            this.lblPistola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPistola.Location = new System.Drawing.Point(291, 95);
            this.lblPistola.Name = "lblPistola";
            this.lblPistola.Size = new System.Drawing.Size(20, 24);
            this.lblPistola.TabIndex = 21;
            this.lblPistola.Text = "0";
            // 
            // lblGarrafa
            // 
            this.lblGarrafa.AutoSize = true;
            this.lblGarrafa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarrafa.Location = new System.Drawing.Point(231, 95);
            this.lblGarrafa.Name = "lblGarrafa";
            this.lblGarrafa.Size = new System.Drawing.Size(20, 24);
            this.lblGarrafa.TabIndex = 20;
            this.lblGarrafa.Text = "0";
            // 
            // lblFaca
            // 
            this.lblFaca.AutoSize = true;
            this.lblFaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaca.Location = new System.Drawing.Point(171, 95);
            this.lblFaca.Name = "lblFaca";
            this.lblFaca.Size = new System.Drawing.Size(20, 24);
            this.lblFaca.TabIndex = 19;
            this.lblFaca.Text = "0";
            // 
            // lblEsqueleto
            // 
            this.lblEsqueleto.AutoSize = true;
            this.lblEsqueleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsqueleto.Location = new System.Drawing.Point(103, 95);
            this.lblEsqueleto.Name = "lblEsqueleto";
            this.lblEsqueleto.Size = new System.Drawing.Size(20, 24);
            this.lblEsqueleto.TabIndex = 18;
            this.lblEsqueleto.Text = "0";
            // 
            // lblPosicaoSelecionada
            // 
            this.lblPosicaoSelecionada.AutoSize = true;
            this.lblPosicaoSelecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicaoSelecionada.Location = new System.Drawing.Point(219, 212);
            this.lblPosicaoSelecionada.Name = "lblPosicaoSelecionada";
            this.lblPosicaoSelecionada.Size = new System.Drawing.Size(20, 24);
            this.lblPosicaoSelecionada.TabIndex = 17;
            this.lblPosicaoSelecionada.Text = "x";
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChave.Location = new System.Drawing.Point(42, 95);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(20, 24);
            this.lblChave.TabIndex = 16;
            this.lblChave.Text = "0";
            // 
            // pnlPistola
            // 
            this.pnlPistola.BackColor = System.Drawing.Color.Transparent;
            this.pnlPistola.BackgroundImage = global::PI3.Properties.Resources.Pistola;
            this.pnlPistola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPistola.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pnlPistola.Location = new System.Drawing.Point(277, 18);
            this.pnlPistola.Name = "pnlPistola";
            this.pnlPistola.Size = new System.Drawing.Size(57, 71);
            this.pnlPistola.TabIndex = 2;
            this.pnlPistola.Tag = "Pistola";
            this.pnlPistola.Click += new System.EventHandler(this.cardClick);
            // 
            // pnlGarrafa
            // 
            this.pnlGarrafa.BackColor = System.Drawing.Color.Transparent;
            this.pnlGarrafa.BackgroundImage = global::PI3.Properties.Resources.Garrafa;
            this.pnlGarrafa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGarrafa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGarrafa.Location = new System.Drawing.Point(214, 18);
            this.pnlGarrafa.Name = "pnlGarrafa";
            this.pnlGarrafa.Size = new System.Drawing.Size(57, 71);
            this.pnlGarrafa.TabIndex = 2;
            this.pnlGarrafa.Tag = "Garrafa";
            this.pnlGarrafa.Click += new System.EventHandler(this.cardClick);
            // 
            // pnlFaca
            // 
            this.pnlFaca.BackColor = System.Drawing.Color.Transparent;
            this.pnlFaca.BackgroundImage = global::PI3.Properties.Resources.Faca;
            this.pnlFaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlFaca.Location = new System.Drawing.Point(151, 18);
            this.pnlFaca.Name = "pnlFaca";
            this.pnlFaca.Size = new System.Drawing.Size(57, 71);
            this.pnlFaca.TabIndex = 2;
            this.pnlFaca.Tag = "Faca";
            this.pnlFaca.Click += new System.EventHandler(this.cardClick);
            // 
            // pnlEsqueleto
            // 
            this.pnlEsqueleto.BackColor = System.Drawing.Color.Transparent;
            this.pnlEsqueleto.BackgroundImage = global::PI3.Properties.Resources.Esqueleto;
            this.pnlEsqueleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEsqueleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEsqueleto.Location = new System.Drawing.Point(85, 18);
            this.pnlEsqueleto.Name = "pnlEsqueleto";
            this.pnlEsqueleto.Size = new System.Drawing.Size(57, 71);
            this.pnlEsqueleto.TabIndex = 2;
            this.pnlEsqueleto.Tag = "Esqueleto";
            this.pnlEsqueleto.Click += new System.EventHandler(this.cardClick);
            // 
            // pnlChave
            // 
            this.pnlChave.BackColor = System.Drawing.Color.Transparent;
            this.pnlChave.BackgroundImage = global::PI3.Properties.Resources.Chave;
            this.pnlChave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlChave.Location = new System.Drawing.Point(22, 18);
            this.pnlChave.Name = "pnlChave";
            this.pnlChave.Size = new System.Drawing.Size(57, 71);
            this.pnlChave.TabIndex = 2;
            this.pnlChave.Tag = "Chave";
            this.pnlChave.Click += new System.EventHandler(this.cardClick);
            // 
            // pnlTricornio
            // 
            this.pnlTricornio.BackColor = System.Drawing.Color.Transparent;
            this.pnlTricornio.BackgroundImage = global::PI3.Properties.Resources.Tricornio;
            this.pnlTricornio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTricornio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTricornio.Location = new System.Drawing.Point(340, 18);
            this.pnlTricornio.Name = "pnlTricornio";
            this.pnlTricornio.Size = new System.Drawing.Size(57, 71);
            this.pnlTricornio.TabIndex = 1;
            this.pnlTricornio.Tag = "Tricornio";
            this.pnlTricornio.Click += new System.EventHandler(this.cardClick);
            // 
            // TabuleiroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 666);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lstPlayersLobby);
            this.Controls.Add(this.HistoricoGrid);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.pnlMadeira);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(1172, 705);
            this.Name = "TabuleiroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuleiro";
            ((System.ComponentModel.ISupportInitialize)(this.HistoricoGrid)).EndInit();
            this.pnlMadeira.ResumeLayout(false);
            this.pnlMadeira.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.DataGridView HistoricoGrid;
        private System.Windows.Forms.ListBox lstPlayersLobby;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmJogada;
        private System.Windows.Forms.DataGridViewTextBoxColumn simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn posOrigem;
        private System.Windows.Forms.DataGridViewTextBoxColumn posDestino;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label lblComunicacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCartaSelecionada;
        private System.Windows.Forms.Panel pnlMadeira;
        private System.Windows.Forms.Label lblTricornio;
        private System.Windows.Forms.Label lblPistola;
        private System.Windows.Forms.Label lblGarrafa;
        private System.Windows.Forms.Label lblFaca;
        private System.Windows.Forms.Label lblEsqueleto;
        private System.Windows.Forms.Label lblPosicaoSelecionada;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Panel pnlPistola;
        private System.Windows.Forms.Panel pnlGarrafa;
        private System.Windows.Forms.Panel pnlFaca;
        private System.Windows.Forms.Panel pnlEsqueleto;
        private System.Windows.Forms.Panel pnlChave;
        private System.Windows.Forms.Panel pnlTricornio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
