namespace Asteria_Restaurant_Otamasyonu
{
    partial class Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uBolgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Asteria_s_Asian_RestaurantDataSet = new Asteria_Restaurant_Otamasyonu._Asteria_s_Asian_RestaurantDataSet();
            this.ürünBilgiTableAdapter = new Asteria_Restaurant_Otamasyonu._Asteria_s_Asian_RestaurantDataSetTableAdapters.ÜrünBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Asteria_s_Asian_RestaurantDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIDDataGridViewTextBoxColumn,
            this.uAdDataGridViewTextBoxColumn,
            this.uTurDataGridViewTextBoxColumn,
            this.uStokDataGridViewTextBoxColumn,
            this.uBolgeDataGridViewTextBoxColumn,
            this.uFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ürünBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "uID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "uID";
            this.uIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uAdDataGridViewTextBoxColumn
            // 
            this.uAdDataGridViewTextBoxColumn.DataPropertyName = "uAd";
            this.uAdDataGridViewTextBoxColumn.HeaderText = "uAd";
            this.uAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uAdDataGridViewTextBoxColumn.Name = "uAdDataGridViewTextBoxColumn";
            this.uAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.uAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // uTurDataGridViewTextBoxColumn
            // 
            this.uTurDataGridViewTextBoxColumn.DataPropertyName = "uTur";
            this.uTurDataGridViewTextBoxColumn.HeaderText = "uTur";
            this.uTurDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uTurDataGridViewTextBoxColumn.Name = "uTurDataGridViewTextBoxColumn";
            this.uTurDataGridViewTextBoxColumn.ReadOnly = true;
            this.uTurDataGridViewTextBoxColumn.Width = 125;
            // 
            // uStokDataGridViewTextBoxColumn
            // 
            this.uStokDataGridViewTextBoxColumn.DataPropertyName = "uStok";
            this.uStokDataGridViewTextBoxColumn.HeaderText = "uStok";
            this.uStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uStokDataGridViewTextBoxColumn.Name = "uStokDataGridViewTextBoxColumn";
            this.uStokDataGridViewTextBoxColumn.ReadOnly = true;
            this.uStokDataGridViewTextBoxColumn.Width = 125;
            // 
            // uBolgeDataGridViewTextBoxColumn
            // 
            this.uBolgeDataGridViewTextBoxColumn.DataPropertyName = "uBolge";
            this.uBolgeDataGridViewTextBoxColumn.HeaderText = "uBolge";
            this.uBolgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uBolgeDataGridViewTextBoxColumn.Name = "uBolgeDataGridViewTextBoxColumn";
            this.uBolgeDataGridViewTextBoxColumn.ReadOnly = true;
            this.uBolgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // uFiyatDataGridViewTextBoxColumn
            // 
            this.uFiyatDataGridViewTextBoxColumn.DataPropertyName = "uFiyat";
            this.uFiyatDataGridViewTextBoxColumn.HeaderText = "uFiyat";
            this.uFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uFiyatDataGridViewTextBoxColumn.Name = "uFiyatDataGridViewTextBoxColumn";
            this.uFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            this.uFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünBilgiBindingSource
            // 
            this.ürünBilgiBindingSource.DataMember = "ÜrünBilgi";
            this.ürünBilgiBindingSource.DataSource = this._Asteria_s_Asian_RestaurantDataSet;
            // 
            // _Asteria_s_Asian_RestaurantDataSet
            // 
            this._Asteria_s_Asian_RestaurantDataSet.DataSetName = "_Asteria_s_Asian_RestaurantDataSet";
            this._Asteria_s_Asian_RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürünBilgiTableAdapter
            // 
            this.ürünBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 288);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin";
            this.Text = "d";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Asteria_s_Asian_RestaurantDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _Asteria_s_Asian_RestaurantDataSet _Asteria_s_Asian_RestaurantDataSet;
        private System.Windows.Forms.BindingSource ürünBilgiBindingSource;
        private _Asteria_s_Asian_RestaurantDataSetTableAdapters.ÜrünBilgiTableAdapter ürünBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uBolgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFiyatDataGridViewTextBoxColumn;
    }
}