using System;

namespace ExamenTask
{
	public static class ColorWrite
	{
		// вывод текста в цвете
		// шифры цветов:   9 - синий, 10 - зеленый, 12 - красный, 14 - желтый и т.д.
		public static void WriteLineColor(string message, int color)
		{
			Console.ForegroundColor = (ConsoleColor)color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
		public static void WriteColor(string message, int color)
		{
			Console.ForegroundColor = (ConsoleColor)color;
			Console.Write(message);
			Console.ResetColor();
		}
	}
}
