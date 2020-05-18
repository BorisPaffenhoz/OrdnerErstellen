//  #   Funktions Beschreibung der Konsolen Anwendung   #
//  #   Das Programm "OrdnerErstellen" erstellt einen Ordner in dem Verzeichnis C:\ und hat den Namen Start-Stream-00000 (C:\Start_Stream_00000).    #
//  #   Falls der Ordner schon existiert, dann wird das über die "if else" Methode abgefangen.  # 
//  #   Dokumentation   #
//  #   Erfolgreicher durchlauf des Programms   #


using System;
using System.IO;

namespace OrdnerErstellen
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Enthaelt den string fuer das erstellte Verzeichnis.
            string folderName = @"C:\Start_Stream_00000";

            //  Prueft ob der Ordner existiert.
            //  Wenn er nicht existiert, dann wird der Ordner erstellt und gibt eine Meldung aus.
            if (!Directory.Exists(folderName))
            {
                System.IO.Directory.CreateDirectory(folderName);
                Console.WriteLine("Datei wurde erstellt ! " +folderName);
                Console.WriteLine("Zum Beenden bitte Enter drücken.");
                Console.ReadLine();
            }

            //  Wenn der Ordner existiert, dann kommt die Meldung aus dem else Blog.
            else
            {
                Console.WriteLine("Ordner existiert! "+ folderName);
                Console.WriteLine("Zum Beenden bitte Enter drücken.");
                Console.ReadLine();
                return;
            }
        }
    }
}
