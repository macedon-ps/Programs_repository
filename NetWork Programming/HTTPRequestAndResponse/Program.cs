/*Создать приложение.
1) Используя HttpWebRequest и HttpWebResponse необходимо получить и вывести на экран код ответа 
('https://google.com', 'http://asfhyugsdh.com', 'http://rosumniy.prostir.com.ua/')
И вывести содержимое на экран если код 200. */

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Utilities;


namespace HTTPRequestAndResponse
{
	class Program
	{
		static void Main(string[] args)
		{
			MyUtilities.ShowIsResponseFrom("https://google.com");
			MyUtilities.ShowIsResponseFrom("http://asfhyugsdh.com");
			MyUtilities.ShowIsResponseFrom("http://rosumniy.prostir.com.ua/");
		}
	}
}
