using System;
using System.Windows.Forms;

namespace YJKP_Curve_Display
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600002B RID: 43 RVA: 0x0000752A File Offset: 0x0000572A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frMain());
		}
	}
}
