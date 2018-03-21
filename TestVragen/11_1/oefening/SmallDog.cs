namespace oefening
{
    internal class SmallDog : Dog
    {
        public SmallDog(string name) : base(name)
        {
        }

        public override string Sound()
        {
            return "kef kef";
        }
    }
}
