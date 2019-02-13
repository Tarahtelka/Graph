using System;
using System.Windows.Forms;

namespace GraphApp.Views.Implementations.Helpers
{
    public static class FormExtensions
    {
        public static float? TryGetFloat(this TextBox textBox, Action infoAction, Action warningAction)
        {
            var text = textBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                infoAction();

                return null;
            }

            float number;

            if (!float.TryParse(text, out number))
            {
                warningAction();

                return null;
            }

            return number;
        }

        public static int? TryGetInt32(this TextBox textBox, Action infoAction, Action warningAction)
        {
            var text = textBox.Text;

            if (string.IsNullOrEmpty(text))
            {
                infoAction();

                return null;
            }

            int number;

            if (!int.TryParse(text, out number))
            {
                warningAction();

                return null;
            }

            return number;
        }
    }
}