namespace PTAS
{
    partial class frmGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboXf = new System.Windows.Forms.ComboBox();
            this.tblTransformerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtbPTASDataSet = new PTAS.dtbPTASDataSet();
            this.cboTest = new System.Windows.Forms.ComboBox();
            this.tblTestListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboParam = new System.Windows.Forms.ComboBox();
            this.tblParamListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tblTransformerTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblTransformerTableAdapter();
            this.tblTestListTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblTestListTableAdapter();
            this.tblParamListTableAdapter = new PTAS.dtbPTASDataSetTableAdapters.tblParamListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chtTrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParamListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chtTrend
            // 
            chartArea1.Name = "ChartArea1";
            this.chtTrend.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chtTrend.Legends.Add(legend1);
            this.chtTrend.Location = new System.Drawing.Point(12, 77);
            this.chtTrend.Name = "chtTrend";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chtTrend.Series.Add(series1);
            this.chtTrend.Size = new System.Drawing.Size(307, 314);
            this.chtTrend.TabIndex = 0;
            this.chtTrend.Text = "Trend";
            // 
            // cboXf
            // 
            this.cboXf.DataSource = this.tblTransformerBindingSource;
            this.cboXf.DisplayMember = "xfID";
            this.cboXf.FormattingEnabled = true;
            this.cboXf.Location = new System.Drawing.Point(423, 130);
            this.cboXf.Name = "cboXf";
            this.cboXf.Size = new System.Drawing.Size(121, 21);
            this.cboXf.TabIndex = 1;
            this.cboXf.ValueMember = "xfID";
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
            // cboTest
            // 
            this.cboTest.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblTestListBindingSource, "TestValue", true));
            this.cboTest.DataSource = this.tblTestListBindingSource;
            this.cboTest.DisplayMember = "TestName";
            this.cboTest.FormattingEnabled = true;
            this.cboTest.Location = new System.Drawing.Point(423, 157);
            this.cboTest.Name = "cboTest";
            this.cboTest.Size = new System.Drawing.Size(121, 21);
            this.cboTest.TabIndex = 2;
            this.cboTest.ValueMember = "TestValue";
            this.cboTest.SelectedIndexChanged += new System.EventHandler(this.cboTest_SelectedIndexChanged);
            // 
            // tblTestListBindingSource
            // 
            this.tblTestListBindingSource.DataMember = "tblTestList";
            this.tblTestListBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // cboParam
            // 
            this.cboParam.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblParamListBindingSource, "ParameterValue", true));
            this.cboParam.DataSource = this.tblParamListBindingSource;
            this.cboParam.DisplayMember = "ParameterName";
            this.cboParam.FormattingEnabled = true;
            this.cboParam.Location = new System.Drawing.Point(423, 184);
            this.cboParam.Name = "cboParam";
            this.cboParam.Size = new System.Drawing.Size(121, 21);
            this.cboParam.TabIndex = 3;
            this.cboParam.ValueMember = "ParameterValue";
            // 
            // tblParamListBindingSource
            // 
            this.tblParamListBindingSource.DataMember = "tblParamList";
            this.tblParamListBindingSource.DataSource = this.dtbPTASDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transformer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parameter";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(346, 227);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tblTransformerTableAdapter
            // 
            this.tblTransformerTableAdapter.ClearBeforeFill = true;
            // 
            // tblTestListTableAdapter
            // 
            this.tblTestListTableAdapter.ClearBeforeFill = true;
            // 
            // tblParamListTableAdapter
            // 
            this.tblParamListTableAdapter.ClearBeforeFill = true;
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 403);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboParam);
            this.Controls.Add(this.cboTest);
            this.Controls.Add(this.cboXf);
            this.Controls.Add(this.chtTrend);
            this.Name = "frmGraph";
            this.Text = "Graphs and Trends";
            this.Load += new System.EventHandler(this.frmGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtTrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransformerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbPTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTestListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblParamListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtTrend;
        private System.Windows.Forms.ComboBox cboXf;
        private System.Windows.Forms.ComboBox cboTest;
        private System.Windows.Forms.ComboBox cboParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoad;
        private dtbPTASDataSet dtbPTASDataSet;
        private System.Windows.Forms.BindingSource tblTransformerBindingSource;
        private dtbPTASDataSetTableAdapters.tblTransformerTableAdapter tblTransformerTableAdapter;
        private System.Windows.Forms.BindingSource tblTestListBindingSource;
        private dtbPTASDataSetTableAdapters.tblTestListTableAdapter tblTestListTableAdapter;
        private System.Windows.Forms.BindingSource tblParamListBindingSource;
        private dtbPTASDataSetTableAdapters.tblParamListTableAdapter tblParamListTableAdapter;
    }
}