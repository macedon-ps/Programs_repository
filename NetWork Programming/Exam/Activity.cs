using System;
using System.Collections.Generic;

namespace ExamenTask
{
	public static class Activity
	{
		// сдесь будет отображаться логика приложения

		// 1. Введите количество сайтов, которые хотите проверить? Нужно убедиться, что пользователь ввел число, если нет, то вывести
		// "введите пожалуйста целое число" и попросить ввести заново,
		// 2. Установить лимит на кол-во попыток, например, после 4-х неправильных попыток ввода закрыть приложение)

		// проверка на соответствие типу Int32
		public static int CorrectSelect()
		{
			int selectNumber;
			bool IsNumber = false;
			do
			{
				if (int.TryParse(Console.ReadLine(), out selectNumber))
				{
					IsNumber = true;
				}
				else
				{
					ColorWrite.WriteLineColor("Введите, пожалуйста. целое число! Попробуйте еще раз", 12);
				}
			} while (!IsNumber);
			
			return selectNumber;
		}

		public static int CorrectSelect(int attemps)
		{
			int selectNumber;
			int count = 1;
			bool IsNumber = false;
			do
			{
				Console.Write($"У вас есть {attemps} попытки для ввода:   ");
				if (int.TryParse(Console.ReadLine(), out selectNumber))
				{
					IsNumber = true;
				}
				else
				{
					if (count >= attemps)
					{
						ColorWrite.WriteLineColor("\nВы использовали лимит попыток. ", 12);
						ColorWrite.WriteLineColor($"Это уже {count} попытка.", 14);
						ColorWrite.WriteLineColor("Будьте внимательнее! Попробуйте еще!", 12);
						break;
					}
					ColorWrite.WriteLineColor("Введите, пожалуйста. целое число! Попробуйте еще раз", 12);
					ColorWrite.WriteLineColor($"Осталось попыток: {attemps - count}\n", 14);
					count++;
				}
			} while (!IsNumber && count < attemps + 1);

			return selectNumber;
		}
		
		public static int SelectNumberOfSites()
		{
			ColorWrite.WriteLineColor("ПРИЛОЖЕНИЕ  ПО  ПАРСИНГУ  СОЕДИНЕНИЙ\nс доменными именами\n", 10);
			Console.WriteLine("Введите количество доменных имен для проверки соединения:   ");

			int attemps = 4;												// количество попыток ввода
			int NumberOfSites = CorrectSelect(attemps);						// корректный результат ввода чисел

			// отпарсенный out параметр
			return NumberOfSites;
		}

		public static List<string> GetListDomainName(int number)
		{
			int count = 1;                                                  // счетчик
			var InsertDomainArray = new List<string>();						// список строк
			Domains domainName = new Domains();

			Console.WriteLine($"Введите названия {number} доменных имен (названий сайтов):\n");

			// повторяющийся number раз цикл ввода доменных имен
			do
			{
				ColorWrite.WriteLineColor($"Введите {count}-ое доменное имя: ", 10);
				if(count==1) Console.Write("Ввести вручную (1) или создать автоматически (2), или ввести сразу списком (3):  ");
				else if(count>1) Console.Write("Ввести вручную (1) или создать автоматически (2):  ");

				if (!int.TryParse(Console.ReadLine(), out int selectNumber))
				{
					ColorWrite.WriteLineColor("Вы ввели неправильно. Повторите\n", 12);
					break;
				}

				string nextElement = "";

				switch (selectNumber)
				{
					case 1:
						ColorWrite.WriteLineColor("Будет введено вручную:\n", 14);
						// логика ввода вручную
						nextElement = domainName.GetManualDomainName();
						if (!InsertDomainArray.Contains(nextElement))
						{
							InsertDomainArray.Add(nextElement);
						}
						else
						{
							ColorWrite.WriteLineColor($"Доменное имя {nextElement} уже существует в списке. Попробуйте еще раз!\n", 12);
							number++;
							count--;
						}
						break;
					case 2:
						ColorWrite.WriteLineColor("Будет создано автоматически:\n", 14);
						// логика создания автоматически
						nextElement = domainName.GetRandomDomainName();
						if (!InsertDomainArray.Contains(nextElement))
						{
							InsertDomainArray.Add(nextElement);
						}
						else
						{
							ColorWrite.WriteLineColor($"Доменное имя {nextElement} уже существует в списке. Попробуйте еще раз!\n", 12);
							number++;
							count--;
						}
						break;
					case 3:
						ColorWrite.WriteLineColor("Будет введено списком:\n", 14);
						// логика ввода списком
						// получение всего списка одной строкой
						InsertDomainArray = domainName.GetStringDomainName();
						// парсинг строки в список отдельных доменных имен
						break;
					default:
						ColorWrite.WriteLineColor("По ходу, ошибка: \nВыберите (1) - вручную или (2) - автоматическиб или (3) - списком\n", 12);
						// логика по дефолту
						nextElement = domainName.GetDefoultValue();
						if (!InsertDomainArray.Contains(nextElement))
						{
							InsertDomainArray.Add(nextElement);
						}
						else
						{
							ColorWrite.WriteLineColor($"Дефолтное доменное имя {nextElement} уже существует в списке. Нужно ввести еще раз!\n", 12);
							number++;
							count--;
						}
						break;
				}
				number--;
				count++;
			} while (number != 0);

			return InsertDomainArray;
		}
	}
}
