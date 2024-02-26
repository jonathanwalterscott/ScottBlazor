using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ScottBlazorLibrary.Buttons;

namespace ScottBlazorLibrary.UseCase.ServerSideRendering.Components.Pages
{
    public partial class Test : ComponentBase
    {
        private ScottButton DefaultButton { get; set; }
        private ScottButton CancelButton { get; set; }
        private ScottButton DisabledDefaultButton { get; set; }
        private ScottButton DisabledCancelButton { get; set; }

        private string _value = "";

        public Test()
        {
        }

        protected override void OnInitialized() { }

    }
}
