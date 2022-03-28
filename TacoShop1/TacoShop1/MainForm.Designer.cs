
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
            this.ReceiptBox.FormattingEnabled = true;
            this.ReceiptBox.ItemHeight = 15;
            this.ReceiptBox.Location = new System.Drawing.Point(551, 61);
            this.ReceiptBox.Name = "ReceiptBox";
            this.ReceiptBox.Size = new System.Drawing.Size(120, 244);
            this.ReceiptBox.TabIndex = 2;
            this.ReceiptBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.ClearButton.Location = new System.Drawing.Point(572, 311);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SodaButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.WaterButton);
            this.Controls.Add(this.ReceiptBox);
            this.Controls.Add(this.BurritoButton);
            this.Controls.Add(this.TacoButton);
            this.Name = "Form1";
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
    }
}

