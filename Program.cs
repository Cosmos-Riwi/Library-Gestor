using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> titles = new List<string>();
        List<string> authors = new List<string>();
        List<string> isbns = new List<string>();
        List<string> categories = new List<string>();
        List<bool> availability = new List<bool>();

        bool exit = false;
        while (!exit) {
            Console.WriteLine("\n--- Menú Libros ---");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros por categoría");
            Console.WriteLine("3. Buscar libro por título");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione: ");
            string option = Console.ReadLine();

            switch (option) {
                case "1":
                    Console.Write("Título: ");
                    string title = Console.ReadLine();
                    Console.Write("Autor: ");
                    string author = Console.ReadLine();
                    Console.Write("ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Categoría: ");
                    string category = Console.ReadLine();

                    if (isbns.Contains(isbn)) {
                        Console.WriteLine("❌ El ISBN ya existe.");
                    } else {
                        titles.Add(title);
                        authors.Add(author);
                        isbns.Add(isbn);
                        categories.Add(category);
                        availability.Add(true);
                        Console.WriteLine("✅ Libro registrado.");
                    }
                    break;

                case "2":
                    Console.Write("Categoría: ");
                    string cat = Console.ReadLine();
                    for (int i = 0; i < titles.Count; i++) {
                        if (categories[i] == cat) {
                            Console.WriteLine($"{titles[i]} - {authors[i]} - {(availability[i] ? "Disponible" : "Prestado")}");
                        }
                    }
                    break;

                case "3":
                    Console.Write("Título a buscar: ");
                    string search = Console.ReadLine();
                    bool found = false;
                    for (int i = 0; i < titles.Count; i++) {
                        if (titles[i].ToLower().Contains(search.ToLower())) {
                            Console.WriteLine($"{titles[i]} - {authors[i]} - {categories[i]}");
                            found = true;
                        }
                    }
                    if (!found) Console.WriteLine("No encontrado.");
                    break;

                case "0":
                    exit = true;
                    break;
            }
        }
    }
}