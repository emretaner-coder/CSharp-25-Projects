namespace Satis_Projesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbSatisDataSet = new Satis_Projesi.DbSatisDataSet();
            this.satisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satisTableAdapter = new Satis_Projesi.DbSatisDataSetTableAdapters.satisTableAdapter();
            this.üRÜNADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mÜŞTERİDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERSONELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fİYATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.üRÜNADDataGridViewTextBoxColumn,
            this.mÜŞTERİDataGridViewTextBoxColumn,
            this.pERSONELDataGridViewTextBoxColumn,
            this.fİYATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.satisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbSatisDataSet
            // 
            this.dbSatisDataSet.DataSetName = "DbSatisDataSet";
            this.dbSatisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satisBindingSource
            // 
            this.satisBindingSource.DataMember = "satis";
            this.satisBindingSource.DataSource = this.dbSatisDataSet;
            // 
            // satisTableAdapter
            // 
            this.satisTableAdapter.ClearBeforeFill = true;
            // 
            // üRÜNADDataGridViewTextBoxColumn
            // 
            this.üRÜNADDataGridViewTextBoxColumn.DataPropertyName = "ÜRÜN AD";
            this.üRÜNADDataGridViewTextBoxColumn.HeaderText = "ÜRÜN AD";
            this.üRÜNADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.üRÜNADDataGridViewTextBoxColumn.Name = "üRÜNADDataGridViewTextBoxColumn";
            // 
            // mÜŞTERİDataGridViewTextBoxColumn
            // 
            this.mÜŞTERİDataGridViewTextBoxColumn.DataPropertyName = "MÜŞTERİ";
            this.mÜŞTERİDataGridViewTextBoxColumn.HeaderText = "MÜŞTERİ";
            this.mÜŞTERİDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mÜŞTERİDataGridViewTextBoxColumn.Name = "mÜŞTERİDataGridViewTextBoxColumn";
            // 
            // pERSONELDataGridViewTextBoxColumn
            // 
            this.pERSONELDataGridViewTextBoxColumn.DataPropertyName = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.HeaderText = "PERSONEL";
            this.pERSONELDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pERSONELDataGridViewTextBoxColumn.Name = "pERSONELDataGridViewTextBoxColumn";
            // 
            // fİYATDataGridViewTextBoxColumn
            // 
            this.fİYATDataGridViewTextBoxColumn.DataPropertyName = "FİYAT";
            this.fİYATDataGridViewTextBoxColumn.HeaderText = "FİYAT";
            this.fİYATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fİYATDataGridViewTextBoxColumn.Name = "fİYATDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 404);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSatisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DbSatisDataSet dbSatisDataSet;
        private System.Windows.Forms.BindingSource satisBindingSource;
        private DbSatisDataSetTableAdapters.satisTableAdapter satisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn üRÜNADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mÜŞTERİDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERSONELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fİYATDataGridViewTextBoxColumn;
    }
}

