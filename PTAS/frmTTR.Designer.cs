namespace PTAS
{
    partial class frmTTR
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
            this.label13 = new System.Windows.Forms.Label();
            this.ttrTapTextBox = new System.Windows.Forms.TextBox();
            this.tblTTRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.ttrHVTextBox = new System.Windows.Forms.TextBox();
            this.ttrRHVLVTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ttrRHVTVTextBox = new System.Windows.Forms.TextBox();
            this.ttrLVTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttrTVTextBox = new System.Windows.Forms.TextBox();
            this.grpMeasured = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ttrAHVLVTextBox = new System.Windows.Forms.TextBox();
            this.ttrCHVTVTextBox = new System.Windows.Forms.TextBox();
            this.ttrBHVTVTextBox = new System.Windows.Forms.TextBox();
            this.ttrAHVTVTextBox = new System.Windows.Forms.TextBox();
            this.ttrBHVLVTextBox = new System.Windows.Forms.TextBox();
            this.ttrCHVLVTextBox = new System.Windows.Forms.TextBox();
            this.grpError = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ttrAHVLVeTextBox = new System.Windows.Forms.TextBox();
            this.ttrCHVTVeTextBox = new System.Windows.Forms.TextBox();
            this.ttrBHVTVeTextBox = new System.Windows.Forms.TextBox();
            this.ttrAHVTVeTextBox = new System.Windows.Forms.TextBox();
            this.ttrCHVLVeTextBox = new System.Windows.Forms.TextBox();
            this.ttrBHVLVeTextBox = new System.Windows.Forms.TextBox();
            this.txtAssess = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAssess = new System.Windows.Forms.Button();
            this.tblTTRTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblTTRTableAdapter();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            testNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTTRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            this.grpMeasured.SuspendLayout();
            this.grpError.SuspendLayout();
            this.SuspendLayout();
            // 
            // testNumberLabel
            // 
            testNumberLabel.AutoSize = true;
            testNumberLabel.Location = new System.Drawing.Point(45, 33);
            testNumberLabel.Name = "testNumberLabel";
            testNumberLabel.Size = new System.Drawing.Size(71, 13);
            testNumberLabel.TabIndex = 50;
            testNumberLabel.Text = "Test Number:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ttrTapTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ttrHVTextBox);
            this.groupBox1.Controls.Add(this.ttrRHVLVTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ttrRHVTVTextBox);
            this.groupBox1.Controls.Add(this.ttrLVTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ttrTVTextBox);
            this.groupBox1.Location = new System.Drawing.Point(82, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preliminary Calculations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "HV/LV Ratio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "TAP POSITION";
            // 
            // ttrTapTextBox
            // 
            this.ttrTapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrTap", true));
            this.ttrTapTextBox.Location = new System.Drawing.Point(182, 25);
            this.ttrTapTextBox.Name = "ttrTapTextBox";
            this.ttrTapTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrTapTextBox.TabIndex = 53;
            // 
            // tblTTRBindingSource
            // 
            this.tblTTRBindingSource.DataMember = "tblTTR";
            this.tblTTRBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "High Voltage";
            // 
            // ttrHVTextBox
            // 
            this.ttrHVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrHV", true));
            this.ttrHVTextBox.Location = new System.Drawing.Point(182, 51);
            this.ttrHVTextBox.Name = "ttrHVTextBox";
            this.ttrHVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrHVTextBox.TabIndex = 55;
            // 
            // ttrRHVLVTextBox
            // 
            this.ttrRHVLVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrRHVLV", true));
            this.ttrRHVLVTextBox.Location = new System.Drawing.Point(424, 51);
            this.ttrRHVLVTextBox.Name = "ttrRHVLVTextBox";
            this.ttrRHVLVTextBox.ReadOnly = true;
            this.ttrRHVLVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrRHVLVTextBox.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "HV/TV Ratio";
            // 
            // ttrRHVTVTextBox
            // 
            this.ttrRHVTVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrRHVTV", true));
            this.ttrRHVTVTextBox.Location = new System.Drawing.Point(424, 77);
            this.ttrRHVTVTextBox.Name = "ttrRHVTVTextBox";
            this.ttrRHVTVTextBox.ReadOnly = true;
            this.ttrRHVTVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrRHVTVTextBox.TabIndex = 63;
            // 
            // ttrLVTextBox
            // 
            this.ttrLVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrLV", true));
            this.ttrLVTextBox.Location = new System.Drawing.Point(182, 77);
            this.ttrLVTextBox.Name = "ttrLVTextBox";
            this.ttrLVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrLVTextBox.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Low Voltage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tertiary Voltage";
            // 
            // ttrTVTextBox
            // 
            this.ttrTVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrTV", true));
            this.ttrTVTextBox.Location = new System.Drawing.Point(182, 103);
            this.ttrTVTextBox.Name = "ttrTVTextBox";
            this.ttrTVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrTVTextBox.TabIndex = 59;
            // 
            // grpMeasured
            // 
            this.grpMeasured.Controls.Add(this.label9);
            this.grpMeasured.Controls.Add(this.label11);
            this.grpMeasured.Controls.Add(this.label5);
            this.grpMeasured.Controls.Add(this.label6);
            this.grpMeasured.Controls.Add(this.label8);
            this.grpMeasured.Controls.Add(this.label7);
            this.grpMeasured.Controls.Add(this.ttrAHVLVTextBox);
            this.grpMeasured.Controls.Add(this.ttrCHVTVTextBox);
            this.grpMeasured.Controls.Add(this.ttrBHVTVTextBox);
            this.grpMeasured.Controls.Add(this.ttrAHVTVTextBox);
            this.grpMeasured.Controls.Add(this.ttrBHVLVTextBox);
            this.grpMeasured.Controls.Add(this.ttrCHVLVTextBox);
            this.grpMeasured.Location = new System.Drawing.Point(104, 230);
            this.grpMeasured.Name = "grpMeasured";
            this.grpMeasured.Size = new System.Drawing.Size(242, 241);
            this.grpMeasured.TabIndex = 1;
            this.grpMeasured.TabStop = false;
            this.grpMeasured.Text = "Ratio Measured";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Primary / Tertiary C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Primary / Tertiary B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Primary / Secondary A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Primary / Secondary B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Primary / Tertiary A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Primary / Secondary C";
            // 
            // ttrAHVLVTextBox
            // 
            this.ttrAHVLVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrAHVLV", true));
            this.ttrAHVLVTextBox.Location = new System.Drawing.Point(144, 46);
            this.ttrAHVLVTextBox.Name = "ttrAHVLVTextBox";
            this.ttrAHVLVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrAHVLVTextBox.TabIndex = 0;
            // 
            // ttrCHVTVTextBox
            // 
            this.ttrCHVTVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrCHVTV", true));
            this.ttrCHVTVTextBox.Location = new System.Drawing.Point(144, 176);
            this.ttrCHVTVTextBox.Name = "ttrCHVTVTextBox";
            this.ttrCHVTVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrCHVTVTextBox.TabIndex = 5;
            // 
            // ttrBHVTVTextBox
            // 
            this.ttrBHVTVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrBHVTV", true));
            this.ttrBHVTVTextBox.Location = new System.Drawing.Point(144, 150);
            this.ttrBHVTVTextBox.Name = "ttrBHVTVTextBox";
            this.ttrBHVTVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrBHVTVTextBox.TabIndex = 4;
            // 
            // ttrAHVTVTextBox
            // 
            this.ttrAHVTVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrAHVTV", true));
            this.ttrAHVTVTextBox.Location = new System.Drawing.Point(144, 124);
            this.ttrAHVTVTextBox.Name = "ttrAHVTVTextBox";
            this.ttrAHVTVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrAHVTVTextBox.TabIndex = 3;
            // 
            // ttrBHVLVTextBox
            // 
            this.ttrBHVLVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrBHVLV", true));
            this.ttrBHVLVTextBox.Location = new System.Drawing.Point(144, 72);
            this.ttrBHVLVTextBox.Name = "ttrBHVLVTextBox";
            this.ttrBHVLVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrBHVLVTextBox.TabIndex = 1;
            // 
            // ttrCHVLVTextBox
            // 
            this.ttrCHVLVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrCHVLV", true));
            this.ttrCHVLVTextBox.Location = new System.Drawing.Point(144, 98);
            this.ttrCHVLVTextBox.Name = "ttrCHVLVTextBox";
            this.ttrCHVLVTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrCHVLVTextBox.TabIndex = 2;
            // 
            // grpError
            // 
            this.grpError.Controls.Add(this.label20);
            this.grpError.Controls.Add(this.label21);
            this.grpError.Controls.Add(this.label22);
            this.grpError.Controls.Add(this.label23);
            this.grpError.Controls.Add(this.label24);
            this.grpError.Controls.Add(this.label25);
            this.grpError.Controls.Add(this.ttrAHVLVeTextBox);
            this.grpError.Controls.Add(this.ttrCHVTVeTextBox);
            this.grpError.Controls.Add(this.ttrBHVTVeTextBox);
            this.grpError.Controls.Add(this.ttrAHVTVeTextBox);
            this.grpError.Controls.Add(this.ttrCHVLVeTextBox);
            this.grpError.Controls.Add(this.ttrBHVLVeTextBox);
            this.grpError.Location = new System.Drawing.Point(375, 230);
            this.grpError.Name = "grpError";
            this.grpError.Size = new System.Drawing.Size(242, 241);
            this.grpError.TabIndex = 46;
            this.grpError.TabStop = false;
            this.grpError.Text = "% Error Computed";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 13);
            this.label20.TabIndex = 51;
            this.label20.Text = "Primary / Tertiary C";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Primary / Tertiary B";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 45);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Primary / Secondary A";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 13);
            this.label23.TabIndex = 47;
            this.label23.Text = "Primary / Secondary B";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 123);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Primary / Tertiary A";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 13);
            this.label25.TabIndex = 48;
            this.label25.Text = "Primary / Secondary C";
            // 
            // ttrAHVLVeTextBox
            // 
            this.ttrAHVLVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrAHVLVe", true));
            this.ttrAHVLVeTextBox.Location = new System.Drawing.Point(149, 46);
            this.ttrAHVLVeTextBox.Name = "ttrAHVLVeTextBox";
            this.ttrAHVLVeTextBox.ReadOnly = true;
            this.ttrAHVLVeTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrAHVLVeTextBox.TabIndex = 0;
            // 
            // ttrCHVTVeTextBox
            // 
            this.ttrCHVTVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrCHVTVe", true));
            this.ttrCHVTVeTextBox.Location = new System.Drawing.Point(149, 176);
            this.ttrCHVTVeTextBox.Name = "ttrCHVTVeTextBox";
            this.ttrCHVTVeTextBox.ReadOnly = true;
            this.ttrCHVTVeTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrCHVTVeTextBox.TabIndex = 5;
            // 
            // ttrBHVTVeTextBox
            // 
            this.ttrBHVTVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrBHVTVe", true));
            this.ttrBHVTVeTextBox.Location = new System.Drawing.Point(149, 150);
            this.ttrBHVTVeTextBox.Name = "ttrBHVTVeTextBox";
            this.ttrBHVTVeTextBox.ReadOnly = true;
            this.ttrBHVTVeTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrBHVTVeTextBox.TabIndex = 4;
            // 
            // ttrAHVTVeTextBox
            // 
            this.ttrAHVTVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrAHVTVe", true));
            this.ttrAHVTVeTextBox.Location = new System.Drawing.Point(149, 124);
            this.ttrAHVTVeTextBox.Name = "ttrAHVTVeTextBox";
            this.ttrAHVTVeTextBox.ReadOnly = true;
            this.ttrAHVTVeTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrAHVTVeTextBox.TabIndex = 3;
            // 
            // ttrCHVLVeTextBox
            // 
            this.ttrCHVLVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrCHVLVe", true));
            this.ttrCHVLVeTextBox.Location = new System.Drawing.Point(149, 98);
            this.ttrCHVLVeTextBox.Name = "ttrCHVLVeTextBox";
            this.ttrCHVLVeTextBox.ReadOnly = true;
            this.ttrCHVLVeTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrCHVLVeTextBox.TabIndex = 2;
            // 
            // ttrBHVLVeTextBox
            // 
            this.ttrBHVLVeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrBHVLVe", true));
            this.ttrBHVLVeTextBox.Location = new System.Drawing.Point(149, 72);
            this.ttrBHVLVeTextBox.Name = "ttrBHVLVeTextBox";
            this.ttrBHVLVeTextBox.ReadOnly = true;
            this.ttrBHVLVeTextBox.Size = new System.Drawing.Size(68, 20);
            this.ttrBHVLVeTextBox.TabIndex = 1;
            // 
            // txtAssess
            // 
            this.txtAssess.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "ttrAssess", true));
            this.txtAssess.Location = new System.Drawing.Point(449, 487);
            this.txtAssess.Name = "txtAssess";
            this.txtAssess.ReadOnly = true;
            this.txtAssess.Size = new System.Drawing.Size(168, 20);
            this.txtAssess.TabIndex = 47;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(350, 490);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "Assessment";
            // 
            // btnAssess
            // 
            this.btnAssess.Location = new System.Drawing.Point(481, 523);
            this.btnAssess.Name = "btnAssess";
            this.btnAssess.Size = new System.Drawing.Size(160, 36);
            this.btnAssess.TabIndex = 49;
            this.btnAssess.Text = "Assess";
            this.btnAssess.UseVisualStyleBackColor = true;
            this.btnAssess.Click += new System.EventHandler(this.btnAssess_Click);
            // 
            // tblTTRTableAdapter
            // 
            this.tblTTRTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = this.tblTTRTableAdapter;
            this.tableAdapterManager.tblWindingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTTRBindingSource, "TestNumber", true));
            this.testNumberTextBox.Location = new System.Drawing.Point(122, 30);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.testNumberTextBox.TabIndex = 51;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(81, 511);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 32);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 32);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 32);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(300, 511);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(67, 32);
            this.btnCompute.TabIndex = 55;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // frmTTR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 589);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(testNumberLabel);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.txtAssess);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnAssess);
            this.Controls.Add(this.grpError);
            this.Controls.Add(this.grpMeasured);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTTR";
            this.Text = "frmTTR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTTR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTTRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            this.grpMeasured.ResumeLayout(false);
            this.grpMeasured.PerformLayout();
            this.grpError.ResumeLayout(false);
            this.grpError.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMeasured;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpError;
        private System.Windows.Forms.TextBox txtAssess;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAssess;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblTTRBindingSource;
        private dtbPTASDataSetTableAdapters.tblTTRTableAdapter tblTTRTableAdapter;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ttrTapTextBox;
        private System.Windows.Forms.TextBox ttrHVTextBox;
        private System.Windows.Forms.TextBox ttrRHVLVTextBox;
        private System.Windows.Forms.TextBox ttrRHVTVTextBox;
        private System.Windows.Forms.TextBox ttrLVTextBox;
        private System.Windows.Forms.TextBox ttrTVTextBox;
        private System.Windows.Forms.TextBox ttrAHVLVTextBox;
        private System.Windows.Forms.TextBox ttrCHVTVTextBox;
        private System.Windows.Forms.TextBox ttrBHVTVTextBox;
        private System.Windows.Forms.TextBox ttrAHVTVTextBox;
        private System.Windows.Forms.TextBox ttrBHVLVTextBox;
        private System.Windows.Forms.TextBox ttrCHVLVTextBox;
        private System.Windows.Forms.TextBox ttrAHVLVeTextBox;
        private System.Windows.Forms.TextBox ttrCHVTVeTextBox;
        private System.Windows.Forms.TextBox ttrBHVTVeTextBox;
        private System.Windows.Forms.TextBox ttrAHVTVeTextBox;
        private System.Windows.Forms.TextBox ttrCHVLVeTextBox;
        private System.Windows.Forms.TextBox ttrBHVLVeTextBox;
        private System.Windows.Forms.TextBox testNumberTextBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCompute;
    }
}