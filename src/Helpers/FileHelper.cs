// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

using System.Diagnostics;

namespace WindowsCursorSwitcher.Helpers
{
    internal static class FileHelper
    {
        public static void OpenFileLocation(string filePath)
        {
            try
            {
                Process.Start("explorer.exe", $"/select,\"{filePath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file location: {ex.Message}");
            }
        }

        internal static void OpenWindowsMousePropertiesWindow() => Process.Start("control", "main.cpl,,1");

        internal static string OpenFileDialog()
        {
            var openFileDialog = new OpenFileDialog()
            {
                Title = "Select a Cursor File",
                Filter = "Cursor Files (*.cur;*.ani)|*.cur;*.ani",
                Multiselect = false
            };
            string path = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK) path = Path.GetRelativePath(Application.StartupPath, openFileDialog.FileName);
            return path;
        }

        internal static string OpenFolderDialog()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            string path = string.Empty;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) path = Path.GetRelativePath(Application.StartupPath, folderBrowserDialog.SelectedPath);
            return path;
        }
    }
}
