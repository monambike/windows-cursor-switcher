// Copyright(c) 2025 Vinicius Gabriel Marques de Melo. All rights reserved.
// Contact: @monambike for more information.
// For license information, please see the LICENSE file in the root directory.

namespace WindowsCursorSwitcher.Utils
{
    internal static class UtilMessages
    {
        internal static void ShowConfirmationExitMessage()
        {
            var dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) Application.Exit();
        }

        internal static void ShowHowToUseMessage() =>
            MessageBox.Show(
                @"Right Clicks The Tabs To:"
                + Environment.NewLine + "Rename, Duplicate or Delete Schemas.",
                "How To Use",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        internal static void ShowAboutMessage() =>
            MessageBox.Show(@"""Windows Cursor Switcher"" created by: @monambike. (2025) :D Enjoy it!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
