/*Создайте набор оконных приложение. Первое приложение — сервер, второе приложение клиент. Пользователь вводит в элементы управления информацию об IP-адресе 
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
			
			Console.WriteLine("Создадим сокет клиента");

			IPAddress ip = IPAddress.Parse("207.46.197.32");
			IPEndPoint endPoint = new IPEndPoint(ip, 80);
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
			try
			{
				socket.Connect(endPoint);
				if (socket.Connected)
				{
					String strSend = "GET\r\n\r\n";
					socket.Send(System.Text.Encoding.ASCII.
					GetBytes(strSend));
					byte[] buffer = new byte[1024];
					int l;
					string text = null;
					do
					{
						l = socket.Receive(buffer);
						text += System.Text.Encoding.ASCII.
						GetString(buffer, 0, l);
					} while (l > 0);
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
	}
}
