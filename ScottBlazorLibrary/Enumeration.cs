namespace ScottBlazorLibrary
{
    public abstract class Enumeration : IComparable
    {
        public string Name { get; private set; }

        protected Enumeration(string name) => (Name) = (name);

        public override string ToString() => Name;

        public override bool Equals(object obj)
        {
            if (obj is not Enumeration otherValue)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Name.Equals(otherValue.Name);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object other) => Name.CompareTo(((Enumeration)other).Name);
    }
}
