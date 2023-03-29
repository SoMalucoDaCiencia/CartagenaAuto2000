namespace PI3
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
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.lblListarPartidas = new System.Windows.Forms.Label();
            this.lstListaDePartidas = new System.Windows.Forms.ListBox();
            this.btnPartidaSelecionada = new System.Windows.Forms.Button();
            this.lblPartidaSelecionada = new System.Windows.Forms.Label();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblCriarPartida = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblEntrarPartida = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lstListaDeJogadores = new System.Windows.Forms.ListBox();
            this.btnTabuleiro = new System.Windows.Forms.Button();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.txtCriarSenha = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblNomeP = new System.Windows.Forms.Label();
            this.lblSenhaP = new System.Windows.Forms.Label();
            this.lstDadosPartidaEntrada = new System.Windows.Forms.ListBox();
            this.lblDadosPartida = new System.Windows.Forms.Label();
            this.lblIniciarPatida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTabuleiro = new System.Windows.Forms.ListBox();
            this.lstExibirMao = new System.Windows.Forms.ListBox();
            this.btnJogarFrente = new System.Windows.Forms.Button();
            this.btnJogarTras = new System.Windows.Forms.Button();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.lblDadosJogador = new System.Windows.Forms.Label();
            this.btnListarJogadores = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.lstHistorico = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.BackColor = System.Drawing.Color.Pink;
            this.btnListarPartidas.Location = new System.Drawing.Point(233, 40);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(148, 23);
            this.btnListarPartidas.TabIndex = 0;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = false;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // lblListarPartidas
            // 
            this.lblListarPartidas.AutoSize = true;
            this.lblListarPartidas.Location = new System.Drawing.Point(381, 359);
            this.lblListarPartidas.Name = "lblListarPartidas";
            this.lblListarPartidas.Size = new System.Drawing.Size(0, 13);
            this.lblListarPartidas.TabIndex = 1;
            // 
            // lstListaDePartidas
            // 
            this.lstListaDePartidas.FormattingEnabled = true;
            this.lstListaDePartidas.Location = new System.Drawing.Point(222, 76);
            this.lstListaDePartidas.Name = "lstListaDePartidas";
            this.lstListaDePartidas.Size = new System.Drawing.Size(169, 459);
            this.lstListaDePartidas.TabIndex = 2;
            // 
            // btnPartidaSelecionada
            // 
            this.btnPartidaSelecionada.BackColor = System.Drawing.Color.Pink;
            this.btnPartidaSelecionada.Location = new System.Drawing.Point(442, 40);
            this.btnPartidaSelecionada.Name = "btnPartidaSelecionada";
            this.btnPartidaSelecionada.Size = new System.Drawing.Size(148, 23);
            this.btnPartidaSelecionada.TabIndex = 3;
            this.btnPartidaSelecionada.Text = "Partida Selecionada";
            this.btnPartidaSelecionada.UseVisualStyleBackColor = false;
            this.btnPartidaSelecionada.Click += new System.EventHandler(this.btnPartidaSelecionada_Click);
            // 
            // lblPartidaSelecionada
            // 
            this.lblPartidaSelecionada.AutoSize = true;
            this.lblPartidaSelecionada.Location = new System.Drawing.Point(461, 78);
            this.lblPartidaSelecionada.Name = "lblPartidaSelecionada";
            this.lblPartidaSelecionada.Size = new System.Drawing.Size(102, 13);
            this.lblPartidaSelecionada.TabIndex = 4;
            this.lblPartidaSelecionada.Text = "Partida Selecionada";
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Pink;
            this.btnCriarPartida.Location = new System.Drawing.Point(38, 39);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(148, 23);
            this.btnCriarPartida.TabIndex = 5;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblCriarPartida
            // 
            this.lblCriarPartida.AutoSize = true;
            this.lblCriarPartida.Location = new System.Drawing.Point(69, 202);
            this.lblCriarPartida.Name = "lblCriarPartida";
            this.lblCriarPartida.Size = new System.Drawing.Size(73, 13);
            this.lblCriarPartida.TabIndex = 6;
            this.lblCriarPartida.Text = "Partida Criada";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(457, 175);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(118, 20);
            this.txtNomeJogador.TabIndex = 7;
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(457, 230);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(120, 20);
            this.txtSenhaPartida.TabIndex = 8;
            // 
            // lblEntrarPartida
            // 
            this.lblEntrarPartida.AutoSize = true;
            this.lblEntrarPartida.Location = new System.Drawing.Point(454, 117);
            this.lblEntrarPartida.Name = "lblEntrarPartida";
            this.lblEntrarPartida.Size = new System.Drawing.Size(0, 13);
            this.lblEntrarPartida.TabIndex = 9;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(470, 214);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha da Partida:";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(470, 159);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(94, 13);
            this.lblJogador.TabIndex = 11;
            this.lblJogador.Text = "Nome de Jogador:";
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Pink;
            this.btnEntrarPartida.Location = new System.Drawing.Point(442, 117);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(148, 23);
            this.btnEntrarPartida.TabIndex = 12;
            this.btnEntrarPartida.Text = "Entrar Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lstListaDeJogadores
            // 
            this.lstListaDeJogadores.FormattingEnabled = true;
            this.lstListaDeJogadores.Location = new System.Drawing.Point(457, 434);
            this.lstListaDeJogadores.Name = "lstListaDeJogadores";
            this.lstListaDeJogadores.Size = new System.Drawing.Size(120, 95);
            this.lstListaDeJogadores.TabIndex = 14;
            // 
            // btnTabuleiro
            // 
            this.btnTabuleiro.BackColor = System.Drawing.Color.Pink;
            this.btnTabuleiro.Location = new System.Drawing.Point(680, 97);
            this.btnTabuleiro.Name = "btnTabuleiro";
            this.btnTabuleiro.Size = new System.Drawing.Size(75, 23);
            this.btnTabuleiro.TabIndex = 15;
            this.btnTabuleiro.Text = "Tabuleiro";
            this.btnTabuleiro.UseVisualStyleBackColor = false;
            this.btnTabuleiro.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Pink;
            this.btnIniciarPartida.Location = new System.Drawing.Point(657, 39);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(118, 23);
            this.btnIniciarPartida.TabIndex = 16;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.BackColor = System.Drawing.Color.Pink;
            this.btnExibirMao.Location = new System.Drawing.Point(900, 39);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(75, 23);
            this.btnExibirMao.TabIndex = 17;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = false;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click);
            // 
            // txtCriarSenha
            // 
            this.txtCriarSenha.Location = new System.Drawing.Point(58, 153);
            this.txtCriarSenha.Name = "txtCriarSenha";
            this.txtCriarSenha.Size = new System.Drawing.Size(114, 20);
            this.txtCriarSenha.TabIndex = 18;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(58, 98);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(114, 20);
            this.txtNomePartida.TabIndex = 19;
            // 
            // lblNomeP
            // 
            this.lblNomeP.AutoSize = true;
            this.lblNomeP.Location = new System.Drawing.Point(69, 81);
            this.lblNomeP.Name = "lblNomeP";
            this.lblNomeP.Size = new System.Drawing.Size(89, 13);
            this.lblNomeP.TabIndex = 20;
            this.lblNomeP.Text = "Nome da Partida:";
            // 
            // lblSenhaP
            // 
            this.lblSenhaP.AutoSize = true;
            this.lblSenhaP.Location = new System.Drawing.Point(66, 138);
            this.lblSenhaP.Name = "lblSenhaP";
            this.lblSenhaP.Size = new System.Drawing.Size(92, 13);
            this.lblSenhaP.TabIndex = 21;
            this.lblSenhaP.Text = "Senha da Partida:";
            // 
            // lstDadosPartidaEntrada
            // 
            this.lstDadosPartidaEntrada.AccessibleName = "";
            this.lstDadosPartidaEntrada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstDadosPartidaEntrada.FormattingEnabled = true;
            this.lstDadosPartidaEntrada.Location = new System.Drawing.Point(455, 279);
            this.lstDadosPartidaEntrada.Name = "lstDadosPartidaEntrada";
            this.lstDadosPartidaEntrada.Size = new System.Drawing.Size(120, 95);
            this.lstDadosPartidaEntrada.TabIndex = 22;
            // 
            // lblDadosPartida
            // 
            this.lblDadosPartida.AutoSize = true;
            this.lblDadosPartida.Location = new System.Drawing.Point(493, 214);
            this.lblDadosPartida.Name = "lblDadosPartida";
            this.lblDadosPartida.Size = new System.Drawing.Size(0, 13);
            this.lblDadosPartida.TabIndex = 23;
            // 
            // lblIniciarPatida
            // 
            this.lblIniciarPatida.AutoSize = true;
            this.lblIniciarPatida.Location = new System.Drawing.Point(677, 81);
            this.lblIniciarPatida.Name = "lblIniciarPatida";
            this.lblIniciarPatida.Size = new System.Drawing.Size(0, 13);
            this.lblIniciarPatida.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 25;
            // 
            // lstTabuleiro
            // 
            this.lstTabuleiro.FormattingEnabled = true;
            this.lstTabuleiro.Location = new System.Drawing.Point(637, 126);
            this.lstTabuleiro.Name = "lstTabuleiro";
            this.lstTabuleiro.Size = new System.Drawing.Size(169, 407);
            this.lstTabuleiro.TabIndex = 26;
            // 
            // lstExibirMao
            // 
            this.lstExibirMao.FormattingEnabled = true;
            this.lstExibirMao.Location = new System.Drawing.Point(856, 76);
            this.lstExibirMao.Name = "lstExibirMao";
            this.lstExibirMao.Size = new System.Drawing.Size(169, 160);
            this.lstExibirMao.TabIndex = 27;
            // 
            // btnJogarFrente
            // 
            this.btnJogarFrente.BackColor = System.Drawing.Color.Pink;
            this.btnJogarFrente.Location = new System.Drawing.Point(873, 261);
            this.btnJogarFrente.Name = "btnJogarFrente";
            this.btnJogarFrente.Size = new System.Drawing.Size(125, 23);
            this.btnJogarFrente.TabIndex = 28;
            this.btnJogarFrente.Text = "Jogar Para Frente";
            this.btnJogarFrente.UseVisualStyleBackColor = false;
            this.btnJogarFrente.Click += new System.EventHandler(this.btnJogarFrente_Click);
            // 
            // btnJogarTras
            // 
            this.btnJogarTras.BackColor = System.Drawing.Color.Pink;
            this.btnJogarTras.Location = new System.Drawing.Point(873, 290);
            this.btnJogarTras.Name = "btnJogarTras";
            this.btnJogarTras.Size = new System.Drawing.Size(125, 23);
            this.btnJogarTras.TabIndex = 29;
            this.btnJogarTras.Text = "Jogar Para Trás";
            this.btnJogarTras.UseVisualStyleBackColor = false;
            this.btnJogarTras.Click += new System.EventHandler(this.btnJogarTras_Click);
            // 
            // btnPularVez
            // 
            this.btnPularVez.BackColor = System.Drawing.Color.Pink;
            this.btnPularVez.Location = new System.Drawing.Point(873, 319);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(125, 23);
            this.btnPularVez.TabIndex = 30;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = false;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // lblDadosJogador
            // 
            this.lblDadosJogador.AutoSize = true;
            this.lblDadosJogador.Location = new System.Drawing.Point(44, 359);
            this.lblDadosJogador.Name = "lblDadosJogador";
            this.lblDadosJogador.Size = new System.Drawing.Size(0, 13);
            this.lblDadosJogador.TabIndex = 31;
            // 
            // btnListarJogadores
            // 
            this.btnListarJogadores.BackColor = System.Drawing.Color.Pink;
            this.btnListarJogadores.Location = new System.Drawing.Point(442, 395);
            this.btnListarJogadores.Name = "btnListarJogadores";
            this.btnListarJogadores.Size = new System.Drawing.Size(148, 23);
            this.btnListarJogadores.TabIndex = 32;
            this.btnListarJogadores.Text = "Listar Jogadores";
            this.btnListarJogadores.UseVisualStyleBackColor = false;
            this.btnListarJogadores.Click += new System.EventHandler(this.btnListarJogadores_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Pink;
            this.btnHistorico.Location = new System.Drawing.Point(873, 349);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(125, 23);
            this.btnHistorico.TabIndex = 33;
            this.btnHistorico.Text = "Exibir Historico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // lstHistorico
            // 
            this.lstHistorico.FormattingEnabled = true;
            this.lstHistorico.Location = new System.Drawing.Point(856, 378);
            this.lstHistorico.Name = "lstHistorico";
            this.lstHistorico.Size = new System.Drawing.Size(169, 160);
            this.lstHistorico.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1130, 603);
            this.Controls.Add(this.lstHistorico);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnListarJogadores);
            this.Controls.Add(this.lblDadosJogador);
            this.Controls.Add(this.btnPularVez);
            this.Controls.Add(this.btnJogarTras);
            this.Controls.Add(this.btnJogarFrente);
            this.Controls.Add(this.lstExibirMao);
            this.Controls.Add(this.lstTabuleiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIniciarPatida);
            this.Controls.Add(this.lblDadosPartida);
            this.Controls.Add(this.lstDadosPartidaEntrada);
            this.Controls.Add(this.lblSenhaP);
            this.Controls.Add(this.lblNomeP);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.txtCriarSenha);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.btnTabuleiro);
            this.Controls.Add(this.lstListaDeJogadores);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEntrarPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblCriarPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.lblPartidaSelecionada);
            this.Controls.Add(this.btnPartidaSelecionada);
            this.Controls.Add(this.lstListaDePartidas);
            this.Controls.Add(this.lblListarPartidas);
            this.Controls.Add(this.btnListarPartidas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(1146, 642);
            this.Name = "Form1";
            this.Text = "Catagena2000 PI3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Label lblListarPartidas;
        private System.Windows.Forms.ListBox lstListaDePartidas;
        private System.Windows.Forms.Button btnPartidaSelecionada;
        private System.Windows.Forms.Label lblPartidaSelecionada;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblCriarPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblEntrarPartida;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.ListBox lstListaDeJogadores;
        private System.Windows.Forms.Button btnTabuleiro;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Button btnExibirMao;
        private System.Windows.Forms.TextBox txtCriarSenha;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblNomeP;
        private System.Windows.Forms.Label lblSenhaP;
        private System.Windows.Forms.ListBox lstDadosPartidaEntrada;
        private System.Windows.Forms.Label lblDadosPartida;
        private System.Windows.Forms.Label lblIniciarPatida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTabuleiro;
        private System.Windows.Forms.ListBox lstExibirMao;
        private System.Windows.Forms.Button btnJogarFrente;
        private System.Windows.Forms.Button btnJogarTras;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.Label lblDadosJogador;
        private System.Windows.Forms.Button btnListarJogadores;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.ListBox lstHistorico;
    }
}

