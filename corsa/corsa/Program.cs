// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
using static System.Console;

// Baravelli Andrea 4E 2022-09-22

Console.WriteLine("Autore: Andrea Baravelli");




namespace corsa
{
    class Program
    {
        static int posAndrea = 0;// posizione di partenza di Andrea
        static int posBaldo = 0; // posizione di partenza di Baldo
        static int posCarlo = 0;// posizione di partenza di Carlo

        static void pronti()// preparazione degli omini per la corsa
        {
            SetCursorPosition(posAndrea, 2);
            Write("Andrea");
            SetCursorPosition(posAndrea, 3);
            Write(" ☺");
            SetCursorPosition(posAndrea, 4);
            Write(@" /\ ");
            SetCursorPosition(posAndrea, 5);
            Write("||");
            SetCursorPosition(posBaldo, 6);
            Write("Baldo");

            SetCursorPosition(posBaldo, 7);
            Write("()");

            SetCursorPosition(posBaldo, 8);
            Write(@"/\");

            SetCursorPosition(posBaldo, 9);

            Write("||");
        }

    }

    






}

