
using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        List<string> titles = new List<string> { "Libro1", "Libro2", "Libro3" };
        List<bool> availability = new List<bool> { true, false, true };
        List<int> borrowCount = new List<int> { 5, 2, 8 };

        bool exit = false;
        while (!exit) {
            Console.WriteLine("\n--- Menú Estadísticas ---");
            Console.WriteLine("1. Mostrar disponibilidad");
            Console.WriteLine("2. Top 5 libros más prestados");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione: ");
            string option = Console.ReadLine();

            switch (option) {
                case "1":
                    int available = 0, borrowed = 0;
                    for (int i = 0; i < availability.Count; i++) {
                        if (availability[i]) available++;
                        else borrowed++;
                    }
                    Console.WriteLine($"Disponibles: {available}, Prestados: {borrowed}");
                    break;

                case "2":
                    List<string> tempTitles = new List<string>(titles);
                    List<int> tempCounts = new List<int>(borrowCount);

                    for (int i = 0; i < tempCounts.Count - 1; i++) {
                        for (int j = i + 1; j < tempCounts.Count; j++) {
                            if (tempCounts[j] > tempCounts[i]) {
                                int auxCount = tempCounts[i];
                                tempCounts[i] = tempCounts[j];
                                tempCounts[j] = auxCount;

                                string auxTitle = tempTitles[i];
                                tempTitles[i] = tempTitles[j];
                                tempTitles[j] = auxTitle;
                            }
                        }
                    }

                    Console.WriteLine("Top libros más prestados:");
                    for (int i = 0; i < tempTitles.Count && i < 5; i++) {
                        Console.WriteLine($"{tempTitles[i]} → {tempCounts[i]} préstamos");
                    }
                    break;

                case "0":
                    exit = true;
                    break;
            }
        }
    }
}
