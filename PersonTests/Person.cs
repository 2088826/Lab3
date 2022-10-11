namespace PersonTests
{
    /// <summary>
    /// Represents one person saving their name.
    /// </summary>
    public class Person : IComparable<Person>, IDisplayable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// Constructor for a person optionally adding their name.
        /// </summary>
        /// <param name="name">Person's name, empty by default.</param>
        public Person(string name = "")
        {
            this.Name = name.Trim();
        }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Returns a string that represents the person.
        /// </summary>
        /// <returns>String that represents the person.</returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// This method displays the Name of the Person.
        /// </summary>
        public void Display()
        {
            MessageBox.Show(this.Name);
        }



        /// <summary>
        /// Compares two instances of the Person class.
        /// </summary>
        /// <param name="other">Is another instance of an object to be compared.</param>
        /// <returns>if the return is a positive number, they are the same. If not, a negative number means they are not.</returns>
        public int CompareTo(Person other)
        {
            if (this.Name == other.Name)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
