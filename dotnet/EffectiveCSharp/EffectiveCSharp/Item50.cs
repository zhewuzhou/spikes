namespace EffectiveCSharp
{
    public struct Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}