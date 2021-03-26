using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace NetServiceMonitor {
  public partial class frmMonitor : Form {
    private int _nVezes = 0;
    private string _comando = "";

    public frmMonitor() {
      InitializeComponent();
    }

    private void frmMonitor_Load(object sender, EventArgs e) {
      txIntervalo.Text = "" + timer1.Interval / 1000;

      // Carrega hosts do arquivo
      try {
        string stArquivo = Application.StartupPath + "\\NSMonitor.hosts";
        if (System.IO.File.Exists(stArquivo)) {
          string[] hosts = System.IO.File.ReadAllText(stArquivo).Split('\n');
          foreach (string host in hosts) {
            if (!String.IsNullOrEmpty(host)) {
              string[] row = new string[] { host, "Ok" };
              dgHosts.Rows.Add(row);
            }
          }
        }
      } catch (Exception ee) {
        Log("Err", "Falha ao obter hosts do arquivo: " + ee.Message);
      }
    }

    /// <summary>
    /// Anota mensagem no arquivo de eventos
    /// </summary>
    /// <param name="tipo"></param>
    /// <param name="msg"></param>
    private void Log(string tipo, string msg) {
      string stArquivo = Application.StartupPath + "\\NSMonitor.log";
      string stMsg = string.Format("{0:dd/MM/yyyy HH:mm}", DateTime.Now) + " - " + tipo + " - " + msg + "\n";
      System.IO.File.AppendAllText(stArquivo, stMsg);
    }

    /// <summary>
    /// Executa comando externo
    /// </summary>
    /// <param name="comando"></param>
    /// <param name="parametros"></param>
    private void Executa(string comando, string parametros) {
      System.Diagnostics.Process proc = new System.Diagnostics.Process();
      proc.EnableRaisingEvents = false;
      proc.StartInfo.FileName = comando;
      proc.StartInfo.Arguments = parametros;
      proc.Start();
    }

    /// <summary>
    /// Envia "ping" e trata resultado
    /// </summary>
    private void Monitorar() {
      Ping p = new Ping();
      PingReply r;
      foreach (DataGridViewRow row in dgHosts.Rows) {
        if (row.Cells[0].Value == null)
          continue;

        string s = row.Cells[0].Value.ToString().Trim().Replace("\n", "");
        try {
          r = p.Send(s);
          if (r.Status == IPStatus.Success) {

            if (row.Cells[1].Value == null || row.Cells[1].Value.ToString() != "Ok") {
              string stMsg = "Conexão com " + s + " restabelecida.";
              if (r.Address != null)
                stMsg += "(" + r.Address.ToString() + ")";
              if (r.Buffer != null)
                stMsg += "(" + r.Buffer.Length + " bytes em " + r.RoundtripTime + " ms)";
              lsLog.Items.Add(stMsg);
              Log("Info", stMsg);
            }
            row.Cells[1].Value = "Ok";
          } else {
            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == "Ok") {
              string stMsg = "Falha ao acessar " + s + " ";
              if (r.Address != null)
                stMsg += "(" + r.Address.ToString() + ")";
              Log("Warn", stMsg);
              row.Cells[1].Value = "Falha";

              // Executa comando externo
              if (!String.IsNullOrEmpty(_comando)) {
                string stComando = _comando;
                string stParametros = "";
                int inPos = stComando.IndexOf(" ");
                if (inPos > -1) {
                  stParametros = stComando.Substring(inPos);
                  stComando = stComando.Substring(0, inPos + 1);
                }
                stParametros = stParametros.Replace("{host}", s);
                try {
                  Executa(stComando, stParametros);
                } catch (Exception ee) {
                  stMsg = "Falha ao executar comando: " + ee.Message;
                  lsLog.Items.Add(stMsg);
                  Log("Err", stMsg);
                }
              }
            }
          }
        } catch (Exception ee) {
          if (row.Cells[1].Value.ToString() == "Ok") {
            string stMsg = "Erro ao acessar " + s + ": " + ee.Message;
            if (ee.InnerException != null && ee.InnerException.Message != null)
              stMsg += "(" + ee.InnerException.Message + ")";
            lsLog.Items.Add(stMsg);
            Log("Err", stMsg);
            row.Cells[1].Value = "Falha";
          }
        }
      }
    }

    private void cmAplicar_Click(object sender, EventArgs e) {
      int intervalo;
      int.TryParse(txIntervalo.Text, out intervalo);
      if (intervalo > 0)
        timer1.Interval = intervalo * 1000;
      if (!String.IsNullOrEmpty(txComando.Text))
        _comando = txComando.Text;
    }

    private void cmAdicionar_Click(object sender, EventArgs e) {
      if (!String.IsNullOrEmpty(txHost.Text)) {
        string[] row = new string[] { txHost.Text, "Ok" };
        dgHosts.Rows.Add(row);
      }
    }

    private void cmRemover_Click(object sender, EventArgs e) {
      DataGridViewRow selecionada = null;
      foreach (DataGridViewRow row in dgHosts.Rows) {
        foreach (DataGridViewCell cell in row.Cells) {
          if (cell.Selected) {
            selecionada = row;
            break;
          }
          if (selecionada != null)
            break;
        }
      }
      if (selecionada != null) {
        try {
          dgHosts.Rows.Remove(selecionada);
        } catch (Exception ee) {
          MessageBox.Show(ee.Message);
        }
      }
    }

    private void timer1_Tick(object sender, EventArgs e) {
      Monitorar();
      _nVezes++;
      lbVezes.Text = "Executado " + _nVezes + " vezes.";
    }

    private void cmIniciar_Click(object sender, EventArgs e) {
      timer1.Start();
      lbStatus.Text = "Executando";
    }

    private void cmParar_Click(object sender, EventArgs e) {
      timer1.Stop();
      lbStatus.Text = "Parado";
    }

    private void frmMonitor_FormClosing(object sender, FormClosingEventArgs e) {

      // Salva hosts
      try {
        string stArquivo = Application.StartupPath + "\\NSMonitor.hosts";
        if (System.IO.File.Exists(stArquivo))
          System.IO.File.Delete(stArquivo);
        foreach (DataGridViewRow row in dgHosts.Rows) {
          if (row.Cells[0] != null && row.Cells[0].Value != null)
            System.IO.File.AppendAllText(stArquivo, row.Cells[0].Value.ToString() + "\n");
        }
      } catch (Exception ee) {
        Log("Err", "Falha ao salvar hosts no arquivo: " + ee.Message);
      }
    }
  }
}
