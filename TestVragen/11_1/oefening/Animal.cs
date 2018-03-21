    namespace oefening
{
    internal abstract class Animal
    {
        protected string Name;

        protected Animal()
        {
        }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract string Sound();
        

        public override string ToString()
        {
            return $"Naam: '{GetName}' Sound: '{Sound()}'";
        }

        public string GetName => Name;

        public void SetName(string name)
        {
            Name = name;
        }        
    }
}
