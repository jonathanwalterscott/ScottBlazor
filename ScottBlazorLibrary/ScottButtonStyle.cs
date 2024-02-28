namespace ScottBlazorLibrary
{
    public class ScottButtonStyle : Enumeration
    {
        public static ScottButtonStyle Default = new("Default", "button-default");
        public static ScottButtonStyle Save = new("Save", "button-save");
        public static ScottButtonStyle Cancel = new("Cancel", "button-cancel");

        public string ClassName { get; private set; }

        private ScottButtonStyle(string name, string className) : base(name) 
        {
            ClassName = className;
        }
    }
}
