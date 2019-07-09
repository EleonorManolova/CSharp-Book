namespace BGN_EUR
{
    partial class Convertor
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
            this.labelChange = new System.Windows.Forms.Label();
            this.labelBGNeur = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChange.Location = new System.Drawing.Point(64, 39);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(64, 20);
            this.labelChange.TabIndex = 0;
            this.labelChange.Text = "Convert";
            // 
            // labelBGNeur
            // 
            this.labelBGNeur.AutoSize = true;
            this.labelBGNeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBGNeur.Location = new System.Drawing.Point(313, 39);
            this.labelBGNeur.Name = "labelBGNeur";
            this.labelBGNeur.Size = new System.Drawing.Size(101, 20);
            this.labelBGNeur.TabIndex = 1;
            this.labelBGNeur.Text = "BGN to EUR";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(94, 68);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(259, 27);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "label3";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(163, 39);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAmount.TabIndex = 3;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
            this.numericUpDownAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownAmount_KeyUp);
            // 
            // Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 146);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelBGNeur);
            this.Controls.Add(this.labelChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Convertor";
            this.ShowIcon = false;
            this.Text = "Changer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label labelBGNeur;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
    }
}

