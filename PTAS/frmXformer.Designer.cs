namespace PTAS
{
    partial class frmXformer
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
            System.Windows.Forms.Label xfIDLabel;
            System.Windows.Forms.Label xfSubIDLabel;
            System.Windows.Forms.Label xfMakeLabel;
            System.Windows.Forms.Label xfSerialLabel;
            System.Windows.Forms.Label xfClassLabel;
            System.Windows.Forms.Label xfCapLabel;
            System.Windows.Forms.Label xfDateLabel;
            System.Windows.Forms.Label xfPrimVoltLabel;
            System.Windows.Forms.Label xfSecVoltLabel;
            System.Windows.Forms.Label xfTertVoltLabel;
            System.Windows.Forms.Label xfPrimWLabel;
            System.Windows.Forms.Label xfPhaseLabel;
            System.Windows.Forms.Label xfImpedanceALabel;
            System.Windows.Forms.Label label1;
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblTransformerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tableAdapterManager = new PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager();
            this.tblSubstationTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblSubstationTableAdapter();
            this.xfIDTextBox = new System.Windows.Forms.TextBox();
            this.xfMakeTextBox = new System.Windows.Forms.TextBox();
            this.xfSerialTextBox = new System.Windows.Forms.TextBox();
            this.xfClassTextBox = new System.Windows.Forms.TextBox();
            this.xfCapTextBox = new System.Windows.Forms.TextBox();
            this.xfImpedanceATextBox = new System.Windows.Forms.TextBox();
            this.xfImpedanceBTextBox = new System.Windows.Forms.TextBox();
            this.xfImpedanceCTextBox = new System.Windows.Forms.TextBox();
            this.tblSubstationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.xfPrimVoltTextBox = new System.Windows.Forms.TextBox();
            this.xfSecVoltTextBox = new System.Windows.Forms.TextBox();
            this.xfTertVoltTextBox = new System.Windows.Forms.TextBox();
            this.xfPrimWTextBox = new System.Windows.Forms.TextBox();
            this.xfAutoTextBox = new System.Windows.Forms.TextBox();
            this.xfSecWTextBox = new System.Windows.Forms.TextBox();
            this.xfSecClockTextBox = new System.Windows.Forms.TextBox();
            this.xfPhaseTextBox = new System.Windows.Forms.TextBox();
            this.xfSubIDComboBox = new System.Windows.Forms.ComboBox();
            this.tblTransformerTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblTransformerTableAdapter();
            this.xfYearTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblTransformerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            xfIDLabel = new System.Windows.Forms.Label();
            xfSubIDLabel = new System.Windows.Forms.Label();
            xfMakeLabel = new System.Windows.Forms.Label();
            xfSerialLabel = new System.Windows.Forms.Label();
            xfClassLabel = new System.Windows.Forms.Label();
            xfCapLabel = new System.Windows.Forms.Label();
            xfDateLabel = new System.Windows.Forms.Label();
            xfPrimVoltLabel = new System.Windows.Forms.Label();
            xfSecVoltLabel = new System.Windows.Forms.Label();
            xfTertVoltLabel = new System.Windows.Forms.Label();
            xfPrimWLabel = new System.Windows.Forms.Label();
            xfPhaseLabel = new System.Windows.Forms.Label();
            xfImpedanceALabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubstationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // xfIDLabel
            // 
            xfIDLabel.AutoSize = true;
            xfIDLabel.Location = new System.Drawing.Point(67, 61);
            xfIDLabel.Name = "xfIDLabel";
            xfIDLabel.Size = new System.Drawing.Size(81, 13);
            xfIDLabel.TabIndex = 38;
            xfIDLabel.Text = "Transformer ID*";
            // 
            // xfSubIDLabel
            // 
            xfSubIDLabel.AutoSize = true;
            xfSubIDLabel.Location = new System.Drawing.Point(67, 87);
            xfSubIDLabel.Name = "xfSubIDLabel";
            xfSubIDLabel.Size = new System.Drawing.Size(61, 13);
            xfSubIDLabel.TabIndex = 40;
            xfSubIDLabel.Text = "Substation*";
            // 
            // xfMakeLabel
            // 
            xfMakeLabel.AutoSize = true;
            xfMakeLabel.Location = new System.Drawing.Point(67, 113);
            xfMakeLabel.Name = "xfMakeLabel";
            xfMakeLabel.Size = new System.Drawing.Size(38, 13);
            xfMakeLabel.TabIndex = 42;
            xfMakeLabel.Text = "Make*";
            // 
            // xfSerialLabel
            // 
            xfSerialLabel.AutoSize = true;
            xfSerialLabel.Location = new System.Drawing.Point(67, 139);
            xfSerialLabel.Name = "xfSerialLabel";
            xfSerialLabel.Size = new System.Drawing.Size(77, 13);
            xfSerialLabel.TabIndex = 44;
            xfSerialLabel.Text = "Serial Number*";
            // 
            // xfClassLabel
            // 
            xfClassLabel.AutoSize = true;
            xfClassLabel.Location = new System.Drawing.Point(67, 165);
            xfClassLabel.Name = "xfClassLabel";
            xfClassLabel.Size = new System.Drawing.Size(36, 13);
            xfClassLabel.TabIndex = 46;
            xfClassLabel.Text = "Class*";
            // 
            // xfCapLabel
            // 
            xfCapLabel.AutoSize = true;
            xfCapLabel.Location = new System.Drawing.Point(67, 191);
            xfCapLabel.Name = "xfCapLabel";
            xfCapLabel.Size = new System.Drawing.Size(95, 13);
            xfCapLabel.TabIndex = 48;
            xfCapLabel.Text = "Capacity (in MVA)*";
            // 
            // xfDateLabel
            // 
            xfDateLabel.AutoSize = true;
            xfDateLabel.Location = new System.Drawing.Point(67, 243);
            xfDateLabel.Name = "xfDateLabel";
            xfDateLabel.Size = new System.Drawing.Size(102, 13);
            xfDateLabel.TabIndex = 50;
            xfDateLabel.Text = "Year Manufactured*";
            // 
            // xfPrimVoltLabel
            // 
            xfPrimVoltLabel.AutoSize = true;
            xfPrimVoltLabel.Location = new System.Drawing.Point(90, 295);
            xfPrimVoltLabel.Name = "xfPrimVoltLabel";
            xfPrimVoltLabel.Size = new System.Drawing.Size(45, 13);
            xfPrimVoltLabel.TabIndex = 52;
            xfPrimVoltLabel.Text = "Primary*";
            // 
            // xfSecVoltLabel
            // 
            xfSecVoltLabel.AutoSize = true;
            xfSecVoltLabel.Location = new System.Drawing.Point(90, 321);
            xfSecVoltLabel.Name = "xfSecVoltLabel";
            xfSecVoltLabel.Size = new System.Drawing.Size(62, 13);
            xfSecVoltLabel.TabIndex = 54;
            xfSecVoltLabel.Text = "Secondary*";
            // 
            // xfTertVoltLabel
            // 
            xfTertVoltLabel.AutoSize = true;
            xfTertVoltLabel.Location = new System.Drawing.Point(90, 347);
            xfTertVoltLabel.Name = "xfTertVoltLabel";
            xfTertVoltLabel.Size = new System.Drawing.Size(42, 13);
            xfTertVoltLabel.TabIndex = 56;
            xfTertVoltLabel.Text = "Tertiary";
            // 
            // xfPrimWLabel
            // 
            xfPrimWLabel.AutoSize = true;
            xfPrimWLabel.Location = new System.Drawing.Point(68, 373);
            xfPrimWLabel.Name = "xfPrimWLabel";
            xfPrimWLabel.Size = new System.Drawing.Size(78, 13);
            xfPrimWLabel.TabIndex = 58;
            xfPrimWLabel.Text = "Vector Group**";
            // 
            // xfPhaseLabel
            // 
            xfPhaseLabel.AutoSize = true;
            xfPhaseLabel.Location = new System.Drawing.Point(67, 399);
            xfPhaseLabel.Name = "xfPhaseLabel";
            xfPhaseLabel.Size = new System.Drawing.Size(41, 13);
            xfPhaseLabel.TabIndex = 66;
            xfPhaseLabel.Text = "Phase*";
            // 
            // xfImpedanceALabel
            // 
            xfImpedanceALabel.AutoSize = true;
            xfImpedanceALabel.Location = new System.Drawing.Point(68, 217);
            xfImpedanceALabel.Name = "xfImpedanceALabel";
            xfImpedanceALabel.Size = new System.Drawing.Size(71, 13);
            xfImpedanceALabel.TabIndex = 68;
            xfImpedanceALabel.Text = "% Impedance";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(67, 269);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 75;
            label1.Text = "Voltage Level";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(423, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 33);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(423, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tblTransformerBindingSource
            // 
            this.tblTransformerBindingSource.DataMember = "tblTransformer";
            this.tblTransformerBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // dtbPTASDataSet
            // 
            this.dtbPTASDataSet.DataSetName = "dtbPTASDataSet";
            this.dtbPTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(423, 175);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(51, 33);
            this.btnPrev.TabIndex = 21;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(482, 175);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 33);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.tableAdapterManager.tblSubstationTableAdapter = this.tblSubstationTableAdapter;
            this.tableAdapterManager.tblTestListTableAdapter = null;
            this.tableAdapterManager.tblTestTableAdapter = null;
            this.tableAdapterManager.tblTransformerTableAdapter = null;
            this.tableAdapterManager.tblTTRTableAdapter = null;
            this.tableAdapterManager.tblWindingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PTAS.dtbPTASDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblSubstationTableAdapter
            // 
            this.tblSubstationTableAdapter.ClearBeforeFill = true;
            // 
            // xfIDTextBox
            // 
            this.xfIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfID", true));
            this.xfIDTextBox.Location = new System.Drawing.Point(200, 58);
            this.xfIDTextBox.Name = "xfIDTextBox";
            this.xfIDTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfIDTextBox.TabIndex = 0;
            // 
            // xfMakeTextBox
            // 
            this.xfMakeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfMake", true));
            this.xfMakeTextBox.Location = new System.Drawing.Point(200, 110);
            this.xfMakeTextBox.Name = "xfMakeTextBox";
            this.xfMakeTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfMakeTextBox.TabIndex = 2;
            // 
            // xfSerialTextBox
            // 
            this.xfSerialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfSerial", true));
            this.xfSerialTextBox.Location = new System.Drawing.Point(200, 136);
            this.xfSerialTextBox.Name = "xfSerialTextBox";
            this.xfSerialTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfSerialTextBox.TabIndex = 3;
            // 
            // xfClassTextBox
            // 
            this.xfClassTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfClass", true));
            this.xfClassTextBox.Location = new System.Drawing.Point(200, 162);
            this.xfClassTextBox.Name = "xfClassTextBox";
            this.xfClassTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfClassTextBox.TabIndex = 4;
            // 
            // xfCapTextBox
            // 
            this.xfCapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfCap", true));
            this.xfCapTextBox.Location = new System.Drawing.Point(200, 188);
            this.xfCapTextBox.Name = "xfCapTextBox";
            this.xfCapTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfCapTextBox.TabIndex = 5;
            // 
            // xfImpedanceATextBox
            // 
            this.xfImpedanceATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfImpedanceA", true));
            this.xfImpedanceATextBox.Location = new System.Drawing.Point(201, 214);
            this.xfImpedanceATextBox.Name = "xfImpedanceATextBox";
            this.xfImpedanceATextBox.Size = new System.Drawing.Size(47, 20);
            this.xfImpedanceATextBox.TabIndex = 6;
            // 
            // xfImpedanceBTextBox
            // 
            this.xfImpedanceBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfImpedanceB", true));
            this.xfImpedanceBTextBox.Location = new System.Drawing.Point(253, 214);
            this.xfImpedanceBTextBox.Name = "xfImpedanceBTextBox";
            this.xfImpedanceBTextBox.Size = new System.Drawing.Size(47, 20);
            this.xfImpedanceBTextBox.TabIndex = 7;
            // 
            // xfImpedanceCTextBox
            // 
            this.xfImpedanceCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfImpedanceC", true));
            this.xfImpedanceCTextBox.Location = new System.Drawing.Point(305, 214);
            this.xfImpedanceCTextBox.Name = "xfImpedanceCTextBox";
            this.xfImpedanceCTextBox.Size = new System.Drawing.Size(47, 20);
            this.xfImpedanceCTextBox.TabIndex = 8;
            // 
            // tblSubstationBindingSource
            // 
            this.tblSubstationBindingSource.DataMember = "tblSubstation";
            this.tblSubstationBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(423, 214);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 33);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // xfPrimVoltTextBox
            // 
            this.xfPrimVoltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfPrimVolt", true));
            this.xfPrimVoltTextBox.Location = new System.Drawing.Point(200, 292);
            this.xfPrimVoltTextBox.Name = "xfPrimVoltTextBox";
            this.xfPrimVoltTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfPrimVoltTextBox.TabIndex = 10;
            // 
            // xfSecVoltTextBox
            // 
            this.xfSecVoltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfSecVolt", true));
            this.xfSecVoltTextBox.Location = new System.Drawing.Point(200, 318);
            this.xfSecVoltTextBox.Name = "xfSecVoltTextBox";
            this.xfSecVoltTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfSecVoltTextBox.TabIndex = 11;
            // 
            // xfTertVoltTextBox
            // 
            this.xfTertVoltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfTertVolt", true));
            this.xfTertVoltTextBox.Location = new System.Drawing.Point(200, 344);
            this.xfTertVoltTextBox.Name = "xfTertVoltTextBox";
            this.xfTertVoltTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfTertVoltTextBox.TabIndex = 12;
            // 
            // xfPrimWTextBox
            // 
            this.xfPrimWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfPrimW", true));
            this.xfPrimWTextBox.Location = new System.Drawing.Point(200, 370);
            this.xfPrimWTextBox.Name = "xfPrimWTextBox";
            this.xfPrimWTextBox.Size = new System.Drawing.Size(31, 20);
            this.xfPrimWTextBox.TabIndex = 13;
            // 
            // xfAutoTextBox
            // 
            this.xfAutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfAuto", true));
            this.xfAutoTextBox.Location = new System.Drawing.Point(240, 370);
            this.xfAutoTextBox.Name = "xfAutoTextBox";
            this.xfAutoTextBox.Size = new System.Drawing.Size(31, 20);
            this.xfAutoTextBox.TabIndex = 14;
            // 
            // xfSecWTextBox
            // 
            this.xfSecWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfSecW", true));
            this.xfSecWTextBox.Location = new System.Drawing.Point(280, 370);
            this.xfSecWTextBox.Name = "xfSecWTextBox";
            this.xfSecWTextBox.Size = new System.Drawing.Size(31, 20);
            this.xfSecWTextBox.TabIndex = 15;
            // 
            // xfSecClockTextBox
            // 
            this.xfSecClockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfSecClock", true));
            this.xfSecClockTextBox.Location = new System.Drawing.Point(320, 370);
            this.xfSecClockTextBox.Name = "xfSecClockTextBox";
            this.xfSecClockTextBox.Size = new System.Drawing.Size(31, 20);
            this.xfSecClockTextBox.TabIndex = 16;
            // 
            // xfPhaseTextBox
            // 
            this.xfPhaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfPhase", true));
            this.xfPhaseTextBox.Location = new System.Drawing.Point(200, 396);
            this.xfPhaseTextBox.Name = "xfPhaseTextBox";
            this.xfPhaseTextBox.Size = new System.Drawing.Size(151, 20);
            this.xfPhaseTextBox.TabIndex = 17;
            // 
            // xfSubIDComboBox
            // 
            this.xfSubIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfSubID", true));
            this.xfSubIDComboBox.DataSource = this.tblSubstationBindingSource;
            this.xfSubIDComboBox.DisplayMember = "subID";
            this.xfSubIDComboBox.FormattingEnabled = true;
            this.xfSubIDComboBox.Location = new System.Drawing.Point(200, 84);
            this.xfSubIDComboBox.Name = "xfSubIDComboBox";
            this.xfSubIDComboBox.Size = new System.Drawing.Size(151, 21);
            this.xfSubIDComboBox.TabIndex = 76;
            this.xfSubIDComboBox.ValueMember = "subID";
            // 
            // tblTransformerTableAdapter
            // 
            this.tblTransformerTableAdapter.ClearBeforeFill = true;
            // 
            // xfYearTextBox
            // 
            this.xfYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblTransformerBindingSource, "xfYear", true));
            this.xfYearTextBox.Location = new System.Drawing.Point(200, 240);
            this.xfYearTextBox.Name = "xfYearTextBox";
            this.xfYearTextBox.Size = new System.Drawing.Size(152, 20);
            this.xfYearTextBox.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "*Field Required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "**Use format as in: YN a D 5. Leave second field blank if not autotransformer. Fi" +
    "elds not required.";
            // 
            // tblTransformerDataGridView
            // 
            this.tblTransformerDataGridView.AutoGenerateColumns = false;
            this.tblTransformerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTransformerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.tblTransformerDataGridView.DataSource = this.tblTransformerBindingSource;
            this.tblTransformerDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.tblTransformerDataGridView.Location = new System.Drawing.Point(598, 0);
            this.tblTransformerDataGridView.Name = "tblTransformerDataGridView";
            this.tblTransformerDataGridView.Size = new System.Drawing.Size(590, 498);
            this.tblTransformerDataGridView.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "xfSubID";
            this.dataGridViewTextBoxColumn1.HeaderText = "xfSubID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xfMake";
            this.dataGridViewTextBoxColumn2.HeaderText = "xfMake";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "xfSerial";
            this.dataGridViewTextBoxColumn3.HeaderText = "xfSerial";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "xfClass";
            this.dataGridViewTextBoxColumn4.HeaderText = "xfClass";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "xfCap";
            this.dataGridViewTextBoxColumn5.HeaderText = "xfCap";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "xfImpedanceA";
            this.dataGridViewTextBoxColumn6.HeaderText = "xfImpedanceA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "xfImpedanceB";
            this.dataGridViewTextBoxColumn7.HeaderText = "xfImpedanceB";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "xfImpedanceC";
            this.dataGridViewTextBoxColumn8.HeaderText = "xfImpedanceC";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "xfPrimVolt";
            this.dataGridViewTextBoxColumn9.HeaderText = "xfPrimVolt";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "xfSecVolt";
            this.dataGridViewTextBoxColumn10.HeaderText = "xfSecVolt";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "xfTertVolt";
            this.dataGridViewTextBoxColumn11.HeaderText = "xfTertVolt";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "xfPrimW";
            this.dataGridViewTextBoxColumn12.HeaderText = "xfPrimW";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "xfSecW";
            this.dataGridViewTextBoxColumn13.HeaderText = "xfSecW";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "xfSecClock";
            this.dataGridViewTextBoxColumn14.HeaderText = "xfSecClock";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "xfAuto";
            this.dataGridViewTextBoxColumn15.HeaderText = "xfAuto";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "xfPhase";
            this.dataGridViewTextBoxColumn16.HeaderText = "xfPhase";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "xfYear";
            this.dataGridViewTextBoxColumn17.HeaderText = "xfYear";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "xfID";
            this.dataGridViewTextBoxColumn18.HeaderText = "xfID";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // frmXformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1188, 498);
            this.Controls.Add(this.tblTransformerDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xfYearTextBox);
            this.Controls.Add(this.xfSubIDComboBox);
            this.Controls.Add(this.xfPhaseTextBox);
            this.Controls.Add(this.xfSecClockTextBox);
            this.Controls.Add(this.xfSecWTextBox);
            this.Controls.Add(this.xfAutoTextBox);
            this.Controls.Add(this.xfPrimWTextBox);
            this.Controls.Add(this.xfTertVoltTextBox);
            this.Controls.Add(this.xfSecVoltTextBox);
            this.Controls.Add(this.xfPrimVoltTextBox);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(label1);
            this.Controls.Add(xfIDLabel);
            this.Controls.Add(this.xfIDTextBox);
            this.Controls.Add(xfSubIDLabel);
            this.Controls.Add(xfMakeLabel);
            this.Controls.Add(this.xfMakeTextBox);
            this.Controls.Add(xfSerialLabel);
            this.Controls.Add(this.xfSerialTextBox);
            this.Controls.Add(xfClassLabel);
            this.Controls.Add(this.xfClassTextBox);
            this.Controls.Add(xfCapLabel);
            this.Controls.Add(this.xfCapTextBox);
            this.Controls.Add(xfDateLabel);
            this.Controls.Add(xfPrimVoltLabel);
            this.Controls.Add(xfSecVoltLabel);
            this.Controls.Add(xfTertVoltLabel);
            this.Controls.Add(xfPrimWLabel);
            this.Controls.Add(xfPhaseLabel);
            this.Controls.Add(xfImpedanceALabel);
            this.Controls.Add(this.xfImpedanceATextBox);
            this.Controls.Add(this.xfImpedanceBTextBox);
            this.Controls.Add(this.xfImpedanceCTextBox);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmXformer";
            this.Text = "frmXformer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXformer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmXformer_FormClosed);
            this.Load += new System.EventHandler(this.frmXformer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSubstationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblTransformerBindingSource;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private dtbPTASDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox xfIDTextBox;
        private System.Windows.Forms.TextBox xfMakeTextBox;
        private System.Windows.Forms.TextBox xfSerialTextBox;
        private System.Windows.Forms.TextBox xfClassTextBox;
        private System.Windows.Forms.TextBox xfCapTextBox;
        private System.Windows.Forms.TextBox xfImpedanceATextBox;
        private System.Windows.Forms.TextBox xfImpedanceBTextBox;
        private System.Windows.Forms.TextBox xfImpedanceCTextBox;
        private dtbPTASDataSetTableAdapters.tblSubstationTableAdapter tblSubstationTableAdapter;
        private System.Windows.Forms.BindingSource tblSubstationBindingSource;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox xfPrimVoltTextBox;
        private System.Windows.Forms.TextBox xfSecVoltTextBox;
        private System.Windows.Forms.TextBox xfTertVoltTextBox;
        private System.Windows.Forms.TextBox xfPrimWTextBox;
        private System.Windows.Forms.TextBox xfAutoTextBox;
        private System.Windows.Forms.TextBox xfSecWTextBox;
        private System.Windows.Forms.TextBox xfSecClockTextBox;
        private System.Windows.Forms.TextBox xfPhaseTextBox;
        private System.Windows.Forms.ComboBox xfSubIDComboBox;
        private dtbPTASDataSetTableAdapters.tblTransformerTableAdapter tblTransformerTableAdapter;
        private System.Windows.Forms.TextBox xfYearTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tblTransformerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}