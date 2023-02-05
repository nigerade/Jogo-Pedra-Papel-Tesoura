
namespace RockScissorsPaper
{
    partial class PedraPapelTesoura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedraPapelTesoura));
            this.gbPlacar = new System.Windows.Forms.GroupBox();
            this.lblPlacarM = new System.Windows.Forms.Label();
            this.lblPlacarJ = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            this.gbJog = new System.Windows.Forms.GroupBox();
            this.gbComput = new System.Windows.Forms.GroupBox();
            this.picComputador = new System.Windows.Forms.PictureBox();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPlacar.SuspendLayout();
            this.gbJog.SuspendLayout();
            this.gbComput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlacar
            // 
            this.gbPlacar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbPlacar.Controls.Add(this.lblPlacarM);
            this.gbPlacar.Controls.Add(this.lblPlacarJ);
            this.gbPlacar.Controls.Add(this.lblMaquina);
            this.gbPlacar.Controls.Add(this.lblJogador);
            this.gbPlacar.Location = new System.Drawing.Point(254, 110);
            this.gbPlacar.Name = "gbPlacar";
            this.gbPlacar.Size = new System.Drawing.Size(200, 100);
            this.gbPlacar.TabIndex = 6;
            this.gbPlacar.TabStop = false;
            this.gbPlacar.Text = "Placar";
            // 
            // lblPlacarM
            // 
            this.lblPlacarM.AutoSize = true;
            this.lblPlacarM.Location = new System.Drawing.Point(137, 49);
            this.lblPlacarM.Name = "lblPlacarM";
            this.lblPlacarM.Size = new System.Drawing.Size(13, 13);
            this.lblPlacarM.TabIndex = 3;
            this.lblPlacarM.Text = "0";
            // 
            // lblPlacarJ
            // 
            this.lblPlacarJ.AutoSize = true;
            this.lblPlacarJ.Location = new System.Drawing.Point(40, 49);
            this.lblPlacarJ.Name = "lblPlacarJ";
            this.lblPlacarJ.Size = new System.Drawing.Size(13, 13);
            this.lblPlacarJ.TabIndex = 2;
            this.lblPlacarJ.Text = "0";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquina.Location = new System.Drawing.Point(110, 16);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(64, 20);
            this.lblMaquina.TabIndex = 1;
            this.lblMaquina.Text = "Máquina";
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(20, 16);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(63, 20);
            this.lblJogador.TabIndex = 0;
            this.lblJogador.Text = "Jogador ";
            // 
            // gbJog
            // 
            this.gbJog.Controls.Add(this.PicJogador);
            this.gbJog.Location = new System.Drawing.Point(19, 66);
            this.gbJog.Name = "gbJog";
            this.gbJog.Size = new System.Drawing.Size(200, 176);
            this.gbJog.TabIndex = 7;
            this.gbJog.TabStop = false;
            this.gbJog.Text = "Jogador";
            // 
            // gbComput
            // 
            this.gbComput.Controls.Add(this.picComputador);
            this.gbComput.Location = new System.Drawing.Point(488, 66);
            this.gbComput.Name = "gbComput";
            this.gbComput.Size = new System.Drawing.Size(200, 176);
            this.gbComput.TabIndex = 8;
            this.gbComput.TabStop = false;
            this.gbComput.Text = "Máquina";
            // 
            // picComputador
            // 
            this.picComputador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picComputador.Location = new System.Drawing.Point(27, 19);
            this.picComputador.Name = "picComputador";
            this.picComputador.Size = new System.Drawing.Size(150, 150);
            this.picComputador.TabIndex = 4;
            this.picComputador.TabStop = false;
            // 
            // PicJogador
            // 
            this.PicJogador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicJogador.Location = new System.Drawing.Point(28, 19);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            // 
            // btnPedra
            // 
            this.btnPedra.BackgroundImage = global::RockScissorsPaper.Properties.Resources.PedraJ;
            this.btnPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPedra.Location = new System.Drawing.Point(281, 305);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(150, 150);
            this.btnPedra.TabIndex = 2;
            this.btnPedra.UseVisualStyleBackColor = true;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::RockScissorsPaper.Properties.Resources.PapelJ;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPapel.Location = new System.Drawing.Point(69, 305);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(150, 150);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackgroundImage = global::RockScissorsPaper.Properties.Resources.TesouraJ;
            this.btnTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTesoura.Location = new System.Drawing.Point(488, 305);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(150, 150);
            this.btnTesoura.TabIndex = 0;
            this.btnTesoura.UseVisualStyleBackColor = true;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jogo: Pedra, Papel e Tesoura";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PedraPapelTesoura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbComput);
            this.Controls.Add(this.gbJog);
            this.Controls.Add(this.gbPlacar);
            this.Controls.Add(this.btnPedra);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnTesoura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedraPapelTesoura";
            this.Text = "Pedra, Papel e Tesoura";
            this.gbPlacar.ResumeLayout(false);
            this.gbPlacar.PerformLayout();
            this.gbJog.ResumeLayout(false);
            this.gbJog.PerformLayout();
            this.gbComput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.PictureBox PicJogador;
        private System.Windows.Forms.PictureBox picComputador;
        private System.Windows.Forms.GroupBox gbPlacar;
        private System.Windows.Forms.Label lblPlacarM;
        private System.Windows.Forms.Label lblPlacarJ;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.GroupBox gbJog;
        private System.Windows.Forms.GroupBox gbComput;
        private System.Windows.Forms.Label label1;
    }
}

