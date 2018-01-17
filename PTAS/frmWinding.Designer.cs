namespace PTAS
{
    partial class frmWinding
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windPrimATextBox = new System.Windows.Forms.TextBox();
            this.tblWindingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.windPrimCTextBox = new System.Windows.Forms.TextBox();
            this.windPrimBTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.windSecBTextBox = new System.Windows.Forms.TextBox();
            this.windSecCTextBox = new System.Windows.Forms.TextBox();
            this.windSecATextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.windTertBTextBox = new System.Windows.Forms.TextBox();
            this.windTertCTextBox = new System.Windows.Forms.TextBox();
            this.windTertATextBox = new System.Windows.Forms.TextBox();
            this.txtAssess = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAssess = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblWindingTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblWindingTableAdapter();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            testNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblWindingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // testNumberLabel
            // 
            testNumberLabel.AutoSize = true;
            testNumberLabel.Location = new System.Drawing.Point(57, 44);
            testNumberLabel.Name = "testNumberLabel";
            testNumberLabel.Size = new System.Drawing.Size(71, 13);
            testNumberLabel.TabIndex = 58;
            testNumberLabel.Text = "Test Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.windPrimATextBox);
            this.groupBox1.Controls.Add(this.windPrimCTextBox);
            this.groupBox1.Controls.Add(this.windPrimBTextBox);
            this.groupBox1.Location = new System.Drawing.Point(34, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "High Voltage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phase C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phase A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phase B";
            // 
            // windPrimATextBox
            // 
            this.windPrimATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windPrimA", true));
            this.windPrimATextBox.Location = new System.Drawing.Point(100, 33);
            this.windPrimATextBox.Name = "windPrimATextBox";
            this.windPrimATextBox.Size = new System.Drawing.Size(122, 20);
            this.windPrimATextBox.TabIndex = 61;
            // 
            // tblWindingBindingSource
            // 
            this.tblWindingBindingSource.DataMember = "tblWinding";
            this.tblWindingBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // windPrimCTextBox
            // 
            this.windPrimCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windPrimC", true));
            this.windPrimCTextBox.Location = new System.Drawing.Point(100, 85);
            this.windPrimCTextBox.Name = "windPrimCTextBox";
            this.windPrimCTextBox.Size = new System.Drawing.Size(122, 20);
            this.windPrimCTextBox.TabIndex = 65;
            // 
            // windPrimBTextBox
            // 
            this.windPrimBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windPrimB", true));
            this.windPrimBTextBox.Location = new System.Drawing.Point(100, 59);
            this.windPrimBTextBox.Name = "windPrimBTextBox";
            this.windPrimBTextBox.Size = new System.Drawing.Size(122, 20);
            this.windPrimBTextBox.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.windSecBTextBox);
            this.groupBox2.Controls.Add(this.windSecCTextBox);
            this.groupBox2.Controls.Add(this.windSecATextBox);
            this.groupBox2.Location = new System.Drawing.Point(299, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 127);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Low Voltage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phase C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phase A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phase B";
            // 
            // windSecBTextBox
            // 
            this.windSecBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windSecB", true));
            this.windSecBTextBox.Location = new System.Drawing.Point(100, 59);
            this.windSecBTextBox.Name = "windSecBTextBox";
            this.windSecBTextBox.Size = new System.Drawing.Size(122, 20);
            this.windSecBTextBox.TabIndex = 69;
            // 
            // windSecCTextBox
            // 
            this.windSecCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windSecC", true));
            this.windSecCTextBox.Location = new System.Drawing.Point(100, 85);
            this.windSecCTextBox.Name = "windSecCTextBox";
            this.windSecCTextBox.Size = new System.Drawing.Size(122, 20);
            this.windSecCTextBox.TabIndex = 71;
            // 
            // windSecATextBox
            // 
            this.windSecATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windSecA", true));
            this.windSecATextBox.Location = new System.Drawing.Point(100, 33);
            this.windSecATextBox.Name = "windSecATextBox";
            this.windSecATextBox.Size = new System.Drawing.Size(122, 20);
            this.windSecATextBox.TabIndex = 67;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.windTertBTextBox);
            this.groupBox3.Controls.Add(this.windTertCTextBox);
            this.groupBox3.Controls.Add(this.windTertATextBox);
            this.groupBox3.Location = new System.Drawing.Point(564, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 127);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tertiary Voltage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Phase C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phase A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Phase B";
            // 
            // windTertBTextBox
            // 
            this.windTertBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windTertB", true));
            this.windTertBTextBox.Location = new System.Drawing.Point(100, 59);
            this.windTertBTextBox.Name = "windTertBTextBox";
            this.windTertBTextBox.Size = new System.Drawing.Size(122, 20);
            this.windTertBTextBox.TabIndex = 75;
            // 
            // windTertCTextBox
            // 
            this.windTertCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windTertC", true));
            this.windTertCTextBox.Location = new System.Drawing.Point(100, 85);
            this.windTertCTextBox.Name = "windTertCTextBox";
            this.windTertCTextBox.Size = new System.Drawing.Size(122, 20);
            this.windTertCTextBox.TabIndex = 77;
            // 
            // windTertATextBox
            // 
            this.windTertATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "windTertA", true));
            this.windTertATextBox.Location = new System.Drawing.Point(100, 33);
            this.windTertATextBox.Name = "windTertATextBox";
            this.windTertATextBox.Size = new System.Drawing.Size(122, 20);
            this.windTertATextBox.TabIndex = 73;
            // 
            // txtAssess
            // 
            this.txtAssess.Location = new System.Drawing.Point(636, 229);
            this.txtAssess.Name = "txtAssess";
            this.txtAssess.ReadOnly = true;
            this.txtAssess.Size = new System.Drawing.Size(168, 20);
            this.txtAssess.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(533, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Assessment";
            // 
            // btnAssess
            // 
            this.btnAssess.Location = new System.Drawing.Point(659, 265);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(160, 36);
            this.btnAssess.TabIndex = 30;
            this.btnAssess.Text = "Assess";
            this.btnAssess.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(180, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 32);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 32);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 32);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblWindingTableAdapter
            // 
            this.tblWindingTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblSubstationTableAdapter = null;
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = null;
            this.tableAdapterManager.tblWindingTableAdapter = this.tblWindingTableAdapter;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblWindingBindingSource, "TestNumber", true));
            this.testNumberTextBox.Location = new System.Drawing.Point(134, 41);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.testNumberTextBox.TabIndex = 59;
            // 
            // frmWinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 342);
            this.Controls.Add(testNumberLabel);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAssess);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnAssess);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWinding";
            this.Text = "frmWinding";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmWinding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblWindingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAssess;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAssess;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblWindingBindingSource;
        private dtbPTASDataSetTableAdapters.tblWindingTableAdapter tblWindingTableAdapter;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.TextBox windPrimATextBox;
        private System.Windows.Forms.TextBox windPrimBTextBox;
        private System.Windows.Forms.TextBox windPrimCTextBox;
        private System.Windows.Forms.TextBox windSecATextBox;
        private System.Windows.Forms.TextBox windSecBTextBox;
        private System.Windows.Forms.TextBox windSecCTextBox;
        private System.Windows.Forms.TextBox windTertATextBox;
        private System.Windows.Forms.TextBox windTertBTextBox;
        private System.Windows.Forms.TextBox windTertCTextBox;
    }
}