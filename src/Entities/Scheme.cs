namespace WindowsCursorSwitcher.Entities
{
    internal class Scheme
    {
        public string Name { get; set; }
        //new(nameof(help)

        public List<Cursor> Cursors { get; set; } = [];

        public Scheme(string name)
        {
            // Setting the property values.
            Name = name;
        }
    }
}
