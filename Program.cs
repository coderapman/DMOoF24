namespace MenuSys2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til vores MENUSYSTEM!!");

           /** MenuItem m1 = new MenuItem("1 stk. Sushi");
            MenuItem m2 = new MenuItem("10 stk. Sushi");
            MenuItem m3 = new MenuItem("200 stk. Sushi");*/
            MenuItem vm = null;

            Menu minmenu = new Menu("Den fantastisk sushirestaurant");


            minmenu.AddMenuItem("1 stk. Sushi");
            minmenu.AddMenuItem("10 stk. Sushi");
            minmenu.AddMenuItem("200 stk. Sushi");
            
            minmenu.show();
            vm = minmenu.Choose();
            Console.ReadLine();
        }
    }
}
