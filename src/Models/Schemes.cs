using WindowsCursorSwitcher.Utils;

namespace WindowsCursorSwitcher.Models
{
    internal class Schemes
    {
        public bool CreateNewCursorSchemeForCurrentUser(string scheme)
        {
            UtilRegedit.ModifyKeyValue(scheme, "paths");

            CreateRegistry(RegeditSchemesPath);
        }

        private void AddAndSaveToSettings()
        {

        }

        private void ChangePaths()
        {
            string SelectedPaths
        }
    }
}
