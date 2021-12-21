using System;
using System.Text.RegularExpressions;

namespace ExamenTask
{
	public static class Validation
	{
		// Добавить отдельный класс для валидации.

		// Поскольку пользователь вводит сайты по одному.Он может ввести так "http://example.com " (пробел в конце, в начале, в середине).

		internal static string Validate(string domainName)
		{
			string correctDomainName = "";
			
			// убрать пробелы до и после
			domainName = domainName.Trim();
			
			// проверка, есть ли в URI указание протокола http:// или https://
			// если нет, то вставка его
			if (!domainName.Contains("http://") && !domainName.Contains("https://"))
			{
				domainName = "http://" + domainName;
			}
			
			// проверка на спецсимволы (через регулярные выражения)
			// если не проходит проверку, просим повторить ввод
			correctDomainName = ValidateOnSpecialSymbols(domainName);
			
			return correctDomainName;
		}

		// Может ввести не валидные для урл символы. (меньше и больше(«»), открыть и закрыть скобки(«[]»), открыть и закрыть фигурные скобки
		// («{ }»), pipe(«|»), обратная косая черта(«\»), вставки(« »),процентов(«% »).

		public static string ValidateOnSpecialSymbols(string domainName)
		{
			string correctDomainName = "";
			// шаблон для проверки корректности вводимых доменных имен
			string template = @"^htt(p|ps)\:\/\/(www\.)?([a-zA-Z_-]{1,}\.)?[a-zA-Z]+[a-zA-Z0-9_-]*\.[a-z]{2,3}$";

			// проверка вводимых доменных имен на соответсвие установленному шаблону
			// если соответствует шаблону - то возвращается проверенное слово, если нет - то возвращается "error"
			
			Regex regex = new Regex(template);
			Match match = regex.Match(domainName);
			if (match.Success)
			{
				correctDomainName = match.Value;
			}
			else
			{
				correctDomainName = "error";
			}
			
			return correctDomainName;
		}

	}
}
