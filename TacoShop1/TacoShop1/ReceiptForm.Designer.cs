
namespace TacoShop
{
    partial class ReceiptForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.receiptDataGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(377, 348);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(298, 23);
            this.searchInput.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(499, 377);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // receiptDataGrid
            // 
            this.receiptDataGrid.AllowUserToAddRows = false;
            this.receiptDataGrid.AllowUserToDeleteRows = false;
            this.receiptDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.receiptDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.receiptDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.ITEMS,
            this.TAX,
            this.TIP,
            this.TOTAL});
            this.receiptDataGrid.Location = new System.Drawing.Point(168, 12);
            this.receiptDataGrid.Name = "receiptDataGrid";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.receiptDataGrid.RowTemplate.Height = 25;
            this.receiptDataGrid.Size = new System.Drawing.Size(740, 311);
            this.receiptDataGrid.TabIndex = 3;
            this.receiptDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptDataGrid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NAME";
            this.NAME.Name = "NAME";
            this.NAME.Width = 66;
            // 
            // ITEMS
            // 
            this.ITEMS.HeaderText = "ITEMS";
            this.ITEMS.Name = "ITEMS";
            this.ITEMS.Width = 64;
            // 
            // TAX
            // 
            this.TAX.HeaderText = "TAX";
            this.TAX.Name = "TAX";
            this.TAX.Width = 52;
            // 
            // TIP
            // 
            this.TIP.HeaderText = "TIP";
            this.TIP.Name = "TIP";
            this.TIP.Width = 48;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Width = 64;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 641);
            this.Controls.Add(this.receiptDataGrid);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchInput);
            this.Name = "ReceiptForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receiptDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView receiptDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}