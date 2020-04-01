using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Описати клас «Книга в бібліотеці».
Клас повинен включати в себе наступні поля (властивості):
• Прізвище ім’я по-батькові автора
• Назва книги
• Код
• Рік видання
• Кількість сторінок
• Жанр
o Визначити конструктор без параметрів, конструктори з параметрами.
o Продумати, які властивості повинні бути доступні тільки для перегляду, а які - і для
зміни/установки значення.
o Визначити методи для порівняння двох книг за вказаним параметром.
o Реалізувати пошук книги по коду.
o Обов’язково реалізувати перевірку та обробку всіх нештатних ситуацій: книги з таким номер
не існує, книг взагалі немає в списку, в поле коде встановлюються знаки пунктуації та інше.
o Всі класи описати в окремих файлах.
o Перевантажити стандартний метод toString();, для виводу інформації про книгу на екран.
o Книг повинно бути не менше п’яти.
*/

namespace Lab5_2
{
    class Book
    {
        string AuthorName;
        string SurName;
        string Name;
        string Code;
        int Year;
        int Count;
        string Genre;
        public Book()
        {

        }
        public Book(string a,string s,string n,string c, int y, int cc, string g)
        {
            AuthorName = a;
            SurName = s;
            Name = n;
            Code = c;
            Year = y;
            Count = cc;
            Genre = g;
        }
        public int CompareGenre(Book A)
        {
            if (Genre.CompareTo(A.Genre) == 0)
            {
                Console.WriteLine("Books '{0}' and '{1}' have same genre;", Name, A.Name);
                return 1;
            }
            else
            {
                Console.WriteLine("Books '{0}' and '{1}' have different genre;", Name, A.Name);
                return 0;
            }
        }

        public Book SearchByCode(Book[] A, ref string z_code)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if ((String.Equals(A[i].Code, z_code)))
                    return A[i];
            }
            return null;
        }
        public override string ToString()
        {
            string str = String.Empty;
            str += ("Name of the book      -    " + Name + ";\n");
            str += ("Author        -    " + AuthorName + " " + SurName + ";\n");
            str += ("Code      -    " + Code + ";\n");
            str += ("Year      -   " + Year + ";\n");
            str += ("Count     -    " + Count + ";\n");
            str += ("Genre     -   " + Genre + ";\n");
            return str;
        }


        public int CompareByAuthor(Book A)
        {
            if (AuthorName.CompareTo(A.AuthorName) == 0 && SurName.CompareTo(A.SurName) == 0)
            {
                Console.WriteLine("Books '{0}' and '{1}' have same author - {2} {3};", Name, A.Name, A.AuthorName, A.SurName);
                return 1;
            }
            else
            {
                Console.WriteLine("Books '{0}' and '{1}' have different authors - {2} {3};", Name, A.Name, A.AuthorName, A.SurName);
                return 0;
            }
        }


    }
}
