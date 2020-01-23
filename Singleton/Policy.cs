namespace Singleton
{
    public sealed class Policy
    {
        private static readonly Policy _instance = new Policy();
        // static contructor to avoid marking type as beforefieldinit
        static Policy() { }
        private Policy() { }
        public static Policy GetInstance
        {
            get
            {
                return _instance;
            }
        }

        private int Id { get; set; } = 1;
        private string Insured { get; } = "Kowalig";

        public string GetInsuredName() => Insured;
    }
}
