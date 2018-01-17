namespace PTAS
{
    partial class frmSubstation
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
            this.tblSubstationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblSubstationTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblSubstationTableAdapter();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            this.subIDTextBox = new System.Windows.Forms.TextBox();
            this.subNameTextBox = new System.Windows.Forms.TextBox();
            this.subAddressTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubstationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Substation ID";
            // 
            // tblSubstationBindingSource
            // 
            this.tblSubstationBindingSource.DataMember = "tblSubstation";
            this.tblSubstationBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Substation Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(334, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 33);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 106);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(334, 67);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 33);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblSubstationTableAdapter
            // 
            this.tblSubstationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBushingTableAdapter = null;
            this.tableAdapterManager.tblDielectricTableAdapter = null;
            this.tableAdapterManager.tblExcitationTableAdapter = null;
            this.tableAdapterManager.tblIPFTableAdapter = null;
            this.tableAdapterManager.tblOilPFTableAdapter = null;
            this.tableAdapterManager.tblSecurityTableAdapter = null;
            this.tableAdapterManager.tblSubstationTableAdapter = this.tblSubstationTableAdapter;
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = null;
            this.tableAdapterManager.tblWindingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // subIDTextBox
            // 
            this.subIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSubstationBindingSource, "subID", true));
            this.subIDTextBox.Location = new System.Drawing.Point(160, 77);
            this.subIDTextBox.Name = "subIDTextBox";
            this.subIDTextBox.Size = new System.Drawing.Size(119, 20);
            this.subIDTextBox.TabIndex = 37;
            // 
            // subNameTextBox
            // 
            this.subNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSubstationBindingSource, "subName", true));
            this.subNameTextBox.Location = new System.Drawing.Point(160, 103);
            this.subNameTextBox.Name = "subNameTextBox";
            this.subNameTextBox.Size = new System.Drawing.Size(119, 20);
            this.subNameTextBox.TabIndex = 39;
            // 
            // subAddressTextBox
            // 
            this.subAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblSubstationBindingSource, "subAddress", true));
            this.subAddressTextBox.Location = new System.Drawing.Point(160, 129);
            this.subAddressTextBox.Name = "subAddressTextBox";
            this.subAddressTextBox.Size = new System.Drawing.Size(119, 20);
            this.subAddressTextBox.TabIndex = 41;
            // 
            // frmSubstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 234);
            this.Controls.Add(this.subIDTextBox);
            this.Controls.Add(this.subNameTextBox);
            this.Controls.Add(this.subAddressTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSubstation";
            this.Text = "Substation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSubstation_FormClosed);
            this.Load += new System.EventHandler(this.frmSubstation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSubstationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblSubstationBindingSource;
        private dtbPTASDataSetTableAdapters.tblSubstationTableAdapter tblSubstationTableAdapter;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox subIDTextBox;
        private System.Windows.Forms.TextBox subNameTextBox;
        private System.Windows.Forms.TextBox subAddressTextBox;
    }
}