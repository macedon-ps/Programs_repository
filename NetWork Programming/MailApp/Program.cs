/*Создать приложение.
Используя MailMessage и SmtpClient отправить через сторонний smtp-serverver (например smtp.gmail.com), сообщение на свою 
собственную почту. На экран вывести Диалог с smtp-сервером, и время через сколько было обработано письмо. */

using System;
using System.Net;
using System.Text;
using System.Net.Mail;
using Utilities;

namespace MailApp
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				MyUtilities.WriteLineColor("Приложение для отправки сообщений через SMTP-сервер\n", 10);

				// 1. Формируем входные параметры сообщения (From, To, Subject, Body) и SMTP клиента (Server)

				string From = "macedon1971@gmail.com";						// адрес отправителя сообщения
				string To = "kazanchan1972@gmail.com";						// адрес получателя сообщения
				string server = "smtp.gmail.com";							// адрес SMPT сервера

				// 1.1. Данные первого отправленного сообщения

				//string Subject = "Новые предложения к Новому году!";
				//string Body = "Дорогие друзья!\nБлизится Новый год и нужно много успеть!\nСпешите приобрести лучшие подарки к Новому году для всей семьи! ";

				// 1.2. Данные второго отправленного сообщения

				string Subject = "Тестовое задание по \"Сетевому программированию\"";
				string Body = "Домашнее задание №5\nСоздать приложение. Используя MailMessage и SmtpClient отправить через сторонний " +
				"smtp-serverver(например smtp.gmail.com), сообщение на свою собственную почту.\nНа экран вывести Диалог с smtp-сервером, " +
				"и время через сколько было обработано письмо.\n\nОтправка сообщений уже реализована, сообщения доходят до адресата)))\n" +
				"К сожалению, реализация ответа от SMTP сервера средствами C# через создание POP3-клиента на данный момент невозможна";

				// 2. Создание сообщения
				MailMessage post = new (From, To, Subject, Body);
												
				// Вводим пароль для доступа к приложению через аккаунт
				MyUtilities.WriteLineColor("Введите пароль к приложению", 10);
				
				// пароль вводим через ввод с клавиатуры (так безопасней)
				string mypassword = Console.ReadLine();
				Console.WriteLine();

				// 3. Создаем SMTP-клиент для передачи сообщения через SMTP-сервер
				SmtpClient client = new (server, 587);
				client.Credentials = new NetworkCredential("macedon1971@gmail.com", mypassword);

				client.EnableSsl = true;
				//client.Timeout = 0;
				//client.UseDefaultCredentials = true;

				try
				{
					// 4. Отправляем сообщение
					client.Send(post);											
					MyUtilities.WriteLineColor("Сообщение успешно оправлено", 10);
				}
				catch(Exception cl)
				{
					MyUtilities.WriteLineColor($"Сообщение не отправлено. Причина:  {cl.Message}", 12);
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine($"Упс! Что-то пошло не так!\nКод ошибки:  {ex.Message}");
			}
		}
	}
}
