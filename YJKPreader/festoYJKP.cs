using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace YJKPreader
{
	// Token: 0x02000002 RID: 2
	public class festoYJKP
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public string Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public bool XisTime
		{
			get
			{
				return this.xisTime;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002080 File Offset: 0x00000280
		public int NumPoint
		{
			get
			{
				return this.numPoint;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000298
		public float MaxForce
		{
			get
			{
				return this.maxForce;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020B0 File Offset: 0x000002B0
		public float MaxPosition
		{
			get
			{
				return this.maxPosition;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020C8 File Offset: 0x000002C8
		public float MinForce
		{
			get
			{
				return this.minForce;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020E0 File Offset: 0x000002E0
		public float MinPosition
		{
			get
			{
				return this.minPosition;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020F8 File Offset: 0x000002F8
		public int RecordTime
		{
			get
			{
				return this.recordTime;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002110 File Offset: 0x00000310
		public float[] ReadForce
		{
			get
			{
				return this.readForce;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002128 File Offset: 0x00000328
		public float[] ReadPosition
		{
			get
			{
				return this.readPosition;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002140 File Offset: 0x00000340
		public int[] ReadTime
		{
			get
			{
				return this.readTime;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002158 File Offset: 0x00000358
		public int SizeCanvas_x
		{
			get
			{
				return this.sizeCanvas_x;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002170 File Offset: 0x00000370
		public int SizeCanvas_y
		{
			get
			{
				return this.sizeCanvas_y;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002188 File Offset: 0x00000388
		public float Grid_x
		{
			get
			{
				return this.grid_x;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000021A0 File Offset: 0x000003A0
		public float Grid_y
		{
			get
			{
				return this.grid_y;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021B8 File Offset: 0x000003B8
		public float Ref_x
		{
			get
			{
				return this.ref_x;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000021D0 File Offset: 0x000003D0
		public float Ref_y
		{
			get
			{
				return this.ref_y;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021E8 File Offset: 0x000003E8
		public int[] NormForce
		{
			get
			{
				return this.normForce;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002200 File Offset: 0x00000400
		public int[] NormPosition_x
		{
			get
			{
				return this.normPosition_x;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002218 File Offset: 0x00000418
		public int[] NormPosition_y
		{
			get
			{
				return this.normPosition_y;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002230 File Offset: 0x00000430
		public int[] NormTime
		{
			get
			{
				return this.normTime;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002248 File Offset: 0x00000448
		public float CursorValue_x
		{
			get
			{
				return this.cursorValue_x;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002260 File Offset: 0x00000460
		public float CursorValue_y
		{
			get
			{
				return this.cursorValue_y;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002278 File Offset: 0x00000478
		private void ClearArray()
		{
			for (int i = 0; i < 20000; i++)
			{
				this.readForce[i] = 0f;
				this.readPosition[i] = 0f;
				this.readTime[i] = 0;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000022C0 File Offset: 0x000004C0
		public byte ReadLogFile(string PathDir, string FileName)
		{
			byte result;
			try
			{
				using (StreamReader streamReader = new StreamReader(PathDir + "\\" + FileName))
				{
					string text = streamReader.ReadToEnd();
					bool flag = !this.DecimalSeparatorisknown;
					if (flag)
					{
						this.DecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
					}
					bool flag2 = this.DecimalSeparator == ".";
					if (flag2)
					{
						text = text.Replace(",", ".");
					}
					else
					{
						text = text.Replace(".", ",");
					}
					this.logText = text;
				}
				string text2 = this.ReadLine(this.logText, "[Curves]", 1);
				string[] array = text2.Split(new string[]
				{
					";"
				}, StringSplitOptions.None);
				result = byte.Parse(array[1]);
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000023BC File Offset: 0x000005BC
		private string ReadLine(string sString, string sFind, int iLine)
		{
			int[] array = new int[20];
			array[0] = sString.IndexOf(sFind, 0);
			string text = sString.Substring(array[0], sString.Length - array[0]);
			array[0] = 0;
			for (int i = 1; i <= iLine + 1; i++)
			{
				array[i] = text.IndexOf("\r\n", array[i - 1] + 1);
			}
			return text.Substring(array[iLine] + 2, array[iLine + 1] - array[iLine] - 2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002444 File Offset: 0x00000644
		public bool GetRecordData(string LookFor)
		{
			bool result;
			try
			{
				string text = this.logText;
				int num = text.IndexOf(LookFor);
				bool flag = num < 0;
				if (flag)
				{
					result = false;
				}
				else
				{
					int length = text.Length;
					string text2 = text.Substring(num, length - num);
					string[] array = text2.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.None);
					num = array[1].IndexOf(";") + 1;
					length = array[1].Length;
					text2 = array[1].Substring(num, length - num);
					this.numPoint = int.Parse(text2);
					this.minPosition = 0f;
					this.minForce = 0f;
					this.ClearArray();
					for (int i = 1; i <= this.NumPoint; i++)
					{
						string[] array2 = array[i + 2].Split(new string[]
						{
							";"
						}, StringSplitOptions.None);
						this.readPosition[i] = float.Parse(array2[1]);
						this.readForce[i] = float.Parse(array2[2]);
						this.readTime[i] = this.GetTimeInt(array2[3]);
						bool flag2 = this.minPosition == 0f || this.minPosition > this.readPosition[i];
						if (flag2)
						{
							this.minPosition = this.readPosition[i];
						}
						bool flag3 = this.minForce == 0f || this.minForce > this.readForce[i];
						if (flag3)
						{
							this.minForce = this.readForce[i];
						}
					}
					for (int j = 2; j <= this.NumPoint; j++)
					{
						this.readTime[j] = this.readTime[j] - this.readTime[1];
					}
					this.readTime[1] = 0;
					this.maxPosition = this.readPosition.Max();
					this.maxForce = this.readForce.Max();
					this.recordTime = this.readTime[this.NumPoint];
					this.ReadEvaluationRecipe(text, LookFor);
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002694 File Offset: 0x00000894
		private int GetTimeInt(string s)
		{
			int num = 0;
			try
			{
				int num2 = s.IndexOf("m");
				int num3 = s.IndexOf("ms");
				bool flag = num2 > 0 && num2 != num3;
				if (flag)
				{
					string s2 = s.Substring(2, num2 - 2);
					num = int.Parse(s2) * 60;
				}
				else
				{
					num2 = 1;
				}
				int num4 = s.IndexOf("s");
				num3 = s.IndexOf("ms") + 1;
				bool flag2 = num4 > 0 && num4 != num3;
				if (flag2)
				{
					string s2 = s.Substring(num2 + 1, num4 - num2 - 1);
					num = (num + int.Parse(s2)) * 1000;
				}
				else
				{
					num4 = 1;
				}
				bool flag3 = s.IndexOf("ms") > 0;
				if (flag3)
				{
					int num5 = s.IndexOf("ms");
					string s2 = s.Substring(num4 + 1, num5 - num4 - 1);
					num += int.Parse(s2);
				}
			}
			catch
			{
			}
			return num;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000027B4 File Offset: 0x000009B4
		private float GetTime(float Pos)
		{
			bool flag = !this.xisTime;
			if (flag)
			{
				for (int i = 0; i < this.numPoint; i++)
				{
					bool flag2 = this.readPosition[i] >= Pos;
					if (flag2)
					{
						return (float)this.readTime[i];
					}
				}
			}
			return Pos;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002810 File Offset: 0x00000A10
		private float GetPos(float Time)
		{
			bool flag = this.xisTime;
			if (flag)
			{
				for (int i = 0; i < this.numPoint; i++)
				{
					bool flag2 = this.readTime[i] >= (int)Time;
					if (flag2)
					{
						return this.readPosition[i];
					}
				}
			}
			return Time;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002868 File Offset: 0x00000A68
		public bool NormalizeReadDatatoCanvasSize(int CurveType, int Canvas_x, int Canvas_y, int GapSize, int GridSize, int Span_x, int Span_y)
		{
			bool result;
			try
			{
				this.sizeCanvas_x = Canvas_x - GapSize * 3;
				this.sizeCanvas_y = Canvas_y - GapSize * 3;
				for (int i = 1; i <= this.NumPoint; i++)
				{
					switch (CurveType)
					{
					case 0:
						this.normPosition_x[i] = Convert.ToInt32((this.readPosition[i] - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
						this.normForce[i] = Canvas_y - Convert.ToInt32((this.readForce[i] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						break;
					case 1:
						this.normTime[i] = Convert.ToInt32((float)this.readTime[i] / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
						this.normForce[i] = Canvas_y - Convert.ToInt32((this.readForce[i] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						break;
					case 2:
						this.normTime[i] = Convert.ToInt32((float)this.readTime[i] / (float)this.RecordTime * (float)this.sizeCanvas_x) + GapSize;
						this.normPosition_y[i] = Canvas_y - Convert.ToInt32((this.readPosition[i] - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_y) - GapSize;
						break;
					}
				}
				switch (CurveType)
				{
				case 0:
					this.grid_x = (this.maxPosition - this.minPosition) * (float)GridSize / (float)this.sizeCanvas_x;
					this.grid_y = (this.maxForce - this.minForce) * (float)GridSize / (float)this.sizeCanvas_y;
					this.ref_x = this.minPosition + (this.maxPosition - this.minPosition) * (float)(-(float)Span_x) / (float)this.sizeCanvas_x;
					this.ref_y = this.minForce + (this.maxForce - this.minForce) * (float)(-(float)Span_y) / (float)this.sizeCanvas_y;
					break;
				case 1:
					this.grid_x = (float)(this.RecordTime * GridSize / this.sizeCanvas_x);
					this.grid_y = (this.maxForce - this.minForce) * (float)GridSize / (float)this.sizeCanvas_y;
					this.ref_x = (float)(this.RecordTime * -(float)Span_x / this.sizeCanvas_x);
					this.ref_y = this.minForce + (this.maxForce - this.minForce) * (float)(-(float)Span_y) / (float)this.sizeCanvas_y;
					break;
				case 2:
					this.grid_x = (float)(this.recordTime * GridSize / this.sizeCanvas_x);
					this.grid_y = (this.maxPosition - this.minPosition) * (float)GridSize / (float)this.sizeCanvas_y;
					this.ref_x = (float)(this.recordTime * -(float)Span_x / this.sizeCanvas_x);
					this.ref_y = this.minPosition + (this.maxPosition - this.minPosition) * (float)(-(float)Span_y) / (float)this.sizeCanvas_y;
					break;
				}
				bool flag = CurveType == 0;
				if (flag)
				{
					for (int j = 0; j < 5; j++)
					{
						bool flag2 = this.wActive[j];
						if (flag2)
						{
							this.wNormMinPosVal[j] = Convert.ToInt32((this.GetPos(this.wMinPosVal[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.wNormMaxPosVal[j] = Convert.ToInt32((this.GetPos(this.wMaxPosVal[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.wNormMinForceVal[j] = Canvas_y - Convert.ToInt32((this.wMinForceVal[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.wNormMaxForceVal[j] = Canvas_y - Convert.ToInt32((this.wMaxForceVal[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						}
						bool flag3 = this.tActive[j];
						if (flag3)
						{
							this.tNormPosVal[j] = Convert.ToInt32((this.GetPos(this.tPosVal[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.tNormMinPosVal[j] = Convert.ToInt32((this.GetPos(this.tMinPosVal[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.tNormMaxPosVal[j] = Convert.ToInt32((this.GetPos(this.tMaxPosVal[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.tNormForceVal[j] = Canvas_y - Convert.ToInt32((this.tForceVal[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.tNormMinForceVal[j] = Canvas_y - Convert.ToInt32((this.tMinForceVal[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.tNormMaxForceVal[j] = Canvas_y - Convert.ToInt32((this.tMaxForceVal[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						}
						bool flag4 = this.eActive[j];
						if (flag4)
						{
							this.eNormPointUp1Pos[j] = Convert.ToInt32((this.GetPos(this.ePointUp1Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp1Force[j] = Canvas_y - Convert.ToInt32((this.ePointUp1Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp2Pos[j] = Convert.ToInt32((this.GetPos(this.ePointUp2Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp2Force[j] = Canvas_y - Convert.ToInt32((this.ePointUp2Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp3Pos[j] = Convert.ToInt32((this.GetPos(this.ePointUp3Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp3Force[j] = Canvas_y - Convert.ToInt32((this.ePointUp3Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp4Pos[j] = Convert.ToInt32((this.GetPos(this.ePointUp4Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp4Force[j] = Canvas_y - Convert.ToInt32((this.ePointUp4Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp5Pos[j] = Convert.ToInt32((this.GetPos(this.ePointUp5Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp5Force[j] = Canvas_y - Convert.ToInt32((this.ePointUp5Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown1Pos[j] = Convert.ToInt32((this.GetPos(this.ePointDown1Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown1Force[j] = Canvas_y - Convert.ToInt32((this.ePointDown1Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown2Pos[j] = Convert.ToInt32((this.GetPos(this.ePointDown2Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown2Force[j] = Canvas_y - Convert.ToInt32((this.ePointDown2Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown3Pos[j] = Convert.ToInt32((this.GetPos(this.ePointDown3Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown3Force[j] = Canvas_y - Convert.ToInt32((this.ePointDown3Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown4Pos[j] = Convert.ToInt32((this.GetPos(this.ePointDown4Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown4Force[j] = Canvas_y - Convert.ToInt32((this.ePointDown4Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown5Pos[j] = Convert.ToInt32((this.GetPos(this.ePointDown5Pos[j]) - this.minPosition) / (this.maxPosition - this.minPosition) * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown5Force[j] = Canvas_y - Convert.ToInt32((this.ePointDown5Force[j] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						}
					}
				}
				bool flag5 = CurveType == 1;
				if (flag5)
				{
					for (int k = 0; k < 5; k++)
					{
						bool flag6 = this.wActive[k];
						if (flag6)
						{
							this.wNormMinTime[k] = Convert.ToInt32((this.GetTime(this.wMinPosVal[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.wNormMaxTime[k] = Convert.ToInt32((this.GetTime(this.wMaxPosVal[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.wNormMinForceVal[k] = Canvas_y - Convert.ToInt32((this.wMinForceVal[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.wNormMaxForceVal[k] = Canvas_y - Convert.ToInt32((this.wMaxForceVal[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						}
						bool flag7 = this.tActive[k];
						if (flag7)
						{
							this.tNormTime[k] = Convert.ToInt32((this.GetTime(this.tPosVal[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.tNormMinTime[k] = Convert.ToInt32((this.GetTime(this.tMinPosVal[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.tNormMaxTime[k] = Convert.ToInt32((this.GetTime(this.tMaxPosVal[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.tNormForceVal[k] = Canvas_y - Convert.ToInt32((this.tForceVal[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.tNormMinForceVal[k] = Canvas_y - Convert.ToInt32((this.tMinForceVal[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.tNormMaxForceVal[k] = Canvas_y - Convert.ToInt32((this.tMaxForceVal[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						}
						bool flag8 = this.eActive[k];
						if (flag8)
						{
							this.eNormPointUp1Time[k] = Convert.ToInt32((this.GetTime(this.ePointUp1Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp1Force[k] = Canvas_y - Convert.ToInt32((this.ePointUp1Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp2Time[k] = Convert.ToInt32((this.GetTime(this.ePointUp2Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp2Force[k] = Canvas_y - Convert.ToInt32((this.ePointUp2Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp3Time[k] = Convert.ToInt32((this.GetTime(this.ePointUp3Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp3Force[k] = Canvas_y - Convert.ToInt32((this.ePointUp3Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp4Time[k] = Convert.ToInt32((this.GetTime(this.ePointUp4Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp4Force[k] = Canvas_y - Convert.ToInt32((this.ePointUp4Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointUp5Time[k] = Convert.ToInt32((this.GetTime(this.ePointUp5Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointUp5Force[k] = Canvas_y - Convert.ToInt32((this.ePointUp5Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown1Time[k] = Convert.ToInt32((this.GetTime(this.ePointDown1Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown1Force[k] = Canvas_y - Convert.ToInt32((this.ePointDown1Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown2Time[k] = Convert.ToInt32((this.GetTime(this.ePointDown2Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown2Force[k] = Canvas_y - Convert.ToInt32((this.ePointDown2Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown3Time[k] = Convert.ToInt32((this.GetTime(this.ePointDown3Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown3Force[k] = Canvas_y - Convert.ToInt32((this.ePointDown3Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown4Time[k] = Convert.ToInt32((this.GetTime(this.ePointDown4Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown4Force[k] = Canvas_y - Convert.ToInt32((this.ePointDown4Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
							this.eNormPointDown5Time[k] = Convert.ToInt32((this.GetTime(this.ePointDown5Pos[k]) - 0f) / (float)this.recordTime * (float)this.sizeCanvas_x) + GapSize;
							this.eNormPointDown5Force[k] = Canvas_y - Convert.ToInt32((this.ePointDown5Force[k] - this.minForce) / (this.maxForce - this.minForce) * (float)this.sizeCanvas_y) - GapSize;
						}
					}
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003A04 File Offset: 0x00001C04
		public bool CursorValue(int CurveType, int CursorPosition_x, int CursorPosition_y, int Location_x, int Location_y, int CanvasLocation_x, int CanvasLocation_y, int Canvas_y, int GapSize, int Span_x, int Span_y)
		{
			bool result;
			try
			{
				float num = (float)(CursorPosition_x - Location_x - CanvasLocation_x - GapSize - 8);
				float num2 = (float)(Canvas_y - (CursorPosition_y - Location_y - CanvasLocation_y + GapSize - 30));
				switch (CurveType)
				{
				case 0:
					this.cursorValue_x = this.minPosition + (this.maxPosition - this.minPosition) * (num - (float)Span_x) / (float)this.sizeCanvas_x;
					this.cursorValue_y = this.minForce + (this.maxForce - this.minForce) * (num2 - (float)Span_y) / (float)this.sizeCanvas_y;
					break;
				case 1:
					this.cursorValue_x = (float)this.recordTime * (num - (float)Span_x) / (float)this.sizeCanvas_x;
					this.cursorValue_y = this.minForce + (this.maxForce - this.minForce) * (num2 - (float)Span_y) / (float)this.sizeCanvas_y;
					break;
				case 2:
					this.cursorValue_x = (float)this.recordTime * (num - (float)Span_x) / (float)this.sizeCanvas_x;
					this.cursorValue_y = this.minPosition + (this.maxPosition - this.minPosition) * (num2 - (float)Span_y) / (float)this.sizeCanvas_y;
					break;
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00003B58 File Offset: 0x00001D58
		public int[] WNormMinPosVal
		{
			get
			{
				return this.wNormMinPosVal;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003B70 File Offset: 0x00001D70
		public int[] WNormMaxPosVal
		{
			get
			{
				return this.wNormMaxPosVal;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003B88 File Offset: 0x00001D88
		public int[] WNormMinForceVal
		{
			get
			{
				return this.wNormMinForceVal;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003BA0 File Offset: 0x00001DA0
		public int[] WNormMaxForceVal
		{
			get
			{
				return this.wNormMaxForceVal;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public int[] WNormMinTime
		{
			get
			{
				return this.wNormMinTime;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003BD0 File Offset: 0x00001DD0
		public int[] WNormMaxTime
		{
			get
			{
				return this.wNormMaxTime;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003BE8 File Offset: 0x00001DE8
		public bool[] WActive
		{
			get
			{
				return this.wActive;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003C00 File Offset: 0x00001E00
		public bool[] WConfig
		{
			get
			{
				return this.wConfig;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003C18 File Offset: 0x00001E18
		public bool[] WConfigMinPos
		{
			get
			{
				return this.wConfigMinPos;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003C30 File Offset: 0x00001E30
		public float[] WMinPosVal
		{
			get
			{
				return this.wMinPosVal;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003C48 File Offset: 0x00001E48
		public byte[] WMinPosVar
		{
			get
			{
				return this.wMinPosVar;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003C60 File Offset: 0x00001E60
		public bool[] WConfigMaxPos
		{
			get
			{
				return this.wConfigMaxPos;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003C78 File Offset: 0x00001E78
		public float[] WMaxPosVal
		{
			get
			{
				return this.wMaxPosVal;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003C90 File Offset: 0x00001E90
		public byte[] WMaxPosVar
		{
			get
			{
				return this.wMaxPosVar;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public bool[] WConfigMinForce
		{
			get
			{
				return this.wConfigMinForce;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003CC0 File Offset: 0x00001EC0
		public float[] WMinForceVal
		{
			get
			{
				return this.wMinForceVal;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003CD8 File Offset: 0x00001ED8
		public byte[] WMinForceVar
		{
			get
			{
				return this.wMinForceVar;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003CF0 File Offset: 0x00001EF0
		public bool[] WConfigMaxForce
		{
			get
			{
				return this.wConfigMaxForce;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003D08 File Offset: 0x00001F08
		public float[] WMaxForceVal
		{
			get
			{
				return this.wMaxForceVal;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003D20 File Offset: 0x00001F20
		public byte[] WMaxForceVar
		{
			get
			{
				return this.wMaxForceVar;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003D38 File Offset: 0x00001F38
		public byte[] WConfigDown
		{
			get
			{
				return this.wConfigDown;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003D50 File Offset: 0x00001F50
		public byte[] WConfigUp
		{
			get
			{
				return this.wConfigUp;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003D68 File Offset: 0x00001F68
		public byte[] WConfigLeft
		{
			get
			{
				return this.wConfigLeft;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003D80 File Offset: 0x00001F80
		public byte[] WConfigRight
		{
			get
			{
				return this.wConfigRight;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00003D98 File Offset: 0x00001F98
		public int[] TNormPosVal
		{
			get
			{
				return this.tNormPosVal;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public int[] TNormMinPosVal
		{
			get
			{
				return this.tNormMinPosVal;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public int[] TNormMaxPosVal
		{
			get
			{
				return this.tNormMaxPosVal;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003DE0 File Offset: 0x00001FE0
		public int[] TNormForceVal
		{
			get
			{
				return this.tNormForceVal;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003DF8 File Offset: 0x00001FF8
		public int[] TNormMinForceVal
		{
			get
			{
				return this.tNormMinForceVal;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003E10 File Offset: 0x00002010
		public int[] TNormMaxForceVal
		{
			get
			{
				return this.tNormMaxForceVal;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003E28 File Offset: 0x00002028
		public int[] TNormTime
		{
			get
			{
				return this.tNormTime;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00003E40 File Offset: 0x00002040
		public int[] TNormMinTime
		{
			get
			{
				return this.tNormMinTime;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00003E58 File Offset: 0x00002058
		public int[] TNormMaxTime
		{
			get
			{
				return this.tNormMaxTime;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00003E70 File Offset: 0x00002070
		public bool[] TActive
		{
			get
			{
				return this.tActive;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00003E88 File Offset: 0x00002088
		public bool[] TConfig
		{
			get
			{
				return this.tConfig;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00003EA0 File Offset: 0x000020A0
		public bool[] TMode
		{
			get
			{
				return this.tMode;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003EB8 File Offset: 0x000020B8
		public bool[] TConfigPos
		{
			get
			{
				return this.tConfigPos;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003ED0 File Offset: 0x000020D0
		public float[] TPosVal
		{
			get
			{
				return this.tPosVal;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003EE8 File Offset: 0x000020E8
		public byte[] TPosVar
		{
			get
			{
				return this.tPosVar;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003F00 File Offset: 0x00002100
		public bool[] TConfigMinPos
		{
			get
			{
				return this.tConfigMinPos;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003F18 File Offset: 0x00002118
		public float[] TMinPosVal
		{
			get
			{
				return this.tMinPosVal;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003F30 File Offset: 0x00002130
		public byte[] TMinPosVar
		{
			get
			{
				return this.tMinPosVar;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003F48 File Offset: 0x00002148
		public bool[] TConfigMaxPos
		{
			get
			{
				return this.tConfigMaxPos;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003F60 File Offset: 0x00002160
		public float[] TMaxPosVal
		{
			get
			{
				return this.tMaxPosVal;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003F78 File Offset: 0x00002178
		public byte[] TMaxPosVar
		{
			get
			{
				return this.tMaxPosVar;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003F90 File Offset: 0x00002190
		public bool[] TConfigForce
		{
			get
			{
				return this.tConfigForce;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003FA8 File Offset: 0x000021A8
		public float[] TForceVal
		{
			get
			{
				return this.tForceVal;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003FC0 File Offset: 0x000021C0
		public byte[] TForceVar
		{
			get
			{
				return this.tForceVar;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003FD8 File Offset: 0x000021D8
		public bool[] TConfigMinForce
		{
			get
			{
				return this.tConfigMinForce;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003FF0 File Offset: 0x000021F0
		public float[] TMinForceVal
		{
			get
			{
				return this.tMinForceVal;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00004008 File Offset: 0x00002208
		public byte[] TMinForceVar
		{
			get
			{
				return this.tMinForceVar;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00004020 File Offset: 0x00002220
		public bool[] TConfigMaxForce
		{
			get
			{
				return this.tConfigMaxForce;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00004038 File Offset: 0x00002238
		public float[] TMaxForceVal
		{
			get
			{
				return this.tMaxForceVal;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00004050 File Offset: 0x00002250
		public byte[] TMaxForceVar
		{
			get
			{
				return this.tMaxForceVar;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004068 File Offset: 0x00002268
		public byte[] TConfig2
		{
			get
			{
				return this.tConfig2;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00004080 File Offset: 0x00002280
		public int[] ENormPointUp1Pos
		{
			get
			{
				return this.eNormPointUp1Pos;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00004098 File Offset: 0x00002298
		public int[] ENormPointUp1Force
		{
			get
			{
				return this.eNormPointUp1Force;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000040B0 File Offset: 0x000022B0
		public int[] ENormPointUp2Pos
		{
			get
			{
				return this.eNormPointUp2Pos;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000040C8 File Offset: 0x000022C8
		public int[] ENormPointUp2Force
		{
			get
			{
				return this.eNormPointUp2Force;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000040E0 File Offset: 0x000022E0
		public int[] ENormPointUp3Pos
		{
			get
			{
				return this.eNormPointUp3Pos;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000040F8 File Offset: 0x000022F8
		public int[] ENormPointUp3Force
		{
			get
			{
				return this.eNormPointUp3Force;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004110 File Offset: 0x00002310
		public int[] ENormPointUp4Pos
		{
			get
			{
				return this.eNormPointUp4Pos;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004128 File Offset: 0x00002328
		public int[] ENormPointUp4Force
		{
			get
			{
				return this.eNormPointUp4Force;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004140 File Offset: 0x00002340
		public int[] ENormPointUp5Pos
		{
			get
			{
				return this.eNormPointUp5Pos;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00004158 File Offset: 0x00002358
		public int[] ENormPointUp5Force
		{
			get
			{
				return this.eNormPointUp5Force;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00004170 File Offset: 0x00002370
		public int[] ENormPointDown1Pos
		{
			get
			{
				return this.eNormPointDown1Pos;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00004188 File Offset: 0x00002388
		public int[] ENormPointDown1Force
		{
			get
			{
				return this.eNormPointDown1Force;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000041A0 File Offset: 0x000023A0
		public int[] ENormPointDown2Pos
		{
			get
			{
				return this.eNormPointDown2Pos;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000041B8 File Offset: 0x000023B8
		public int[] ENormPointDown2Force
		{
			get
			{
				return this.eNormPointDown2Force;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000041D0 File Offset: 0x000023D0
		public int[] ENormPointDown3Pos
		{
			get
			{
				return this.eNormPointDown3Pos;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000041E8 File Offset: 0x000023E8
		public int[] ENormPointDown3Force
		{
			get
			{
				return this.eNormPointDown3Force;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004200 File Offset: 0x00002400
		public int[] ENormPointDown4Pos
		{
			get
			{
				return this.eNormPointDown4Pos;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004218 File Offset: 0x00002418
		public int[] ENormPointDown4Force
		{
			get
			{
				return this.eNormPointDown4Force;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004230 File Offset: 0x00002430
		public int[] ENormPointDown5Pos
		{
			get
			{
				return this.eNormPointDown5Pos;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004248 File Offset: 0x00002448
		public int[] ENormPointDown5Force
		{
			get
			{
				return this.eNormPointDown5Force;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004260 File Offset: 0x00002460
		public int[] ENormPointUp1Time
		{
			get
			{
				return this.eNormPointUp1Time;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004278 File Offset: 0x00002478
		public int[] ENormPointUp2Time
		{
			get
			{
				return this.eNormPointUp2Time;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004290 File Offset: 0x00002490
		public int[] ENormPointUp3Time
		{
			get
			{
				return this.eNormPointUp3Time;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000042A8 File Offset: 0x000024A8
		public int[] ENormPointUp4Time
		{
			get
			{
				return this.eNormPointUp4Time;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000042C0 File Offset: 0x000024C0
		public int[] ENormPointUp5Time
		{
			get
			{
				return this.eNormPointUp5Time;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000042D8 File Offset: 0x000024D8
		public int[] ENormPointDown1Time
		{
			get
			{
				return this.eNormPointDown1Time;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000042F0 File Offset: 0x000024F0
		public int[] ENormPointDown2Time
		{
			get
			{
				return this.eNormPointDown2Time;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004308 File Offset: 0x00002508
		public int[] ENormPointDown3Time
		{
			get
			{
				return this.eNormPointDown3Time;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004320 File Offset: 0x00002520
		public int[] ENormPointDown4Time
		{
			get
			{
				return this.eNormPointDown4Time;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004338 File Offset: 0x00002538
		public int[] ENormPointDown5Time
		{
			get
			{
				return this.eNormPointDown5Time;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004350 File Offset: 0x00002550
		public bool[] EActive
		{
			get
			{
				return this.eActive;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004368 File Offset: 0x00002568
		public bool[] EConfig
		{
			get
			{
				return this.eConfig;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004380 File Offset: 0x00002580
		public byte[] EPointUp
		{
			get
			{
				return this.ePointUp;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004398 File Offset: 0x00002598
		public float[] EPointUp1Pos
		{
			get
			{
				return this.ePointUp1Pos;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000043B0 File Offset: 0x000025B0
		public float[] EPointUp1Force
		{
			get
			{
				return this.ePointUp1Force;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000043C8 File Offset: 0x000025C8
		public float[] EPointUp2Pos
		{
			get
			{
				return this.ePointUp2Pos;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000043E0 File Offset: 0x000025E0
		public float[] EPointUp2Force
		{
			get
			{
				return this.ePointUp2Force;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000043F8 File Offset: 0x000025F8
		public float[] EPointUp3Pos
		{
			get
			{
				return this.ePointUp3Pos;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00004410 File Offset: 0x00002610
		public float[] EPointUp3Force
		{
			get
			{
				return this.ePointUp3Force;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004428 File Offset: 0x00002628
		public float[] EPointUp4Pos
		{
			get
			{
				return this.ePointUp4Pos;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00004440 File Offset: 0x00002640
		public float[] EPointUp4Force
		{
			get
			{
				return this.ePointUp4Force;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004458 File Offset: 0x00002658
		public float[] EPointUp5Pos
		{
			get
			{
				return this.ePointUp5Pos;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00004470 File Offset: 0x00002670
		public float[] EPointUp5Force
		{
			get
			{
				return this.ePointUp5Force;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00004488 File Offset: 0x00002688
		public byte[] EPointDown
		{
			get
			{
				return this.ePointDown;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000044A0 File Offset: 0x000026A0
		public float[] EPointDown1Pos
		{
			get
			{
				return this.ePointDown1Pos;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000085 RID: 133 RVA: 0x000044B8 File Offset: 0x000026B8
		public float[] EPointDown1Force
		{
			get
			{
				return this.ePointDown1Force;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000044D0 File Offset: 0x000026D0
		public float[] EPointDown2Pos
		{
			get
			{
				return this.ePointDown2Pos;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000044E8 File Offset: 0x000026E8
		public float[] EPointDown2Force
		{
			get
			{
				return this.ePointDown2Force;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00004500 File Offset: 0x00002700
		public float[] EPointDown3Pos
		{
			get
			{
				return this.ePointDown3Pos;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00004518 File Offset: 0x00002718
		public float[] EPointDown3Force
		{
			get
			{
				return this.ePointDown3Force;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00004530 File Offset: 0x00002730
		public float[] EPointDown4Pos
		{
			get
			{
				return this.ePointDown4Pos;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004548 File Offset: 0x00002748
		public float[] EPointDown4Force
		{
			get
			{
				return this.ePointDown4Force;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004560 File Offset: 0x00002760
		public float[] EPointDown5Pos
		{
			get
			{
				return this.ePointDown5Pos;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004578 File Offset: 0x00002778
		public float[] EPointDown5Force
		{
			get
			{
				return this.ePointDown5Force;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004590 File Offset: 0x00002790
		public byte[] EPointUp1PosVar
		{
			get
			{
				return this.ePointUp1PosVar;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000045A8 File Offset: 0x000027A8
		public byte[] EPointUp2PosVar
		{
			get
			{
				return this.ePointUp2PosVar;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000045C0 File Offset: 0x000027C0
		public byte[] EPointUp3PosVar
		{
			get
			{
				return this.ePointUp3PosVar;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000045D8 File Offset: 0x000027D8
		public byte[] EPointUp4PosVar
		{
			get
			{
				return this.ePointUp4PosVar;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000045F0 File Offset: 0x000027F0
		public byte[] EPointUp5PosVar
		{
			get
			{
				return this.ePointUp5PosVar;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004608 File Offset: 0x00002808
		public byte[] EPointDown1PosVar
		{
			get
			{
				return this.ePointDown1PosVar;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004620 File Offset: 0x00002820
		public byte[] EPointDown2PosVar
		{
			get
			{
				return this.ePointDown2PosVar;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004638 File Offset: 0x00002838
		public byte[] EPointDown3PosVar
		{
			get
			{
				return this.ePointDown3PosVar;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004650 File Offset: 0x00002850
		public byte[] EPointDown4PosVar
		{
			get
			{
				return this.ePointDown4PosVar;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004668 File Offset: 0x00002868
		public byte[] EPointDown5PosVar
		{
			get
			{
				return this.ePointDown5PosVar;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004680 File Offset: 0x00002880
		public byte[] EPointUp1ForceVar
		{
			get
			{
				return this.ePointUp1ForceVar;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004698 File Offset: 0x00002898
		public byte[] EPointUp2ForceVar
		{
			get
			{
				return this.ePointUp2ForceVar;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000046B0 File Offset: 0x000028B0
		public byte[] EPointUp3ForceVar
		{
			get
			{
				return this.ePointUp3ForceVar;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000046C8 File Offset: 0x000028C8
		public byte[] EPointUp4ForceVar
		{
			get
			{
				return this.ePointUp4ForceVar;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000046E0 File Offset: 0x000028E0
		public byte[] EPointUp5ForceVar
		{
			get
			{
				return this.ePointUp5ForceVar;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000046F8 File Offset: 0x000028F8
		public byte[] EPointDown1ForceVar
		{
			get
			{
				return this.ePointDown1ForceVar;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004710 File Offset: 0x00002910
		public byte[] EPointDown2ForceVar
		{
			get
			{
				return this.ePointDown2ForceVar;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004728 File Offset: 0x00002928
		public byte[] EPointDown3ForceVar
		{
			get
			{
				return this.ePointDown3ForceVar;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004740 File Offset: 0x00002940
		public byte[] EPointDown4ForceVar
		{
			get
			{
				return this.ePointDown4ForceVar;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004758 File Offset: 0x00002958
		public byte[] EPointDown5ForceVar
		{
			get
			{
				return this.ePointDown5ForceVar;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004770 File Offset: 0x00002970
		public bool[] EConfigPointUp1Pos
		{
			get
			{
				return this.eConfigPointUp1Pos;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004788 File Offset: 0x00002988
		public bool[] EConfigPointUp2Pos
		{
			get
			{
				return this.eConfigPointUp2Pos;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000047A0 File Offset: 0x000029A0
		public bool[] EConfigPointUp3Pos
		{
			get
			{
				return this.eConfigPointUp3Pos;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000047B8 File Offset: 0x000029B8
		public bool[] EConfigPointUp4Pos
		{
			get
			{
				return this.eConfigPointUp4Pos;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000047D0 File Offset: 0x000029D0
		public bool[] EConfigPointUp5Pos
		{
			get
			{
				return this.eConfigPointUp5Pos;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000047E8 File Offset: 0x000029E8
		public bool[] EConfigPointDown1Pos
		{
			get
			{
				return this.eConfigPointDown1Pos;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004800 File Offset: 0x00002A00
		public bool[] EConfigPointDown2Pos
		{
			get
			{
				return this.eConfigPointDown2Pos;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00004818 File Offset: 0x00002A18
		public bool[] EConfigPointDown3Pos
		{
			get
			{
				return this.eConfigPointDown3Pos;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00004830 File Offset: 0x00002A30
		public bool[] EConfigPointDown4Pos
		{
			get
			{
				return this.eConfigPointDown4Pos;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00004848 File Offset: 0x00002A48
		public bool[] EConfigPointDown5Pos
		{
			get
			{
				return this.eConfigPointDown5Pos;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00004860 File Offset: 0x00002A60
		public bool[] EConfigPointUp1Force
		{
			get
			{
				return this.eConfigPointUp1Force;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004878 File Offset: 0x00002A78
		public bool[] EConfigPointUp2Force
		{
			get
			{
				return this.eConfigPointUp2Force;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00004890 File Offset: 0x00002A90
		public bool[] EConfigPointUp3Force
		{
			get
			{
				return this.eConfigPointUp3Force;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000048A8 File Offset: 0x00002AA8
		public bool[] EConfigPointUp4Force
		{
			get
			{
				return this.eConfigPointUp4Force;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000048C0 File Offset: 0x00002AC0
		public bool[] EConfigPointUp5Force
		{
			get
			{
				return this.eConfigPointUp5Force;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000048D8 File Offset: 0x00002AD8
		public bool[] EConfigPointDown1Force
		{
			get
			{
				return this.eConfigPointDown1Force;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000048F0 File Offset: 0x00002AF0
		public bool[] EConfigPointDown2Force
		{
			get
			{
				return this.eConfigPointDown2Force;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00004908 File Offset: 0x00002B08
		public bool[] EConfigPointDown3Force
		{
			get
			{
				return this.eConfigPointDown3Force;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00004920 File Offset: 0x00002B20
		public bool[] EConfigPointDown4Force
		{
			get
			{
				return this.eConfigPointDown4Force;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00004938 File Offset: 0x00002B38
		public bool[] EConfigPointDown5Force
		{
			get
			{
				return this.eConfigPointDown5Force;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00004950 File Offset: 0x00002B50
		public int[] WIntersection
		{
			get
			{
				return this.wIntersection;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00004968 File Offset: 0x00002B68
		public float[] WiUpPos
		{
			get
			{
				return this.wiUpPos;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004980 File Offset: 0x00002B80
		public float[] WiUpForce
		{
			get
			{
				return this.wiUpForce;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00004998 File Offset: 0x00002B98
		public float[] WiDownPos
		{
			get
			{
				return this.wiDownPos;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000049B0 File Offset: 0x00002BB0
		public float[] WiDownForce
		{
			get
			{
				return this.wiDownForce;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000049C8 File Offset: 0x00002BC8
		public float[] WiLeftPos
		{
			get
			{
				return this.wiLeftPos;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000049E0 File Offset: 0x00002BE0
		public float[] WiLeftForce
		{
			get
			{
				return this.wiLeftForce;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000049F8 File Offset: 0x00002BF8
		public float[] WiRightPos
		{
			get
			{
				return this.wiRightPos;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00004A10 File Offset: 0x00002C10
		public float[] WiRightForce
		{
			get
			{
				return this.wiRightForce;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004A28 File Offset: 0x00002C28
		public int[] TIntersection
		{
			get
			{
				return this.tIntersection;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00004A40 File Offset: 0x00002C40
		public float[] TiPosition
		{
			get
			{
				return this.tiPosition;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00004A58 File Offset: 0x00002C58
		public float[] TiForce
		{
			get
			{
				return this.tiForce;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004A70 File Offset: 0x00002C70
		public int[] EIntersection
		{
			get
			{
				return this.eIntersection;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00004A88 File Offset: 0x00002C88
		public float[] EiUpPos
		{
			get
			{
				return this.eiUpPos;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004AA0 File Offset: 0x00002CA0
		public float[] EiUpForce
		{
			get
			{
				return this.eiUpForce;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public float[] EiDownPos
		{
			get
			{
				return this.eiDownPos;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00004AD0 File Offset: 0x00002CD0
		public float[] EiDownForce
		{
			get
			{
				return this.eiDownForce;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public bool[] WEvaluationStatus
		{
			get
			{
				return this.wEvaluationStatus;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00004B00 File Offset: 0x00002D00
		public bool[] TEvaluationStatus
		{
			get
			{
				return this.tEvaluationStatus;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00004B18 File Offset: 0x00002D18
		public bool[] EEvaluationStatus
		{
			get
			{
				return this.eEvaluationStatus;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004B30 File Offset: 0x00002D30
		private byte ReadEvaluationRecipe(string sav, string LookFor)
		{
			byte b = byte.Parse(LookFor.Substring(LookFor.Length - 2, 1));
			byte result;
			try
			{
				bool flag = false;
				this.xisTime = false;
				byte b2 = 0;
				int startIndex = 0;
				int num;
				do
				{
					num = sav.IndexOf("[Windowing]", startIndex);
					startIndex = num + 1;
					b2 += 1;
				}
				while (b2 < b);
				bool flag2 = num < 1;
				if (flag2)
				{
					result = 99;
				}
				else
				{
					string savNew = sav.Substring(num, sav.Length - num);
					this.ActiveIdx = -1;
					this.ActiveIdx++;
					for (int i = 0; i < 5; i++)
					{
						this.wActive[i] = false;
					}
					bool flag3 = this.ActiveEvaluation(savNew, this.ActiveIdx, false, "");
					if (flag3)
					{
						for (int j = 0; j < 5; j++)
						{
							this.ActiveIdx++;
							bool flag4 = this.ActiveEvaluation(savNew, this.ActiveIdx, true, "Windowing");
							if (flag4)
							{
								this.wActive[j] = true;
								string[] array = this.ActiveData[0].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.wConfig[j] = bool.Parse(array[0]);
								this.wConfigMinPos[j] = bool.Parse(array[1]);
								this.wMinPosVal[j] = float.Parse(array[2]);
								this.wMinPosVar[j] = byte.Parse(array[3]);
								this.wConfigMaxPos[j] = bool.Parse(array[4]);
								this.wMaxPosVal[j] = float.Parse(array[5]);
								this.wMaxPosVar[j] = byte.Parse(array[6]);
								this.wConfigMinForce[j] = bool.Parse(array[7]);
								this.wMinForceVal[j] = float.Parse(array[8]);
								this.wMinForceVar[j] = byte.Parse(array[9]);
								this.wConfigMaxForce[j] = bool.Parse(array[10]);
								this.wMaxForceVal[j] = float.Parse(array[11]);
								this.wMaxForceVar[j] = byte.Parse(array[12]);
								string[] array2 = this.ActiveData[1].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.wConfigDown[j] = byte.Parse(array2[0]);
								this.wConfigUp[j] = byte.Parse(array2[1]);
								this.wConfigLeft[j] = byte.Parse(array2[2]);
								this.wConfigRight[j] = byte.Parse(array2[3]);
								bool flag5 = !flag;
								if (flag5)
								{
									this.xisTime = this.GetXisTime("Window", j);
								}
								bool flag6 = this.xisTime;
								if (flag6)
								{
									flag = true;
								}
							}
						}
					}
					this.ActiveIdx++;
					for (int k = 0; k < 5; k++)
					{
						this.tActive[k] = false;
					}
					bool flag7 = this.ActiveEvaluation(savNew, this.ActiveIdx, false, "");
					if (flag7)
					{
						for (int l = 0; l < 5; l++)
						{
							this.ActiveIdx++;
							bool flag8 = this.ActiveEvaluation(savNew, this.ActiveIdx, true, "Treshold");
							if (flag8)
							{
								this.tActive[l] = true;
								string[] array3 = this.ActiveData[0].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.tConfig[l] = bool.Parse(array3[0]);
								this.tMode[l] = bool.Parse(array3[1]);
								this.tConfigPos[l] = bool.Parse(array3[2]);
								this.tPosVal[l] = float.Parse(array3[3]);
								this.tPosVar[l] = byte.Parse(array3[4]);
								this.tConfigMinPos[l] = bool.Parse(array3[5]);
								this.tMinPosVal[l] = float.Parse(array3[6]);
								this.tMinPosVar[l] = byte.Parse(array3[7]);
								this.tConfigMaxPos[l] = bool.Parse(array3[8]);
								this.tMaxPosVal[l] = float.Parse(array3[9]);
								this.tMaxPosVar[l] = byte.Parse(array3[10]);
								this.tConfigForce[l] = bool.Parse(array3[11]);
								this.tForceVal[l] = float.Parse(array3[12]);
								this.tForceVar[l] = byte.Parse(array3[13]);
								this.tConfigMinForce[l] = bool.Parse(array3[14]);
								this.tMinForceVal[l] = float.Parse(array3[15]);
								this.tMinForceVar[l] = byte.Parse(array3[16]);
								this.tConfigMaxForce[l] = bool.Parse(array3[17]);
								this.tMaxForceVal[l] = float.Parse(array3[18]);
								this.tMaxForceVar[l] = byte.Parse(array3[19]);
								this.tConfig2[l] = byte.Parse(array3[20]);
								bool flag9 = !flag;
								if (flag9)
								{
									this.xisTime = this.GetXisTime("Threshold", l);
								}
								bool flag10 = this.xisTime;
								if (flag10)
								{
									flag = true;
								}
							}
						}
					}
					this.ActiveIdx++;
					for (int m = 0; m < 5; m++)
					{
						this.eActive[m] = false;
					}
					bool flag11 = this.ActiveEvaluation(savNew, this.ActiveIdx, false, "");
					if (flag11)
					{
						for (int n = 0; n < 5; n++)
						{
							this.ActiveIdx++;
							bool flag12 = this.ActiveEvaluation(savNew, this.ActiveIdx, true, "Envelope");
							if (flag12)
							{
								this.eActive[n] = true;
								string[] array4 = this.ActiveData[0].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfig[n] = bool.Parse(array4[1]);
								string[] array5 = this.ActiveData[1].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.ePointUp[n] = byte.Parse(array5[1]);
								string[] array6 = this.ActiveData[2].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointUp1Pos[n] = bool.Parse(array6[1]);
								this.ePointUp1Pos[n] = float.Parse(array6[2]);
								this.ePointUp1PosVar[n] = byte.Parse(array6[3]);
								this.eConfigPointUp1Force[n] = bool.Parse(array6[4]);
								this.ePointUp1Force[n] = float.Parse(array6[5]);
								this.ePointUp1ForceVar[n] = byte.Parse(array6[6]);
								string[] array7 = this.ActiveData[3].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointUp2Pos[n] = bool.Parse(array7[1]);
								this.ePointUp2Pos[n] = float.Parse(array7[2]);
								this.ePointUp2PosVar[n] = byte.Parse(array7[3]);
								this.eConfigPointUp2Force[n] = bool.Parse(array7[4]);
								this.ePointUp2Force[n] = float.Parse(array7[5]);
								this.ePointUp2ForceVar[n] = byte.Parse(array7[6]);
								string[] array8 = this.ActiveData[4].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointUp3Pos[n] = bool.Parse(array8[1]);
								this.ePointUp3Pos[n] = float.Parse(array8[2]);
								this.ePointUp3PosVar[n] = byte.Parse(array8[3]);
								this.eConfigPointUp3Force[n] = bool.Parse(array8[4]);
								this.ePointUp3Force[n] = float.Parse(array8[5]);
								this.ePointUp3ForceVar[n] = byte.Parse(array8[6]);
								string[] array9 = this.ActiveData[5].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointUp4Pos[n] = bool.Parse(array9[1]);
								this.ePointUp4Pos[n] = float.Parse(array9[2]);
								this.ePointUp4PosVar[n] = byte.Parse(array9[3]);
								this.eConfigPointUp4Force[n] = bool.Parse(array9[4]);
								this.ePointUp4Force[n] = float.Parse(array9[5]);
								this.ePointUp4ForceVar[n] = byte.Parse(array9[6]);
								string[] array10 = this.ActiveData[6].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointUp5Pos[n] = bool.Parse(array10[1]);
								this.ePointUp5Pos[n] = float.Parse(array10[2]);
								this.ePointUp5PosVar[n] = byte.Parse(array10[3]);
								this.eConfigPointUp5Force[n] = bool.Parse(array10[4]);
								this.ePointUp5Force[n] = float.Parse(array10[5]);
								this.ePointUp5ForceVar[n] = byte.Parse(array10[6]);
								string[] array11 = this.ActiveData[7].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.ePointDown[n] = byte.Parse(array11[1]);
								string[] array12 = this.ActiveData[8].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointDown1Pos[n] = bool.Parse(array12[1]);
								this.ePointDown1Pos[n] = float.Parse(array12[2]);
								this.ePointDown1PosVar[n] = byte.Parse(array12[3]);
								this.eConfigPointDown1Force[n] = bool.Parse(array12[4]);
								this.ePointDown1Force[n] = float.Parse(array12[5]);
								this.ePointDown1ForceVar[n] = byte.Parse(array12[6]);
								string[] array13 = this.ActiveData[9].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointDown2Pos[n] = bool.Parse(array13[1]);
								this.ePointDown2Pos[n] = float.Parse(array13[2]);
								this.ePointDown2PosVar[n] = byte.Parse(array13[3]);
								this.eConfigPointDown2Force[n] = bool.Parse(array13[4]);
								this.ePointDown2Force[n] = float.Parse(array13[5]);
								this.ePointDown2ForceVar[n] = byte.Parse(array13[6]);
								string[] array14 = this.ActiveData[10].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointDown3Pos[n] = bool.Parse(array14[1]);
								this.ePointDown3Pos[n] = float.Parse(array14[2]);
								this.ePointDown3PosVar[n] = byte.Parse(array14[3]);
								this.eConfigPointDown3Force[n] = bool.Parse(array14[4]);
								this.ePointDown3Force[n] = float.Parse(array14[5]);
								this.ePointDown3ForceVar[n] = byte.Parse(array14[6]);
								string[] array15 = this.ActiveData[11].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointDown4Pos[n] = bool.Parse(array15[1]);
								this.ePointDown4Pos[n] = float.Parse(array15[2]);
								this.ePointDown4PosVar[n] = byte.Parse(array15[3]);
								this.eConfigPointDown4Force[n] = bool.Parse(array15[4]);
								this.ePointDown4Force[n] = float.Parse(array15[5]);
								this.ePointDown4ForceVar[n] = byte.Parse(array15[6]);
								string[] array16 = this.ActiveData[12].Split(new string[]
								{
									";"
								}, StringSplitOptions.None);
								this.eConfigPointDown5Pos[n] = bool.Parse(array16[1]);
								this.ePointDown5Pos[n] = float.Parse(array16[2]);
								this.ePointDown5PosVar[n] = byte.Parse(array16[3]);
								this.eConfigPointDown5Force[n] = bool.Parse(array16[4]);
								this.ePointDown5Force[n] = float.Parse(array16[5]);
								this.ePointDown5ForceVar[n] = byte.Parse(array16[6]);
								bool flag13 = !flag;
								if (flag13)
								{
									this.xisTime = this.GetXisTime("Envelope", n);
								}
								bool flag14 = this.xisTime;
								if (flag14)
								{
									flag = true;
								}
							}
						}
					}
					for (int num2 = 0; num2 < 5; num2++)
					{
						bool flag15 = this.wActive[num2];
						if (flag15)
						{
							this.wEvaluationStatus[num2] = this.GetIntersection(b, "Window", num2, sav, num2);
						}
						bool flag16 = this.tActive[num2];
						if (flag16)
						{
							this.tEvaluationStatus[num2] = this.GetIntersection(b, "Threshold", num2, sav, num2);
						}
						bool flag17 = this.eActive[num2];
						if (flag17)
						{
							this.eEvaluationStatus[num2] = this.GetIntersection(b, "Envelope", num2, sav, num2);
						}
					}
					for (int num3 = 0; num3 < 5; num3++)
					{
						bool flag18 = this.wActive[num3];
						if (flag18)
						{
							bool flag19 = this.wConfigMinPos[num3];
							if (flag19)
							{
								this.wMinPosVal[num3] = this.GetVariable((int)this.wMinPosVar[num3]);
							}
							bool flag20 = this.wConfigMaxPos[num3];
							if (flag20)
							{
								this.wMaxPosVal[num3] = this.GetVariable((int)this.wMaxPosVar[num3]);
							}
							bool flag21 = this.wConfigMinForce[num3];
							if (flag21)
							{
								this.wMinForceVal[num3] = this.GetVariable((int)this.wMinForceVar[num3]);
							}
							bool flag22 = this.wConfigMaxForce[num3];
							if (flag22)
							{
								this.wMaxForceVal[num3] = this.GetVariable((int)this.wMaxForceVar[num3]);
							}
						}
						bool flag23 = this.tActive[num3];
						if (flag23)
						{
							bool flag24 = this.tConfigPos[num3];
							if (flag24)
							{
								this.tPosVal[num3] = this.GetVariable((int)this.tPosVar[num3]);
							}
							bool flag25 = this.tConfigMinPos[num3];
							if (flag25)
							{
								this.tMinPosVal[num3] = this.GetVariable((int)this.tMinPosVar[num3]);
							}
							bool flag26 = this.tConfigMaxPos[num3];
							if (flag26)
							{
								this.tMaxPosVal[num3] = this.GetVariable((int)this.tMaxPosVar[num3]);
							}
							bool flag27 = this.tConfigForce[num3];
							if (flag27)
							{
								this.tForceVal[num3] = this.GetVariable((int)this.tForceVar[num3]);
							}
							bool flag28 = this.tConfigMinForce[num3];
							if (flag28)
							{
								this.tMinForceVal[num3] = this.GetVariable((int)this.tMinForceVar[num3]);
							}
							bool flag29 = this.tConfigMaxForce[num3];
							if (flag29)
							{
								this.tMaxForceVal[num3] = this.GetVariable((int)this.tMaxForceVar[num3]);
							}
						}
						bool flag30 = this.eActive[num3];
						if (flag30)
						{
							bool flag31 = this.eConfigPointUp1Pos[num3];
							if (flag31)
							{
								this.ePointUp1Pos[num3] = this.GetVariable((int)this.ePointUp1PosVar[num3]);
							}
							bool flag32 = this.eConfigPointUp2Pos[num3];
							if (flag32)
							{
								this.ePointUp2Pos[num3] = this.GetVariable((int)this.ePointUp2PosVar[num3]);
							}
							bool flag33 = this.eConfigPointUp3Pos[num3];
							if (flag33)
							{
								this.ePointUp3Pos[num3] = this.GetVariable((int)this.ePointUp3PosVar[num3]);
							}
							bool flag34 = this.eConfigPointUp4Pos[num3];
							if (flag34)
							{
								this.ePointUp4Pos[num3] = this.GetVariable((int)this.ePointUp4PosVar[num3]);
							}
							bool flag35 = this.eConfigPointUp5Pos[num3];
							if (flag35)
							{
								this.ePointUp5Pos[num3] = this.GetVariable((int)this.ePointUp5PosVar[num3]);
							}
							bool flag36 = this.eConfigPointUp1Force[num3];
							if (flag36)
							{
								this.ePointUp1Force[num3] = this.GetVariable((int)this.ePointUp1ForceVar[num3]);
							}
							bool flag37 = this.eConfigPointUp2Force[num3];
							if (flag37)
							{
								this.ePointUp2Force[num3] = this.GetVariable((int)this.ePointUp2ForceVar[num3]);
							}
							bool flag38 = this.eConfigPointUp3Force[num3];
							if (flag38)
							{
								this.ePointUp3Force[num3] = this.GetVariable((int)this.ePointUp3ForceVar[num3]);
							}
							bool flag39 = this.eConfigPointUp4Force[num3];
							if (flag39)
							{
								this.ePointUp4Force[num3] = this.GetVariable((int)this.ePointUp4ForceVar[num3]);
							}
							bool flag40 = this.eConfigPointUp5Force[num3];
							if (flag40)
							{
								this.ePointUp5Force[num3] = this.GetVariable((int)this.ePointUp5ForceVar[num3]);
							}
							bool flag41 = this.eConfigPointDown1Pos[num3];
							if (flag41)
							{
								this.ePointDown1Pos[num3] = this.GetVariable((int)this.ePointDown1PosVar[num3]);
							}
							bool flag42 = this.eConfigPointDown2Pos[num3];
							if (flag42)
							{
								this.ePointDown2Pos[num3] = this.GetVariable((int)this.ePointDown2PosVar[num3]);
							}
							bool flag43 = this.eConfigPointDown3Pos[num3];
							if (flag43)
							{
								this.ePointDown3Pos[num3] = this.GetVariable((int)this.ePointDown3PosVar[num3]);
							}
							bool flag44 = this.eConfigPointDown4Pos[num3];
							if (flag44)
							{
								this.ePointDown4Pos[num3] = this.GetVariable((int)this.ePointDown4PosVar[num3]);
							}
							bool flag45 = this.eConfigPointDown5Pos[num3];
							if (flag45)
							{
								this.ePointDown5Pos[num3] = this.GetVariable((int)this.ePointDown5PosVar[num3]);
							}
							bool flag46 = this.eConfigPointDown1Force[num3];
							if (flag46)
							{
								this.ePointDown1Force[num3] = this.GetVariable((int)this.ePointDown1ForceVar[num3]);
							}
							bool flag47 = this.eConfigPointDown2Force[num3];
							if (flag47)
							{
								this.ePointDown2Force[num3] = this.GetVariable((int)this.ePointDown2ForceVar[num3]);
							}
							bool flag48 = this.eConfigPointDown3Force[num3];
							if (flag48)
							{
								this.ePointDown3Force[num3] = this.GetVariable((int)this.ePointDown3ForceVar[num3]);
							}
							bool flag49 = this.eConfigPointDown4Force[num3];
							if (flag49)
							{
								this.ePointDown4Force[num3] = this.GetVariable((int)this.ePointDown4ForceVar[num3]);
							}
							bool flag50 = this.eConfigPointDown5Force[num3];
							if (flag50)
							{
								this.ePointDown5Force[num3] = this.GetVariable((int)this.ePointDown5ForceVar[num3]);
							}
						}
						bool flag51 = this.wActive[num3];
						if (flag51)
						{
							bool flag52 = this.wConfig[num3];
							if (flag52)
							{
								bool flag53 = !this.xisTime;
								if (flag53)
								{
									bool flag54 = this.PosDirectionRight();
									if (flag54)
									{
										this.wMinPosVal[num3] = this.wMinPosVal[num3] + this.minPosition;
										this.wMaxPosVal[num3] = this.wMaxPosVal[num3] + this.minPosition;
									}
									else
									{
										this.wMinPosVal[num3] = this.wMinPosVal[num3] + this.maxPosition;
										this.wMaxPosVal[num3] = this.wMaxPosVal[num3] + this.maxPosition;
									}
								}
							}
						}
						bool flag55 = this.tActive[num3];
						if (flag55)
						{
							bool flag56 = this.tConfig[num3];
							if (flag56)
							{
								bool flag57 = !this.xisTime;
								if (flag57)
								{
									bool flag58 = this.PosDirectionRight();
									if (flag58)
									{
										this.tPosVal[num3] = this.tPosVal[num3] + this.minPosition;
										this.tMinPosVal[num3] = this.tMinPosVal[num3] + this.minPosition;
										this.tMaxPosVal[num3] = this.tMaxPosVal[num3] + this.minPosition;
									}
									else
									{
										this.tPosVal[num3] = this.tPosVal[num3] + this.maxPosition;
										this.tMinPosVal[num3] = this.tMinPosVal[num3] + this.maxPosition;
										this.tMaxPosVal[num3] = this.tMaxPosVal[num3] + this.maxPosition;
									}
								}
							}
						}
						bool flag59 = this.eActive[num3];
						if (flag59)
						{
							bool flag60 = this.eConfig[num3];
							if (flag60)
							{
								bool flag61 = !this.xisTime;
								if (flag61)
								{
									bool flag62 = this.PosDirectionRight();
									if (flag62)
									{
										this.ePointUp1Pos[num3] = this.ePointUp1Pos[num3] + this.minPosition;
										this.ePointUp2Pos[num3] = this.ePointUp2Pos[num3] + this.minPosition;
										this.ePointUp3Pos[num3] = this.ePointUp3Pos[num3] + this.minPosition;
										this.ePointUp4Pos[num3] = this.ePointUp4Pos[num3] + this.minPosition;
										this.ePointUp5Pos[num3] = this.ePointUp5Pos[num3] + this.minPosition;
										this.ePointDown1Pos[num3] = this.ePointDown1Pos[num3] + this.minPosition;
										this.ePointDown2Pos[num3] = this.ePointDown2Pos[num3] + this.minPosition;
										this.ePointDown3Pos[num3] = this.ePointDown3Pos[num3] + this.minPosition;
										this.ePointDown4Pos[num3] = this.ePointDown4Pos[num3] + this.minPosition;
										this.ePointDown5Pos[num3] = this.ePointDown5Pos[num3] + this.minPosition;
									}
									else
									{
										this.ePointUp1Pos[num3] = this.ePointUp1Pos[num3] + this.maxPosition;
										this.ePointUp2Pos[num3] = this.ePointUp2Pos[num3] + this.maxPosition;
										this.ePointUp3Pos[num3] = this.ePointUp3Pos[num3] + this.maxPosition;
										this.ePointUp4Pos[num3] = this.ePointUp4Pos[num3] + this.maxPosition;
										this.ePointUp5Pos[num3] = this.ePointUp5Pos[num3] + this.maxPosition;
										this.ePointDown1Pos[num3] = this.ePointDown1Pos[num3] + this.maxPosition;
										this.ePointDown2Pos[num3] = this.ePointDown2Pos[num3] + this.maxPosition;
										this.ePointDown3Pos[num3] = this.ePointDown3Pos[num3] + this.maxPosition;
										this.ePointDown4Pos[num3] = this.ePointDown4Pos[num3] + this.maxPosition;
										this.ePointDown5Pos[num3] = this.ePointDown5Pos[num3] + this.maxPosition;
									}
								}
							}
						}
					}
					result = 1;
				}
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000610C File Offset: 0x0000430C
		private float GetVariable(int VarNum)
		{
			string text = this.ReadLine(this.logText, "[Variables]", VarNum);
			string[] array = text.Split(new string[]
			{
				";"
			}, StringSplitOptions.None);
			return float.Parse(array[1]);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006150 File Offset: 0x00004350
		private bool GetXisTime(string Evaluation, int id)
		{
			if (!(Evaluation == "Window"))
			{
				if (!(Evaluation == "Threshold"))
				{
					if (Evaluation == "Envelope")
					{
						bool flag = this.ePointUp1Pos[id] > 400f || this.ePointUp2Pos[id] > 400f || this.ePointUp3Pos[id] > 400f || this.ePointUp4Pos[id] > 400f || this.ePointUp5Pos[id] > 400f || this.ePointDown1Pos[id] > 400f || this.ePointDown2Pos[id] > 400f || this.ePointDown3Pos[id] > 400f || this.ePointDown4Pos[id] > 400f || this.ePointDown5Pos[id] > 400f;
						if (flag)
						{
							return false;
						}
					}
				}
				else
				{
					bool flag2 = this.tPosVal[id] > 400f || this.tMaxPosVal[id] > 400f;
					if (flag2)
					{
						return true;
					}
				}
			}
			else
			{
				bool flag3 = this.wMaxPosVal[id] > 400f;
				if (flag3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00006290 File Offset: 0x00004490
		private bool GetIntersection(byte RecordNumber, string Evaluation, int id, string str, int i)
		{
			int num = str.IndexOf("[Curve " + RecordNumber.ToString() + "]", 0);
			string sString = str.Substring(num, str.Length - num);
			string text = this.ReadLine(sString, string.Concat(new string[]
			{
				"[",
				Evaluation,
				" ",
				(id + 1).ToString(),
				"]"
			}), 2);
			string[] array = text.Split(new string[]
			{
				";"
			}, StringSplitOptions.None);
			bool flag = Evaluation == "Window";
			bool result;
			if (flag)
			{
				this.wIntersection[id] = int.Parse(array[0]);
				this.wiUpPos[id] = float.Parse(array[1]);
				this.wiUpForce[id] = float.Parse(array[2]);
				this.wiDownPos[id] = float.Parse(array[3]);
				this.wiDownForce[id] = float.Parse(array[4]);
				this.wiLeftPos[id] = float.Parse(array[5]);
				this.wiLeftForce[id] = float.Parse(array[6]);
				this.wiRightPos[id] = float.Parse(array[7]);
				this.wiRightForce[id] = float.Parse(array[8]);
				result = this.IntersectionEvaluationWindow(id);
			}
			else
			{
				bool flag2 = Evaluation == "Threshold";
				if (flag2)
				{
					this.tIntersection[id] = int.Parse(array[0]);
					this.tiPosition[id] = float.Parse(array[1]);
					this.tiForce[id] = float.Parse(array[2]);
					result = this.IntersectionEvaluationThreshold(id);
				}
				else
				{
					this.eIntersection[id] = int.Parse(array[0]);
					this.eiUpPos[id] = float.Parse(array[1]);
					this.eiUpForce[id] = float.Parse(array[2]);
					this.eiDownPos[id] = float.Parse(array[3]);
					this.eiDownForce[id] = float.Parse(array[4]);
					result = this.IntersectionEvaluationEnvelope(id);
				}
			}
			return result;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00006484 File Offset: 0x00004684
		private bool GetBitfromInt(int myInt, int bitNumber)
		{
			return (myInt & 1 << bitNumber) != 0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000064A4 File Offset: 0x000046A4
		public bool PosDirectionRight()
		{
			return this.readPosition[1] < this.readPosition[this.numPoint - 1];
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000064DC File Offset: 0x000046DC
		private bool IntersectionEvaluationDirection(string sType, float Value)
		{
			bool flag = this.PosDirectionRight();
			bool flag2 = Value != 0f;
			if (flag2)
			{
				if (!(sType == "GoUp"))
				{
					if (!(sType == "GoDown"))
					{
						if (!(sType == "GoRight"))
						{
							if (sType == "GoLeft")
							{
								for (int i = 0; i <= this.numPoint; i++)
								{
									bool flag3 = !this.xisTime;
									if (flag3)
									{
										bool flag4 = flag;
										if (flag4)
										{
											bool flag5 = this.readPosition[i] >= Value;
											if (flag5)
											{
												bool flag6 = this.readPosition[i + 1] < this.readPosition[i - 1];
												if (flag6)
												{
													return true;
												}
												break;
											}
										}
										else
										{
											bool flag7 = this.readPosition[i] >= Value;
											if (flag7)
											{
												bool flag8 = this.readPosition[i - 1] < this.readPosition[i + 1];
												if (flag8)
												{
													return true;
												}
												break;
											}
										}
									}
									else
									{
										bool flag9 = (float)this.readTime[i] >= Value;
										if (flag9)
										{
											bool flag10 = this.readTime[i + 1] < this.readTime[i - 1];
											if (flag10)
											{
												return true;
											}
											break;
										}
									}
								}
							}
						}
						else
						{
							for (int j = 0; j <= this.numPoint; j++)
							{
								bool flag11 = !this.xisTime;
								if (flag11)
								{
									bool flag12 = flag;
									if (flag12)
									{
										bool flag13 = this.readPosition[j] >= Value;
										if (flag13)
										{
											bool flag14 = this.readPosition[j + 1] > this.readPosition[j - 1];
											if (flag14)
											{
												return true;
											}
											break;
										}
									}
									else
									{
										bool flag15 = this.readPosition[j] >= Value;
										if (flag15)
										{
											bool flag16 = this.readPosition[j - 1] > this.readPosition[j + 1];
											if (flag16)
											{
												return true;
											}
											break;
										}
									}
								}
								else
								{
									bool flag17 = (float)this.readTime[j] >= Value;
									if (flag17)
									{
										bool flag18 = this.readTime[j + 1] > this.readTime[j - 1];
										if (flag18)
										{
											return true;
										}
										break;
									}
								}
							}
						}
					}
					else
					{
						int k = 0;
						while (k <= this.numPoint)
						{
							bool flag19 = this.readForce[k] >= Value;
							if (flag19)
							{
								bool flag20 = this.readForce[k + 1] < this.readForce[k - 1];
								if (flag20)
								{
									return true;
								}
								break;
							}
							else
							{
								k++;
							}
						}
					}
				}
				else
				{
					int l = 0;
					while (l <= this.numPoint)
					{
						bool flag21 = this.readForce[l] >= Value;
						if (flag21)
						{
							bool flag22 = this.readForce[l + 1] > this.readForce[l - 1];
							if (flag22)
							{
								return true;
							}
							break;
						}
						else
						{
							l++;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000683C File Offset: 0x00004A3C
		private bool IntersectionEvaluationWindow(int id)
		{
			bool flag = false;
			switch (this.wConfigRight[id])
			{
			case 1:
			{
				bool bitfromInt = this.GetBitfromInt(this.wIntersection[id], 0);
				if (bitfromInt)
				{
					return true;
				}
				break;
			}
			case 2:
			{
				bool bitfromInt2 = this.GetBitfromInt(this.wIntersection[id], 0);
				if (!bitfromInt2)
				{
					return true;
				}
				flag = !this.IntersectionEvaluationDirection("GoLeft", this.wiRightPos[id]);
				bool flag2 = flag;
				if (flag2)
				{
					return flag;
				}
				break;
			}
			case 3:
			{
				bool bitfromInt3 = this.GetBitfromInt(this.wIntersection[id], 0);
				if (!bitfromInt3)
				{
					return true;
				}
				flag = !this.IntersectionEvaluationDirection("GoRight", this.wiRightPos[id]);
				bool flag3 = flag;
				if (flag3)
				{
					return flag;
				}
				break;
			}
			}
			switch (this.wConfigLeft[id])
			{
			case 1:
			{
				bool bitfromInt4 = this.GetBitfromInt(this.wIntersection[id], 4);
				if (bitfromInt4)
				{
					return true;
				}
				break;
			}
			case 2:
			{
				bool bitfromInt5 = this.GetBitfromInt(this.wIntersection[id], 4);
				if (!bitfromInt5)
				{
					return true;
				}
				flag = !this.IntersectionEvaluationDirection("GoRight", this.wiLeftPos[id]);
				bool flag4 = flag;
				if (flag4)
				{
					return flag;
				}
				break;
			}
			case 3:
			{
				bool bitfromInt6 = this.GetBitfromInt(this.wIntersection[id], 4);
				if (!bitfromInt6)
				{
					return true;
				}
				flag = !this.IntersectionEvaluationDirection("GoLeft", this.wiLeftPos[id]);
				bool flag5 = flag;
				if (flag5)
				{
					return flag;
				}
				break;
			}
			}
			switch (this.wConfigDown[id])
			{
			case 1:
			{
				bool bitfromInt7 = this.GetBitfromInt(this.wIntersection[id], 8);
				if (bitfromInt7)
				{
					return true;
				}
				break;
			}
			case 2:
			{
				bool bitfromInt8 = this.GetBitfromInt(this.wIntersection[id], 8);
				if (!bitfromInt8)
				{
					return true;
				}
				flag = !this.IntersectionEvaluationDirection("GoUp", this.wiDownForce[id]);
				bool flag6 = flag;
				if (flag6)
				{
					return flag;
				}
				break;
			}
			case 3:
			{
				bool bitfromInt9 = this.GetBitfromInt(this.wIntersection[id], 8);
				if (!bitfromInt9)
				{
					return true;
				}
				flag = !this.IntersectionEvaluationDirection("GoDown", this.wiDownForce[id]);
				bool flag7 = flag;
				if (flag7)
				{
					return flag;
				}
				break;
			}
			}
			switch (this.wConfigUp[id])
			{
			case 1:
			{
				bool bitfromInt10 = this.GetBitfromInt(this.wIntersection[id], 12);
				if (bitfromInt10)
				{
					flag = true;
				}
				break;
			}
			case 2:
			{
				bool bitfromInt11 = this.GetBitfromInt(this.wIntersection[id], 12);
				if (bitfromInt11)
				{
					flag = !this.IntersectionEvaluationDirection("GoDown", this.wiUpForce[id]);
					bool flag8 = flag;
					if (flag8)
					{
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
			case 3:
			{
				bool bitfromInt12 = this.GetBitfromInt(this.wIntersection[id], 12);
				if (bitfromInt12)
				{
					flag = !this.IntersectionEvaluationDirection("GoUp", this.wiUpForce[id]);
					bool flag9 = flag;
					if (flag9)
					{
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
			}
			return flag;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00006BC4 File Offset: 0x00004DC4
		private bool IntersectionEvaluationThreshold(int id)
		{
			bool flag = false;
			switch (this.tConfig2[id])
			{
			case 0:
			{
				bool flag2 = this.tIntersection[id] == 1;
				if (flag2)
				{
					flag = !this.IntersectionEvaluationDirection("GoUp", this.tiForce[id]);
					bool flag3 = flag;
					if (flag3)
					{
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
			case 1:
			{
				bool flag4 = this.tIntersection[id] == 1;
				if (flag4)
				{
					flag = !this.IntersectionEvaluationDirection("GoDown", this.tiForce[id]);
					bool flag5 = flag;
					if (flag5)
					{
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
			case 2:
			{
				bool flag6 = this.tIntersection[id] == 1;
				if (flag6)
				{
					flag = !this.IntersectionEvaluationDirection("GoLeft", this.tiPosition[id]);
					bool flag7 = flag;
					if (flag7)
					{
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
			case 3:
			{
				bool flag8 = this.tIntersection[id] == 1;
				if (flag8)
				{
					flag = !this.IntersectionEvaluationDirection("GoRight", this.tiPosition[id]);
					bool flag9 = flag;
					if (flag9)
					{
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
			}
			return flag;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00006D00 File Offset: 0x00004F00
		private bool IntersectionEvaluationEnvelope(int id)
		{
			return this.eIntersection[id] != 0;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006D28 File Offset: 0x00004F28
		private bool ActiveEvaluation(string savNew, int activeIdx, bool getActiveData, string EvaluationType)
		{
			this.ActiveIdx = savNew.IndexOf("Active", activeIdx);
			int num = savNew.IndexOf("\r\n", this.ActiveIdx + 1);
			string a = savNew.Substring(this.ActiveIdx + 8, num - this.ActiveIdx - 8);
			bool flag = a == "TRUE";
			bool result;
			if (flag)
			{
				if (getActiveData)
				{
					for (int i = 1; i < 5; i++)
					{
						this.ActiveData[i] = "";
					}
					bool flag2 = EvaluationType == "Windowing";
					if (flag2)
					{
						int num2 = savNew.IndexOf("\r\n", num + 1);
						int num3 = savNew.IndexOf("\r\n", num2 + 1);
						int num4 = savNew.IndexOf("\r\n", num3 + 1);
						int num5 = savNew.IndexOf("\r\n", num4 + 1);
						this.ActiveData[0] = savNew.Substring(num2 + 2, num3 - num2 - 2);
						this.ActiveData[1] = savNew.Substring(num4 + 2, num5 - num4 - 2);
					}
					bool flag3 = EvaluationType == "Treshold";
					if (flag3)
					{
						int num6 = savNew.IndexOf("\r\n", num + 1);
						int num7 = savNew.IndexOf("\r\n", num6 + 1);
						this.ActiveData[0] = savNew.Substring(num6 + 2, num7 - num6 - 2);
					}
					bool flag4 = EvaluationType == "Envelope";
					if (flag4)
					{
						int num8 = savNew.IndexOf("\r\n", num + 1);
						int num9 = savNew.IndexOf("\r\n", num8 + 1);
						int num10 = savNew.IndexOf("\r\n", num9 + 1);
						int num11 = savNew.IndexOf("\r\n", num10 + 1);
						int num12 = savNew.IndexOf("\r\n", num11 + 1);
						int num13 = savNew.IndexOf("\r\n", num12 + 1);
						int num14 = savNew.IndexOf("\r\n", num13 + 1);
						int num15 = savNew.IndexOf("\r\n", num14 + 1);
						int num16 = savNew.IndexOf("\r\n", num15 + 1);
						int num17 = savNew.IndexOf("\r\n", num16 + 1);
						int num18 = savNew.IndexOf("\r\n", num17 + 1);
						int num19 = savNew.IndexOf("\r\n", num18 + 1);
						int num20 = savNew.IndexOf("\r\n", num19 + 1);
						int num21 = savNew.IndexOf("\r\n", num20 + 1);
						this.ActiveData[0] = savNew.Substring(num + 2, num8 - num - 2);
						this.ActiveData[1] = savNew.Substring(num8 + 2, num9 - num8 - 2);
						this.ActiveData[2] = savNew.Substring(num9 + 2, num10 - num9 - 2);
						this.ActiveData[3] = savNew.Substring(num10 + 2, num11 - num10 - 2);
						this.ActiveData[4] = savNew.Substring(num11 + 2, num12 - num11 - 2);
						this.ActiveData[5] = savNew.Substring(num12 + 2, num13 - num12 - 2);
						this.ActiveData[6] = savNew.Substring(num13 + 2, num14 - num13 - 2);
						this.ActiveData[7] = savNew.Substring(num14 + 2, num15 - num14 - 2);
						this.ActiveData[8] = savNew.Substring(num15 + 2, num16 - num15 - 2);
						this.ActiveData[9] = savNew.Substring(num16 + 2, num17 - num16 - 2);
						this.ActiveData[10] = savNew.Substring(num17 + 2, num18 - num17 - 2);
						this.ActiveData[11] = savNew.Substring(num18 + 2, num19 - num18 - 2);
						this.ActiveData[12] = savNew.Substring(num19 + 2, num20 - num19 - 2);
					}
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private string version = "v210502 - BETA - mRH";

		// Token: 0x04000002 RID: 2
		private string logText = "";

		// Token: 0x04000003 RID: 3
		private bool xisTime = false;

		// Token: 0x04000004 RID: 4
		private int numPoint;

		// Token: 0x04000005 RID: 5
		private float maxForce = 0f;

		// Token: 0x04000006 RID: 6
		private float maxPosition = 0f;

		// Token: 0x04000007 RID: 7
		private float minForce = 0f;

		// Token: 0x04000008 RID: 8
		private float minPosition = 0f;

		// Token: 0x04000009 RID: 9
		private int recordTime = 0;

		// Token: 0x0400000A RID: 10
		private float[] readForce = new float[20000];

		// Token: 0x0400000B RID: 11
		private float[] readPosition = new float[20000];

		// Token: 0x0400000C RID: 12
		private int[] readTime = new int[20000];

		// Token: 0x0400000D RID: 13
		private float[] windowIntersection = new float[5];

		// Token: 0x0400000E RID: 14
		private float[] windowUpsidePosition = new float[5];

		// Token: 0x0400000F RID: 15
		private float[] windowUpsideForce = new float[5];

		// Token: 0x04000010 RID: 16
		private float[] windowDownsidePosition = new float[5];

		// Token: 0x04000011 RID: 17
		private float[] windowDownsideForce = new float[5];

		// Token: 0x04000012 RID: 18
		private float[] windowLeftsidePosition = new float[5];

		// Token: 0x04000013 RID: 19
		private float[] windowLeftsideForce = new float[5];

		// Token: 0x04000014 RID: 20
		private float[] windowRightsidePosition = new float[5];

		// Token: 0x04000015 RID: 21
		private float[] windowRightsideForce = new float[5];

		// Token: 0x04000016 RID: 22
		private float[] windowMinPosition = new float[5];

		// Token: 0x04000017 RID: 23
		private float[] windowMinForce = new float[5];

		// Token: 0x04000018 RID: 24
		private float[] windowMaxPosition = new float[5];

		// Token: 0x04000019 RID: 25
		private float[] windowMaxForce = new float[5];

		// Token: 0x0400001A RID: 26
		private int sizeCanvas_x = 0;

		// Token: 0x0400001B RID: 27
		private int sizeCanvas_y = 0;

		// Token: 0x0400001C RID: 28
		private float grid_x = 0f;

		// Token: 0x0400001D RID: 29
		private float grid_y = 0f;

		// Token: 0x0400001E RID: 30
		private float ref_x = 0f;

		// Token: 0x0400001F RID: 31
		private float ref_y = 0f;

		// Token: 0x04000020 RID: 32
		private int[] normForce = new int[20000];

		// Token: 0x04000021 RID: 33
		private int[] normPosition_x = new int[20000];

		// Token: 0x04000022 RID: 34
		private int[] normPosition_y = new int[20000];

		// Token: 0x04000023 RID: 35
		private int[] normTime = new int[20000];

		// Token: 0x04000024 RID: 36
		private float cursorValue_x;

		// Token: 0x04000025 RID: 37
		private float cursorValue_y;

		// Token: 0x04000026 RID: 38
		private string DecimalSeparator = "";

		// Token: 0x04000027 RID: 39
		private bool DecimalSeparatorisknown = false;

		// Token: 0x04000028 RID: 40
		private int[] wNormMinPosVal = new int[5];

		// Token: 0x04000029 RID: 41
		private int[] wNormMaxPosVal = new int[5];

		// Token: 0x0400002A RID: 42
		private int[] wNormMinForceVal = new int[5];

		// Token: 0x0400002B RID: 43
		private int[] wNormMaxForceVal = new int[5];

		// Token: 0x0400002C RID: 44
		private int[] wNormMinTime = new int[5];

		// Token: 0x0400002D RID: 45
		private int[] wNormMaxTime = new int[5];

		// Token: 0x0400002E RID: 46
		private bool[] wActive = new bool[5];

		// Token: 0x0400002F RID: 47
		private bool[] wConfig = new bool[5];

		// Token: 0x04000030 RID: 48
		private bool[] wConfigMinPos = new bool[5];

		// Token: 0x04000031 RID: 49
		private float[] wMinPosVal = new float[5];

		// Token: 0x04000032 RID: 50
		private byte[] wMinPosVar = new byte[5];

		// Token: 0x04000033 RID: 51
		private bool[] wConfigMaxPos = new bool[5];

		// Token: 0x04000034 RID: 52
		private float[] wMaxPosVal = new float[5];

		// Token: 0x04000035 RID: 53
		private byte[] wMaxPosVar = new byte[5];

		// Token: 0x04000036 RID: 54
		private bool[] wConfigMinForce = new bool[5];

		// Token: 0x04000037 RID: 55
		private float[] wMinForceVal = new float[5];

		// Token: 0x04000038 RID: 56
		private byte[] wMinForceVar = new byte[5];

		// Token: 0x04000039 RID: 57
		private bool[] wConfigMaxForce = new bool[5];

		// Token: 0x0400003A RID: 58
		private float[] wMaxForceVal = new float[5];

		// Token: 0x0400003B RID: 59
		private byte[] wMaxForceVar = new byte[5];

		// Token: 0x0400003C RID: 60
		private byte[] wConfigDown = new byte[5];

		// Token: 0x0400003D RID: 61
		private byte[] wConfigUp = new byte[5];

		// Token: 0x0400003E RID: 62
		private byte[] wConfigLeft = new byte[5];

		// Token: 0x0400003F RID: 63
		private byte[] wConfigRight = new byte[5];

		// Token: 0x04000040 RID: 64
		private int[] tNormPosVal = new int[5];

		// Token: 0x04000041 RID: 65
		private int[] tNormMinPosVal = new int[5];

		// Token: 0x04000042 RID: 66
		private int[] tNormMaxPosVal = new int[5];

		// Token: 0x04000043 RID: 67
		private int[] tNormForceVal = new int[5];

		// Token: 0x04000044 RID: 68
		private int[] tNormMinForceVal = new int[5];

		// Token: 0x04000045 RID: 69
		private int[] tNormMaxForceVal = new int[5];

		// Token: 0x04000046 RID: 70
		private int[] tNormTime = new int[5];

		// Token: 0x04000047 RID: 71
		private int[] tNormMinTime = new int[5];

		// Token: 0x04000048 RID: 72
		private int[] tNormMaxTime = new int[5];

		// Token: 0x04000049 RID: 73
		private bool[] tActive = new bool[5];

		// Token: 0x0400004A RID: 74
		private bool[] tConfig = new bool[5];

		// Token: 0x0400004B RID: 75
		private bool[] tMode = new bool[5];

		// Token: 0x0400004C RID: 76
		private bool[] tConfigPos = new bool[5];

		// Token: 0x0400004D RID: 77
		private float[] tPosVal = new float[5];

		// Token: 0x0400004E RID: 78
		private byte[] tPosVar = new byte[5];

		// Token: 0x0400004F RID: 79
		private bool[] tConfigMinPos = new bool[5];

		// Token: 0x04000050 RID: 80
		private float[] tMinPosVal = new float[5];

		// Token: 0x04000051 RID: 81
		private byte[] tMinPosVar = new byte[5];

		// Token: 0x04000052 RID: 82
		private bool[] tConfigMaxPos = new bool[5];

		// Token: 0x04000053 RID: 83
		private float[] tMaxPosVal = new float[5];

		// Token: 0x04000054 RID: 84
		private byte[] tMaxPosVar = new byte[5];

		// Token: 0x04000055 RID: 85
		private bool[] tConfigForce = new bool[5];

		// Token: 0x04000056 RID: 86
		private float[] tForceVal = new float[5];

		// Token: 0x04000057 RID: 87
		private byte[] tForceVar = new byte[5];

		// Token: 0x04000058 RID: 88
		private bool[] tConfigMinForce = new bool[5];

		// Token: 0x04000059 RID: 89
		private float[] tMinForceVal = new float[5];

		// Token: 0x0400005A RID: 90
		private byte[] tMinForceVar = new byte[5];

		// Token: 0x0400005B RID: 91
		private bool[] tConfigMaxForce = new bool[5];

		// Token: 0x0400005C RID: 92
		private float[] tMaxForceVal = new float[5];

		// Token: 0x0400005D RID: 93
		private byte[] tMaxForceVar = new byte[5];

		// Token: 0x0400005E RID: 94
		private byte[] tConfig2 = new byte[5];

		// Token: 0x0400005F RID: 95
		private int[] eNormPointUp1Pos = new int[5];

		// Token: 0x04000060 RID: 96
		private int[] eNormPointUp1Force = new int[5];

		// Token: 0x04000061 RID: 97
		private int[] eNormPointUp2Pos = new int[5];

		// Token: 0x04000062 RID: 98
		private int[] eNormPointUp2Force = new int[5];

		// Token: 0x04000063 RID: 99
		private int[] eNormPointUp3Pos = new int[5];

		// Token: 0x04000064 RID: 100
		private int[] eNormPointUp3Force = new int[5];

		// Token: 0x04000065 RID: 101
		private int[] eNormPointUp4Pos = new int[5];

		// Token: 0x04000066 RID: 102
		private int[] eNormPointUp4Force = new int[5];

		// Token: 0x04000067 RID: 103
		private int[] eNormPointUp5Pos = new int[5];

		// Token: 0x04000068 RID: 104
		private int[] eNormPointUp5Force = new int[5];

		// Token: 0x04000069 RID: 105
		private int[] eNormPointDown1Pos = new int[5];

		// Token: 0x0400006A RID: 106
		private int[] eNormPointDown1Force = new int[5];

		// Token: 0x0400006B RID: 107
		private int[] eNormPointDown2Pos = new int[5];

		// Token: 0x0400006C RID: 108
		private int[] eNormPointDown2Force = new int[5];

		// Token: 0x0400006D RID: 109
		private int[] eNormPointDown3Pos = new int[5];

		// Token: 0x0400006E RID: 110
		private int[] eNormPointDown3Force = new int[5];

		// Token: 0x0400006F RID: 111
		private int[] eNormPointDown4Pos = new int[5];

		// Token: 0x04000070 RID: 112
		private int[] eNormPointDown4Force = new int[5];

		// Token: 0x04000071 RID: 113
		private int[] eNormPointDown5Pos = new int[5];

		// Token: 0x04000072 RID: 114
		private int[] eNormPointDown5Force = new int[5];

		// Token: 0x04000073 RID: 115
		private int[] eNormPointUp1Time = new int[5];

		// Token: 0x04000074 RID: 116
		private int[] eNormPointUp2Time = new int[5];

		// Token: 0x04000075 RID: 117
		private int[] eNormPointUp3Time = new int[5];

		// Token: 0x04000076 RID: 118
		private int[] eNormPointUp4Time = new int[5];

		// Token: 0x04000077 RID: 119
		private int[] eNormPointUp5Time = new int[5];

		// Token: 0x04000078 RID: 120
		private int[] eNormPointDown1Time = new int[5];

		// Token: 0x04000079 RID: 121
		private int[] eNormPointDown2Time = new int[5];

		// Token: 0x0400007A RID: 122
		private int[] eNormPointDown3Time = new int[5];

		// Token: 0x0400007B RID: 123
		private int[] eNormPointDown4Time = new int[5];

		// Token: 0x0400007C RID: 124
		private int[] eNormPointDown5Time = new int[5];

		// Token: 0x0400007D RID: 125
		private bool[] eActive = new bool[5];

		// Token: 0x0400007E RID: 126
		private bool[] eConfig = new bool[5];

		// Token: 0x0400007F RID: 127
		private byte[] ePointUp = new byte[5];

		// Token: 0x04000080 RID: 128
		private float[] ePointUp1Pos = new float[5];

		// Token: 0x04000081 RID: 129
		private float[] ePointUp1Force = new float[5];

		// Token: 0x04000082 RID: 130
		private float[] ePointUp2Pos = new float[5];

		// Token: 0x04000083 RID: 131
		private float[] ePointUp2Force = new float[5];

		// Token: 0x04000084 RID: 132
		private float[] ePointUp3Pos = new float[5];

		// Token: 0x04000085 RID: 133
		private float[] ePointUp3Force = new float[5];

		// Token: 0x04000086 RID: 134
		private float[] ePointUp4Pos = new float[5];

		// Token: 0x04000087 RID: 135
		private float[] ePointUp4Force = new float[5];

		// Token: 0x04000088 RID: 136
		private float[] ePointUp5Pos = new float[5];

		// Token: 0x04000089 RID: 137
		private float[] ePointUp5Force = new float[5];

		// Token: 0x0400008A RID: 138
		private byte[] ePointDown = new byte[5];

		// Token: 0x0400008B RID: 139
		private float[] ePointDown1Pos = new float[5];

		// Token: 0x0400008C RID: 140
		private float[] ePointDown1Force = new float[5];

		// Token: 0x0400008D RID: 141
		private float[] ePointDown2Pos = new float[5];

		// Token: 0x0400008E RID: 142
		private float[] ePointDown2Force = new float[5];

		// Token: 0x0400008F RID: 143
		private float[] ePointDown3Pos = new float[5];

		// Token: 0x04000090 RID: 144
		private float[] ePointDown3Force = new float[5];

		// Token: 0x04000091 RID: 145
		private float[] ePointDown4Pos = new float[5];

		// Token: 0x04000092 RID: 146
		private float[] ePointDown4Force = new float[5];

		// Token: 0x04000093 RID: 147
		private float[] ePointDown5Pos = new float[5];

		// Token: 0x04000094 RID: 148
		private float[] ePointDown5Force = new float[5];

		// Token: 0x04000095 RID: 149
		private byte[] ePointUp1PosVar = new byte[5];

		// Token: 0x04000096 RID: 150
		private byte[] ePointUp1ForceVar = new byte[5];

		// Token: 0x04000097 RID: 151
		private byte[] ePointUp2PosVar = new byte[5];

		// Token: 0x04000098 RID: 152
		private byte[] ePointUp2ForceVar = new byte[5];

		// Token: 0x04000099 RID: 153
		private byte[] ePointUp3PosVar = new byte[5];

		// Token: 0x0400009A RID: 154
		private byte[] ePointUp3ForceVar = new byte[5];

		// Token: 0x0400009B RID: 155
		private byte[] ePointUp4PosVar = new byte[5];

		// Token: 0x0400009C RID: 156
		private byte[] ePointUp4ForceVar = new byte[5];

		// Token: 0x0400009D RID: 157
		private byte[] ePointUp5PosVar = new byte[5];

		// Token: 0x0400009E RID: 158
		private byte[] ePointUp5ForceVar = new byte[5];

		// Token: 0x0400009F RID: 159
		private byte[] ePointDown1PosVar = new byte[5];

		// Token: 0x040000A0 RID: 160
		private byte[] ePointDown1ForceVar = new byte[5];

		// Token: 0x040000A1 RID: 161
		private byte[] ePointDown2PosVar = new byte[5];

		// Token: 0x040000A2 RID: 162
		private byte[] ePointDown2ForceVar = new byte[5];

		// Token: 0x040000A3 RID: 163
		private byte[] ePointDown3PosVar = new byte[5];

		// Token: 0x040000A4 RID: 164
		private byte[] ePointDown3ForceVar = new byte[5];

		// Token: 0x040000A5 RID: 165
		private byte[] ePointDown4PosVar = new byte[5];

		// Token: 0x040000A6 RID: 166
		private byte[] ePointDown4ForceVar = new byte[5];

		// Token: 0x040000A7 RID: 167
		private byte[] ePointDown5PosVar = new byte[5];

		// Token: 0x040000A8 RID: 168
		private byte[] ePointDown5ForceVar = new byte[5];

		// Token: 0x040000A9 RID: 169
		private bool[] eConfigPointUp1Pos = new bool[5];

		// Token: 0x040000AA RID: 170
		private bool[] eConfigPointUp2Pos = new bool[5];

		// Token: 0x040000AB RID: 171
		private bool[] eConfigPointUp3Pos = new bool[5];

		// Token: 0x040000AC RID: 172
		private bool[] eConfigPointUp4Pos = new bool[5];

		// Token: 0x040000AD RID: 173
		private bool[] eConfigPointUp5Pos = new bool[5];

		// Token: 0x040000AE RID: 174
		private bool[] eConfigPointDown1Pos = new bool[5];

		// Token: 0x040000AF RID: 175
		private bool[] eConfigPointDown2Pos = new bool[5];

		// Token: 0x040000B0 RID: 176
		private bool[] eConfigPointDown3Pos = new bool[5];

		// Token: 0x040000B1 RID: 177
		private bool[] eConfigPointDown4Pos = new bool[5];

		// Token: 0x040000B2 RID: 178
		private bool[] eConfigPointDown5Pos = new bool[5];

		// Token: 0x040000B3 RID: 179
		private bool[] eConfigPointUp1Force = new bool[5];

		// Token: 0x040000B4 RID: 180
		private bool[] eConfigPointUp2Force = new bool[5];

		// Token: 0x040000B5 RID: 181
		private bool[] eConfigPointUp3Force = new bool[5];

		// Token: 0x040000B6 RID: 182
		private bool[] eConfigPointUp4Force = new bool[5];

		// Token: 0x040000B7 RID: 183
		private bool[] eConfigPointUp5Force = new bool[5];

		// Token: 0x040000B8 RID: 184
		private bool[] eConfigPointDown1Force = new bool[5];

		// Token: 0x040000B9 RID: 185
		private bool[] eConfigPointDown2Force = new bool[5];

		// Token: 0x040000BA RID: 186
		private bool[] eConfigPointDown3Force = new bool[5];

		// Token: 0x040000BB RID: 187
		private bool[] eConfigPointDown4Force = new bool[5];

		// Token: 0x040000BC RID: 188
		private bool[] eConfigPointDown5Force = new bool[5];

		// Token: 0x040000BD RID: 189
		private int[] wIntersection = new int[5];

		// Token: 0x040000BE RID: 190
		private float[] wiUpPos = new float[5];

		// Token: 0x040000BF RID: 191
		private float[] wiUpForce = new float[5];

		// Token: 0x040000C0 RID: 192
		private float[] wiDownPos = new float[5];

		// Token: 0x040000C1 RID: 193
		private float[] wiDownForce = new float[5];

		// Token: 0x040000C2 RID: 194
		private float[] wiLeftPos = new float[5];

		// Token: 0x040000C3 RID: 195
		private float[] wiLeftForce = new float[5];

		// Token: 0x040000C4 RID: 196
		private float[] wiRightPos = new float[5];

		// Token: 0x040000C5 RID: 197
		private float[] wiRightForce = new float[5];

		// Token: 0x040000C6 RID: 198
		private int[] tIntersection = new int[5];

		// Token: 0x040000C7 RID: 199
		private float[] tiPosition = new float[5];

		// Token: 0x040000C8 RID: 200
		private float[] tiForce = new float[5];

		// Token: 0x040000C9 RID: 201
		private int[] eIntersection = new int[5];

		// Token: 0x040000CA RID: 202
		private float[] eiUpPos = new float[5];

		// Token: 0x040000CB RID: 203
		private float[] eiUpForce = new float[5];

		// Token: 0x040000CC RID: 204
		private float[] eiDownPos = new float[5];

		// Token: 0x040000CD RID: 205
		private float[] eiDownForce = new float[5];

		// Token: 0x040000CE RID: 206
		private bool[] wEvaluationStatus = new bool[5];

		// Token: 0x040000CF RID: 207
		private bool[] tEvaluationStatus = new bool[5];

		// Token: 0x040000D0 RID: 208
		private bool[] eEvaluationStatus = new bool[5];

		// Token: 0x040000D1 RID: 209
		private int ActiveIdx = 0;

		// Token: 0x040000D2 RID: 210
		private string[] ActiveData = new string[14];
	}
}
