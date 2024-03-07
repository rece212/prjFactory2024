namespace prjFactory2024
{
    internal class ChickenBurger : IBurger
    {
        public string getBun()
        {
            return "French Bread";
        }

        public string getCondiments()
        {
            return "Sweet Chilli Sauce";
        }

        public string getPatty()
        {
            return "Chicken";
        }
    }
}