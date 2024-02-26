using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottBlazorLibrary
{
    public class ScottButtonStyle : Enumeration
    {
        public static ScottButtonStyle Default = new(1, "Default", "button-default");
        public static ScottButtonStyle Cancel = new(2, "Cancel", "button-cancel");

        public string StyleName { get; private set; }

        private ScottButtonStyle(int id, string name, string styleName) : base(id, name) 
        {
            StyleName = styleName;
        }
    }
}
