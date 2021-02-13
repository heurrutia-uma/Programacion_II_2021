using System;
using System.IO;
using System.Text;

namespace Unidad1d
{
    class Program
    {
        static string char179 = "│";
        static string char182 = "╢";
        static string char185 = "╣";
        static string char186 = "║";
        static string char187 = "╗";
        static string char188 = "╝";
        static string char194 = "┬";
        static string char196 = "─";
        static string char199 = "╟";
        static string char200 = "╚";
        static string char201 = "╔";
        static string char204 = "╠";
        static string char205 = "═";

        enum TipoLinea { simple, doble };

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(437);
            Console.WindowWidth = 100;
            Console.WindowHeight = 30;

            Principal();
            Presentacion();

            int op;
            do
            {
                Menu();
                CentrarTexto("Opción: ", 23);
                string resp = LeerEn(54, 23);

                op = int.TryParse(resp, out int num) ? num : 0;

                switch (op)
                {
                    case 1:
                        MotrarRegistros();
                        break;
                    case 2:
                        // AgregarRegistro();
                        break;
                    case 3:
                        // BorrarRegistro();
                        break;
                    default:
                        break;
                }

            } while (op >= 1 && op <= 3);
        }

        static void MotrarRegistros()
        {
            Console.Clear();
            Principal();
            Linea(TipoLinea.simple, 0, 5, Console.WindowWidth);

            const int lineaInicial = 5;
            const int tamanioColumna = 25;

            int pos = 6;

            for (int y = 5; y < Console.WindowHeight - 2; y++)
            {
                for (int x = pos; x < 60; x++)
                {
                    if (x == pos || x == (pos + tamanioColumna) || x == (pos + (tamanioColumna * 2)))
                        EscribirEn(char179, x, y);
                }
            }

            EscribirEn(char194, pos, 5);
            EscribirEn(char194, (pos + tamanioColumna), 5);
            EscribirEn(char194, (pos + (tamanioColumna * 2)), 5);

            int idx = 0;
            pos += 2;

            string archivo = "c:\\datos\\clientes.csv"; // Archivo debe existir.
            using (StreamReader reader = new StreamReader(archivo))
            {
                while (!reader.EndOfStream)
                {
                    string[] valor = reader.ReadLine().Split(',');

                    if (idx == 0)
                    {
                        EscribirEn(valor[0], pos, 4);
                        EscribirEn(valor[1], (pos + tamanioColumna), 4);
                        EscribirEn(valor[2], (pos + (tamanioColumna * 2)), 4);
                    }
                    else
                    {
                        EscribirEn(idx.ToString(), 1, idx + lineaInicial);
                        EscribirEn(valor[0], pos, idx + lineaInicial);
                        EscribirEn(valor[1], (pos + tamanioColumna), idx + lineaInicial);
                        EscribirEn(valor[2], (pos + (tamanioColumna * 2)), idx + lineaInicial);
                    }

                    idx++;
                }
            }

            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Principal();

            int anchoVentana = 30;
            int pos = (Console.WindowWidth - anchoVentana) / 2;

            Ventana(pos, 8, (pos + anchoVentana), 21);
            Linea(TipoLinea.simple, pos, 10, (pos + anchoVentana));

            CentrarTexto("Registro de Datos", 9);
            EscribirEn("1 - Ver Registros", (pos + 3), 12);
            EscribirEn("2 - Agregar Registro", (pos + 3), 14);
            EscribirEn("3 - Borrar Registro", (pos + 3), 16);
            EscribirEn("4 - Salir", (pos + 3), 18);
        }

        static void Presentacion()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            CentrarTexto("Materia", 5);
            Console.ForegroundColor = ConsoleColor.White;
            CentrarTexto("Programación II", 6);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            CentrarTexto("Alumnos", 8);
            Console.ForegroundColor = ConsoleColor.White;
            CentrarTexto("Jose Ayala", 9);
            CentrarTexto("Erika Alas", 10);
            CentrarTexto("Eunice Bonilla", 11);

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        static void Principal()
        {
            Console.Clear();
            Ventana(0, 0, Console.WindowWidth, Console.WindowHeight - 1);
            Linea(TipoLinea.doble, 0, 3, Console.WindowWidth);

            string titulo1 = "** Universidad Modular Abierta **";
            string titulo2 = "Santa Ana";

            Console.ForegroundColor = ConsoleColor.DarkRed;
            CentrarTexto(titulo1.ToUpper(), 1);
            CentrarTexto(titulo2, 2);

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void CentrarTexto(string _texto, int y)
        {
            int pos = (Console.WindowWidth - _texto.Length) / 2;
            EscribirEn(_texto, pos, y);
        }

        static void Linea(TipoLinea tipo, int x, int y, int largo)
        {
            string caracter;
            string extremoIzq;
            string extremoDer;

            if (tipo == TipoLinea.simple)
            {
                caracter = char196;
                extremoIzq = char199;
                extremoDer = char182;
            }
            else
            {
                caracter = char205;
                extremoIzq = char204;
                extremoDer = char185;
            }

            for (int i = x; i < largo; i++)
                EscribirEn(caracter, i, y);

            EscribirEn(extremoIzq, x, y);
            EscribirEn(extremoDer, (largo - 1), y);
        }

        static void Ventana(int iniX, int iniY, int finX, int finY)
        {
            for (int j = iniY; j < finY; j++)
            {
                for (int i = iniX; i < finX; i++)
                {
                    if (j == iniY || j == (finY - 1))
                        EscribirEn(char205, i, j);
                    else if (i == iniX || i == (finX - 1))
                        EscribirEn(char186, i, j);
                }
            }

            EscribirEn(char201, iniX, iniY);
            EscribirEn(char187, (finX - 1), iniY);

            EscribirEn(char200, iniX, (finY - 1));
            EscribirEn(char188, (finX - 1), (finY - 1));
        }

        static void EscribirEn(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        static string LeerEn(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            return Console.ReadLine();
        }
    }
}
