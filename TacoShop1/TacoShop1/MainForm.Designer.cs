
namespace TacoShop1
{
    partial class MainForm
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
            this.TacoButton = new System.Windows.Forms.Button();
            this.BurritoButton = new System.Windows.Forms.Button();
            this.ReceiptBox = new System.Windows.Forms.ListBox();
            this.WaterButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SodaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.create_receipt_button = new System.Windows.Forms.Button();
            this.view_receipts_button = new System.Windows.Forms.Button();
            this.taxBox = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TacoButton
            // 
            this.TacoButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TacoButton.Location = new System.Drawing.Point(71, 150);
            this.TacoButton.Name = "TacoButton";
            this.TacoButton.Size = new System.Drawing.Size(142, 92);
            this.TacoButton.TabIndex = 0;
            this.TacoButton.Text = "Taco";
            this.TacoButton.UseVisualStyleBackColor = true;
            this.TacoButton.Click += new System.EventHandler(this.TacoButton_Click);
            // 
            // BurritoButton
            // 
            this.BurritoButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BurritoButton.Location = new System.Drawing.Point(71, 262);
            this.BurritoButton.Name = "BurritoButton";
            this.BurritoButton.Size = new System.Drawing.Size(142, 92);
            this.BurritoButton.TabIndex = 1;
            this.BurritoButton.Text = "Burrito";
            this.BurritoButton.UseVisualStyleBackColor = true;
            this.BurritoButton.Click += new System.EventHandler(this.BurritoButton_Click);
            // 
            // ReceiptBox
            // 
            this.ReceiptBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReceiptBox.FormattingEnabled = true;
            this.ReceiptBox.ItemHeight = 21;
            this.ReceiptBox.Location = new System.Drawing.Point(563, 12);
            this.ReceiptBox.Name = "ReceiptBox";
            this.ReceiptBox.Size = new System.Drawing.Size(225, 235);
            this.ReceiptBox.TabIndex = 2;
            // 
            // WaterButton
            // 
            this.WaterButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WaterButton.Location = new System.Drawing.Point(287, 148);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(168, 97);
            this.WaterButton.TabIndex = 3;
            this.WaterButton.Text = "Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(637, 301);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SodaButton
            // 
            this.SodaButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SodaButton.Location = new System.Drawing.Point(287, 259);
            this.SodaButton.Name = "SodaButton";
            this.SodaButton.Size = new System.Drawing.Size(138, 98);
            this.SodaButton.TabIndex = 5;
            this.SodaButton.Text = "Soda";
            this.SodaButton.UseVisualStyleBackColor = true;
            this.SodaButton.Click += new System.EventHandler(this.SodaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho N-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "TacoShop POS Program";
            // 
            // create_receipt_button
            // 
            this.create_receipt_button.Location = new System.Drawing.Point(616, 330);
            this.create_receipt_button.Name = "create_receipt_button";
            this.create_receipt_button.Size = new System.Drawing.Size(120, 49);
            this.create_receipt_button.TabIndex = 7;
            this.create_receipt_button.Text = "Create Receipt";
            this.create_receipt_button.UseVisualStyleBackColor = true;
            this.create_receipt_button.Click += new System.EventHandler(this.create_receipt_button_Click);
            // 
            // view_receipts_button
            // 
            this.view_receipts_button.Location = new System.Drawing.Point(616, 385);
            this.view_receipts_button.Name = "view_receipts_button";
            this.view_receipts_button.Size = new System.Drawing.Size(120, 49);
            this.view_receipts_button.TabIndex = 8;
            this.view_receipts_button.Text = "View Receipts";
            this.view_receipts_button.UseVisualStyleBackColor = true;
            this.view_receipts_button.Click += new System.EventHandler(this.view_receipts_button_Click);
            // 
            // taxBox
            // 
            this.taxBox.AutoSize = true;
            this.taxBox.Location = new System.Drawing.Point(563, 262);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(30, 15);
            this.taxBox.TabIndex = 9;
            this.taxBox.Text = "TAX:";
            // 
            // totalBox
            // 
            this.totalBox.AutoSize = true;
            this.totalBox.Location = new System.Drawing.Point(563, 277);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(42, 15);
            this.totalBox.TabIndex = 10;
            this.totalBox.Text = "TOTAL:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(760, 263);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(28, 15);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "0.00";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(760, 277);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(28, 15);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "0.00";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(43, 67);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(322, 23);
            this.nametextBox.TabIndex = 13;
            this.nametextBox.Text = "Name of Order Here";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.view_receipts_button);
            this.Controls.Add(this.create_receipt_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SodaButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.WaterButton);
            this.Controls.Add(this.ReceiptBox);
            this.Controls.Add(this.BurritoButton);
            this.Controls.Add(this.TacoButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TacoButton;
        private System.Windows.Forms.Button BurritoButton;
        private System.Windows.Forms.ListBox ReceiptBox;
        private System.Windows.Forms.Button WaterButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SodaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_receipt_button;
        private System.Windows.Forms.Button view_receipts_button;
        private System.Windows.Forms.Label taxBox;
        private System.Windows.Forms.Label totalBox;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox nametextBox;
    }
}

