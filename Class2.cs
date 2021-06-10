using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class MyList<T>

	{
		Node<T> firstElement;

		Node<T> GetLast()
		{
			Node<T> last = firstElement;

			while (last.next != null)
			{
				last = last.next;
			}
			return last;
		}
		public T Get(int i)
		{
			Node<T> last = firstElement;
			for (int j = 0; j < i; j++)
			{
				last = last.next;
			}
			return last.value;
		}
		public void Print()
		{
			Node<T> last = GetFirst();
			while (last != null)
			{
				Console.WriteLine(last.value);
				last = last.next;

			}
		}
		public void AddFront(T value)//добавление в начале списка
		{
			Node<T> abc = new Node<T>();
			abc.value = value;

			if (firstElement == null)
			{
				firstElement = abc;
			}
			else
			{
				abc.next = GetFirst();
				abc.next.prev = abc;
			}
		}
		public void AddBack(T value)//добавление в конце списка 
		{
			Node<T> abc = new Node<T>();
			abc.value = value;

			if (firstElement == null)
			{
				firstElement = abc;
			}
			else
			{
				abc.prev = GetLast();
				GetLast().next = abc;


			}
		}
		Node<T> GetFirst()
		{
			Node<T> last = firstElement;

			while (last.prev != null)
			{
				last = last.prev;
			}
			return last;
		}
		int Count()
		{
			int i = 0;
			Node<T> last = firstElement;
			while (last.next != null)
			{
				i++;
				last = last.next;
			}
			return i;
		}
		public void Search(int i)//копирование скроки 
		{
			if ((i != 0) && (i <= Count()))
			{
				Node<T> last = firstElement;

				for (int j = 0; j < i; j++)
				{
					last = last.next;
				}
				Console.WriteLine(last.value);
			}
			else throw new IndexOutOfRangeException();
		}
		public void Remove(int i)
		{
			Node<T> last = firstElement;
			Node<T> OneAhead;
			for (int j = 0; j < i; j++)
			{
				last = last.next;
			}
			OneAhead = last.next;
			last = last.prev;
			last.next = OneAhead;
		}
		public void InsertBefore(int i, T C)
		{
			Node<T> last = firstElement;
			Node<T> ded1 = new Node<T>();
			Node<T> ded2 = last.prev;
			for (int j = 0; j < i; j++)
			{
				last = last.next;
			}
			ded1.value = C;
			ded1.prev = ded2;
			ded1.next = last;
			ded2.next = ded1;
			last.prev = ded1;
		}
		public void InsertAfter(int i, T C)
		{
			Node<T> last = firstElement;
			Node<T> ded1 = new Node<T>();
			Node<T> ded2 = last.next;

			ded1.value = C;
			ded1.next = ded2;
			ded1.prev = last;
			ded2.prev = ded1;
			last.next = ded1;
		}
		public void PopFront()
		{
			Node<T> ded = firstElement;
			firstElement = ded;
			ded.next = firstElement.next;
			ded.prev = firstElement.prev;
			firstElement = ded;
		}
		public void PopBack()
		{
			Node<T> ded = firstElement;
			firstElement = ded;
			ded.next = firstElement.next;
			ded.prev = firstElement.prev;
			firstElement = ded;
		}
		public void PrintRevers()
		{
			Node<T> last = GetLast();
			while (last != null)
			{
				Console.WriteLine(last.value);
				last = last.prev;

			}
		}
		public int Search3(int i, T C)
		{
			{
				Node<T> last = firstElement;
				int index = -1;
				while (last != null)
				{
					index++;
					if (last.next == last)
					{
						return index;
					}
				}
				last = last.next;
				return -1;
			}
		}
	
	}
}
