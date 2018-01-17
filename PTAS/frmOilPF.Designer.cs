namespace PTAS
{
    partial class frmOilPF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAssess = new System.Windows.Forms.Button();
            this.txtAssessOLTC = new System.Windows.Forms.TextBox();
            this.txtAssessMain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.tblOilPFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblOilPFTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblOilPFTableAdapter();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.pfMainTextBox = new System.Windows.Forms.TextBox();
            this.pfOLTCTextBox = new System.Windows.Forms.TextBox();
            testNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOilPFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testNumberLabel
            // 
            testNumberLabel.AutoSize = true;
            testNumberLabel.Location = new System.Drawing.Point(85, 46);
            testNumberLabel.Name = "testNumberLabel";
            testNumberLabel.Size = new System.Drawing.Size(71, 13);
            testNumberLabel.TabIndex = 58;
            testNumberLabel.Text = "Test Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Tank";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OLTC";
            // 
            // btnAssess
            // 
            this.btnAssess.Location = new System.Drawing.Point(318, 212);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(160, 36);
            this.btnAssess.TabIndex = 11;
            this.btnAssess.Text = "Assess";
            this.btnAssess.UseVisualStyleBackColor = true;
            this.btnAssess.Click += new System.EventHandler(this.btnAssess_Click);
            // 
            // txtAssessOLTC
            // 
            this.txtAssessOLTC.Location = new System.Drawing.Point(323, 122);
            this.txtAssessOLTC.Name = "txtAssessOLTC";
            this.txtAssessOLTC.ReadOnly = true;
            this.txtAssessOLTC.Size = new System.Drawing.Size(155, 20);
            this.txtAssessOLTC.TabIndex = 13;
            // 
            // txtAssessMain
            // 
            this.txtAssessMain.Location = new System.Drawing.Point(323, 96);
            this.txtAssessMain.Name = "txtAssessMain";
            this.txtAssessMain.ReadOnly = true;
            this.txtAssessMain.Size = new System.Drawing.Size(155, 20);
            this.txtAssessMain.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Assessment";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 32);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(157, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 32);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 32);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOilPFBindingSource
            // 
            this.tblOilPFBindingSource.DataMember = "tblOilPF";
            this.tblOilPFBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // tblOilPFTableAdapter
            // 
            this.tblOilPFTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBushingTableAdapter = null;
            this.tableAdapterManager.tblDielectricTableAdapter = null;
            this.tableAdapterManager.tblExcitationTableAdapter = null;
            this.tableAdapterManager.tblIPFTableAdapter = null;
            this.tableAdapterManager.tblOilPFTableAdapter = this.tblOilPFTableAdapter;
            this.tableAdapterManager.tblSecurityTableAdapter = null;
            this.tableAdapterManager.tblSubstationTableAdapter = null;
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = null;
            this.tableAdapterManager.tblWindingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblOilPFBindingSource, "TestNumber", true));
            this.testNumberTextBox.Location = new System.Drawing.Point(162, 43);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.testNumberTextBox.TabIndex = 59;
            // 
            // pfMainTextBox
            // 
            this.pfMainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblOilPFBindingSource, "pfMain", true));
            this.pfMainTextBox.Location = new System.Drawing.Point(162, 96);
            this.pfMainTextBox.Name = "pfMainTextBox";
            this.pfMainTextBox.Size = new System.Drawing.Size(155, 20);
            this.pfMainTextBox.TabIndex = 61;
            // 
            // pfOLTCTextBox
            // 
            this.pfOLTCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblOilPFBindingSource, "pfOLTC", true));
            this.pfOLTCTextBox.Location = new System.Drawing.Point(162, 122);
            this.pfOLTCTextBox.Name = "pfOLTCTextBox";
            this.pfOLTCTextBox.Size = new System.Drawing.Size(155, 20);
            this.pfOLTCTextBox.TabIndex = 63;
            // 
            // frmOilPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 290);
            this.Controls.Add(testNumberLabel);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.pfMainTextBox);
            this.Controls.Add(this.pfOLTCTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssessOLTC);
            this.Controls.Add(this.txtAssessMain);
            this.Controls.Add(this.btnAssess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOilPF";
            this.Text = "frmOilPF";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOilPF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOilPFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAssess;
        private System.Windows.Forms.TextBox txtAssessOLTC;
        private System.Windows.Forms.TextBox txtAssessMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblOilPFBindingSource;
        private dtbPTASDataSetTableAdapters.tblOilPFTableAdapter tblOilPFTableAdapter;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.TextBox pfMainTextBox;
        private System.Windows.Forms.TextBox pfOLTCTextBox;
    }
}