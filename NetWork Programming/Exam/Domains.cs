using System;
using System.Collections.Generic;

namespace ExamenTask
{
	public class Domains
	{
		// 26 доменных имен для режима автоматического (рандомного) создания доменного имени
		public string[] DomainNamesArray = new[]	
		{
			"https://google.com",
			"https://www.microsoft.com",
			"https://id.cisco.com",
			"https://kherson.itstep.org",
			"https://metanit.com",
			"https://store.steampowered.com",
			"https://www.virtualbox.org",
			"https://desktop.telegram.org",
			"https://www.ubisoft.com",
			"https://habr.com",
			"https://www.work.ua",
			"https://rabota.ua",
			"https://jobs.dou.ua",
			"https://djinni.co",
			"https://www.w3schools.com",
			"https://github.com",
			"https://ru.reactjs.org",
			"https://learn.javascript.ru",
			"https://developer.mozilla.org",
			"https://coderoad.ru",
			"https://ostfilm.org",
			"https://filmweb.pl",
			"http://wrong.com",
			"http://example.com",
			"http://seasonvar.ru",
			"http://kokos.com",
			"http://ananas.com"
		};
		// генерация рандомных доменных имен из перечня в массиве DomainNamesArray
		public string GetRandomDomainName()
		{
			string correctDomain = "";
			Random indexRandom = new Random();

			// длина массива DomainNamesArray
			int indexNumber = DomainNamesArray.Length;                          
			int randomNumber;
			
			do
			{
				// получение случайного индекса данного массива
				randomNumber = indexRandom.Next(indexNumber - 1);              
				
				// выбор доменного имени по рандомному индексу
				string randomDomainName = DomainNamesArray[randomNumber];
				
				Console.Write($"Сгенерировано доменное имя:  ");
				ColorWrite.WriteLineColor($"{randomDomainName}\n", 10);

				// проверка рандомного доменного имени (в списках тоже могут быть ошибки)
				correctDomain = Validation.Validate(randomDomainName);

				if (correctDomain == "error")
				{
					ColorWrite.WriteLineColor("Использование некорректного названия доменного имени невозможно. Попробуйте еще!", 12);
					Console.WriteLine("Нажмите на любую клавишу");
					Console.ReadKey();
				}
			} while (correctDomain == "error");

			return correctDomain;
		}

		// ввод пользователем доменных имен
		public string GetManualDomainName()
		{
			string correctDomain = "";
			do
			{
				if (correctDomain == "error")
				{
					ColorWrite.WriteLineColor("Использование некорректного названия доменного имени невозможно. Введите еще раз!", 12);
				}

				Console.Write("Введено доменное имя:   ");
				
				// ввод доменного имени пользователем
				string manualDomainName = Console.ReadLine();
				Console.WriteLine();

				// проверка доменного имени, введенного пользователем
				correctDomain = Validation.Validate(manualDomainName);

			} while (correctDomain=="error");
				
			return correctDomain;
		}

		// доменное имя по умолчанию
		public string GetDefoultValue()
		{
			string domain = "http://google.com";
			return domain;
		}

		public List<string> GetStringDomainName()
		{
			List<string> ListDomainName = new List<string>();
			
			string domainsByString = Console.ReadLine();						// так будет, пока закрыто
			//string domainsByString = "https://www.microsoft.com,https://id.cisco.com,https://kherson.itstep.org,https://metanit.com,https://store.steampowered.com,https://www.virtualbox.org,https://desktop.telegram.org,https://www.ubisoft.com,https://habr.com";
			// разбить на части
			char[] separator = new char[] { ',' };

			string[] subList = domainsByString.Split(separator);

			Console.WriteLine("Выведем список из string[] subList:");

			// провалидировать ввод и записать в List<string> ListDomainName
			string validetedString = "";
			foreach(string str in subList)
			{
				Console.WriteLine(str);
				validetedString = Validation.Validate(str);
				ListDomainName.Add(validetedString);
			}

			Console.WriteLine("А теперь выведем список из ist<string> ListDomainName:");
			foreach (string str in ListDomainName)
			{
				Console.WriteLine(str);
			}

			return ListDomainName;
		}
	}
}
