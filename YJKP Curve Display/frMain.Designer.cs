namespace YJKP_Curve_Display
{
	// Token: 0x02000002 RID: 2
	public partial class frMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000047AC File Offset: 0x000029AC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000047E4 File Offset: 0x000029E4
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.pLeft = new System.Windows.Forms.Panel();
            this.cbLookFor = new System.Windows.Forms.ComboBox();
            this.lsFileName = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHidePanelLeft = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chEvaluationNumber = new System.Windows.Forms.CheckBox();
            this.lbCurve1 = new System.Windows.Forms.Label();
            this.lbCurve0 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudCurvePoint = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.chEnvelope = new System.Windows.Forms.CheckBox();
            this.chThreshold = new System.Windows.Forms.CheckBox();
            this.chWindow = new System.Windows.Forms.CheckBox();
            this.chGetData = new System.Windows.Forms.CheckBox();
            this.btGetData = new System.Windows.Forms.Button();
            this.nudGridSize = new System.Windows.Forms.NumericUpDown();
            this.nudSpanY = new System.Windows.Forms.NumericUpDown();
            this.nudSpanX = new System.Windows.Forms.NumericUpDown();
            this.lbStatus = new System.Windows.Forms.Label();
            this.chShowGrid = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btGenerateCurve = new System.Windows.Forms.Button();
            this.lbCurveType = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.canvas = new System.Windows.Forms.Panel();
            this.pGridY = new System.Windows.Forms.Panel();
            this.lbRefY = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbAxisY = new System.Windows.Forms.Label();
            this.pGridX0 = new System.Windows.Forms.Panel();
            this.pGridX = new System.Windows.Forms.Panel();
            this.lbPosDirectionLeft = new System.Windows.Forms.Label();
            this.pGridXLeft = new System.Windows.Forms.Panel();
            this.lbRefX = new System.Windows.Forms.Label();
            this.lbAxisX = new System.Windows.Forms.Label();
            this.pTop = new System.Windows.Forms.Panel();
            this.pFTP = new System.Windows.Forms.Panel();
            this.lbFTP = new System.Windows.Forms.Label();
            this.btGetLogFiles = new System.Windows.Forms.Button();
            this.txProgramName = new System.Windows.Forms.TextBox();
            this.txIP = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbMaxPosition = new System.Windows.Forms.Label();
            this.lbMaxForce = new System.Windows.Forms.Label();
            this.lbRecordTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNumPoint = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbGrid = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbCursorValue = new System.Windows.Forms.Label();
            this.tDelay = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btGetFileName = new System.Windows.Forms.Button();
            this.txPath = new System.Windows.Forms.TextBox();
            this.lbCanvasSize = new System.Windows.Forms.Label();
            this.cob_ParaName = new System.Windows.Forms.ComboBox();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chk_Select = new System.Windows.Forms.CheckBox();
            this.rdo_All = new System.Windows.Forms.RadioButton();
            this.rdo_OK = new System.Windows.Forms.RadioButton();
            this.rdo_NOK = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurvePoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpanY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpanX)).BeginInit();
            this.canvas.SuspendLayout();
            this.pGridY.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pGridX0.SuspendLayout();
            this.pGridX.SuspendLayout();
            this.pGridXLeft.SuspendLayout();
            this.pTop.SuspendLayout();
            this.pFTP.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.cbLookFor);
            this.pLeft.Controls.Add(this.lsFileName);
            this.pLeft.Controls.Add(this.label4);
            this.pLeft.Controls.Add(this.panel9);
            this.pLeft.Controls.Add(this.panel2);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(292, 742);
            this.pLeft.TabIndex = 0;
            // 
            // cbLookFor
            // 
            this.cbLookFor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLookFor.FormattingEnabled = true;
            this.cbLookFor.Items.AddRange(new object[] {
            "[Record 1]",
            "[Record 2]",
            "[Record 3]",
            "[Record 4]",
            "[Record 5]"});
            this.cbLookFor.Location = new System.Drawing.Point(26, 371);
            this.cbLookFor.Name = "cbLookFor";
            this.cbLookFor.Size = new System.Drawing.Size(236, 25);
            this.cbLookFor.TabIndex = 13;
            this.cbLookFor.Text = "[Record 1]";
            this.cbLookFor.SelectedIndexChanged += new System.EventHandler(this.cbLookFor_SelectedIndexChanged);
            // 
            // lsFileName
            // 
            this.lsFileName.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsFileName.FormattingEnabled = true;
            this.lsFileName.ItemHeight = 17;
            this.lsFileName.Items.AddRange(new object[] {
            "Log files"});
            this.lsFileName.Location = new System.Drawing.Point(26, 240);
            this.lsFileName.Name = "lsFileName";
            this.lsFileName.ScrollAlwaysVisible = true;
            this.lsFileName.Size = new System.Drawing.Size(236, 106);
            this.lsFileName.TabIndex = 13;
            this.lsFileName.SelectedIndexChanged += new System.EventHandler(this.lsFileName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Look for";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.chEvaluationNumber);
            this.panel2.Controls.Add(this.lbCurve1);
            this.panel2.Controls.Add(this.lbCurve0);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.nudCurvePoint);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.chEnvelope);
            this.panel2.Controls.Add(this.chThreshold);
            this.panel2.Controls.Add(this.chWindow);
            this.panel2.Controls.Add(this.chGetData);
            this.panel2.Controls.Add(this.btGetData);
            this.panel2.Controls.Add(this.nudGridSize);
            this.panel2.Controls.Add(this.nudSpanY);
            this.panel2.Controls.Add(this.nudSpanX);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.chShowGrid);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btGenerateCurve);
            this.panel2.Controls.Add(this.lbCurveType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 312);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbHidePanelLeft);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(266, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 292);
            this.panel1.TabIndex = 27;
            // 
            // lbHidePanelLeft
            // 
            this.lbHidePanelLeft.AutoSize = true;
            this.lbHidePanelLeft.Location = new System.Drawing.Point(3, 258);
            this.lbHidePanelLeft.Name = "lbHidePanelLeft";
            this.lbHidePanelLeft.Size = new System.Drawing.Size(22, 18);
            this.lbHidePanelLeft.TabIndex = 23;
            this.lbHidePanelLeft.Text = "<<";
            this.lbHidePanelLeft.Click += new System.EventHandler(this.lbHidePanelLeft_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 53);
            this.button1.TabIndex = 22;
            this.button1.Text = "Get Log Files";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 26);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Program Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 26);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "192.168.004.002";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chEvaluationNumber
            // 
            this.chEvaluationNumber.AutoSize = true;
            this.chEvaluationNumber.Checked = true;
            this.chEvaluationNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chEvaluationNumber.Location = new System.Drawing.Point(26, 115);
            this.chEvaluationNumber.Name = "chEvaluationNumber";
            this.chEvaluationNumber.Size = new System.Drawing.Size(81, 22);
            this.chEvaluationNumber.TabIndex = 25;
            this.chEvaluationNumber.Text = "Number";
            this.chEvaluationNumber.UseVisualStyleBackColor = true;
            this.chEvaluationNumber.CheckedChanged += new System.EventHandler(this.chEvaluationNumber_CheckedChanged);
            // 
            // lbCurve1
            // 
            this.lbCurve1.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbCurve1.Location = new System.Drawing.Point(8, 206);
            this.lbCurve1.Name = "lbCurve1";
            this.lbCurve1.Size = new System.Drawing.Size(15, 14);
            this.lbCurve1.TabIndex = 24;
            this.lbCurve1.Visible = false;
            // 
            // lbCurve0
            // 
            this.lbCurve0.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbCurve0.Location = new System.Drawing.Point(8, 192);
            this.lbCurve0.Name = "lbCurve0";
            this.lbCurve0.Size = new System.Drawing.Size(15, 14);
            this.lbCurve0.TabIndex = 20;
            this.lbCurve0.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Curve Point:";
            // 
            // nudCurvePoint
            // 
            this.nudCurvePoint.Location = new System.Drawing.Point(215, 35);
            this.nudCurvePoint.Name = "nudCurvePoint";
            this.nudCurvePoint.Size = new System.Drawing.Size(47, 26);
            this.nudCurvePoint.TabIndex = 22;
            this.nudCurvePoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCurvePoint.ValueChanged += new System.EventHandler(this.nudCurvePoint_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Grid size:";
            // 
            // chEnvelope
            // 
            this.chEnvelope.AutoSize = true;
            this.chEnvelope.Checked = true;
            this.chEnvelope.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chEnvelope.Location = new System.Drawing.Point(26, 89);
            this.chEnvelope.Name = "chEnvelope";
            this.chEnvelope.Size = new System.Drawing.Size(88, 22);
            this.chEnvelope.TabIndex = 20;
            this.chEnvelope.Text = "Envelope";
            this.chEnvelope.UseVisualStyleBackColor = true;
            this.chEnvelope.CheckedChanged += new System.EventHandler(this.chEnvelope_CheckedChanged);
            // 
            // chThreshold
            // 
            this.chThreshold.AutoSize = true;
            this.chThreshold.Checked = true;
            this.chThreshold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chThreshold.Location = new System.Drawing.Point(26, 63);
            this.chThreshold.Name = "chThreshold";
            this.chThreshold.Size = new System.Drawing.Size(92, 22);
            this.chThreshold.TabIndex = 19;
            this.chThreshold.Text = "Threshold";
            this.chThreshold.UseVisualStyleBackColor = true;
            this.chThreshold.CheckedChanged += new System.EventHandler(this.chThreshold_CheckedChanged);
            // 
            // chWindow
            // 
            this.chWindow.AutoSize = true;
            this.chWindow.Checked = true;
            this.chWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chWindow.Location = new System.Drawing.Point(26, 37);
            this.chWindow.Name = "chWindow";
            this.chWindow.Size = new System.Drawing.Size(82, 22);
            this.chWindow.TabIndex = 18;
            this.chWindow.Text = "Window";
            this.chWindow.UseVisualStyleBackColor = true;
            this.chWindow.CheckedChanged += new System.EventHandler(this.chWindow_CheckedChanged);
            // 
            // chGetData
            // 
            this.chGetData.AutoSize = true;
            this.chGetData.Location = new System.Drawing.Point(26, 9);
            this.chGetData.Name = "chGetData";
            this.chGetData.Size = new System.Drawing.Size(83, 22);
            this.chGetData.TabIndex = 15;
            this.chGetData.Text = "Get Data";
            this.chGetData.UseVisualStyleBackColor = true;
            this.chGetData.Visible = false;
            this.chGetData.CheckedChanged += new System.EventHandler(this.chGetData_CheckedChanged);
            // 
            // btGetData
            // 
            this.btGetData.Location = new System.Drawing.Point(26, 242);
            this.btGetData.Name = "btGetData";
            this.btGetData.Size = new System.Drawing.Size(102, 47);
            this.btGetData.TabIndex = 0;
            this.btGetData.Text = "Get data";
            this.btGetData.UseVisualStyleBackColor = true;
            this.btGetData.Visible = false;
            this.btGetData.Click += new System.EventHandler(this.btGetData_Click);
            // 
            // nudGridSize
            // 
            this.nudGridSize.Location = new System.Drawing.Point(215, 61);
            this.nudGridSize.Name = "nudGridSize";
            this.nudGridSize.Size = new System.Drawing.Size(47, 26);
            this.nudGridSize.TabIndex = 17;
            this.nudGridSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGridSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGridSize.ValueChanged += new System.EventHandler(this.nudGridSize_ValueChanged);
            // 
            // nudSpanY
            // 
            this.nudSpanY.Location = new System.Drawing.Point(215, 113);
            this.nudSpanY.Name = "nudSpanY";
            this.nudSpanY.Size = new System.Drawing.Size(47, 26);
            this.nudSpanY.TabIndex = 16;
            this.nudSpanY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSpanY.ValueChanged += new System.EventHandler(this.nudSpanY_ValueChanged);
            // 
            // nudSpanX
            // 
            this.nudSpanX.Location = new System.Drawing.Point(215, 87);
            this.nudSpanX.Name = "nudSpanX";
            this.nudSpanX.Size = new System.Drawing.Size(47, 26);
            this.nudSpanX.TabIndex = 2;
            this.nudSpanX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSpanX.ValueChanged += new System.EventHandler(this.nudSpanX_ValueChanged);
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Location = new System.Drawing.Point(0, 292);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(292, 20);
            this.lbStatus.TabIndex = 14;
            this.lbStatus.Text = "Status";
            // 
            // chShowGrid
            // 
            this.chShowGrid.AutoSize = true;
            this.chShowGrid.Checked = true;
            this.chShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chShowGrid.Location = new System.Drawing.Point(26, 141);
            this.chShowGrid.Name = "chShowGrid";
            this.chShowGrid.Size = new System.Drawing.Size(56, 22);
            this.chShowGrid.TabIndex = 3;
            this.chShowGrid.Text = "Grid";
            this.chShowGrid.UseVisualStyleBackColor = true;
            this.chShowGrid.CheckedChanged += new System.EventHandler(this.chShowGrid_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 18);
            this.label10.TabIndex = 11;
            this.label10.Text = "Span Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Span X:";
            // 
            // btGenerateCurve
            // 
            this.btGenerateCurve.Enabled = false;
            this.btGenerateCurve.Location = new System.Drawing.Point(134, 242);
            this.btGenerateCurve.Name = "btGenerateCurve";
            this.btGenerateCurve.Size = new System.Drawing.Size(128, 47);
            this.btGenerateCurve.TabIndex = 8;
            this.btGenerateCurve.Text = "Generate Curve";
            this.btGenerateCurve.UseVisualStyleBackColor = true;
            this.btGenerateCurve.Click += new System.EventHandler(this.btGenerateCurve_Click);
            // 
            // lbCurveType
            // 
            this.lbCurveType.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurveType.FormattingEnabled = true;
            this.lbCurveType.ItemHeight = 17;
            this.lbCurveType.Items.AddRange(new object[] {
            "Y-Force (N)      X-Position (mm)  ",
            "Y-Force (N)      X-Time (s)       ",
            "Y-Position (mm)  X-Time (s)       "});
            this.lbCurveType.Location = new System.Drawing.Point(26, 190);
            this.lbCurveType.Name = "lbCurveType";
            this.lbCurveType.Size = new System.Drawing.Size(236, 38);
            this.lbCurveType.TabIndex = 0;
            this.lbCurveType.SelectedIndexChanged += new System.EventHandler(this.lbCurveType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curve type";
            // 
            // canvas
            // 
            this.canvas.AllowDrop = true;
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Controls.Add(this.pGridY);
            this.canvas.Controls.Add(this.panel6);
            this.canvas.Controls.Add(this.pGridX0);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(292, 92);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(880, 627);
            this.canvas.TabIndex = 1;
            this.canvas.DragDrop += new System.Windows.Forms.DragEventHandler(this.canvas_DragDrop);
            this.canvas.DragEnter += new System.Windows.Forms.DragEventHandler(this.canvas_DragEnter);
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // pGridY
            // 
            this.pGridY.Controls.Add(this.lbRefY);
            this.pGridY.Dock = System.Windows.Forms.DockStyle.Left;
            this.pGridY.Location = new System.Drawing.Point(0, 44);
            this.pGridY.Name = "pGridY";
            this.pGridY.Size = new System.Drawing.Size(42, 541);
            this.pGridY.TabIndex = 12;
            // 
            // lbRefY
            // 
            this.lbRefY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbRefY.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRefY.Location = new System.Drawing.Point(0, 519);
            this.lbRefY.Name = "lbRefY";
            this.lbRefY.Size = new System.Drawing.Size(42, 22);
            this.lbRefY.TabIndex = 10;
            this.lbRefY.Text = "0.00";
            this.lbRefY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbAxisY);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(880, 44);
            this.panel6.TabIndex = 11;
            // 
            // lbAxisY
            // 
            this.lbAxisY.Location = new System.Drawing.Point(8, 15);
            this.lbAxisY.Name = "lbAxisY";
            this.lbAxisY.Size = new System.Drawing.Size(93, 26);
            this.lbAxisY.TabIndex = 0;
            this.lbAxisY.Text = "Axis Y";
            this.lbAxisY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pGridX0
            // 
            this.pGridX0.Controls.Add(this.pGridX);
            this.pGridX0.Controls.Add(this.pGridXLeft);
            this.pGridX0.Controls.Add(this.lbAxisX);
            this.pGridX0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pGridX0.Location = new System.Drawing.Point(0, 585);
            this.pGridX0.Name = "pGridX0";
            this.pGridX0.Size = new System.Drawing.Size(880, 42);
            this.pGridX0.TabIndex = 2;
            // 
            // pGridX
            // 
            this.pGridX.Controls.Add(this.lbPosDirectionLeft);
            this.pGridX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGridX.Location = new System.Drawing.Point(101, 0);
            this.pGridX.Name = "pGridX";
            this.pGridX.Size = new System.Drawing.Size(676, 42);
            this.pGridX.TabIndex = 11;
            this.pGridX.Paint += new System.Windows.Forms.PaintEventHandler(this.pGridX_Paint);
            // 
            // lbPosDirectionLeft
            // 
            this.lbPosDirectionLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbPosDirectionLeft.ForeColor = System.Drawing.Color.Blue;
            this.lbPosDirectionLeft.Location = new System.Drawing.Point(0, 20);
            this.lbPosDirectionLeft.Name = "lbPosDirectionLeft";
            this.lbPosDirectionLeft.Size = new System.Drawing.Size(676, 22);
            this.lbPosDirectionLeft.TabIndex = 1;
            this.lbPosDirectionLeft.Text = "<-----------";
            this.lbPosDirectionLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPosDirectionLeft.Visible = false;
            // 
            // pGridXLeft
            // 
            this.pGridXLeft.Controls.Add(this.lbRefX);
            this.pGridXLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pGridXLeft.Location = new System.Drawing.Point(0, 0);
            this.pGridXLeft.Name = "pGridXLeft";
            this.pGridXLeft.Size = new System.Drawing.Size(101, 42);
            this.pGridXLeft.TabIndex = 10;
            // 
            // lbRefX
            // 
            this.lbRefX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRefX.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRefX.Location = new System.Drawing.Point(0, 0);
            this.lbRefX.Name = "lbRefX";
            this.lbRefX.Size = new System.Drawing.Size(101, 42);
            this.lbRefX.TabIndex = 9;
            this.lbRefX.Text = "0.00";
            this.lbRefX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbAxisX
            // 
            this.lbAxisX.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbAxisX.Location = new System.Drawing.Point(777, 0);
            this.lbAxisX.Name = "lbAxisX";
            this.lbAxisX.Size = new System.Drawing.Size(103, 42);
            this.lbAxisX.TabIndex = 1;
            this.lbAxisX.Text = "Axis X";
            this.lbAxisX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.pFTP);
            this.pTop.Controls.Add(this.panel8);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(292, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(880, 92);
            this.pTop.TabIndex = 90;
            // 
            // pFTP
            // 
            this.pFTP.Controls.Add(this.lbFTP);
            this.pFTP.Controls.Add(this.btGetLogFiles);
            this.pFTP.Controls.Add(this.txProgramName);
            this.pFTP.Controls.Add(this.txIP);
            this.pFTP.Dock = System.Windows.Forms.DockStyle.Left;
            this.pFTP.Location = new System.Drawing.Point(0, 0);
            this.pFTP.Name = "pFTP";
            this.pFTP.Size = new System.Drawing.Size(26, 92);
            this.pFTP.TabIndex = 13;
            this.pFTP.Visible = false;
            // 
            // lbFTP
            // 
            this.lbFTP.AutoSize = true;
            this.lbFTP.Location = new System.Drawing.Point(3, 40);
            this.lbFTP.Name = "lbFTP";
            this.lbFTP.Size = new System.Drawing.Size(22, 18);
            this.lbFTP.TabIndex = 23;
            this.lbFTP.Text = ">>";
            this.lbFTP.Click += new System.EventHandler(this.lbFTP_Click);
            // 
            // btGetLogFiles
            // 
            this.btGetLogFiles.Location = new System.Drawing.Point(126, 24);
            this.btGetLogFiles.Name = "btGetLogFiles";
            this.btGetLogFiles.Size = new System.Drawing.Size(102, 53);
            this.btGetLogFiles.TabIndex = 22;
            this.btGetLogFiles.Text = "Get Log Files";
            this.btGetLogFiles.UseVisualStyleBackColor = true;
            this.btGetLogFiles.Click += new System.EventHandler(this.btGetLogFiles_Click);
            // 
            // txProgramName
            // 
            this.txProgramName.Location = new System.Drawing.Point(27, 54);
            this.txProgramName.Name = "txProgramName";
            this.txProgramName.Size = new System.Drawing.Size(93, 26);
            this.txProgramName.TabIndex = 21;
            this.txProgramName.Text = "Program Name";
            this.txProgramName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txIP
            // 
            this.txIP.Location = new System.Drawing.Point(27, 25);
            this.txIP.Name = "txIP";
            this.txIP.Size = new System.Drawing.Size(93, 26);
            this.txIP.TabIndex = 20;
            this.txIP.Text = "192.168.004.002";
            this.txIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lbMaxPosition);
            this.panel8.Controls.Add(this.lbMaxForce);
            this.panel8.Controls.Add(this.lbRecordTime);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.lbNumPoint);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(464, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(416, 92);
            this.panel8.TabIndex = 19;
            // 
            // lbMaxPosition
            // 
            this.lbMaxPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaxPosition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxPosition.Location = new System.Drawing.Point(335, 55);
            this.lbMaxPosition.Name = "lbMaxPosition";
            this.lbMaxPosition.Size = new System.Drawing.Size(62, 22);
            this.lbMaxPosition.TabIndex = 14;
            this.lbMaxPosition.Text = "0";
            this.lbMaxPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMaxForce
            // 
            this.lbMaxForce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaxForce.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxForce.Location = new System.Drawing.Point(335, 27);
            this.lbMaxForce.Name = "lbMaxForce";
            this.lbMaxForce.Size = new System.Drawing.Size(62, 22);
            this.lbMaxForce.TabIndex = 13;
            this.lbMaxForce.Text = "0";
            this.lbMaxForce.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbRecordTime
            // 
            this.lbRecordTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecordTime.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordTime.Location = new System.Drawing.Point(119, 55);
            this.lbRecordTime.Name = "lbRecordTime";
            this.lbRecordTime.Size = new System.Drawing.Size(62, 22);
            this.lbRecordTime.TabIndex = 12;
            this.lbRecordTime.Text = "0";
            this.lbRecordTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Record time (ms):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Maximum position (mm):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Maximum force (N):";
            // 
            // lbNumPoint
            // 
            this.lbNumPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumPoint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumPoint.Location = new System.Drawing.Point(119, 26);
            this.lbNumPoint.Name = "lbNumPoint";
            this.lbNumPoint.Size = new System.Drawing.Size(62, 22);
            this.lbNumPoint.TabIndex = 8;
            this.lbNumPoint.Text = "0";
            this.lbNumPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of point:";
            // 
            // lbGrid
            // 
            this.lbGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbGrid.Location = new System.Drawing.Point(185, 0);
            this.lbGrid.Name = "lbGrid";
            this.lbGrid.Size = new System.Drawing.Size(189, 23);
            this.lbGrid.TabIndex = 15;
            this.lbGrid.Text = "[Grid]";
            this.lbGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbGrid.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbGrid);
            this.panel4.Controls.Add(this.lbFileName);
            this.panel4.Controls.Add(this.lbCursorValue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(292, 719);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(880, 23);
            this.panel4.TabIndex = 1;
            // 
            // lbFileName
            // 
            this.lbFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFileName.Location = new System.Drawing.Point(185, 0);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(695, 23);
            this.lbFileName.TabIndex = 11;
            this.lbFileName.Text = "Selected file name";
            this.lbFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCursorValue
            // 
            this.lbCursorValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCursorValue.Location = new System.Drawing.Point(0, 0);
            this.lbCursorValue.Name = "lbCursorValue";
            this.lbCursorValue.Size = new System.Drawing.Size(185, 23);
            this.lbCursorValue.TabIndex = 10;
            this.lbCursorValue.Text = "[Pos]";
            this.lbCursorValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tDelay
            // 
            this.tDelay.Tick += new System.EventHandler(this.tDelay_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "File name";
            // 
            // btGetFileName
            // 
            this.btGetFileName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btGetFileName.Location = new System.Drawing.Point(201, 180);
            this.btGetFileName.Name = "btGetFileName";
            this.btGetFileName.Size = new System.Drawing.Size(58, 22);
            this.btGetFileName.TabIndex = 13;
            this.btGetFileName.Text = ">";
            this.btGetFileName.UseVisualStyleBackColor = true;
            this.btGetFileName.Click += new System.EventHandler(this.btGetFileName_Click);
            // 
            // txPath
            // 
            this.txPath.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPath.Location = new System.Drawing.Point(26, 42);
            this.txPath.Multiline = true;
            this.txPath.Name = "txPath";
            this.txPath.Size = new System.Drawing.Size(236, 50);
            this.txPath.TabIndex = 1;
            this.txPath.Text = "Application Path";
            this.txPath.TextChanged += new System.EventHandler(this.txPath_TextChanged);
            this.txPath.DoubleClick += new System.EventHandler(this.txPath_DoubleClick);
            this.txPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txPath_KeyPress);
            // 
            // lbCanvasSize
            // 
            this.lbCanvasSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCanvasSize.Location = new System.Drawing.Point(0, 0);
            this.lbCanvasSize.Name = "lbCanvasSize";
            this.lbCanvasSize.Size = new System.Drawing.Size(292, 20);
            this.lbCanvasSize.TabIndex = 9;
            this.lbCanvasSize.Text = "[Size]";
            this.lbCanvasSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCanvasSize.Visible = false;
            // 
            // cob_ParaName
            // 
            this.cob_ParaName.Enabled = false;
            this.cob_ParaName.FormattingEnabled = true;
            this.cob_ParaName.Items.AddRange(new object[] {
            "Serial number",
            "Program name",
            "MAC Address"});
            this.cob_ParaName.Location = new System.Drawing.Point(52, 118);
            this.cob_ParaName.Name = "cob_ParaName";
            this.cob_ParaName.Size = new System.Drawing.Size(210, 26);
            this.cob_ParaName.TabIndex = 16;
            this.cob_ParaName.Text = "Serial number";
            // 
            // txt_Value
            // 
            this.txt_Value.Enabled = false;
            this.txt_Value.Location = new System.Drawing.Point(52, 150);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(210, 26);
            this.txt_Value.TabIndex = 17;
            this.txt_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Value_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filter";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Path";
            // 
            // chk_Select
            // 
            this.chk_Select.AutoSize = true;
            this.chk_Select.Location = new System.Drawing.Point(29, 122);
            this.chk_Select.Name = "chk_Select";
            this.chk_Select.Size = new System.Drawing.Size(18, 17);
            this.chk_Select.TabIndex = 20;
            this.chk_Select.UseVisualStyleBackColor = true;
            this.chk_Select.CheckedChanged += new System.EventHandler(this.chk_Select_CheckedChanged);
            // 
            // rdo_All
            // 
            this.rdo_All.AutoSize = true;
            this.rdo_All.Checked = true;
            this.rdo_All.Location = new System.Drawing.Point(29, 181);
            this.rdo_All.Name = "rdo_All";
            this.rdo_All.Size = new System.Drawing.Size(46, 22);
            this.rdo_All.TabIndex = 22;
            this.rdo_All.TabStop = true;
            this.rdo_All.Text = "All";
            this.rdo_All.UseVisualStyleBackColor = true;
            this.rdo_All.CheckedChanged += new System.EventHandler(this.rdo_All_CheckedChanged);
            // 
            // rdo_OK
            // 
            this.rdo_OK.AutoSize = true;
            this.rdo_OK.Location = new System.Drawing.Point(83, 181);
            this.rdo_OK.Name = "rdo_OK";
            this.rdo_OK.Size = new System.Drawing.Size(47, 22);
            this.rdo_OK.TabIndex = 23;
            this.rdo_OK.Text = "OK";
            this.rdo_OK.UseVisualStyleBackColor = true;
            this.rdo_OK.CheckedChanged += new System.EventHandler(this.rdo_OK_CheckedChanged);
            // 
            // rdo_NOK
            // 
            this.rdo_NOK.AutoSize = true;
            this.rdo_NOK.Location = new System.Drawing.Point(138, 181);
            this.rdo_NOK.Name = "rdo_NOK";
            this.rdo_NOK.Size = new System.Drawing.Size(57, 22);
            this.rdo_NOK.TabIndex = 24;
            this.rdo_NOK.Text = "NOK";
            this.rdo_NOK.UseVisualStyleBackColor = true;
            this.rdo_NOK.CheckedChanged += new System.EventHandler(this.rdo_NOK_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.rdo_NOK);
            this.panel9.Controls.Add(this.rdo_OK);
            this.panel9.Controls.Add(this.rdo_All);
            this.panel9.Controls.Add(this.chk_Select);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.txt_Value);
            this.panel9.Controls.Add(this.cob_ParaName);
            this.panel9.Controls.Add(this.lbCanvasSize);
            this.panel9.Controls.Add(this.txPath);
            this.panel9.Controls.Add(this.btGetFileName);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(292, 405);
            this.panel9.TabIndex = 14;
            // 
            // frMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 742);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pLeft);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YJKP Curve Display";
            this.Load += new System.EventHandler(this.frMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frMain_DragEnter);
            this.Resize += new System.EventHandler(this.frMain_Resize);
            this.pLeft.ResumeLayout(false);
            this.pLeft.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCurvePoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpanY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpanX)).EndInit();
            this.canvas.ResumeLayout(false);
            this.pGridY.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pGridX0.ResumeLayout(false);
            this.pGridX.ResumeLayout(false);
            this.pGridXLeft.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pFTP.ResumeLayout(false);
            this.pFTP.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Panel pLeft;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Panel canvas;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button btGenerateCurve;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button btGetData;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ListBox lbCurveType;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel pTop;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label lbMaxPosition;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label lbMaxForce;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label lbRecordTime;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label lbNumPoint;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label lbAxisY;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label lbAxisX;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Panel pGridX0;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.CheckBox chShowGrid;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label lbGrid;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Label lbRefY;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label lbRefX;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Panel panel6;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Panel pGridY;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label lbCursorValue;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ListBox lsFileName;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label lbStatus;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.ComboBox cbLookFor;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.CheckBox chGetData;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Panel panel8;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.NumericUpDown nudGridSize;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.NumericUpDown nudSpanY;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.NumericUpDown nudSpanX;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.CheckBox chEnvelope;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.CheckBox chThreshold;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.CheckBox chWindow;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.NumericUpDown nudCurvePoint;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label lbFileName;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button btGetLogFiles;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.TextBox txProgramName;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.TextBox txIP;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Panel pFTP;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label lbFTP;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.Panel pGridXLeft;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Panel pGridX;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label lbCurve0;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Label lbCurve1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.CheckBox chEvaluationNumber;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label lbHidePanelLeft;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Timer tDelay;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label lbPosDirectionLeft;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton rdo_NOK;
        private System.Windows.Forms.RadioButton rdo_OK;
        private System.Windows.Forms.RadioButton rdo_All;
        private System.Windows.Forms.CheckBox chk_Select;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.ComboBox cob_ParaName;
        private System.Windows.Forms.Label lbCanvasSize;
        private System.Windows.Forms.TextBox txPath;
        private System.Windows.Forms.Button btGetFileName;
        private System.Windows.Forms.Label label2;
    }
}
