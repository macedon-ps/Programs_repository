﻿/*Создайте набор оконных приложение. Первое приложение — сервер, второе приложение клиент. Пользователь вводит в элементы управления информацию об IP-адресе 
для подсоединения и номере порта. После нажатия на кнопку Подсоединиться клиент подключается к серверу. 
Если соединения успешно, клиент и сервер могут обмениваться сообщениями до тех пор, пока один из них не попрощается, послав строку Bye. После отсылки этой 
строки, соединение должно быть закончено. Реализуйте несколько режимов отсылки сообщений:
■ Человек(в клиентском приложении человек вводит строку) — человек(в серверном приложении человек вводит строку);
■ Человек(клиент) — компьютер(сервер);
■ Компьютер (клиент) — человек (сервер);
■ Компьютер (клиент) — компьютер (сервер).
Для реализации ответов компьютера используйте набор заготовленных фраз, выбранных случайным образом. Проектируйте архитектуру вашего приложения таким 
образом, чтобы сетевой блок кода не был завязан на UI. Например, чтобы его было просто перенести из оконного в консольное приложение.
*/

using System;
using System.Net;
using System.Net.Sockets;

namespace ClientServereNetworking
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1. Создание сокета клиента

			WriteLineColor("Создадим сокет клиента", 10);
			
			IPAddress ip = IPAddress.Parse("77.222.61.70");                                     // создаем переменную ip для конечной точки (сервера)
			Console.WriteLine("IP = " + ip);
			
			IPEndPoint endPoint = new IPEndPoint(ip, 80);                                       // создаем переменную endPoint с указанием IP адреса и порта 80
			Console.WriteLine("endPoint = " + endPoint);
			Console.WriteLine();   
																								// создаем сокет клиента для соединения с конечной точкой (сервером)
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
			Console.ForegroundColor = ConsoleColor.Green;

			WriteLineColor("Создан сокет", 10);
			
			try
			{
				socket.Connect(endPoint);														// метод соединения с конечной точкой (сервером)
				if (socket.Connected)                                                           // проверка, что соединение есть
				{
					WriteLineColor("Соединение есть", 10);
					
					String strSend = "GET\r\n\r\n";												// метод запроса - GET()
					socket.Send(System.Text.Encoding.ASCII.GetBytes(strSend));                  // отправка на сервер сообщения о типе запроса (в байтах)
					
					WriteLineColor("Отправлен GET запрос", 10);
					
					byte[] buffer = new byte[1024];												// создаем массив buffer
					int bytesNumber;															// создаем переменную bytesNumber
					string text = null;
					do
					{
						WriteLineColor("Получили промежуточный text:", 12);
						
						bytesNumber = socket.Receive(buffer);                                   // получение с сервера сведений о количестве байт информации в буфере
						Console.WriteLine("bytesNumber = " + bytesNumber);
						text += System.Text.Encoding.ASCII.GetString(buffer, 0, bytesNumber);
						Console.WriteLine(text);
					} while (bytesNumber > 0);
					
					WriteLineColor("Получили окончательный text:", 12);
				}
				else
					Console.WriteLine("Error");
			}
			catch (SocketException ex)
			{ 

			Console.WriteLine(ex.Message);
			}
			// 2. Создание сокета сервера
			Console.WriteLine("Создадим сокет конечной точки (сервера)");
		}
		public static void WriteLineColor(string message, int color)
		{

			Console.ForegroundColor = (ConsoleColor)color;
			Console.WriteLine(message);
			Console.ResetColor();
			Console.WriteLine();
		}
	}

	
}