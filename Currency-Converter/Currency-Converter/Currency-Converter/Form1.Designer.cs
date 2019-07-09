namespace Currency_Converter
{
    partial class FormConvertor
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
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelBGN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(12, 21);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAmount.TabIndex = 0;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.Form1_Load);
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(246, 19);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCurrency.TabIndex = 1;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(12, 63);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(355, 30);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "label1";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBGN
            // 
            this.labelBGN.AutoSize = true;
            this.labelBGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBGN.Location = new System.Drawing.Point(170, 27);
            this.labelBGN.Name = "labelBGN";
            this.labelBGN.Size = new System.Drawing.Size(44, 20);
            this.labelBGN.TabIndex = 3;
            this.labelBGN.Text = "BGN";
            // 
            // FormConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 115);
            this.Controls.Add(this.labelBGN);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.numericUpDownAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConvertor";
            this.Text = "Currency Convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelBGN;
    }
}

