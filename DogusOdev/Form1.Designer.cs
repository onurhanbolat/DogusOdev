namespace DogusOdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlBottom = new Panel();
            pnlMain = new Panel();
            grpAmount = new GroupBox();
            txtAmount = new TextBox();
            grpPaymentType = new GroupBox();
            cmbPaymentType = new ComboBox();
            btnSave = new Button();
            grpResult = new GroupBox();
            lblResult = new Label();
            pnlMain.SuspendLayout();
            grpAmount.SuspendLayout();
            grpPaymentType.SuspendLayout();
            grpResult.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.White;
            pnlBottom.Location = new Point(0, 347);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(660, 30);
            pnlBottom.TabIndex = 5;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.None;
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(grpAmount);
            pnlMain.Controls.Add(grpPaymentType);
            pnlMain.Controls.Add(btnSave);
            pnlMain.Controls.Add(grpResult);
            pnlMain.Location = new Point(203, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(267, 348);
            pnlMain.TabIndex = 6;
            // 
            // grpAmount
            // 
            grpAmount.Anchor = AnchorStyles.None;
            grpAmount.Controls.Add(txtAmount);
            grpAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpAmount.ForeColor = Color.FromArgb(64, 64, 64);
            grpAmount.Location = new Point(16, 105);
            grpAmount.Name = "grpAmount";
            grpAmount.Size = new Size(236, 46);
            grpAmount.TabIndex = 7;
            grpAmount.TabStop = false;
            grpAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.None;
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAmount.Location = new Point(9, 22);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(221, 16);
            txtAmount.TabIndex = 3;
            // 
            // grpPaymentType
            // 
            grpPaymentType.Anchor = AnchorStyles.None;
            grpPaymentType.Controls.Add(cmbPaymentType);
            grpPaymentType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpPaymentType.ForeColor = Color.FromArgb(64, 64, 64);
            grpPaymentType.Location = new Point(16, 53);
            grpPaymentType.Name = "grpPaymentType";
            grpPaymentType.Size = new Size(236, 46);
            grpPaymentType.TabIndex = 6;
            grpPaymentType.TabStop = false;
            grpPaymentType.Text = "Payment Type";
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.Anchor = AnchorStyles.None;
            cmbPaymentType.BackColor = Color.White;
            cmbPaymentType.FlatStyle = FlatStyle.Flat;
            cmbPaymentType.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Seçiniz", "Cash", "CreditCard", "MailOrder", "Bitcoin" });
            cmbPaymentType.Location = new Point(8, 17);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(222, 23);
            cmbPaymentType.TabIndex = 1;
            cmbPaymentType.SelectedIndexChanged += cmbPaymentType_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(255, 204, 0);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(255, 227, 115);
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.Location = new Point(96, 187);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 70);
            btnSave.TabIndex = 6;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // grpResult
            // 
            grpResult.Anchor = AnchorStyles.None;
            grpResult.Controls.Add(lblResult);
            grpResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpResult.ForeColor = Color.FromArgb(64, 64, 64);
            grpResult.Location = new Point(16, 288);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(236, 46);
            grpResult.TabIndex = 5;
            grpResult.TabStop = false;
            grpResult.Text = "Result";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.ForeColor = SystemColors.ControlDarkDark;
            lblResult.Location = new Point(8, 21);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(56, 15);
            lblResult.TabIndex = 0;
            lblResult.Text = "Waiting..";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 377);
            Controls.Add(pnlMain);
            Controls.Add(pnlBottom);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            pnlMain.ResumeLayout(false);
            grpAmount.ResumeLayout(false);
            grpAmount.PerformLayout();
            grpPaymentType.ResumeLayout(false);
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel pnlBottom;
        private Panel pnlMain;
        private Button btnSave;
        private GroupBox grpResult;
        private Label lblResult;
        private TextBox txtAmount;
        private ComboBox cmbPaymentType;
        private GroupBox grpPaymentType;
        private GroupBox grpAmount;
    }
}
