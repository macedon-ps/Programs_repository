using System;
using System.Collections.Generic;
using System.Net;

namespace ExamenTask
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1.1. запрос количества сайтов, которые нужно проверить 
			// 1.2. проверка на тип int введенного пользователем количества сайтов
			// 1.3. установка лимита на количество попыток ввода (не больше 4-х)
			int numberSites = Activity.SelectNumberOfSites();
			if (numberSites == 0) return;

			// 2.1. ввод доменных имен по заданному количеству  (ввод вручную или рандомно из массива уже существующих сайтов)
			// 2.2. проверка (верификация) введенных доменных имен (наличие пробелов, спец. символов, проверка и добавление "http://")
			// 2.3. и загрузка их в список List<string>
			// 2.3. и загрузка их в список типа List<string>
			List<string> awaitingList = Activity.GetListDomainName(numberSites);

			// 3.1. создание запросов на введенные сайты, обработка кодов ответа от них
			// 3.2. загрузка доменных имен и кодов ответов в дневник типа Dictionary<string, HttpStatusCode> 
			// как ассоциативный массив - ключ (доменное имя): значение (код ответа)
			Dictionary<string, HttpStatusCode> verifiedList = HttpRequest.IsResponseFrom(awaitingList);

			// 4.1.вывод информации о количестве доступных, недоступных и не известных сайтов
			ShowInfo information1 = new ShowInfo(awaitingList);
			
			ShowInfo information2 = new ShowInfo(verifiedList);
			information2.FullInformationAboutSites(verifiedList);
			
		}
	}
}
