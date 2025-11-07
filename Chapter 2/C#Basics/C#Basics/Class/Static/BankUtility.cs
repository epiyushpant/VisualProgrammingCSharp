namespace C_Basics.Class.Static
{
    public static class BankUtility
    {
        public static double ConvertUsdToNpr(double usd)
        {
            double rate = 133.5; // current conversion rate
            return usd * rate;
        }

        public static double CalculateInterest(double balance, double rate)
        {
            return (balance * rate) / 100;
        }
    }
}
