namespace PTAS
{
    partial class frmExcitation
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
            System.Windows.Forms.Label testNumberLabel;
            this.btnAssess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssess = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.tblExcitationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.excHVATextBox = new System.Windows.Forms.TextBox();
            this.excHVBTextBox = new System.Windows.Forms.TextBox();
            this.excHVCTextBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.testVoltageTextBox = new System.Windows.Forms.TextBox();
            this.tblExcitationTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblExcitationTableAdapter();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            testNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblExcitationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // testNumberLabel
            // 
            testNumberLabel.AutoSize = true;
            testNumberLabel.Location = new System.Drawing.Point(40, 44);
            testNumberLabel.Name = "testNumberLabel";
            testNumberLabel.Size = new System.Drawing.Size(71, 13);
            testNumberLabel.TabIndex = 18;
            testNumberLabel.Text = "Test Number:";
            // 
            // btnAssess
            // 
            this.btnAssess.Location = new System.Drawing.Point(212, 235);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(160, 36);
            this.btnAssess.TabIndex = 8;
            this.btnAssess.Text = "Assess";
            this.btnAssess.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primary - Phase A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Primary - Phase B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Primary - Phase C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Test Voltage (kV)";
            // 
            // txtAssess
            // 
            this.txtAssess.Location = new System.Drawing.Point(184, 185);
            this.txtAssess.Name = "txtAssess";
            this.txtAssess.ReadOnly = true;
            this.txtAssess.Size = new System.Drawing.Size(134, 20);
            this.txtAssess.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Assessment";
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExcitationBindingSource, "TestNumber", true));
            this.testNumberTextBox.Location = new System.Drawing.Point(184, 41);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(134, 20);
            this.testNumberTextBox.TabIndex = 19;
            // 
            // tblExcitationBindingSource
            // 
            this.tblExcitationBindingSource.DataMember = "tblExcitation";
            this.tblExcitationBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excHVATextBox
            // 
            this.excHVATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExcitationBindingSource, "excHVA", true));
            this.excHVATextBox.Location = new System.Drawing.Point(184, 107);
            this.excHVATextBox.Name = "excHVATextBox";
            this.excHVATextBox.Size = new System.Drawing.Size(134, 20);
            this.excHVATextBox.TabIndex = 21;
            // 
            // excHVBTextBox
            // 
            this.excHVBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExcitationBindingSource, "excHVB", true));
            this.excHVBTextBox.Location = new System.Drawing.Point(184, 133);
            this.excHVBTextBox.Name = "excHVBTextBox";
            this.excHVBTextBox.Size = new System.Drawing.Size(134, 20);
            this.excHVBTextBox.TabIndex = 23;
            // 
            // excHVCTextBox
            // 
            this.excHVCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExcitationBindingSource, "excHVC", true));
            this.excHVCTextBox.Location = new System.Drawing.Point(184, 159);
            this.excHVCTextBox.Name = "excHVCTextBox";
            this.excHVCTextBox.Size = new System.Drawing.Size(134, 20);
            this.excHVCTextBox.TabIndex = 25;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(189, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 32);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 32);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 292);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 32);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // testVoltageTextBox
            // 
            this.testVoltageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblExcitationBindingSource, "TestVoltage", true));
            this.testVoltageTextBox.Location = new System.Drawing.Point(184, 67);
            this.testVoltageTextBox.Name = "testVoltageTextBox";
            this.testVoltageTextBox.Size = new System.Drawing.Size(134, 20);
            this.testVoltageTextBox.TabIndex = 58;
            // 
            // tblExcitationTableAdapter
            // 
            this.tblExcitationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBushingTableAdapter = null;
            this.tableAdapterManager.tblDielectricTableAdapter = null;
            this.tableAdapterManager.tblExcitationTableAdapter = this.tblExcitationTableAdapter;
            this.tableAdapterManager.tblIPFTableAdapter = null;
            this.tableAdapterManager.tblOilPFTableAdapter = null;
            this.tableAdapterManager.tblSecurityTableAdapter = null;
            this.tableAdapterManager.tblSubstationTableAdapter = null;
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = null;
            this.tableAdapterManager.tblWindingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmExcitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(434, 367);
            this.Controls.Add(this.testVoltageTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(testNumberLabel);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.excHVATextBox);
            this.Controls.Add(this.excHVBTextBox);
            this.Controls.Add(this.excHVCTextBox);
            this.Controls.Add(this.txtAssess);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcitation";
            this.Text = "frmExcitation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExcitation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblExcitationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAssess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAssess;
        private System.Windows.Forms.Label label8;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblExcitationBindingSource;
        private dtbPTASDataSetTableAdapters.tblExcitationTableAdapter tblExcitationTableAdapter;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.TextBox excHVATextBox;
        private System.Windows.Forms.TextBox excHVBTextBox;
        private System.Windows.Forms.TextBox excHVCTextBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox testVoltageTextBox;
    }
}