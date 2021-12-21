using System;
using System.Collections.Generic;

namespace ExamenTask
{
	public class Checker
	{
		// список с ожидающими проверки доменными именами
		private List<string> awaitingVerificationList;
		private Dictionary<string, int?> verifiedList;

		public List<string> AwaitingVerificationList 
		{
			get 
			{ 
				return awaitingVerificationList; 
			}
			set 
			{ 
				awaitingVerificationList = value;
			}
		}

		// словарь (расширяемый ассоциативный массив), ключ - доменное имя, значение - код ответа
		public Dictionary<string, int?> VerifiedList 
		{
			get 
			{
				return verifiedList;
			}
			set 
			{
				verifiedList = value;
			}
		}				
	}
}
