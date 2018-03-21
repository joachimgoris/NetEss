namespace oefening
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override string Sound()
        {
            return "Woef woef";
        }
    }
}
