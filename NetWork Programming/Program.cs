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

namespace ClientServereNetworking
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1. Создание сокета клиента
			
			Console.WriteLine("Создадим сокет клиента");


			// 2. Создание сокета сервера
			Console.WriteLine("Создадим сокет конечной точки (сервера)");
		}
	}
}
