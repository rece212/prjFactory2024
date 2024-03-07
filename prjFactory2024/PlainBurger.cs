namespace prjFactory2024
{
    internal class PlainBurger : IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Tomato Sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}