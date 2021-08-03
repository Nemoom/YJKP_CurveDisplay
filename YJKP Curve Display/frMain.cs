using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using YJKPreader;

namespace YJKP_Curve_Display
{
	// Token: 0x02000002 RID: 2
	public partial class frMain : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250	
		public frMain()
		{
			this.InitializeComponent();				
		
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.nudCurvePoint;
			int[] array = new int[4];
			array[0] = 10;
			numericUpDown.Increment = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.nudCurvePoint;
			int[] array2 = new int[4];
			array2[0] = 1000;
			numericUpDown2.Maximum = new decimal(array2);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.nudCurvePoint;
			int[] array3 = new int[4];
			array3[0] = 10;
			numericUpDown3.Minimum = new decimal(array3);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.nudCurvePoint;
			int[] array4 = new int[4];
			array4[0] = 100;
			numericUpDown4.Value = new decimal(array4);
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.nudGridSize;
			int[] array5 = new int[4];
			array5[0] = 5;
			numericUpDown5.Increment = new decimal(array5);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.nudGridSize;
			int[] array6 = new int[4];
			array6[0] = 200;
			numericUpDown6.Maximum = new decimal(array6);
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.nudGridSize;
			int[] array7 = new int[4];
			array7[0] = 40;
			numericUpDown7.Minimum = new decimal(array7);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.nudGridSize;
			int[] array8 = new int[4];
			array8[0] = 80;
			numericUpDown8.Value = new decimal(array8);
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.nudSpanY;
			int[] array9 = new int[4];
			array9[0] = 5;
			numericUpDown9.Increment = new decimal(array9);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.nudSpanY;
			int[] array10 = new int[4];
			array10[0] = 50;
			numericUpDown10.Maximum = new decimal(array10);
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.nudSpanY;
			int[] array11 = new int[4];
			array11[0] = 25;
			numericUpDown11.Value = new decimal(array11);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.nudSpanX;
			int[] array12 = new int[4];
			array12[0] = 5;
			numericUpDown12.Increment = new decimal(array12);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.nudSpanX;
			int[] array13 = new int[4];
			array13[0] = 50;
			numericUpDown13.Maximum = new decimal(array13);
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.nudSpanX;
			int[] array14 = new int[4];
			array14[0] = 25;
			numericUpDown14.Value = new decimal(array14);
			this.myPen.Width = 1f;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D0 File Offset: 0x000002D0
		private void frMain_Load(object sender, EventArgs e)
		{
			this.GetCanvasSize();
			this.canvas.Refresh();
			this.LabelInit();
			this.txPath.Text = Application.StartupPath;
			this.Text = "YJKP Curve Display " + "   V" + Assembly.GetExecutingAssembly().GetName().Version;
			this.chGetData.Checked = true;
			this.GetFileName();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000213C File Offset: 0x0000033C
		private void frMain_Resize(object sender, EventArgs e)
		{
			this.GetCanvasSize();
			frMain.CurveisReady = false;
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
			this.EvaluationNumberLabelRefresh();
			this.canvas.Refresh();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002184 File Offset: 0x00000384
		private void GetCanvasSize()
		{
			frMain.canvas_x = this.canvas.Width;
			frMain.canvas_y = this.canvas.Height;
			this.lbCanvasSize.Text = string.Concat(new string[]
			{
				"[Size]   X: ",
				frMain.canvas_x.ToString(),
				", Y: ",
				frMain.canvas_y.ToString(),
				"      "
			});
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021FC File Offset: 0x000003FC
		private void canvas_Paint(object sender, PaintEventArgs e)
		{
			this.g = this.canvas.CreateGraphics();
			this.myPen.Color = Color.Black;
			this.myPen.Width = 3f;
			this.Draw(frMain.gapsize, frMain.canvas_y - frMain.gapsize, frMain.canvas_x - frMain.gapsize, frMain.canvas_y - frMain.gapsize);
			this.Draw(frMain.gapsize, frMain.canvas_y - frMain.gapsize, frMain.gapsize, frMain.gapsize);
			bool @checked = this.chShowGrid.Checked;
			if (chShowGrid.Checked)
			{
				frMain.gridsize = Convert.ToInt32(this.nudGridSize.Value);
				this.myPen.Color = Color.LightGray;
				this.myPen.Width = 1f;
				int num = frMain.canvas_y - frMain.gapsize - frMain.gridsize;
				do
				{
					this.Draw(frMain.gapsize, num, frMain.canvas_x - frMain.gapsize, num);
					num -= frMain.gridsize;
				}
				while (num > frMain.gapsize);
				num = frMain.gapsize + frMain.gridsize;
				do
				{
					this.Draw(num, frMain.canvas_y - frMain.gapsize, num, frMain.gapsize);
					num += frMain.gridsize;
				}
				while (num < frMain.canvas_x - frMain.gapsize);
			}
			bool curveisReady = frMain.CurveisReady;
			if (curveisReady)
			{
				try
				{
					frMain.SpanX = Convert.ToInt32(this.nudSpanX.Value);
					frMain.SpanY = Convert.ToInt32(this.nudSpanY.Value);
				}
				catch
				{
					frMain.SpanX = 0;
					frMain.SpanX = 0;
				}
				bool flag = this.festoYJKP.NormalizeReadDatatoCanvasSize(frMain.CurveType, frMain.canvas_x, frMain.canvas_y, frMain.gapsize, frMain.gridsize, frMain.SpanX, frMain.SpanY);
				if (festoYJKP.NormalizeReadDatatoCanvasSize(frMain.CurveType, frMain.canvas_x, frMain.canvas_y, frMain.gapsize, frMain.gridsize, frMain.SpanX, frMain.SpanY))
				{
					this.myPen.Color = Color.Blue;
					this.myPen.Width = 1f;
					this.lbGrid.Text = "[Grid]   X: " + this.festoYJKP.Grid_x.ToString("0.00") + ", Y: " + this.festoYJKP.Grid_y.ToString("0.00");
					this.lbRefX.Text = this.festoYJKP.Ref_x.ToString("0.00");
					this.lbRefY.Text = this.festoYJKP.Ref_y.ToString("0.00");
					this.GridLabel();
					int num2 = Convert.ToInt32(this.nudCurvePoint.Value);
					int num3 = this.festoYJKP.NumPoint / num2;
					bool flag2 = num3 == 0;
					if (num3 == 0)
					{
						num3 = 1;
					}
					for (int i = 1; i < this.festoYJKP.NumPoint; i += num3)
					{
						bool flag3 = i + num3 > this.festoYJKP.NumPoint;
						if (i + num3 > this.festoYJKP.NumPoint)
						{
							num3 = this.festoYJKP.NumPoint - i;
						}
						switch (frMain.CurveType)
						{
						case 0:
							this.DrawSpan(this.festoYJKP.NormPosition_x[i], this.festoYJKP.NormForce[i], this.festoYJKP.NormPosition_x[i + num3], this.festoYJKP.NormForce[i + num3]);
							break;
						case 1:
							this.DrawSpan(this.festoYJKP.NormTime[i], this.festoYJKP.NormForce[i], this.festoYJKP.NormTime[i + num3], this.festoYJKP.NormForce[i + num3]);
							break;
						case 2:
							this.DrawSpan(this.festoYJKP.NormTime[i], this.festoYJKP.NormPosition_y[i], this.festoYJKP.NormTime[i + num3], this.festoYJKP.NormPosition_y[i + num3]);
							break;
						}
					}
					int num4 = 0;
					bool checked2 = this.chWindow.Checked;
					if (chWindow.Checked)
					{
						this.myPen.Color = Color.Green;
						this.myPen.Width = 1f;
						for (int j = 0; j < 5; j++)
						{
							bool flag4 = !this.festoYJKP.WEvaluationStatus[j];
							if (!festoYJKP.WEvaluationStatus[j])
							{
								this.myPen.Color = Color.Green;
							}
							else
							{
								this.myPen.Color = Color.Red;
							}
							bool flag5 = this.festoYJKP.WActive[j] && frMain.CurveType == 0;
							if (festoYJKP.WActive[j] && frMain.CurveType == 0)
							{
								this.DrawSpan(this.festoYJKP.WNormMinPosVal[j], this.festoYJKP.WNormMinForceVal[j], this.festoYJKP.WNormMaxPosVal[j], this.festoYJKP.WNormMinForceVal[j]);
								this.DrawSpan(this.festoYJKP.WNormMaxPosVal[j], this.festoYJKP.WNormMinForceVal[j], this.festoYJKP.WNormMaxPosVal[j], this.festoYJKP.WNormMaxForceVal[j]);
								this.DrawSpan(this.festoYJKP.WNormMaxPosVal[j], this.festoYJKP.WNormMaxForceVal[j], this.festoYJKP.WNormMinPosVal[j], this.festoYJKP.WNormMaxForceVal[j]);
								this.DrawSpan(this.festoYJKP.WNormMinPosVal[j], this.festoYJKP.WNormMaxForceVal[j], this.festoYJKP.WNormMinPosVal[j], this.festoYJKP.WNormMinForceVal[j]);
								this.EvaluationNumber(this.festoYJKP.WNormMinPosVal[j], this.festoYJKP.WNormMaxForceVal[j], num4, j);
								num4++;
							}
							bool flag6 = this.festoYJKP.WActive[j] && frMain.CurveType == 1;
							if (festoYJKP.WActive[j] && frMain.CurveType == 1)
							{
								this.DrawSpan(this.festoYJKP.WNormMinTime[j], this.festoYJKP.WNormMinForceVal[j], this.festoYJKP.WNormMaxTime[j], this.festoYJKP.WNormMinForceVal[j]);
								this.DrawSpan(this.festoYJKP.WNormMaxTime[j], this.festoYJKP.WNormMinForceVal[j], this.festoYJKP.WNormMaxTime[j], this.festoYJKP.WNormMaxForceVal[j]);
								this.DrawSpan(this.festoYJKP.WNormMaxTime[j], this.festoYJKP.WNormMaxForceVal[j], this.festoYJKP.WNormMinTime[j], this.festoYJKP.WNormMaxForceVal[j]);
								this.DrawSpan(this.festoYJKP.WNormMinTime[j], this.festoYJKP.WNormMaxForceVal[j], this.festoYJKP.WNormMinTime[j], this.festoYJKP.WNormMinForceVal[j]);
								this.EvaluationNumber(this.festoYJKP.WNormMinTime[j], this.festoYJKP.WNormMaxForceVal[j], num4, j);
								num4++;
							}
						}
					}
					bool checked3 = this.chThreshold.Checked;
					if (chThreshold.Checked)
					{
						this.myPen.Color = Color.Green;
						this.myPen.Width = 1f;
						for (int k = 0; k < 5; k++)
						{
							bool flag7 = !this.festoYJKP.TEvaluationStatus[k];
							if (!this.festoYJKP.TEvaluationStatus[k])
							{
								this.myPen.Color = Color.Green;
							}
							else
							{
								this.myPen.Color = Color.Red;
							}
							bool flag8 = this.festoYJKP.TActive[k] && frMain.CurveType == 0;
							if (festoYJKP.TActive[k] && frMain.CurveType == 0)
							{
								bool flag9 = !this.festoYJKP.TMode[k];
								if (!this.festoYJKP.TMode[k])
								{
									this.DrawSpan(this.festoYJKP.TNormPosVal[k], this.festoYJKP.TNormMinForceVal[k], this.festoYJKP.TNormPosVal[k], this.festoYJKP.TNormMaxForceVal[k]);
									this.EvaluationNumber(this.festoYJKP.TNormPosVal[k], this.festoYJKP.TNormMaxForceVal[k], num4, k);
									num4++;
								}
								else
								{
									this.DrawSpan(this.festoYJKP.TNormMinPosVal[k], this.festoYJKP.TNormForceVal[k], this.festoYJKP.TNormMaxPosVal[k], this.festoYJKP.TNormForceVal[k]);
									this.EvaluationNumber(this.festoYJKP.TNormMinPosVal[k], this.festoYJKP.TNormForceVal[k], num4, k);
									num4++;
								}
							}
							bool flag10 = this.festoYJKP.TActive[k] && frMain.CurveType == 1;
							if (this.festoYJKP.TActive[k] && frMain.CurveType == 1)
							{
								bool flag11 = !this.festoYJKP.TMode[k];
								if (!this.festoYJKP.TMode[k])
								{
									this.DrawSpan(this.festoYJKP.TNormTime[k], this.festoYJKP.TNormMinForceVal[k], this.festoYJKP.TNormTime[k], this.festoYJKP.TNormMaxForceVal[k]);
									this.EvaluationNumber(this.festoYJKP.TNormTime[k], this.festoYJKP.TNormMaxForceVal[k], num4, k);
									num4++;
								}
								else
								{
									this.DrawSpan(this.festoYJKP.TNormMinTime[k], this.festoYJKP.TNormForceVal[k], this.festoYJKP.TNormMaxTime[k], this.festoYJKP.TNormForceVal[k]);
									this.EvaluationNumber(this.festoYJKP.TNormMinTime[k], this.festoYJKP.TNormForceVal[k], num4, k);
									num4++;
								}
							}
						}
					}
					bool checked4 = this.chEnvelope.Checked;
					if (chEnvelope.Checked)
					{
						this.myPen.Color = Color.Green;
						this.myPen.Width = 1f;
						for (int l = 0; l < 5; l++)
						{
							bool flag12 = !this.festoYJKP.EEvaluationStatus[l];
							if (!this.festoYJKP.EEvaluationStatus[l])
							{
								this.myPen.Color = Color.Green;
							}
							else
							{
								this.myPen.Color = Color.Red;
							}
							bool flag13 = this.festoYJKP.EActive[l] && frMain.CurveType == 0;
							if (festoYJKP.EActive[l] && frMain.CurveType == 0)
							{
								bool flag14 = this.festoYJKP.EPointUp[l] >= 2;
								if (festoYJKP.EPointUp[l] >= 2)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp1Pos[l], this.festoYJKP.ENormPointUp1Force[l], this.festoYJKP.ENormPointUp2Pos[l], this.festoYJKP.ENormPointUp2Force[l]);
								}
								bool flag15 = this.festoYJKP.EPointUp[l] >= 3;
								if (festoYJKP.EPointUp[l] >= 3)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp2Pos[l], this.festoYJKP.ENormPointUp2Force[l], this.festoYJKP.ENormPointUp3Pos[l], this.festoYJKP.ENormPointUp3Force[l]);
								}
								bool flag16 = this.festoYJKP.EPointUp[l] >= 4;
								if (festoYJKP.EPointUp[l] >= 4)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp3Pos[l], this.festoYJKP.ENormPointUp3Force[l], this.festoYJKP.ENormPointUp4Pos[l], this.festoYJKP.ENormPointUp4Force[l]);
								}
								bool flag17 = this.festoYJKP.EPointUp[l] >= 5;
								if (festoYJKP.EPointUp[l] >= 5)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp4Pos[l], this.festoYJKP.ENormPointUp4Force[l], this.festoYJKP.ENormPointUp5Pos[l], this.festoYJKP.ENormPointUp5Force[l]);
								}
								this.EvaluationNumber(this.festoYJKP.ENormPointUp1Pos[l] - 10, this.festoYJKP.ENormPointUp1Force[l], num4, l);
								num4++;
							}
							bool flag18 = this.festoYJKP.EActive[l] && frMain.CurveType == 1;
							if (festoYJKP.EActive[l] && frMain.CurveType == 1)
							{
								bool flag19 = this.festoYJKP.EPointUp[l] >= 2;
								if (festoYJKP.EPointUp[l] >= 2)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp1Time[l], this.festoYJKP.ENormPointUp1Force[l], this.festoYJKP.ENormPointUp2Time[l], this.festoYJKP.ENormPointUp2Force[l]);
								}
								bool flag20 = this.festoYJKP.EPointUp[l] >= 3;
								if (festoYJKP.EPointUp[l] >= 3)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp2Time[l], this.festoYJKP.ENormPointUp2Force[l], this.festoYJKP.ENormPointUp3Time[l], this.festoYJKP.ENormPointUp3Force[l]);
								}
								bool flag21 = this.festoYJKP.EPointUp[l] >= 4;
								if (festoYJKP.EPointUp[l] >= 4)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp3Time[l], this.festoYJKP.ENormPointUp3Force[l], this.festoYJKP.ENormPointUp4Time[l], this.festoYJKP.ENormPointUp4Force[l]);
								}
								bool flag22 = this.festoYJKP.EPointUp[l] >= 5;
								if (festoYJKP.EPointUp[l] >= 5)
								{
									this.DrawSpan(this.festoYJKP.ENormPointUp4Time[l], this.festoYJKP.ENormPointUp4Force[l], this.festoYJKP.ENormPointUp5Time[l], this.festoYJKP.ENormPointUp5Force[l]);
								}
								this.EvaluationNumber(this.festoYJKP.ENormPointUp1Time[l] - 10, this.festoYJKP.ENormPointUp1Force[l], num4, l);
								num4++;
							}
						}
						this.myPen.Color = Color.Green;
						this.myPen.Width = 1f;
						for (int m = 0; m < 5; m++)
						{
							bool flag23 = !this.festoYJKP.EEvaluationStatus[m];
							if (!this.festoYJKP.EEvaluationStatus[m])
							{
								this.myPen.Color = Color.Green;
							}
							else
							{
								this.myPen.Color = Color.Red;
							}
							bool flag24 = this.festoYJKP.EActive[m] && frMain.CurveType == 0;
							if (festoYJKP.EActive[m] && frMain.CurveType == 0)
							{
								bool flag25 = this.festoYJKP.EPointDown[m] >= 2;
								if (flag25)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown1Pos[m], this.festoYJKP.ENormPointDown1Force[m], this.festoYJKP.ENormPointDown2Pos[m], this.festoYJKP.ENormPointDown2Force[m]);
								}
								bool flag26 = this.festoYJKP.EPointDown[m] >= 3;
								if (flag26)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown2Pos[m], this.festoYJKP.ENormPointDown2Force[m], this.festoYJKP.ENormPointDown3Pos[m], this.festoYJKP.ENormPointDown3Force[m]);
								}
								bool flag27 = this.festoYJKP.EPointDown[m] >= 4;
								if (flag27)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown3Pos[m], this.festoYJKP.ENormPointDown3Force[m], this.festoYJKP.ENormPointDown4Pos[m], this.festoYJKP.ENormPointDown4Force[m]);
								}
								bool flag28 = this.festoYJKP.EPointDown[m] >= 5;
								if (flag28)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown4Pos[m], this.festoYJKP.ENormPointDown4Force[m], this.festoYJKP.ENormPointDown5Pos[m], this.festoYJKP.ENormPointDown5Force[m]);
								}
							}
							bool flag29 = this.festoYJKP.EActive[m] && frMain.CurveType == 1;
							if (festoYJKP.EActive[m] && frMain.CurveType == 1)
							{
								bool flag30 = this.festoYJKP.EPointDown[m] >= 2;
								if (flag30)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown1Time[m], this.festoYJKP.ENormPointDown1Force[m], this.festoYJKP.ENormPointDown2Time[m], this.festoYJKP.ENormPointDown2Force[m]);
								}
								bool flag31 = this.festoYJKP.EPointDown[m] >= 3;
								if (flag31)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown2Time[m], this.festoYJKP.ENormPointDown2Force[m], this.festoYJKP.ENormPointDown3Time[m], this.festoYJKP.ENormPointDown3Force[m]);
								}
								bool flag32 = this.festoYJKP.EPointDown[m] >= 4;
								if (flag32)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown3Time[m], this.festoYJKP.ENormPointDown3Force[m], this.festoYJKP.ENormPointDown4Time[m], this.festoYJKP.ENormPointDown4Force[m]);
								}
								bool flag33 = this.festoYJKP.EPointDown[m] >= 5;
								if (flag33)
								{
									this.DrawSpan(this.festoYJKP.ENormPointDown4Time[m], this.festoYJKP.ENormPointDown4Force[m], this.festoYJKP.ENormPointDown5Time[m], this.festoYJKP.ENormPointDown5Force[m]);
								}
							}
						}
					}
					this.myPen.Color = Color.Green;
					this.myPen.Width = 1f;
					for (int n = 0; n < 5; n++)
					{
						bool checked5 = this.chWindow.Checked;
						if (checked5)
						{
							bool flag34 = this.festoYJKP.WActive[n] && frMain.CurveType == 0;
							if (flag34)
							{
								int midPointX = this.GetMidPointX(this.festoYJKP.WNormMinPosVal[n], this.festoYJKP.WNormMaxPosVal[n]);
								int midPointX2 = this.GetMidPointX(this.festoYJKP.WNormMinForceVal[n], this.festoYJKP.WNormMaxForceVal[n]);
								this.DrawConfig(this.festoYJKP.WConfigDown[n], midPointX, this.festoYJKP.WNormMinForceVal[n], "WindowButtom");
								this.DrawConfig(this.festoYJKP.WConfigRight[n], this.festoYJKP.WNormMaxPosVal[n], midPointX2, "WindowRight");
								this.DrawConfig(this.festoYJKP.WConfigUp[n], midPointX, this.festoYJKP.WNormMaxForceVal[n], "WindowUp");
								this.DrawConfig(this.festoYJKP.WConfigLeft[n], this.festoYJKP.WNormMinPosVal[n], midPointX2, "WindowLeft");
							}
							bool flag35 = this.festoYJKP.WActive[n] && frMain.CurveType == 1;
							if (flag35)
							{
								int midPointX3 = this.GetMidPointX(this.festoYJKP.WNormMinTime[n], this.festoYJKP.WNormMaxTime[n]);
								int midPointX4 = this.GetMidPointX(this.festoYJKP.WNormMinForceVal[n], this.festoYJKP.WNormMaxForceVal[n]);
								this.DrawConfig(this.festoYJKP.WConfigDown[n], midPointX3, this.festoYJKP.WNormMinForceVal[n], "WindowButtom");
								this.DrawConfig(this.festoYJKP.WConfigRight[n], this.festoYJKP.WNormMaxTime[n], midPointX4, "WindowRight");
								this.DrawConfig(this.festoYJKP.WConfigUp[n], midPointX3, this.festoYJKP.WNormMaxForceVal[n], "WindowUp");
								this.DrawConfig(this.festoYJKP.WConfigLeft[n], this.festoYJKP.WNormMinTime[n], midPointX4, "WindowLeft");
							}
						}
						bool checked6 = this.chThreshold.Checked;
						if (checked6)
						{
							bool flag36 = this.festoYJKP.TActive[n] && frMain.CurveType == 0;
							if (flag36)
							{
								bool flag37 = !this.festoYJKP.TMode[n];
								if (flag37)
								{
									int midPointX5 = this.GetMidPointX(this.festoYJKP.TNormMinForceVal[n], this.festoYJKP.TNormMaxForceVal[n]);
									this.DrawConfig(this.festoYJKP.TConfig2[n], this.festoYJKP.TNormPosVal[n], midPointX5, "TresholdPos");
								}
								else
								{
									int midPointX6 = this.GetMidPointX(this.festoYJKP.TNormMinPosVal[n], this.festoYJKP.TNormMaxPosVal[n]);
									this.DrawConfig(this.festoYJKP.TConfig2[n], midPointX6, this.festoYJKP.TNormForceVal[n], "TresholdForce");
								}
							}
							bool flag38 = this.festoYJKP.TActive[n] && frMain.CurveType == 1;
							if (flag38)
							{
								bool flag39 = !this.festoYJKP.TMode[n];
								if (flag39)
								{
									int midPointX7 = this.GetMidPointX(this.festoYJKP.TNormMinForceVal[n], this.festoYJKP.TNormMaxForceVal[n]);
									this.DrawConfig(this.festoYJKP.TConfig2[n], this.festoYJKP.TNormTime[n], midPointX7, "TresholdPos");
								}
								else
								{
									int midPointX8 = this.GetMidPointX(this.festoYJKP.TNormMinTime[n], this.festoYJKP.TNormMaxTime[n]);
									this.DrawConfig(this.festoYJKP.TConfig2[n], midPointX8, this.festoYJKP.TNormForceVal[n], "TresholdForce");
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00003844 File Offset: 0x00001A44
		private void EvaluationNumber(int X, int Y, int i, int Num)
		{
			this.lbEvaluationNumber[i].Left = X + frMain.SpanX - 5;
			this.lbEvaluationNumber[i].Top = Y - frMain.SpanY - 15;
			this.lbEvaluationNumber[i].Text = (Num + 1).ToString();
			bool @checked = this.chEvaluationNumber.Checked;
			if (@checked)
			{
				this.lbEvaluationNumber[i].Visible = true;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000038BC File Offset: 0x00001ABC
		private void EvaluationNumberLabelRefresh()
		{
			for (int i = 0; i < 15; i++)
			{
				this.lbEvaluationNumber[i].Visible = false;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000038EC File Offset: 0x00001AEC
		private int GetMidPointX(int X1, int X2)
		{
			return (X1 + X2) / 2;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003904 File Offset: 0x00001B04
		private int GetMidPointY(int Y1, int Y2)
		{
			return (Y1 + Y2) / 2;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000391C File Offset: 0x00001B1C
		private void DrawConfig(byte Config, int X, int Y, string ConfigType)
		{
			int num = 5;
			bool flag = ConfigType.Substring(0, 6) == "Window" && Config == 1;
			if (flag)
			{
				this.DrawSpan(X - num, Y + num, X + num, Y - num);
				this.DrawSpan(X - num, Y - num, X + num, Y + num);
			}
			bool flag2 = (ConfigType == "WindowButtom" && Config == 2) || (ConfigType == "WindowUp" && Config == 3) || (ConfigType == "TresholdForce" && Config == 0);
			if (flag2)
			{
				this.DrawSpan(X - num, Y, X, Y - num);
				this.DrawSpan(X + num, Y, X, Y - num);
			}
			bool flag3 = (ConfigType == "WindowButtom" && Config == 3) || (ConfigType == "WindowUp" && Config == 2) || (ConfigType == "TresholdForce" && Config == 1);
			if (flag3)
			{
				this.DrawSpan(X - num, Y, X, Y + num);
				this.DrawSpan(X + num, Y, X, Y + num);
			}
			bool flag4 = (ConfigType == "WindowLeft" && Config == 3) || (ConfigType == "WindowRight" && Config == 2) || (ConfigType == "TresholdPos" && Config == 2);
			if (flag4)
			{
				this.DrawSpan(X, Y - num, X - num, Y);
				this.DrawSpan(X, Y + num, X - num, Y);
			}
			bool flag5 = (ConfigType == "WindowLeft" && Config == 2) || (ConfigType == "WindowRight" && Config == 3) || (ConfigType == "TresholdPos" && Config == 3);
			if (flag5)
			{
				this.DrawSpan(X, Y - num, X + num, Y);
				this.DrawSpan(X, Y + num, X + num, Y);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003AF8 File Offset: 0x00001CF8
		private void Draw(int startx, int starty, int endx, int endy)
		{
			Point[] points = new Point[]
			{
				new Point(startx, starty),
				new Point(endx, endy)
			};
			this.g.DrawLines(this.myPen, points);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003B40 File Offset: 0x00001D40
		private void DrawSpan(int startx, int starty, int endx, int endy)
		{
			Point[] points = new Point[]
			{
				new Point(startx + frMain.SpanX, starty - frMain.SpanY),
				new Point(endx + frMain.SpanX, endy - frMain.SpanY)
			};
			this.g.DrawLines(this.myPen, points);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003BA0 File Offset: 0x00001DA0
		private void btGenerateCurve_Click(object sender, EventArgs e)
		{
			bool @checked = this.chGetData.Checked;
			if (@checked)
			{
				this.lbStatus.Text = "Loading..";
				bool recordData = this.festoYJKP.GetRecordData(this.cbLookFor.Text);
				if (recordData)
				{
					this.lbNumPoint.Text = this.festoYJKP.NumPoint.ToString("0");
					this.lbRecordTime.Text = this.festoYJKP.RecordTime.ToString("0");
					this.lbMaxForce.Text = this.festoYJKP.MaxForce.ToString("0.00");
					this.lbMaxPosition.Text = this.festoYJKP.MaxPosition.ToString("0.00");
					bool xisTime = this.festoYJKP.XisTime;
					string str;
					if (xisTime)
					{
						str = "Force - Time";
						this.lbCurve1.Visible = true;
						this.lbCurve0.Visible = false;
					}
					else
					{
						str = "Force - Position";
						this.lbCurve1.Visible = false;
						this.lbCurve0.Visible = true;
					}
					this.lbStatus.Text = "Default Evaluation: " + str;
					this.GenerateCurve();
					bool flag = frMain.CurveType == 0;
					if (flag)
					{
						this.lbPosDirectionLeft.Visible = !this.festoYJKP.PosDirectionRight();
					}
					else
					{
						this.lbPosDirectionLeft.Visible = false;
					}
				}
				else
				{
					this.lbStatus.Text = "Data not found!";
				}
			}
			else
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00003D5C File Offset: 0x00001F5C
		private void GenerateCurve()
		{
			bool flag = this.festoYJKP.XisTime && frMain.ClickOnLogFile;
			if (festoYJKP.XisTime && frMain.ClickOnLogFile)
			{
				this.lbCurveType.SelectedIndex = 1;
			}
			bool flag2 = !this.festoYJKP.XisTime && frMain.ClickOnLogFile;
			if (!festoYJKP.XisTime && frMain.ClickOnLogFile)
			{
				this.lbCurveType.SelectedIndex = 0;
			}
			frMain.CurveType = this.lbCurveType.SelectedIndex;
			switch (frMain.CurveType)
			{
			case -1:
				this.lbCurveType.SelectedIndex = 0;
				frMain.CurveType = 0;
				this.lbAxisX.Text = "Position (mm)";
				this.lbAxisY.Text = "Force (N)";
				break;
			case 0:
				this.lbAxisX.Text = "Position (mm)";
				this.lbAxisY.Text = "Force (N)";
				break;
			case 1:
				this.lbAxisX.Text = "Time (ms)";
				this.lbAxisY.Text = "Force (N)";
				break;
			case 2:
				this.lbAxisX.Text = "Time (ms)";
				this.lbAxisY.Text = "Position (mm)";
				break;
			}
			frMain.CurveisReady = true;
			this.EvaluationNumberLabelRefresh();
			this.canvas.Refresh();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003EAC File Offset: 0x000020AC
		private void btGetData_Click(object sender, EventArgs e)
		{
			this.lbStatus.Text = "Loading..";
			bool recordData = this.festoYJKP.GetRecordData(this.cbLookFor.Text);
			if (recordData)
			{
				this.lbNumPoint.Text = this.festoYJKP.NumPoint.ToString("0");
				this.lbRecordTime.Text = this.festoYJKP.RecordTime.ToString("0");
				this.lbMaxForce.Text = this.festoYJKP.MaxForce.ToString("0.00");
				this.lbMaxPosition.Text = this.festoYJKP.MaxPosition.ToString("0.00");
				this.lbStatus.Text = "Data found";
				this.btGenerateCurve.Enabled = true;
			}
			else
			{
				this.lbStatus.Text = "Data not found!";
				this.btGenerateCurve.Enabled = false;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003FBC File Offset: 0x000021BC
		private void GetFileName()
		{
			this.lsFileName.Items.Clear();

			DirectoryInfo di = new DirectoryInfo(txPath.Text);
			FileInfo[] arrFi_CurPath = di.GetFiles("*.log");

			if (chk_Select.Checked)
			{
				if (rdo_OK.Checked)
				{
					if (cob_ParaName.Text == "Serial number")
					{
						arrFi_CurPath = di.GetFiles("*" + txt_Value.Text + "*_OK.log");
					}
					else if (cob_ParaName.Text == "Program name")
					{
						arrFi_CurPath = di.GetFiles(txt_Value.Text + "*_OK.log");
					}
					else if (cob_ParaName.Text == "MAC Address")
					{
						arrFi_CurPath = di.GetFiles("*" + txt_Value.Text + "*_OK.log");
					}
				}
				else if (rdo_NOK.Checked)
				{
					if (cob_ParaName.Text == "Serial number")
					{
						arrFi_CurPath = di.GetFiles("*" + txt_Value.Text + "*_NOK.log");
					}
					else if (cob_ParaName.Text == "Program name")
					{
						arrFi_CurPath = di.GetFiles(txt_Value.Text + "*_NOK.log");
					}
					else if (cob_ParaName.Text == "MAC Address")
					{
						arrFi_CurPath = di.GetFiles("*" + txt_Value.Text + "*_NOK.log");
					}
				}
				else
				{
					if (cob_ParaName.Text == "Serial number")
					{
						arrFi_CurPath = di.GetFiles("*" + txt_Value.Text + "*.log");
					}
					else if (cob_ParaName.Text == "Program name")
					{
						arrFi_CurPath = di.GetFiles(txt_Value.Text + "*.log");
					}
					else if (cob_ParaName.Text == "MAC Address")
					{
						arrFi_CurPath = di.GetFiles("*" + txt_Value.Text + "*.log");
					}
				}

			}
			else
			{
				if (rdo_OK.Checked)
				{
					arrFi_CurPath = di.GetFiles("*_OK.log");
				}
				else if (rdo_NOK.Checked)
				{
					arrFi_CurPath = di.GetFiles("*_NOK.log");
				}
			}
			for (int i = 0; i < arrFi_CurPath.Length; i++)
			{
				lsFileName.Items.Add(arrFi_CurPath[i].Name);
			}
			if (lsFileName.Items.Count > 0)
			{
				this.lsFileName.SelectedIndex = 0;
				this.lbFileName.Text = this.lsFileName.Text;
			}

		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004092 File Offset: 0x00002292
		private void btGetFileName_Click(object sender, EventArgs e)
		{
			this.GetFileName();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000409C File Offset: 0x0000229C
		private void lsFileName_SelectedIndexChanged(object sender, EventArgs e)
		{
			frMain.ClickOnLogFile = true;
			this.lbFileName.Text = this.lsFileName.Text;
			byte b = this.festoYJKP.ReadLogFile(this.txPath.Text, this.lsFileName.Text);
			this.cbLookFor.Items.Clear();
			this.cbLookFor.Text = "";
			for (byte b2 = 1; b2 <= b; b2 += 1)
			{
				this.cbLookFor.Items.Add("[Record " + b2.ToString() + "]");
			}
			bool flag = b > 0;
			if (flag)
			{
				this.cbLookFor.Text = "[Record 1]";
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004163 File Offset: 0x00002363
		private void txPath_TextChanged(object sender, EventArgs e)
		{
			
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00004166 File Offset: 0x00002366
		private void chGetData_CheckedChanged(object sender, EventArgs e)
		{
			this.btGenerateCurve.Enabled = this.chGetData.Checked;
			this.btGetData.Enabled = !this.chGetData.Checked;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000419C File Offset: 0x0000239C
		private void nudGridSize_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000041C4 File Offset: 0x000023C4
		private void nudSpanX_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000041EC File Offset: 0x000023EC
		private void nudSpanY_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004214 File Offset: 0x00002414
		private void chWindow_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000423C File Offset: 0x0000243C
		private void chThreshold_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004264 File Offset: 0x00002464
		private void chEnvelope_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000428C File Offset: 0x0000248C
		private void chEvaluationNumber_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000042B4 File Offset: 0x000024B4
		private void chShowGrid_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000042DC File Offset: 0x000024DC
		private void nudCurvePoint_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GenerateCurve();
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004302 File Offset: 0x00002502
		private void btGetLogFiles_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004308 File Offset: 0x00002508
		private void lbFTP_Click(object sender, EventArgs e)
		{
			bool flag = this.lbFTP.Text == ">>";
			if (flag)
			{
				this.pFTP.Width = 231;
				this.lbFTP.Text = "<<";
			}
			else
			{
				this.pFTP.Width = 26;
				this.lbFTP.Text = ">>";
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004376 File Offset: 0x00002576
		private void cbLookFor_SelectedIndexChanged(object sender, EventArgs e)
		{
			frMain.ClickOnLogFile = true;
			btGenerateCurve_Click(sender, e);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004380 File Offset: 0x00002580
		private void canvas_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.festoYJKP.CursorValue(frMain.CurveType, Cursor.Position.X, Cursor.Position.Y, base.Location.X, base.Location.Y, this.canvas.Location.X, this.canvas.Location.Y, frMain.canvas_y, frMain.gapsize, frMain.SpanX, frMain.SpanY);
			if (flag)
			{
				this.lbCursorValue.Text = "[Pos]   X: " + this.festoYJKP.CursorValue_x.ToString("0.00") + ", Y: " + this.festoYJKP.CursorValue_y.ToString("0.00");
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004460 File Offset: 0x00002660
		private void LabelInit()
		{
			for (int i = 0; i < 20; i++)
			{
				this.lbGridX[i] = new Label();
				this.lbGridX[i].ForeColor = Color.Black;
				this.lbGridX[i].AutoSize = true;
				this.pGridX.Controls.Add(this.lbGridX[i]);
				this.lbGridY[i] = new Label();
				this.lbGridY[i].ForeColor = Color.Black;
				this.lbGridY[i].AutoSize = false;
				this.lbGridY[i].Width = 47;
				this.lbGridY[i].TextAlign = ContentAlignment.MiddleRight;
				this.pGridY.Controls.Add(this.lbGridY[i]);
			}
			for (int j = 0; j < 15; j++)
			{
				this.lbEvaluationNumber[j] = new Label();
				this.lbEvaluationNumber[j].ForeColor = Color.Black;
				this.lbEvaluationNumber[j].AutoSize = true;
				this.lbEvaluationNumber[j].Visible = false;
				this.canvas.Controls.Add(this.lbEvaluationNumber[j]);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000045A1 File Offset: 0x000027A1
		private void lbCurveType_SelectedIndexChanged(object sender, EventArgs e)
		{
			frMain.ClickOnLogFile = false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000045AC File Offset: 0x000027AC
		private void lbHidePanelLeft_Click(object sender, EventArgs e)
		{
			bool flag = this.lbHidePanelLeft.Text == "<<";
			if (flag)
			{
				this.lbHidePanelLeft.Text = ">>";
				this.pLeft.Width = 25;
				this.pTop.Height = 1;
				this.lbStatus.Visible = false;
				this.tDelay.Enabled = true;
			}
			else
			{
				this.lbHidePanelLeft.Text = "<<";
				this.pLeft.Width = 292;
				this.pTop.Height = 92;
				this.lbStatus.Visible = true;
				this.tDelay.Enabled = true;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000466C File Offset: 0x0000286C
		private void tDelay_Tick(object sender, EventArgs e)
		{
			bool enabled = this.btGenerateCurve.Enabled;
			if (enabled)
			{
				this.GetCanvasSize();
				frMain.CurveisReady = false;
				this.GenerateCurve();
				this.EvaluationNumberLabelRefresh();
				this.canvas.Refresh();
			}
			this.tDelay.Enabled = false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000046BF File Offset: 0x000028BF
		private void pGridX_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000046C4 File Offset: 0x000028C4
		private void GridLabel()
		{
			for (int i = 0; i < 20; i++)
			{
				this.lbGridX[i].Text = (this.festoYJKP.Ref_x + this.festoYJKP.Grid_x * (float)(i + 1) * 2f).ToString("0.00");
				this.lbGridX[i].Left = frMain.gridsize * (i + 1) * 2 - 65;
				this.lbGridY[i].Text = (this.festoYJKP.Ref_y + this.festoYJKP.Grid_y * (float)(i + 1) * 2f).ToString("0.00");
				this.lbGridY[i].Top = this.pGridY.Height - frMain.gridsize * (i + 1) * 2 - 20;
			}
		}

		// Token: 0x04000001 RID: 1
		private festoYJKP festoYJKP = new festoYJKP();

		// Token: 0x04000002 RID: 2
		private Pen myPen = new Pen(Color.Black);

		// Token: 0x04000003 RID: 3
		private Graphics g = null;

		// Token: 0x04000004 RID: 4
		private static int canvas_x;

		// Token: 0x04000005 RID: 5
		private static int canvas_y;

		// Token: 0x04000006 RID: 6
		private static int gapsize = 50;

		// Token: 0x04000007 RID: 7
		private static int gridsize = 10;

		// Token: 0x04000008 RID: 8
		private static int SpanX = 0;

		// Token: 0x04000009 RID: 9
		private static int SpanY = 0;

		// Token: 0x0400000A RID: 10
		private static int CurveType = 0;

		// Token: 0x0400000B RID: 11
		private static bool CurveisReady = false;

		// Token: 0x0400000C RID: 12
		private static bool ClickOnLogFile = false;

		// Token: 0x0400000D RID: 13
		private Label[] lbGridX = new Label[20];

		// Token: 0x0400000E RID: 14
		private Label[] lbGridY = new Label[20];

		// Token: 0x0400000F RID: 15
		private Label[] lbEvaluationNumber = new Label[15];

        private void txPath_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar == 13)
			{
				btGetFileName_Click(null, null);
			}
		}

        private void txPath_DoubleClick(object sender, EventArgs e)
        {
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				txPath.Text = folderBrowserDialog.SelectedPath;
				btGetFileName_Click(null, null);
			}
		}

        private void chk_Select_CheckedChanged(object sender, EventArgs e)
        {
			cob_ParaName.Enabled = chk_Select.Checked;
			txt_Value.Enabled = chk_Select.Checked;
			//rdo_All.Enabled=!chk_Select.Checked;
			//rdo_OK.Enabled = !chk_Select.Checked;
			//rdo_NOK.Enabled = !chk_Select.Checked;
			if (chk_Select.Checked && txt_Value.Text != "")
			{
				btGetFileName_Click(null, null);
			}
			else if (!chk_Select.Checked)

			{
				btGetFileName_Click(null, null);
			}
		}

        private void rdo_All_CheckedChanged(object sender, EventArgs e)
        {
			btGetFileName_Click(sender, e);
		}

        private void rdo_OK_CheckedChanged(object sender, EventArgs e)
        {
			btGetFileName_Click(sender, e);
		}

        private void rdo_NOK_CheckedChanged(object sender, EventArgs e)
        {
			btGetFileName_Click(sender, e);
		}

        private void txt_Value_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar == 13)
			{
				btGetFileName_Click(null, null);
			}
		}

        private void frMain_DragDrop(object sender, DragEventArgs e)
        {
			////string fullPath = @"D:\\我的桌面\\Pic\\0003.jpg";
			//////D:\我的桌面\Pic
			////string FilePath = Path.GetDirectoryName(fullPath);

			//////文件名  “0003.aspx”
			////string FileName1 = System.IO.Path.GetFileName(fullPath);

			//////扩展名 “.jpg”
			////string Extension = System.IO.Path.GetExtension(fullPath);

			////// 没有扩展名的文件名 “0003”
			////string FileName2 = System.IO.Path.GetFileNameWithoutExtension(fullPath);
			string[] fullPaths =  e.Data.GetData(DataFormats.FileDrop) as string[];
			txPath.Text = Path.GetDirectoryName(fullPaths[0]);
			lsFileName.Items.Clear();
            for (int i = 0; i < fullPaths.Length; i++)
            {
				lsFileName.Items.Add(System.IO.Path.GetFileName(fullPaths[i]));
			}
			if (lsFileName.Items.Count > 0)
			{
				this.lsFileName.SelectedIndex = 0;
				this.lbFileName.Text = this.lsFileName.Text;
			}
		}

        private void canvas_DragDrop(object sender, DragEventArgs e)
        {
			string[] fullPaths = e.Data.GetData(DataFormats.FileDrop) as string[];
			txPath.Text = Path.GetDirectoryName(fullPaths[0]);
			lsFileName.Items.Clear();
			for (int i = 0; i < fullPaths.Length; i++)
			{
				lsFileName.Items.Add(System.IO.Path.GetFileName(fullPaths[i]));
			}
			if (lsFileName.Items.Count > 0)
			{
				this.lsFileName.SelectedIndex = 0;
				this.lbFileName.Text = this.lsFileName.Text;
			}
		}

        private void frMain_DragEnter(object sender, DragEventArgs e)
        {
			//表示接收到的数据是文件类型
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				//设置鼠标效果
				e.Effect = DragDropEffects.All;
			}
		}

        private void canvas_DragEnter(object sender, DragEventArgs e)
        {
			//表示接收到的数据是文件类型
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				//设置鼠标效果
				e.Effect = DragDropEffects.All;
			}
		}
    }
}
