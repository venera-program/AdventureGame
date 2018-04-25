using System;
using System.Windows.Forms;

namespace PresentationLayer
{
	internal static class FormsMain
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Program_Window());
		}
	}
}
