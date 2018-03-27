﻿namespace PTAS
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tblTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSub = new System.Windows.Forms.ComboBox();
            this.tblSubstationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboXf = new System.Windows.Forms.ComboBox();
            this.tblTransformerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.testDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testEngrTextBox = new System.Windows.Forms.TextBox();
            this.testWeatherTextBox = new System.Windows.Forms.TextBox();
            this.testAmbientTextBox = new System.Windows.Forms.TextBox();
            this.testOilTextBox = new System.Windows.Forms.TextBox();
            this.testPrimWTTextBox = new System.Windows.Forms.TextBox();
            this.testSecWTTextBox = new System.Windows.Forms.TextBox();
            this.testTertWTTextBox = new System.Windows.Forms.TextBox();
            this.chkExcite = new System.Windows.Forms.CheckBox();
            this.chkIPF = new System.Windows.Forms.CheckBox();
            this.chkBushing = new System.Windows.Forms.CheckBox();
            this.chkTTR = new System.Windows.Forms.CheckBox();
            this.chkDCWR = new System.Windows.Forms.CheckBox();
            this.chkDielectric = new System.Windows.Forms.CheckBox();
            this.chkOilPF = new System.Windows.Forms.CheckBox();
            this.tblTestTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblTestTableAdapter();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            this.tblTransformerTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblTransformerTableAdapter();
            this.tblSubstationTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblSubstationTableAdapter();
            this.tbcTest = new System.Windows.Forms.TabControl();
            this.tabExcite = new System.Windows.Forms.TabPage();
            this.tabIPF = new System.Windows.Forms.TabPage();
            this.tabBushing = new System.Windows.Forms.TabPage();
            this.tabTTR = new System.Windows.Forms.TabPage();
            this.tabWinding = new System.Windows.Forms.TabPage();
            this.tabOilBD = new System.Windows.Forms.TabPage();
            this.tabOilPF = new System.Windows.Forms.TabPage();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubstationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerBindingSource)).BeginInit();
            this.tbcTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerAccountToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // registerAccountToolStripMenuItem
            // 
            this.registerAccountToolStripMenuItem.Name = "registerAccountToolStripMenuItem";
            this.registerAccountToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.registerAccountToolStripMenuItem.Text = "Register Account";
            this.registerAccountToolStripMenuItem.Click += new System.EventHandler(this.registerAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewGraphToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transformerToolStripMenuItem,
            this.substationToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addToolStripMenuItem.Text = "Add/Update";
            // 
            // transformerToolStripMenuItem
            // 
            this.transformerToolStripMenuItem.Name = "transformerToolStripMenuItem";
            this.transformerToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.transformerToolStripMenuItem.Text = "Transformer";
            this.transformerToolStripMenuItem.Click += new System.EventHandler(this.transformerToolStripMenuItem_Click);
            // 
            // substationToolStripMenuItem
            // 
            this.substationToolStripMenuItem.Name = "substationToolStripMenuItem";
            this.substationToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.substationToolStripMenuItem.Text = "Substation";
            this.substationToolStripMenuItem.Click += new System.EventHandler(this.substationToolStripMenuItem_Click);
            // 
            // viewGraphToolStripMenuItem
            // 
            this.viewGraphToolStripMenuItem.Name = "viewGraphToolStripMenuItem";
            this.viewGraphToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.viewGraphToolStripMenuItem.Text = "View Graph";
            this.viewGraphToolStripMenuItem.Click += new System.EventHandler(this.viewGraphToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test Engineer (Initial)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Weather Condition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Secondary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Primary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Winding Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Oil Temperature";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tertiary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Transformer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "TESTS CONDUCTED";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "TEST NUMBER";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 31);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(130, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 31);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 31);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(25, 409);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(79, 31);
            this.btnPrev.TabIndex = 36;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(235, 409);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 31);
            this.btnNext.TabIndex = 37;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tblTestBindingSource
            // 
            this.tblTestBindingSource.DataMember = "tblTest";
            this.tblTestBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ambient Temperature";
            // 
            // cboSub
            // 
            this.cboSub.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblTestBindingSource, "testSub", true));
            this.cboSub.DataSource = this.tblSubstationBindingSource;
            this.cboSub.FormattingEnabled = true;
            this.cboSub.Location = new System.Drawing.Point(167, 101);
            this.cboSub.Name = "cboSub";
            this.cboSub.Size = new System.Drawing.Size(95, 21);
            this.cboSub.TabIndex = 56;
            this.cboSub.SelectedIndexChanged += new System.EventHandler(this.cboSub_SelectedIndexChanged);
            // 
            // tblSubstationBindingSource
            // 
            this.tblSubstationBindingSource.DataMember = "tblSubstation";
            this.tblSubstationBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // cboXf
            // 
            this.cboXf.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblTestBindingSource, "testXformer", true));
            this.cboXf.DataSource = this.tblTransformerBindingSource;
            this.cboXf.FormattingEnabled = true;
            this.cboXf.Location = new System.Drawing.Point(268, 101);
            this.cboXf.Name = "cboXf";
            this.cboXf.Size = new System.Drawing.Size(99, 21);
            this.cboXf.TabIndex = 57;
            // 
            // tblTransformerBindingSource
            // 
            this.tblTransformerBindingSource.DataMember = "tblTransformer";
            this.tblTransformerBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "TestNumber", true));
            this.testNumberTextBox.Location = new System.Drawing.Point(167, 75);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.testNumberTextBox.TabIndex = 131;
            // 
            // testDateDateTimePicker
            // 
            this.testDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblTestBindingSource, "testDate", true));
            this.testDateDateTimePicker.Location = new System.Drawing.Point(167, 127);
            this.testDateDateTimePicker.Name = "testDateDateTimePicker";
            this.testDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.testDateDateTimePicker.TabIndex = 133;
            // 
            // testEngrTextBox
            // 
            this.testEngrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "testEngr", true));
            this.testEngrTextBox.Location = new System.Drawing.Point(167, 153);
            this.testEngrTextBox.Name = "testEngrTextBox";
            this.testEngrTextBox.Size = new System.Drawing.Size(200, 20);
            this.testEngrTextBox.TabIndex = 135;
            // 
            // testWeatherTextBox
            // 
            this.testWeatherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "testWeather", true));
            this.testWeatherTextBox.Location = new System.Drawing.Point(167, 179);
            this.testWeatherTextBox.Name = "testWeatherTextBox";
            this.testWeatherTextBox.Size = new System.Drawing.Size(200, 20);
            this.testWeatherTextBox.TabIndex = 137;
            // 
            // testAmbientTextBox
            // 
            this.testAmbientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "testAmbient", true));
            this.testAmbientTextBox.Location = new System.Drawing.Point(167, 205);
            this.testAmbientTextBox.Name = "testAmbientTextBox";
            this.testAmbientTextBox.Size = new System.Drawing.Size(200, 20);
            this.testAmbientTextBox.TabIndex = 139;
            // 
            // testOilTextBox
            // 
            this.testOilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "testOil", true));
            this.testOilTextBox.Location = new System.Drawing.Point(167, 231);
            this.testOilTextBox.Name = "testOilTextBox";
            this.testOilTextBox.Size = new System.Drawing.Size(200, 20);
            this.testOilTextBox.TabIndex = 141;
            // 
            // testPrimWTTextBox
            // 
            this.testPrimWTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "testPrimWT", true));
            this.testPrimWTTextBox.Location = new System.Drawing.Point(167, 283);
            this.testPrimWTTextBox.Name = "testPrimWTTextBox";
            this.testPrimWTTextBox.Size = new System.Drawing.Size(200, 20);
            this.testPrimWTTextBox.TabIndex = 143;
            // 
            // testSecWTTextBox
            // 
            this.testSecWTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "testSecWT", true));
            this.testSecWTTextBox.Location = new System.Drawing.Point(167, 309);
            this.testSecWTTextBox.Name = "testSecWTTextBox";
            this.testSecWTTextBox.Size = new System.Drawing.Size(200, 20);
            this.testSecWTTextBox.TabIndex = 145;
            // 
            // testTertWTTextBox
            // 
            this.testTertWTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTestBindingSource, "testTertWT", true));
            this.testTertWTTextBox.Location = new System.Drawing.Point(167, 335);
            this.testTertWTTextBox.Name = "testTertWTTextBox";
            this.testTertWTTextBox.Size = new System.Drawing.Size(200, 20);
            this.testTertWTTextBox.TabIndex = 147;
            // 
            // chkExcite
            // 
            this.chkExcite.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTestBindingSource, "testExcite", true));
            this.chkExcite.Location = new System.Drawing.Point(42, 531);
            this.chkExcite.Name = "chkExcite";
            this.chkExcite.Size = new System.Drawing.Size(200, 24);
            this.chkExcite.TabIndex = 153;
            this.chkExcite.Text = "Excitation Current";
            this.chkExcite.UseVisualStyleBackColor = true;
            // 
            // chkIPF
            // 
            this.chkIPF.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTestBindingSource, "testIPF", true));
            this.chkIPF.Location = new System.Drawing.Point(42, 561);
            this.chkIPF.Name = "chkIPF";
            this.chkIPF.Size = new System.Drawing.Size(200, 24);
            this.chkIPF.TabIndex = 155;
            this.chkIPF.Text = "Overall Insulation Power Factor";
            this.chkIPF.UseVisualStyleBackColor = true;
            // 
            // chkBushing
            // 
            this.chkBushing.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTestBindingSource, "testBushing", true));
            this.chkBushing.Location = new System.Drawing.Point(42, 591);
            this.chkBushing.Name = "chkBushing";
            this.chkBushing.Size = new System.Drawing.Size(200, 24);
            this.chkBushing.TabIndex = 157;
            this.chkBushing.Text = "Bushing C1/C2 Capacitance";
            this.chkBushing.UseVisualStyleBackColor = true;
            // 
            // chkTTR
            // 
            this.chkTTR.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTestBindingSource, "testTTR", true));
            this.chkTTR.Location = new System.Drawing.Point(42, 621);
            this.chkTTR.Name = "chkTTR";
            this.chkTTR.Size = new System.Drawing.Size(200, 24);
            this.chkTTR.TabIndex = 159;
            this.chkTTR.Text = "Transformer Turns Ratio";
            this.chkTTR.UseVisualStyleBackColor = true;
            // 
            // chkDCWR
            // 
            this.chkDCWR.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTestBindingSource, "testDCWR", true));
            this.chkDCWR.Location = new System.Drawing.Point(42, 651);
            this.chkDCWR.Name = "chkDCWR";
            this.chkDCWR.Size = new System.Drawing.Size(200, 24);
            this.chkDCWR.TabIndex = 161;
            this.chkDCWR.Text = "DC Winding Resistance";
            this.chkDCWR.UseVisualStyleBackColor = true;
            // 
            // chkDielectric
            // 
            this.chkDielectric.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTestBindingSource, "testOilBD", true));
            this.chkDielectric.Location = new System.Drawing.Point(42, 681);
            this.chkDielectric.Name = "chkDielectric";
            this.chkDielectric.Size = new System.Drawing.Size(200, 24);
            this.chkDielectric.TabIndex = 163;
            this.chkDielectric.Text = "Oil Dielectric Breakdown Strength";
            this.chkDielectric.UseVisualStyleBackColor = true;
            // 
            // chkOilPF
            // 
            this.chkOilPF.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblTestBindingSource, "testOilPF", true));
            this.chkOilPF.Location = new System.Drawing.Point(42, 711);
            this.chkOilPF.Name = "chkOilPF";
            this.chkOilPF.Size = new System.Drawing.Size(200, 24);
            this.chkOilPF.TabIndex = 165;
            this.chkOilPF.Text = "Oil Power Factor";
            this.chkOilPF.UseVisualStyleBackColor = true;
            // 
            // tblTestTableAdapter
            // 
            this.tblTestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBushingTableAdapter = null;
            this.tableAdapterManager.tblDielectricTableAdapter = null;
            this.tableAdapterManager.tblExcitationTableAdapter = null;
            this.tableAdapterManager.tblIPFTableAdapter = null;
            this.tableAdapterManager.tblOilPFTableAdapter = null;
            this.tableAdapterManager.tblParamListTableAdapter = null;
            this.tableAdapterManager.tblSecurityTableAdapter = null;
            this.tableAdapterManager.tblStandardsTableAdapter = null;
            this.tableAdapterManager.tblStatusTableAdapter = null;
            this.tableAdapterManager.tblSubstationTableAdapter = null;
            this.tableAdapterManager.tblTestListTableAdapter = null;
            this.tableAdapterManager.tblTestTableAdapter = this.tblTestTableAdapter;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = null;
            this.tableAdapterManager.tblWindingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblTransformerTableAdapter
            // 
            this.tblTransformerTableAdapter.ClearBeforeFill = true;
            // 
            // tblSubstationTableAdapter
            // 
            this.tblSubstationTableAdapter.ClearBeforeFill = true;
            // 
            // tbcTest
            // 
            this.tbcTest.Controls.Add(this.tabExcite);
            this.tbcTest.Controls.Add(this.tabIPF);
            this.tbcTest.Controls.Add(this.tabBushing);
            this.tbcTest.Controls.Add(this.tabTTR);
            this.tbcTest.Controls.Add(this.tabWinding);
            this.tbcTest.Controls.Add(this.tabOilBD);
            this.tbcTest.Controls.Add(this.tabOilPF);
            this.tbcTest.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbcTest.Location = new System.Drawing.Point(442, 24);
            this.tbcTest.Name = "tbcTest";
            this.tbcTest.SelectedIndex = 0;
            this.tbcTest.Size = new System.Drawing.Size(928, 725);
            this.tbcTest.TabIndex = 93;
            // 
            // tabExcite
            // 
            this.tabExcite.Location = new System.Drawing.Point(4, 22);
            this.tabExcite.Name = "tabExcite";
            this.tabExcite.Padding = new System.Windows.Forms.Padding(3);
            this.tabExcite.Size = new System.Drawing.Size(920, 699);
            this.tabExcite.TabIndex = 0;
            this.tabExcite.Text = "Excitation Current";
            this.tabExcite.UseVisualStyleBackColor = true;
            // 
            // tabIPF
            // 
            this.tabIPF.Location = new System.Drawing.Point(4, 22);
            this.tabIPF.Name = "tabIPF";
            this.tabIPF.Size = new System.Drawing.Size(920, 699);
            this.tabIPF.TabIndex = 1;
            this.tabIPF.Text = "Insulation Power Factor";
            this.tabIPF.UseVisualStyleBackColor = true;
            // 
            // tabBushing
            // 
            this.tabBushing.Location = new System.Drawing.Point(4, 22);
            this.tabBushing.Name = "tabBushing";
            this.tabBushing.Size = new System.Drawing.Size(920, 699);
            this.tabBushing.TabIndex = 2;
            this.tabBushing.Text = "Bushing C1/C2 Capacitance";
            this.tabBushing.UseVisualStyleBackColor = true;
            // 
            // tabTTR
            // 
            this.tabTTR.Location = new System.Drawing.Point(4, 22);
            this.tabTTR.Name = "tabTTR";
            this.tabTTR.Size = new System.Drawing.Size(920, 699);
            this.tabTTR.TabIndex = 3;
            this.tabTTR.Text = "Transformer Turns Ratio";
            this.tabTTR.UseVisualStyleBackColor = true;
            // 
            // tabWinding
            // 
            this.tabWinding.Location = new System.Drawing.Point(4, 22);
            this.tabWinding.Name = "tabWinding";
            this.tabWinding.Size = new System.Drawing.Size(920, 699);
            this.tabWinding.TabIndex = 4;
            this.tabWinding.Text = "DC Winding Resistance";
            this.tabWinding.UseVisualStyleBackColor = true;
            // 
            // tabOilBD
            // 
            this.tabOilBD.Location = new System.Drawing.Point(4, 22);
            this.tabOilBD.Name = "tabOilBD";
            this.tabOilBD.Size = new System.Drawing.Size(920, 699);
            this.tabOilBD.TabIndex = 5;
            this.tabOilBD.Text = "Oil Dielectric Breakdown Strength";
            this.tabOilBD.UseVisualStyleBackColor = true;
            // 
            // tabOilPF
            // 
            this.tabOilPF.Location = new System.Drawing.Point(4, 22);
            this.tabOilPF.Name = "tabOilPF";
            this.tabOilPF.Size = new System.Drawing.Size(920, 699);
            this.tabOilPF.TabIndex = 6;
            this.tabOilPF.Text = "Oil Power Factor";
            this.tabOilPF.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(235, 446);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(79, 31);
            this.btnLast.TabIndex = 167;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(25, 446);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(79, 31);
            this.btnFirst.TabIndex = 166;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(130, 409);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(79, 31);
            this.btnReport.TabIndex = 168;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.testDateDateTimePicker);
            this.Controls.Add(this.testEngrTextBox);
            this.Controls.Add(this.testWeatherTextBox);
            this.Controls.Add(this.testAmbientTextBox);
            this.Controls.Add(this.testOilTextBox);
            this.Controls.Add(this.testPrimWTTextBox);
            this.Controls.Add(this.testSecWTTextBox);
            this.Controls.Add(this.testTertWTTextBox);
            this.Controls.Add(this.chkExcite);
            this.Controls.Add(this.chkIPF);
            this.Controls.Add(this.chkBushing);
            this.Controls.Add(this.chkTTR);
            this.Controls.Add(this.chkDCWR);
            this.Controls.Add(this.chkDielectric);
            this.Controls.Add(this.chkOilPF);
            this.Controls.Add(this.tbcTest);
            this.Controls.Add(this.cboXf);
            this.Controls.Add(this.cboSub);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "PTAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubstationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerBindingSource)).EndInit();
            this.tbcTest.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSub;
        private System.Windows.Forms.ComboBox cboXf;
        private System.Windows.Forms.ToolStripMenuItem registerAccountToolStripMenuItem;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblTestBindingSource;
        private dtbPTASDataSetTableAdapters.tblTestTableAdapter tblTestTableAdapter;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.DateTimePicker testDateDateTimePicker;
        private System.Windows.Forms.TextBox testEngrTextBox;
        private System.Windows.Forms.TextBox testWeatherTextBox;
        private System.Windows.Forms.TextBox testAmbientTextBox;
        private System.Windows.Forms.TextBox testOilTextBox;
        private System.Windows.Forms.TextBox testPrimWTTextBox;
        private System.Windows.Forms.TextBox testSecWTTextBox;
        private System.Windows.Forms.TextBox testTertWTTextBox;
        private System.Windows.Forms.CheckBox chkExcite;
        private System.Windows.Forms.CheckBox chkIPF;
        private System.Windows.Forms.CheckBox chkBushing;
        private System.Windows.Forms.CheckBox chkTTR;
        private System.Windows.Forms.CheckBox chkDCWR;
        private System.Windows.Forms.CheckBox chkDielectric;
        private System.Windows.Forms.CheckBox chkOilPF;
        private System.Windows.Forms.BindingSource tblTransformerBindingSource;
        private dtbPTASDataSetTableAdapters.tblTransformerTableAdapter tblTransformerTableAdapter;
        private System.Windows.Forms.BindingSource tblSubstationBindingSource;
        private dtbPTASDataSetTableAdapters.tblSubstationTableAdapter tblSubstationTableAdapter;
        private System.Windows.Forms.TabControl tbcTest;
        private System.Windows.Forms.TabPage tabExcite;
        private System.Windows.Forms.TabPage tabIPF;
        private System.Windows.Forms.TabPage tabBushing;
        private System.Windows.Forms.TabPage tabTTR;
        private System.Windows.Forms.TabPage tabWinding;
        private System.Windows.Forms.TabPage tabOilBD;
        private System.Windows.Forms.TabPage tabOilPF;
        private System.Windows.Forms.ToolStripMenuItem viewGraphToolStripMenuItem;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnReport;
    }
}