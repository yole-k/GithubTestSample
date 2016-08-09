using System;
using Gtk;

namespace GithubTestSample
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Application.Init();
			MainWindow win = new MainWindow();
			//"test";
			win.Show();
			Application.Run();
		}
	}
}
