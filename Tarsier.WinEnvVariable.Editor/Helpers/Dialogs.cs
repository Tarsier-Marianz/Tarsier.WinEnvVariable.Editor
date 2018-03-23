using Tarsier.WinEnvVariable.Editor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarsier.WinEnvVariable.Editor {
    public class Dialogs {
        public static string GetFilters(Filters filter) {
            string result;
            if(filter.Equals(Filters.SUPPORTED_FILES)) {
                result = @"All Supported Files (*.sln,*.proj,*.csproj,*.vdproj,*.vssscc,*.vspscc) |*.sln;*.proj;*.csproj;*.vdproj;*.vssscc;*.vspscc|
Microsoft Visual Studio Solution (*.sln) |*.sln| 
Visual Studio Poject File(*.proj) |*.proj|
Visual Studio C# Poject File(*.csproj) |*.csproj|
Visual Studio VB File(*.vdproj) |*.vdproj|
Visual Studio Solution Source Control File (*.vssscc) |*.vssscc|
Visual Studio Project Source Control File (*.vspscc) |*.vspscc";

            } else {
                result = "All Files (*.*)|*.*";
            }
            return result;
        }

        
    }
}
