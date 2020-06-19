using System;
using System.Collections.Generic;
using System.IO;
using Helpers;

namespace ConsoleApp1
{
    class Principal
    {
        static void Main(string[] args)
        {
            string path = @"bin\debug" ;
            string txt = "*.txt";
            string mp3 = "*.mp3";

            string[] dirtxt = Directory.GetDirectories(path, txt);
            string[] dirmp3 = Directory.GetDirectories(path, mp3);

            string NuevaRuta = "Alguna nueva ruta";

            for (int i = 0; i < dirtxt.Length; i++)
            {
                File.Move(dirtxt[i],NuevaRuta);
            }

            for (int i = 0; i < dirmp3.Length; i++)
            {
                File.Move(dirmp3[i], NuevaRuta);
            }
        }
    }
}
