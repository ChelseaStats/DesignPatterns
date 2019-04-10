namespace FacadePatternExample
{
    /// <summary>
    /// Patron of the restaurant
    /// </summary>
    class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}