using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Utilities
{
	public static class MyUtilities
	{
		// вывод теста в цвете
		// шифры цветов:
		// 9 - синий, 10 - зеленый, 12 - красный, 14 - желтый и т.д.
		public static void WriteLineColor(string message, int color)							
		{
			Console.ForegroundColor = (ConsoleColor)color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
		
		// получение ответа от сервера по заданному доменному имени
		public static void ShowIsResponseFrom(string hostAddress)
		{
			Console.Write("1. Запрос на сервер ");
			MyUtilities.WriteLineColor(hostAddress, 14);

			HttpWebRequest reqw = (HttpWebRequest)HttpWebRequest.Create(hostAddress);
			Console.Write("Начальная строка запроса: ");
			MyUtilities.WriteLineColor($"{reqw.Method} / {reqw.Address} / {reqw.ProtocolVersion}", 10);
			Console.WriteLine();

			try
			{
				//создаем объект отклика
				HttpWebResponse resp = (HttpWebResponse)reqw.GetResponse();                         
				Console.Write("2. Ответ с сервера ");
				MyUtilities.WriteLineColor(hostAddress, 14);

				Console.WriteLine("Начальная строка ответа:  ");
				MyUtilities.WriteLineColor($"{resp.ProtocolVersion} / {(int)resp.StatusCode}", 10);
				Console.WriteLine("Статус код ответа:  ");
				MyUtilities.WriteLineColor($"{(int)resp.StatusCode} {resp.StatusCode}", 10);

				// можно ограничить только кодом 200, но от 200 до 299 - все успешные соединения
				if ((int)resp.StatusCode >= 200 && (int)resp.StatusCode < 300)						
				{
					MyUtilities.WriteLineColor("Соединение успешно", 10);
					Console.WriteLine();
					MyUtilities.WriteLineColor("Заголовки ответа:  их значения", 9);
					Console.WriteLine(resp.Headers);

					StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.Default);
					//создаем поток для чтения отклика
					Console.WriteLine(sr.ReadToEnd());
					//вывести на экран все, что читается
					sr.Close();
				}
			}
			catch(Exception ex)
			{
				MyUtilities.WriteLineColor($"Упс! Что-то пошло не так!\nСоединение с данным сервером невозможно\nКод ошибки:  {ex.Message}", 12);
			}
			Console.WriteLine();
			MyUtilities.WriteLineColor("Нажмите на любую кнопку\n", 14);
			Console.ReadKey();
		}
	}
	
}
