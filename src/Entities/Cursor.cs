using System.Configuration;

namespace WindowsCursorSwitcher.Entities
{
    internal class Cursor(string typeName, string regeditName)
    {
        internal string TypeName { get; init; } = typeName;

        internal string RegeditName { get; set; } = regeditName;
    }
}
