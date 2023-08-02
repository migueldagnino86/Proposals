namespace TestForecastUI
{
    partial class frmTestForecast
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
            lblAmbiente = new Label();
            cmbAmbientePlanit = new ComboBox();
            lblUrl = new Label();
            txtUrl = new TextBox();
            chkPuP = new CheckBox();
            chkTono = new CheckBox();
            tbCtrlRequest = new TabControl();
            tbPageLista = new TabPage();
            rchTxTLista = new RichTextBox();
            tbPageSql = new TabPage();
            dgvResultado = new DataGridView();
            cmbAmbienteForecast = new ComboBox();
            label1 = new Label();
            rchTxTSql = new RichTextBox();
            tbCtrlRequest.SuspendLayout();
            tbPageLista.SuspendLayout();
            tbPageSql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // lblAmbiente
            // 
            lblAmbiente.AutoSize = true;
            lblAmbiente.Location = new Point(26, 37);
            lblAmbiente.Name = "lblAmbiente";
            lblAmbiente.Size = new Size(92, 15);
            lblAmbiente.TabIndex = 0;
            lblAmbiente.Text = "Ambiente Planit";
            // 
            // cmbAmbientePlanit
            // 
            cmbAmbientePlanit.FormattingEnabled = true;
            cmbAmbientePlanit.Items.AddRange(new object[] { "QAS", "PRD", "DEV" });
            cmbAmbientePlanit.Location = new Point(134, 34);
            cmbAmbientePlanit.Name = "cmbAmbientePlanit";
            cmbAmbientePlanit.Size = new Size(79, 23);
            cmbAmbientePlanit.TabIndex = 1;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(226, 82);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(28, 15);
            lblUrl.TabIndex = 2;
            lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(260, 79);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(669, 23);
            txtUrl.TabIndex = 3;
            // 
            // chkPuP
            // 
            chkPuP.AutoSize = true;
            chkPuP.Location = new Point(260, 108);
            chkPuP.Name = "chkPuP";
            chkPuP.Size = new Size(48, 19);
            chkPuP.TabIndex = 4;
            chkPuP.Text = "PUP";
            chkPuP.UseVisualStyleBackColor = true;
            // 
            // chkTono
            // 
            chkTono.AutoSize = true;
            chkTono.Location = new Point(314, 108);
            chkTono.Name = "chkTono";
            chkTono.Size = new Size(65, 19);
            chkTono.TabIndex = 5;
            chkTono.Text = "% Tono";
            chkTono.UseVisualStyleBackColor = true;
            // 
            // tbCtrlRequest
            // 
            tbCtrlRequest.Controls.Add(tbPageLista);
            tbCtrlRequest.Controls.Add(tbPageSql);
            tbCtrlRequest.ImeMode = ImeMode.On;
            tbCtrlRequest.Location = new Point(8, 147);
            tbCtrlRequest.Multiline = true;
            tbCtrlRequest.Name = "tbCtrlRequest";
            tbCtrlRequest.SelectedIndex = 0;
            tbCtrlRequest.Size = new Size(921, 153);
            tbCtrlRequest.TabIndex = 6;
            // 
            // tbPageLista
            // 
            tbPageLista.BorderStyle = BorderStyle.Fixed3D;
            tbPageLista.Controls.Add(rchTxTLista);
            tbPageLista.ImeMode = ImeMode.Hiragana;
            tbPageLista.Location = new Point(4, 24);
            tbPageLista.Name = "tbPageLista";
            tbPageLista.Padding = new Padding(3);
            tbPageLista.Size = new Size(913, 125);
            tbPageLista.TabIndex = 0;
            tbPageLista.Text = "Lista";
            tbPageLista.UseVisualStyleBackColor = true;
            // 
            // rchTxTLista
            // 
            rchTxTLista.Location = new Point(-2, -2);
            rchTxTLista.Name = "rchTxTLista";
            rchTxTLista.Size = new Size(913, 125);
            rchTxTLista.TabIndex = 0;
            rchTxTLista.Text = "";
            // 
            // tbPageSql
            // 
            tbPageSql.BorderStyle = BorderStyle.Fixed3D;
            tbPageSql.Controls.Add(rchTxTSql);
            tbPageSql.ImeMode = ImeMode.Hiragana;
            tbPageSql.Location = new Point(4, 24);
            tbPageSql.Name = "tbPageSql";
            tbPageSql.Padding = new Padding(3);
            tbPageSql.Size = new Size(913, 125);
            tbPageSql.TabIndex = 1;
            tbPageSql.Text = "SQL";
            tbPageSql.UseVisualStyleBackColor = true;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(12, 306);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowHeadersWidth = 51;
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(913, 274);
            dgvResultado.TabIndex = 7;
            // 
            // cmbAmbienteForecast
            // 
            cmbAmbienteForecast.FormattingEnabled = true;
            cmbAmbienteForecast.Items.AddRange(new object[] { "QAS", "PRD" });
            cmbAmbienteForecast.Location = new Point(134, 78);
            cmbAmbienteForecast.Name = "cmbAmbienteForecast";
            cmbAmbienteForecast.Size = new Size(79, 23);
            cmbAmbienteForecast.TabIndex = 9;
            cmbAmbienteForecast.SelectedIndexChanged += cmbAmbienteForecast_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 8;
            label1.Text = "Ambiente Forecast";
            // 
            // rchTxTSql
            // 
            rchTxTSql.Location = new Point(-2, -2);
            rchTxTSql.Name = "rchTxTSql";
            rchTxTSql.Size = new Size(913, 129);
            rchTxTSql.TabIndex = 0;
            rchTxTSql.Text = "";
            // 
            // frmTestForecast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 601);
            Controls.Add(cmbAmbienteForecast);
            Controls.Add(label1);
            Controls.Add(dgvResultado);
            Controls.Add(tbCtrlRequest);
            Controls.Add(chkTono);
            Controls.Add(chkPuP);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(cmbAmbientePlanit);
            Controls.Add(lblAmbiente);
            Name = "frmTestForecast";
            Text = "Test Forecast";
            Load += frmTestForecast_Load;
            tbCtrlRequest.ResumeLayout(false);
            tbPageLista.ResumeLayout(false);
            tbPageSql.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmbiente;
        private ComboBox cmbAmbientePlanit;
        private Label lblUrl;
        private TextBox txtUrl;
        private CheckBox chkPuP;
        private CheckBox chkTono;
        private TabControl tbCtrlRequest;
        private TabPage tbPageLista;
        private TabPage tbPageSql;
        private DataGridView dgvResultado;
        private ComboBox cmbAmbienteForecast;
        private Label label1;
        private RichTextBox rchTxTLista;
        private RichTextBox rchTxTSql;
    }
}