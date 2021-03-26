
namespace NetServiceMonitor {
  partial class frmMonitor {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitor));
      this.label1 = new System.Windows.Forms.Label();
      this.txHost = new System.Windows.Forms.TextBox();
      this.cmAdicionar = new System.Windows.Forms.Button();
      this.dgHosts = new System.Windows.Forms.DataGridView();
      this.NomeHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cmRemover = new System.Windows.Forms.Button();
      this.cmIniciar = new System.Windows.Forms.Button();
      this.cmParar = new System.Windows.Forms.Button();
      this.lsLog = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txIntervalo = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.lbVezes = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txComando = new System.Windows.Forms.TextBox();
      this.cmAplicar = new System.Windows.Forms.Button();
      this.lbStatus = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.dgHosts)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Host";
      // 
      // txHost
      // 
      this.txHost.Location = new System.Drawing.Point(67, 29);
      this.txHost.Name = "txHost";
      this.txHost.Size = new System.Drawing.Size(494, 20);
      this.txHost.TabIndex = 1;
      // 
      // cmAdicionar
      // 
      this.cmAdicionar.Location = new System.Drawing.Point(567, 28);
      this.cmAdicionar.Name = "cmAdicionar";
      this.cmAdicionar.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
      this.cmAdicionar.Size = new System.Drawing.Size(21, 22);
      this.cmAdicionar.TabIndex = 2;
      this.cmAdicionar.Text = "+";
      this.cmAdicionar.UseVisualStyleBackColor = true;
      this.cmAdicionar.Click += new System.EventHandler(this.cmAdicionar_Click);
      // 
      // dgHosts
      // 
      this.dgHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgHosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeHost,
            this.Status});
      this.dgHosts.Location = new System.Drawing.Point(34, 57);
      this.dgHosts.Name = "dgHosts";
      this.dgHosts.Size = new System.Drawing.Size(527, 214);
      this.dgHosts.TabIndex = 3;
      // 
      // NomeHost
      // 
      this.NomeHost.HeaderText = "Nome";
      this.NomeHost.Name = "NomeHost";
      this.NomeHost.Width = 390;
      // 
      // Status
      // 
      this.Status.HeaderText = "Situação";
      this.Status.Name = "Status";
      this.Status.Width = 65;
      // 
      // cmRemover
      // 
      this.cmRemover.Location = new System.Drawing.Point(567, 56);
      this.cmRemover.Name = "cmRemover";
      this.cmRemover.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
      this.cmRemover.Size = new System.Drawing.Size(21, 22);
      this.cmRemover.TabIndex = 4;
      this.cmRemover.Text = "-";
      this.cmRemover.UseVisualStyleBackColor = true;
      this.cmRemover.Click += new System.EventHandler(this.cmRemover_Click);
      // 
      // cmIniciar
      // 
      this.cmIniciar.Location = new System.Drawing.Point(34, 278);
      this.cmIniciar.Name = "cmIniciar";
      this.cmIniciar.Size = new System.Drawing.Size(75, 23);
      this.cmIniciar.TabIndex = 5;
      this.cmIniciar.Text = "&Iniciar";
      this.cmIniciar.UseVisualStyleBackColor = true;
      this.cmIniciar.Click += new System.EventHandler(this.cmIniciar_Click);
      // 
      // cmParar
      // 
      this.cmParar.Location = new System.Drawing.Point(116, 278);
      this.cmParar.Name = "cmParar";
      this.cmParar.Size = new System.Drawing.Size(75, 23);
      this.cmParar.TabIndex = 6;
      this.cmParar.Text = "&Parar";
      this.cmParar.UseVisualStyleBackColor = true;
      this.cmParar.Click += new System.EventHandler(this.cmParar_Click);
      // 
      // lsLog
      // 
      this.lsLog.FormattingEnabled = true;
      this.lsLog.Location = new System.Drawing.Point(34, 325);
      this.lsLog.Name = "lsLog";
      this.lsLog.Size = new System.Drawing.Size(527, 147);
      this.lsLog.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(34, 308);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(25, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Log";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(34, 479);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Intervalo";
      // 
      // txIntervalo
      // 
      this.txIntervalo.Location = new System.Drawing.Point(88, 476);
      this.txIntervalo.Name = "txIntervalo";
      this.txIntervalo.Size = new System.Drawing.Size(43, 20);
      this.txIntervalo.TabIndex = 10;
      this.txIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(133, 480);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(12, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "s";
      // 
      // lbVezes
      // 
      this.lbVezes.AutoSize = true;
      this.lbVezes.Location = new System.Drawing.Point(439, 479);
      this.lbVezes.Name = "lbVezes";
      this.lbVezes.Size = new System.Drawing.Size(101, 13);
      this.lbVezes.TabIndex = 12;
      this.lbVezes.Text = "Executado 0 vezes.";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(34, 508);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(52, 13);
      this.label5.TabIndex = 13;
      this.label5.Text = "Comando";
      // 
      // txComando
      // 
      this.txComando.Location = new System.Drawing.Point(88, 505);
      this.txComando.Name = "txComando";
      this.txComando.Size = new System.Drawing.Size(390, 20);
      this.txComando.TabIndex = 14;
      // 
      // cmAplicar
      // 
      this.cmAplicar.Location = new System.Drawing.Point(486, 503);
      this.cmAplicar.Name = "cmAplicar";
      this.cmAplicar.Size = new System.Drawing.Size(75, 23);
      this.cmAplicar.TabIndex = 15;
      this.cmAplicar.Text = "&Aplicar";
      this.cmAplicar.UseVisualStyleBackColor = true;
      this.cmAplicar.Click += new System.EventHandler(this.cmAplicar_Click);
      // 
      // lbStatus
      // 
      this.lbStatus.AutoSize = true;
      this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lbStatus.Location = new System.Drawing.Point(457, 532);
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(53, 16);
      this.lbStatus.TabIndex = 16;
      this.lbStatus.Text = "Parado";
      // 
      // timer1
      // 
      this.timer1.Interval = 180000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // frmMonitor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(609, 554);
      this.Controls.Add(this.lbStatus);
      this.Controls.Add(this.cmAplicar);
      this.Controls.Add(this.txComando);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lbVezes);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txIntervalo);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lsLog);
      this.Controls.Add(this.cmParar);
      this.Controls.Add(this.cmIniciar);
      this.Controls.Add(this.cmRemover);
      this.Controls.Add(this.dgHosts);
      this.Controls.Add(this.cmAdicionar);
      this.Controls.Add(this.txHost);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmMonitor";
      this.Text = "Monitoramento de Serviços de Rede";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMonitor_FormClosing);
      this.Load += new System.EventHandler(this.frmMonitor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgHosts)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txHost;
    private System.Windows.Forms.Button cmAdicionar;
    private System.Windows.Forms.DataGridView dgHosts;
    private System.Windows.Forms.DataGridViewTextBoxColumn NomeHost;
    private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    private System.Windows.Forms.Button cmRemover;
    private System.Windows.Forms.Button cmIniciar;
    private System.Windows.Forms.Button cmParar;
    private System.Windows.Forms.ListBox lsLog;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txIntervalo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lbVezes;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txComando;
    private System.Windows.Forms.Button cmAplicar;
    private System.Windows.Forms.Label lbStatus;
    private System.Windows.Forms.Timer timer1;
  }
}

