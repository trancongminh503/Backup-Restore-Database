using System;

namespace BK_Restore
{
	public static class LOG
	{
		public static void DEBUG(string caption, string property, object value)
		{
			Console.WriteLine($"DEBUG: {caption} - {property}: {value} - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
		}
	}
}
