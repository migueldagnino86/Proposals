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
            cmbAmbiente = new ComboBox();
            lblUrl = new Label();
            txtUrl = new TextBox();
            chkPuP = new CheckBox();
            chkTono = new CheckBox();
            tbCtrlRequest = new TabControl();
            tbPageLista = new TabPage();
            tbPageSql = new TabPage();
            dgvResultado = new DataGridView();
            tbCtrlRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // lblAmbiente
            // 
            lblAmbiente.AutoSize = true;
            lblAmbiente.Location = new Point(12, 34);
            lblAmbiente.Name = "lblAmbiente";
            lblAmbiente.Size = new Size(59, 15);
            lblAmbiente.TabIndex = 0;
            lblAmbiente.Text = "Ambiente";
            lblAmbiente.Click += label1_Click;
            // 
            // cmbAmbiente
            // 
            cmbAmbiente.FormattingEnabled = true;
            cmbAmbiente.Items.AddRange(new object[] { "QAS", "PRD" });
            cmbAmbiente.Location = new Point(77, 29);
            cmbAmbiente.Name = "cmbAmbiente";
            cmbAmbiente.Size = new Size(121, 23);
            cmbAmbiente.TabIndex = 1;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(233, 34);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(28, 15);
            lblUrl.TabIndex = 2;
            lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(267, 29);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(510, 23);
            txtUrl.TabIndex = 3;
            // 
            // chkPuP
            // 
            chkPuP.AutoSize = true;
            chkPuP.Location = new Point(267, 77);
            chkPuP.Name = "chkPuP";
            chkPuP.Size = new Size(48, 19);
            chkPuP.TabIndex = 4;
            chkPuP.Text = "PUP";
            chkPuP.UseVisualStyleBackColor = true;
            // 
            // chkTono
            // 
            chkTono.AutoSize = true;
            chkTono.Location = new Point(321, 77);
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
            tbCtrlRequest.Location = new Point(12, 102);
            tbCtrlRequest.Multiline = true;
            tbCtrlRequest.Name = "tbCtrlRequest";
            tbCtrlRequest.SelectedIndex = 0;
            tbCtrlRequest.Size = new Size(765, 153);
            tbCtrlRequest.TabIndex = 6;
            // 
            // tbPageLista
            // 
            tbPageLista.BorderStyle = BorderStyle.Fixed3D;
            tbPageLista.ImeMode = ImeMode.Hiragana;
            tbPageLista.Location = new Point(4, 24);
            tbPageLista.Name = "tbPageLista";
            tbPageLista.Padding = new Padding(3);
            tbPageLista.Size = new Size(757, 125);
            tbPageLista.TabIndex = 0;
            tbPageLista.Text = "Lista";
            tbPageLista.UseVisualStyleBackColor = true;
            tbPageLista.Click += tbPageLista_Click;
            // 
            // tbPageSql
            // 
            tbPageSql.BorderStyle = BorderStyle.Fixed3D;
            tbPageSql.ImeMode = ImeMode.Hiragana;
            tbPageSql.Location = new Point(4, 24);
            tbPageSql.Name = "tbPageSql";
            tbPageSql.Padding = new Padding(3);
            tbPageSql.Size = new Size(757, 125);
            tbPageSql.TabIndex = 1;
            tbPageSql.Text = "SQL";
            tbPageSql.UseVisualStyleBackColor = true;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(12, 272);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowTemplate.Height = 25;
            dgvResultado.Size = new Size(757, 274);
            dgvResultado.TabIndex = 7;
            // 
            // frmTestForecast
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 584);
            Controls.Add(dgvResultado);
            Controls.Add(tbCtrlRequest);
            Controls.Add(chkTono);
            Controls.Add(chkPuP);
            Controls.Add(txtUrl);
            Controls.Add(lblUrl);
            Controls.Add(cmbAmbiente);
            Controls.Add(lblAmbiente);
            Name = "frmTestForecast";
            Text = "Test Forecast";
            Load += frmTestForecast_Load;
            tbCtrlRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmbiente;
        private ComboBox cmbAmbiente;
        private Label lblUrl;
        private TextBox txtUrl;
        private CheckBox chkPuP;
        private CheckBox chkTono;
        private TabControl tbCtrlRequest;
        private TabPage tbPageLista;
        private TabPage tbPageSql;
        private DataGridView dgvResultado;
    }
}