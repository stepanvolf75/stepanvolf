using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    public class StartScreen
    {
        public string StartScreenText =
            "-----------------------------------\n" +
            "Evidence pojištěných \n" +
            "-----------------------------------\n" +
            "\nVyberte akci:\n" +
            "1 - Přidat nového pojištěného\n" +
            "2 - Vypsat všechny pojištěné\n" +
            "3 - Vyhledat pojištěného\n" +
            "4 - Konec\n";

        public void ShowStartScreenText()
            {
                Console.WriteLine(StartScreenText);
            }
    }
}
