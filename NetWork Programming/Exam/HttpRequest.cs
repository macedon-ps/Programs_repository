using System;
using System.Collections.Generic;
using System.Net;

namespace ExamenTask
{
	public static class HttpRequest
	{
		// 3. Введите url 1 сайта[пользователь вводит нажимает Enter], введите url 2 сайта[пользователь вводит нажимает Enter] и т.д.
		// получение ответа от сервера по заданному доменному имени
		public static Dictionary<string, HttpStatusCode> IsResponseFrom(List<string> awaitList)
		{
			var verifeidList = new Dictionary<string, HttpStatusCode>();
			int count = 1;

			ColorWrite.WriteLineColor("\nОТВЕТЫ  ОТ  ДОМЕННЫХ  ИМЕН: ", 14);

			foreach (string domain in awaitList)
			{
				HttpWebRequest reqw = (HttpWebRequest)HttpWebRequest.Create(domain);
				
				HttpStatusCode statusCode;

				try
				{
					//создаем объект отклика
					HttpWebResponse resp = (HttpWebResponse)reqw.GetResponse();
					Console.Write($"{count}. Ответ с сервера ");
					ColorWrite.WriteLineColor(domain, 14);
					ColorWrite.WriteLineColor("Успешный ответ", 10);
					count++;
					
					// получаем код ответа
					statusCode = resp.StatusCode;
					Console.WriteLine("Статус код ответа:  ");
					ColorWrite.WriteLineColor($"{(int)statusCode} {statusCode}", 10);       // статус код ответа
					Console.WriteLine();

					// добавляем в словарь (ассоциативный массив) новый элемент: где ключ - доменное имя, значение - код ответа
					verifeidList.Add(domain, statusCode);
					
				}
				catch (WebException ex)
				{
					Console.Write($"{count}. Ответ с сервера ");
					ColorWrite.WriteLineColor(domain, 14);
					count++;

					ColorWrite.WriteLineColor($"Упс! Что-то пошло не так!\nКод ошибки:  {ex.Message}", 12);
					Console.WriteLine("Статус код ответа:  ");

					if (ex.Response != null)
					{
						// полуачам код ответа из сообщения об исключении
						statusCode = ((HttpWebResponse)ex.Response).StatusCode;				// статус код ответа
						ColorWrite.WriteLineColor($"{(int)statusCode} {statusCode}\n", 12);

						// добавляем в словарь (ассоциативный массив) новый элемент: где ключ - доменное имя, значение - код ответа
						verifeidList.Add(domain, statusCode);
					}
					else
					{
						ColorWrite.WriteLineColor("нет ответа\n", 12);                        // статус код ответа
						// когда нет ответа, код ответа - 0
						verifeidList.Add(domain, (HttpStatusCode)0);
					}
				}
			}
			return verifeidList;
		}
	}
}

// примеры с кодами ответов на запросы к доменным именам

//HttpRequest.IsResponseFrom("https://google.com");							// 200
//HttpRequest.IsResponseFrom("google.com");									// 200, после добавления "http://"
//HttpRequest.IsResponseFrom("https://ostfilm.org");						// 301
//HttpRequest.IsResponseFrom("https://filmweb.pl");							// 200
//HttpRequest.IsResponseFrom("https://azov.zp.ua/genichesk/ay-petri/");		// 404
//HttpRequest.IsResponseFrom("http://wrong.com");							// 403
//HttpRequest.IsResponseFrom("http://sea-family.in.ua/item/papademore/");	// 404
//HttpRequest.IsResponseFrom("http://example.com");							// 200
//HttpRequest.IsResponseFrom("http://kozel.com"):							// 504
//HttpRequest.IsResponseFrom("http://127.0.0.1");							// нет ответа
//HttpRequest.IsResponseFrom("http://goo|gle.com");							// не проходит валидацию
//HttpRequest.IsResponseFrom("http://go$ogle&.com");						// не проходит валидацию
// и т.д.