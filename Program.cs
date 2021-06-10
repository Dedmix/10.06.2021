using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> list = new MyList<string>();
			list.AddBack("Безумие это точное повторение одного и того же действия раз за разом,");
			list.AddBack("В надежде на изменнение это и безумие ");
			list.AddBack("Когда впервые я это услышал, не помню кто сказал эту хрень я БУМ, убил его");
			list.AddFront("Я уже говорил что такое безумиею А?");
			list.AddBack("Смысл в том хахаха Окей ? Он был прав.");
			list.AddBack("Куда ни глянь, делают точно одно и тоже, сона и снова, и снова, и снова");
			list.AddBack("И думают: Сейчас все исменить");
			list.AddBack("Не-не-не, прошу. Сейчас все будет иначе.");

			list.Remove(2);
		    list.InsertBefore(2, "Когда впервые я это услышал, не помню кто сказал эту хрень я БУМ, убил его. (добавил)");
		    list.InsertAfter(4, "Везде, куда ни гляну - эти болваны. (доб)");
			list.Print();
			list.Search(1);
			list.Search3();
			Console.WriteLine();
			list.PrintRevers();
		



			Console.ReadKey();





		}
	}
}
