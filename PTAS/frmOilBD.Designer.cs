namespace PTAS
{
    partial class frmOilBD
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
            System.Windows.Forms.Label standardLabel;
            System.Windows.Forms.Label statusLabel;
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.main1TextBox = new System.Windows.Forms.TextBox();
            this.tblDielectricBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.main2TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.main3TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.main4TextBox = new System.Windows.Forms.TextBox();
            this.main5TextBox = new System.Windows.Forms.TextBox();
            this.txtMainAssess = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainAveTextBox = new System.Windows.Forms.TextBox();
            this.grpOLTC = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.oltc1TextBox = new System.Windows.Forms.TextBox();
            this.oltc5TextBox = new System.Windows.Forms.TextBox();
            this.oltc4TextBox = new System.Windows.Forms.TextBox();
            this.oltc2TextBox = new System.Windows.Forms.TextBox();
            this.oltc3TextBox = new System.Windows.Forms.TextBox();
            this.txtOLTCAssess = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.oltcAveTextBox = new System.Windows.Forms.TextBox();
            this.btnAssess = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblDielectricTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblDielectricTableAdapter();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.standardComboBox = new System.Windows.Forms.ComboBox();
            this.tblStandardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.tblStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStandardsTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblStandardsTableAdapter();
            this.tblStatusTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblStatusTableAdapter();
            this.btnCompute = new System.Windows.Forms.Button();
            testNumberLabel = new System.Windows.Forms.Label();
            standardLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDielectricBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            this.grpOLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStandardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testNumberLabel
            // 
            testNumberLabel.AutoSize = true;
            testNumberLabel.Location = new System.Drawing.Point(66, 45);
            testNumberLabel.Name = "testNumberLabel";
            testNumberLabel.Size = new System.Drawing.Size(71, 13);
            testNumberLabel.TabIndex = 58;
            testNumberLabel.Text = "Test Number:";
            // 
            // standardLabel
            // 
            standardLabel.AutoSize = true;
            standardLabel.Location = new System.Drawing.Point(319, 44);
            standardLabel.Name = "standardLabel";
            standardLabel.Size = new System.Drawing.Size(78, 13);
            standardLabel.TabIndex = 59;
            standardLabel.Text = "Standard Used";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(345, 71);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 13);
            statusLabel.TabIndex = 60;
            statusLabel.Text = "Oil Status";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.main1TextBox);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.main2TextBox);
            this.grpMain.Controls.Add(this.label6);
            this.grpMain.Controls.Add(this.label4);
            this.grpMain.Controls.Add(this.main3TextBox);
            this.grpMain.Controls.Add(this.label3);
            this.grpMain.Controls.Add(this.main4TextBox);
            this.grpMain.Controls.Add(this.main5TextBox);
            this.grpMain.Location = new System.Drawing.Point(54, 104);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(230, 164);
            this.grpMain.TabIndex = 0;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "Main Tank";
            // 
            // main1TextBox
            // 
            this.main1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "main1", true));
            this.main1TextBox.Location = new System.Drawing.Point(89, 20);
            this.main1TextBox.Name = "main1TextBox";
            this.main1TextBox.Size = new System.Drawing.Size(123, 20);
            this.main1TextBox.TabIndex = 61;
            // 
            // tblDielectricBindingSource
            // 
            this.tblDielectricBindingSource.DataMember = "tblDielectric";
            this.tblDielectricBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trial 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trial 2";
            // 
            // main2TextBox
            // 
            this.main2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "main2", true));
            this.main2TextBox.Location = new System.Drawing.Point(89, 46);
            this.main2TextBox.Name = "main2TextBox";
            this.main2TextBox.Size = new System.Drawing.Size(123, 20);
            this.main2TextBox.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Trial 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trial 3";
            // 
            // main3TextBox
            // 
            this.main3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "main3", true));
            this.main3TextBox.Location = new System.Drawing.Point(89, 72);
            this.main3TextBox.Name = "main3TextBox";
            this.main3TextBox.Size = new System.Drawing.Size(123, 20);
            this.main3TextBox.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trial 4";
            // 
            // main4TextBox
            // 
            this.main4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "main4", true));
            this.main4TextBox.Location = new System.Drawing.Point(89, 98);
            this.main4TextBox.Name = "main4TextBox";
            this.main4TextBox.Size = new System.Drawing.Size(123, 20);
            this.main4TextBox.TabIndex = 67;
            // 
            // main5TextBox
            // 
            this.main5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "main5", true));
            this.main5TextBox.Location = new System.Drawing.Point(89, 124);
            this.main5TextBox.Name = "main5TextBox";
            this.main5TextBox.Size = new System.Drawing.Size(123, 20);
            this.main5TextBox.TabIndex = 69;
            // 
            // txtMainAssess
            // 
            this.txtMainAssess.Location = new System.Drawing.Point(143, 300);
            this.txtMainAssess.Name = "txtMainAssess";
            this.txtMainAssess.ReadOnly = true;
            this.txtMainAssess.Size = new System.Drawing.Size(123, 20);
            this.txtMainAssess.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Assessment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average";
            // 
            // mainAveTextBox
            // 
            this.mainAveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "mainAve", true));
            this.mainAveTextBox.Location = new System.Drawing.Point(143, 274);
            this.mainAveTextBox.Name = "mainAveTextBox";
            this.mainAveTextBox.ReadOnly = true;
            this.mainAveTextBox.Size = new System.Drawing.Size(123, 20);
            this.mainAveTextBox.TabIndex = 71;
            // 
            // grpOLTC
            // 
            this.grpOLTC.Controls.Add(this.label8);
            this.grpOLTC.Controls.Add(this.label9);
            this.grpOLTC.Controls.Add(this.label10);
            this.grpOLTC.Controls.Add(this.label11);
            this.grpOLTC.Controls.Add(this.label12);
            this.grpOLTC.Controls.Add(this.oltc1TextBox);
            this.grpOLTC.Controls.Add(this.oltc5TextBox);
            this.grpOLTC.Controls.Add(this.oltc4TextBox);
            this.grpOLTC.Controls.Add(this.oltc2TextBox);
            this.grpOLTC.Controls.Add(this.oltc3TextBox);
            this.grpOLTC.Location = new System.Drawing.Point(316, 104);
            this.grpOLTC.Name = "grpOLTC";
            this.grpOLTC.Size = new System.Drawing.Size(230, 164);
            this.grpOLTC.TabIndex = 13;
            this.grpOLTC.TabStop = false;
            this.grpOLTC.Text = "OLTC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Trial 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Trial 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Trial 5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Trial 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Trial 4";
            // 
            // oltc1TextBox
            // 
            this.oltc1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "oltc1", true));
            this.oltc1TextBox.Location = new System.Drawing.Point(89, 20);
            this.oltc1TextBox.Name = "oltc1TextBox";
            this.oltc1TextBox.Size = new System.Drawing.Size(123, 20);
            this.oltc1TextBox.TabIndex = 73;
            // 
            // oltc5TextBox
            // 
            this.oltc5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "oltc5", true));
            this.oltc5TextBox.Location = new System.Drawing.Point(89, 124);
            this.oltc5TextBox.Name = "oltc5TextBox";
            this.oltc5TextBox.Size = new System.Drawing.Size(123, 20);
            this.oltc5TextBox.TabIndex = 81;
            // 
            // oltc4TextBox
            // 
            this.oltc4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "oltc4", true));
            this.oltc4TextBox.Location = new System.Drawing.Point(89, 98);
            this.oltc4TextBox.Name = "oltc4TextBox";
            this.oltc4TextBox.Size = new System.Drawing.Size(123, 20);
            this.oltc4TextBox.TabIndex = 79;
            // 
            // oltc2TextBox
            // 
            this.oltc2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "oltc2", true));
            this.oltc2TextBox.Location = new System.Drawing.Point(89, 46);
            this.oltc2TextBox.Name = "oltc2TextBox";
            this.oltc2TextBox.Size = new System.Drawing.Size(123, 20);
            this.oltc2TextBox.TabIndex = 75;
            // 
            // oltc3TextBox
            // 
            this.oltc3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "oltc3", true));
            this.oltc3TextBox.Location = new System.Drawing.Point(89, 72);
            this.oltc3TextBox.Name = "oltc3TextBox";
            this.oltc3TextBox.Size = new System.Drawing.Size(123, 20);
            this.oltc3TextBox.TabIndex = 77;
            // 
            // txtOLTCAssess
            // 
            this.txtOLTCAssess.Location = new System.Drawing.Point(405, 300);
            this.txtOLTCAssess.Name = "txtOLTCAssess";
            this.txtOLTCAssess.ReadOnly = true;
            this.txtOLTCAssess.Size = new System.Drawing.Size(123, 20);
            this.txtOLTCAssess.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Assessment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Average";
            // 
            // oltcAveTextBox
            // 
            this.oltcAveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "oltcAve", true));
            this.oltcAveTextBox.Location = new System.Drawing.Point(405, 274);
            this.oltcAveTextBox.Name = "oltcAveTextBox";
            this.oltcAveTextBox.ReadOnly = true;
            this.oltcAveTextBox.Size = new System.Drawing.Size(123, 20);
            this.oltcAveTextBox.TabIndex = 83;
            // 
            // btnAssess
            // 
            this.btnAssess.Location = new System.Drawing.Point(386, 387);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(160, 36);
            this.btnAssess.TabIndex = 16;
            this.btnAssess.Text = "Assess";
            this.btnAssess.UseVisualStyleBackColor = true;
            this.btnAssess.Click += new System.EventHandler(this.btnAssess_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 32);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(126, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 32);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 32);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblDielectricTableAdapter
            // 
            this.tblDielectricTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBushingTableAdapter = null;
            this.tableAdapterManager.tblDielectricTableAdapter = this.tblDielectricTableAdapter;
            this.tableAdapterManager.tblExcitationTableAdapter = null;
            this.tableAdapterManager.tblIPFTableAdapter = null;
            this.tableAdapterManager.tblOilPFTableAdapter = null;
            this.tableAdapterManager.tblSecurityTableAdapter = null;
            this.tableAdapterManager.tblStandardsTableAdapter = null;
            this.tableAdapterManager.tblStatusTableAdapter = null;
            this.tableAdapterManager.tblSubstationTableAdapter = null;
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = null;
            this.tableAdapterManager.tblWindingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "TestNumber", true));
            this.testNumberTextBox.Location = new System.Drawing.Point(143, 42);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.testNumberTextBox.TabIndex = 59;
            // 
            // standardComboBox
            // 
            this.standardComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "standard", true));
            this.standardComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblDielectricBindingSource, "standard", true));
            this.standardComboBox.DataSource = this.tblStandardsBindingSource;
            this.standardComboBox.DisplayMember = "standards";
            this.standardComboBox.FormattingEnabled = true;
            this.standardComboBox.Location = new System.Drawing.Point(407, 41);
            this.standardComboBox.Name = "standardComboBox";
            this.standardComboBox.Size = new System.Drawing.Size(121, 21);
            this.standardComboBox.TabIndex = 60;
            this.standardComboBox.ValueMember = "standards";
            // 
            // tblStandardsBindingSource
            // 
            this.tblStandardsBindingSource.DataMember = "tblStandards";
            this.tblStandardsBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblDielectricBindingSource, "status", true));
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblDielectricBindingSource, "status", true));
            this.statusComboBox.DataSource = this.tblStatusBindingSource;
            this.statusComboBox.DisplayMember = "status";
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(407, 68);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 61;
            this.statusComboBox.ValueMember = "status";
            // 
            // tblStatusBindingSource
            // 
            this.tblStatusBindingSource.DataMember = "tblStatus";
            this.tblStatusBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // tblStandardsTableAdapter
            // 
            this.tblStandardsTableAdapter.ClearBeforeFill = true;
            // 
            // tblStatusTableAdapter
            // 
            this.tblStatusTableAdapter.ClearBeforeFill = true;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(386, 345);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(160, 36);
            this.btnCompute.TabIndex = 84;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // frmOilBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 465);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtOLTCAssess);
            this.Controls.Add(this.txtMainAssess);
            this.Controls.Add(this.label14);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(standardLabel);
            this.Controls.Add(this.standardComboBox);
            this.Controls.Add(testNumberLabel);
            this.Controls.Add(this.oltcAveTextBox);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAssess);
            this.Controls.Add(this.grpOLTC);
            this.Controls.Add(this.mainAveTextBox);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOilBD";
            this.Text = "frmOilBD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOilBD_Load);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDielectricBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            this.grpOLTC.ResumeLayout(false);
            this.grpOLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStandardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStatusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpOLTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAssess;
        private System.Windows.Forms.TextBox txtMainAssess;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOLTCAssess;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblDielectricBindingSource;
        private dtbPTASDataSetTableAdapters.tblDielectricTableAdapter tblDielectricTableAdapter;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox main1TextBox;
        private System.Windows.Forms.TextBox main2TextBox;
        private System.Windows.Forms.TextBox main3TextBox;
        private System.Windows.Forms.TextBox mainAveTextBox;
        private System.Windows.Forms.TextBox main4TextBox;
        private System.Windows.Forms.TextBox main5TextBox;
        private System.Windows.Forms.TextBox oltcAveTextBox;
        private System.Windows.Forms.TextBox oltc1TextBox;
        private System.Windows.Forms.TextBox oltc5TextBox;
        private System.Windows.Forms.TextBox oltc4TextBox;
        private System.Windows.Forms.TextBox oltc2TextBox;
        private System.Windows.Forms.TextBox oltc3TextBox;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.ComboBox standardComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.BindingSource tblStandardsBindingSource;
        private dtbPTASDataSetTableAdapters.tblStandardsTableAdapter tblStandardsTableAdapter;
        private System.Windows.Forms.BindingSource tblStatusBindingSource;
        private dtbPTASDataSetTableAdapters.tblStatusTableAdapter tblStatusTableAdapter;
        private System.Windows.Forms.Button btnCompute;
    }
}