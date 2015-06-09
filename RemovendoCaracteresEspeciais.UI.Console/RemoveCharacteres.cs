using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RemovendoCaracteresEspeciais.UI.Console
{
    public sealed class RemoveCharacteres
    {
        public String RemoveEspecialCharecteres(String text)
        {
            var returnText = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormKD).ToCharArray();


            foreach (var textSeparate in arrayText)
            {
                if (Regex.IsMatch(Convert.ToString(textSeparate), "[a-zA-Z0-9]"))
                {
                    returnText.Append(textSeparate);
                }

            }

            return returnText.ToString();
        }
    }
}
