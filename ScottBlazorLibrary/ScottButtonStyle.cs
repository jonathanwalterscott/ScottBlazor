using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ScottBlazorLibrary
{
    public class ScottButtonStyle : Enumeration
    {
        public static ScottButtonStyle Default = new(1, "Default", "button-default", "100px");
        public static ScottButtonStyle Cancel = new(2, "Cancel", "button-cancel", "100px");

        public string Width = "";

        public string StyleName { get; private set; }

        private ScottButtonStyle(int id, string name, string styleName, string width) : base(id, name) 
        {
            StyleName = styleName;
            Width = width;
        }
    }
}
