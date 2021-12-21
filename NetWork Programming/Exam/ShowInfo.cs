using System;
using System.Collections.Generic;
using System.Net;

namespace ExamenTask
{
	public class ShowInfo
	{
		// 3. Введите url 1 сайта[пользователь вводит нажимает Enter], введите url 2 сайта[пользователь вводит нажимает Enter] и т.д.
		// 4. Доступных сайтов: [кол-во(код ответа 200)], недоступных: [кол-во(код ответа 500)], не известно: [кол-во(код ответа 404)]
		
		// вывод информации о количестве доступных, недоступных и не известных сайтов

		public ShowInfo() { }

		public ShowInfo(List<string> InsertDomainArray)
		{
			ColorWrite.WriteLineColor("СПИСОК ВВЕДЕННЫХ ДОМЕННЫХ ИМЕН:", 14);
			foreach (string site in InsertDomainArray)
			{
				Console.Write("Доменное имя:  ");
				ColorWrite.WriteLineColor(site, 10);
			}
			Console.WriteLine();
		}

		public ShowInfo(Dictionary<string, HttpStatusCode> ListAndResponseCodes)
		{
			int countAvailable = 0;
			int countNotAvailable = 0;
			int countUnknown = 0;
			int countAnother = 0;
			
			foreach (var element in ListAndResponseCodes)
			{
				if((int)element.Value >=200 && (int)element.Value < 300)
				{
					countAvailable++;
				}
				else if ((int)element.Value >= 300 && (int)element.Value < 500)
				{
					countUnknown++;
				}
				else if ((int)element.Value >= 500 && (int)element.Value < 600)
				{
					countNotAvailable++;
				}
				else 
				{
					countAnother++;
				}
			}
			ColorWrite.WriteLineColor("ИНФОРМАЦИЯ  О  РЕЗУЛЬТАТАХ  ЗАПРОСОВ:", 14);

			Console.WriteLine($"Доступных сайтов:  Количество: {countAvailable} Коды ответа: 200-206");
			Console.WriteLine($"Недоступных сайтов:  Количество: {countNotAvailable} Код ответа: 500-505");
			Console.WriteLine($"Не извествестно:  Количество: {countUnknown} Код ответа: 300-417");
			Console.WriteLine($"Другие:  Количество: {countAnother} Код ответа: <200 или >600");
			Console.WriteLine();
		}

		public void FullInformationAboutSites(Dictionary<string, HttpStatusCode> verifiedList)
		{
			List<string> availableList = new List<string>();
			List<string> notAvailableList = new List<string>();
			List<string> unknownList = new List<string>();
			List<string> anotherList = new List<string>();
			int countAvailable = 0;
			int countNotAvailable = 0;
			int countUnknown = 0;
			int countAnother = 0;

			foreach (var element in verifiedList)
			{
				if ((int)element.Value >= 200 && (int)element.Value < 300)
				{
					countAvailable++;
					availableList.Add(element.Key);
				}
				else if ((int)element.Value >= 300 && (int)element.Value < 500)
				{
					countUnknown++;
					unknownList.Add(element.Key);
				}
				else if ((int)element.Value >= 500 && (int)element.Value < 600)
				{
					countNotAvailable++;
					notAvailableList.Add(element.Key);
				}
				else
				{
					countAnother++;
					anotherList.Add(element.Key);
				}
			}

			ColorWrite.WriteLineColor("ПОДРОБНАЯ  ИНФОРМАЦИЯ  О  РЕЗУЛЬТАТАХ  ЗАПРОСОВ:", 14);

			ColorWrite.WriteColor($"\nДоступных сайтов:  ", 10);
			foreach(var element in availableList)
			{
				Console.Write(element);
				if (element != null) Console.Write(", ");
			}
			Console.WriteLine($"\nКоличество: {countAvailable} Коды ответа: 200-206");

			ColorWrite.WriteColor($"\nНедоступных сайтов:  ", 12);
			foreach (var element in notAvailableList)
			{
				Console.Write(element);
				if (element != null) Console.Write(", ");
			}
			Console.WriteLine($"\nКоличество: {countNotAvailable} Код ответа: 500-505");

			ColorWrite.WriteColor($"\nНе извествестно:  ", 14);
			foreach (var element in unknownList)
			{
				Console.Write(element);
				if (element != null) Console.Write(", ");
			}
			Console.WriteLine($"\nКоличество: {countUnknown} Код ответа: 300-417");

			ColorWrite.WriteColor($"\nДругие:  ", 10);
			foreach (var element in anotherList)
			{
				Console.Write(element);
				if (element != null) Console.Write(", ");
			}
			Console.WriteLine($"\nКоличество: {countAnother} Код ответа: <200 или >600");
		}
	}
}