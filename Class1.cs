using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Book[] A = new Book[n];
            A[0] = new Book("Jerome", "Salinger", "The Catcher in the Rye", "QE132", 1951, 234, "Novel");
            A[1] = new Book("Elizabeth", "Gilbert", "Eat Pray Love: One Woman's Search for Everything Across Italy, India, and Indonesia", "DF324", 2006, 352, "Memoir");
            A[2] = new Book("Agatha ", "Christie", "And Then There Were None", "JN543", 1939, 272, "Mystery novel");
            A[3] = new Book("Miguel ", "de Cervantes", "Don Quixote", "VD976", 1605, 863, "Novel");
            A[4] = new Book("Francis Scott ", "Fitzgerald", "The Great Gatsby", "OX593", 1925, 218, "Novel");

            Console.WriteLine("             L I B R A R Y");
            for (int i = 0; i < A.Length; i++)
                Console.WriteLine(A[i]);
            Console.WriteLine("Search by code:");
             string z_code;
             Console.WriteLine("Enter code for search:");
             z_code = Console.ReadLine();
             Book searchBook = new Book();
             searchBook = searchBook.SearchByCode(A, ref z_code);
             if (searchBook != null)
               {
                 Console.WriteLine(searchBook);
               }
             else Console.WriteLine("Book with this code does not exist");
            Console.WriteLine("Compare of 2 books:");
            Console.Write("Enter what you want to compare by \n***author or genre***. \nEnter categorie : ");
            string choice = Console.ReadLine();
            Console.WriteLine("Enter two № of books (1,2,3,4,5) to compare:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            switch (choice) 
            {
                case "author":
                        A[a - 1].CompareByAuthor(A[b - 1]);
                        break;
                    case "genre":
                        A[a - 1].CompareGenre(A[b - 1]);
                        break;
                    default:
                        Console.WriteLine("Error");
                    break;
            }
            
        }
    }
}
