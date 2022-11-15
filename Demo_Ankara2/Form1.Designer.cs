
namespace Demo_Ankara2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dbAnkaraProjeDataSet = new Demo_Ankara2.DbAnkaraProjeDataSet();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new Demo_Ankara2.DbAnkaraProjeDataSetTableAdapters.TblCustomerTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAnkaraProjeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(105, 40);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(189, 20);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(105, 66);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(189, 20);
            this.txtCustomerSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri Şehir:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(105, 118);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(189, 20);
            this.txtBalance.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Müşteri Bakiye:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(105, 144);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(189, 20);
            this.txtDepartment.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Müşteri Departman:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(105, 170);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(189, 23);
            this.btnList.TabIndex = 10;
            this.btnList.Text = "Müşteri Listesi";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Müşteri Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(105, 228);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Müşteri Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(105, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Müşteri Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(105, 286);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(189, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Müşteri Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.AutoGenerateColumns = false;
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerCityDataGridViewTextBoxColumn,
            this.customerBalanceDataGridViewTextBoxColumn,
            this.customerDepartmentDataGridViewTextBoxColumn});
            this.dtgCustomer.DataSource = this.tblCustomerBindingSource;
            this.dtgCustomer.Location = new System.Drawing.Point(314, 14);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.Size = new System.Drawing.Size(644, 295);
            this.dtgCustomer.TabIndex = 15;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Adana",
            "Ankara",
            "Bursa",
            "İstanbul",
            "Antalya",
            "Trabzon"});
            this.cmbCity.Location = new System.Drawing.Point(105, 92);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(189, 21);
            this.cmbCity.TabIndex = 16;
            // 
            // dbAnkaraProjeDataSet
            // 
            this.dbAnkaraProjeDataSet.DataSetName = "DbAnkaraProjeDataSet";
            this.dbAnkaraProjeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "TblCustomer";
            this.tblCustomerBindingSource.DataSource = this.dbAnkaraProjeDataSet;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            // 
            // customerCityDataGridViewTextBoxColumn
            // 
            this.customerCityDataGridViewTextBoxColumn.DataPropertyName = "CustomerCity";
            this.customerCityDataGridViewTextBoxColumn.HeaderText = "CustomerCity";
            this.customerCityDataGridViewTextBoxColumn.Name = "customerCityDataGridViewTextBoxColumn";
            // 
            // customerBalanceDataGridViewTextBoxColumn
            // 
            this.customerBalanceDataGridViewTextBoxColumn.DataPropertyName = "CustomerBalance";
            this.customerBalanceDataGridViewTextBoxColumn.HeaderText = "CustomerBalance";
            this.customerBalanceDataGridViewTextBoxColumn.Name = "customerBalanceDataGridViewTextBoxColumn";
            // 
            // customerDepartmentDataGridViewTextBoxColumn
            // 
            this.customerDepartmentDataGridViewTextBoxColumn.DataPropertyName = "CustomerDepartment";
            this.customerDepartmentDataGridViewTextBoxColumn.HeaderText = "CustomerDepartment";
            this.customerDepartmentDataGridViewTextBoxColumn.Name = "customerDepartmentDataGridViewTextBoxColumn";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(105, 14);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(189, 20);
            this.txtCustomerID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Müşteri ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 314);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.dtgCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAnkaraProjeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.ComboBox cmbCity;
        private DbAnkaraProjeDataSet dbAnkaraProjeDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private DbAnkaraProjeDataSetTableAdapters.TblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label6;
    }
}

