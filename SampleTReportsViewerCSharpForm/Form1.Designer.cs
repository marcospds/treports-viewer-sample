namespace SampleTReportsViewerCSharpForm
{
  partial class Form1
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
      this.components = new System.ComponentModel.Container();
      this.buttonGerar = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.textUid = new System.Windows.Forms.TextBox();
      this.textTenant = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textUser = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textPassword = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textClientSecret = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textScope = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textClientId = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.textRacUrl = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.textUrlTReports = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.textFrontendPort = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.textBackendPort = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // buttonGerar
      // 
      this.buttonGerar.Location = new System.Drawing.Point(930, 12);
      this.buttonGerar.Name = "buttonGerar";
      this.buttonGerar.Size = new System.Drawing.Size(66, 72);
      this.buttonGerar.TabIndex = 11;
      this.buttonGerar.Text = "Gerar";
      this.buttonGerar.UseVisualStyleBackColor = true;
      this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Location = new System.Drawing.Point(12, 90);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(984, 627);
      this.panel1.TabIndex = 12;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "UId do Relatório:";
      // 
      // textUid
      // 
      this.textUid.Location = new System.Drawing.Point(112, 38);
      this.textUid.Name = "textUid";
      this.textUid.Size = new System.Drawing.Size(227, 20);
      this.textUid.TabIndex = 4;
      this.textUid.Text = "b1312eea-92c6-4035-ad2c-4658f9ea5569";
      // 
      // textTenant
      // 
      this.textTenant.Location = new System.Drawing.Point(423, 38);
      this.textTenant.Name = "textTenant";
      this.textTenant.Size = new System.Drawing.Size(115, 20);
      this.textTenant.TabIndex = 5;
      this.textTenant.Text = "treports";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(345, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Tenant:";
      // 
      // textUser
      // 
      this.textUser.Location = new System.Drawing.Point(612, 38);
      this.textUser.Name = "textUser";
      this.textUser.Size = new System.Drawing.Size(115, 20);
      this.textUser.TabIndex = 6;
      this.textUser.Text = "teste";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(544, 41);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Usuário:";
      // 
      // textPassword
      // 
      this.textPassword.Location = new System.Drawing.Point(809, 38);
      this.textPassword.Name = "textPassword";
      this.textPassword.Size = new System.Drawing.Size(115, 20);
      this.textPassword.TabIndex = 7;
      this.textPassword.Text = "teste@123";
      this.textPassword.UseSystemPasswordChar = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(733, 41);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Senha:";
      // 
      // textClientSecret
      // 
      this.textClientSecret.Location = new System.Drawing.Point(809, 12);
      this.textClientSecret.Name = "textClientSecret";
      this.textClientSecret.Size = new System.Drawing.Size(115, 20);
      this.textClientSecret.TabIndex = 3;
      this.textClientSecret.Text = "totvs@123";
      this.textClientSecret.UseSystemPasswordChar = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(733, 15);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(70, 13);
      this.label5.TabIndex = 14;
      this.label5.Text = "Client Secret:";
      // 
      // textScope
      // 
      this.textScope.Location = new System.Drawing.Point(423, 12);
      this.textScope.Name = "textScope";
      this.textScope.Size = new System.Drawing.Size(115, 20);
      this.textScope.TabIndex = 1;
      this.textScope.Text = "openid";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(345, 15);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(46, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Escopo:";
      // 
      // textClientId
      // 
      this.textClientId.Location = new System.Drawing.Point(612, 12);
      this.textClientId.Name = "textClientId";
      this.textClientId.Size = new System.Drawing.Size(115, 20);
      this.textClientId.TabIndex = 2;
      this.textClientId.Text = "rac_ro";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(544, 15);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(48, 13);
      this.label7.TabIndex = 10;
      this.label7.Text = "Client Id:";
      // 
      // textRacUrl
      // 
      this.textRacUrl.Location = new System.Drawing.Point(112, 12);
      this.textRacUrl.Name = "textRacUrl";
      this.textRacUrl.Size = new System.Drawing.Size(227, 20);
      this.textRacUrl.TabIndex = 0;
      this.textRacUrl.Text = "http://treports.rac.totvs.com.br/totvs.rac";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(12, 15);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(61, 13);
      this.label8.TabIndex = 16;
      this.label8.Text = "Url do Rac:";
      // 
      // textUrlTReports
      // 
      this.textUrlTReports.Location = new System.Drawing.Point(423, 64);
      this.textUrlTReports.Name = "textUrlTReports";
      this.textUrlTReports.Size = new System.Drawing.Size(115, 20);
      this.textUrlTReports.TabIndex = 8;
      this.textUrlTReports.Text = "http://localhost";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(345, 67);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(70, 13);
      this.label9.TabIndex = 18;
      this.label9.Text = "Url TReports:";
      // 
      // textFrontendPort
      // 
      this.textFrontendPort.Location = new System.Drawing.Point(612, 64);
      this.textFrontendPort.Name = "textFrontendPort";
      this.textFrontendPort.Size = new System.Drawing.Size(115, 20);
      this.textFrontendPort.TabIndex = 9;
      this.textFrontendPort.Text = "7017";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(544, 67);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(62, 13);
      this.label10.TabIndex = 20;
      this.label10.Text = "Porta Front:";
      // 
      // textBackendPort
      // 
      this.textBackendPort.Location = new System.Drawing.Point(809, 64);
      this.textBackendPort.Name = "textBackendPort";
      this.textBackendPort.Size = new System.Drawing.Size(115, 20);
      this.textBackendPort.TabIndex = 10;
      this.textBackendPort.Text = "4999";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(733, 67);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(63, 13);
      this.label11.TabIndex = 22;
      this.label11.Text = "Porta Back:";
      // 
      // timer1
      // 
      this.timer1.Interval = 300000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.textBackendPort);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.textFrontendPort);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.textUrlTReports);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.textRacUrl);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.textClientSecret);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textScope);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textClientId);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.textPassword);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textUser);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textTenant);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textUid);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.buttonGerar);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "TReports - Visualizador de Relatórios ";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonGerar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textUid;
    private System.Windows.Forms.TextBox textTenant;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textUser;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textPassword;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textClientSecret;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textScope;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textClientId;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textRacUrl;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textUrlTReports;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox textFrontendPort;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox textBackendPort;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Timer timer1;
  }
}

