namespace homework1
{
    public static class LocationWindow
    {

        public static void ShowLocation(Location location)
        {
            Console.Clear();
            Console.WriteLine($"Znajdujesz si� w {location.Name}. Co chcesz zrobic?");

            for (int i = 0; i < location.npcList.Length; i++)
            {
                Console.WriteLine($"[{i + 1}]Porozmawiaj z {location.npcList[i].Name}");
            }
            Console.WriteLine($"[X]Zamknij program");

            while (true)
            {
                string choice = Console.ReadLine() ?? "";

                if (choice == "X" || choice == "x")
                {
                    Environment.Exit(0);
                }
                else if (int.TryParse(choice, out int choiceAsInt))
                {
                    if (choiceAsInt >= 1 && choiceAsInt <= location.npcList.Length)
                    {
                        Console.Clear();
                        DialogWindow.TalkTo(location.npcList[choiceAsInt - 1]);
                        ShowLocation(location);
                    }
                    else
                    {
                        Console.WriteLine("wybrana opcja jest niew�a�ciwa");
                        Console.WriteLine("pon�w wyb�r");
                    }

                }
                else
                {
                    Console.WriteLine("wybrana opcja jest niew�a�ciwa");
                    Console.WriteLine("pon�w wyb�r");
                }
            }
        }
    }
}