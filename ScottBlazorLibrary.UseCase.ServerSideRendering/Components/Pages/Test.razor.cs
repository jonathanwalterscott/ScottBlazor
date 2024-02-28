using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ScottBlazorLibrary.Buttons;

namespace ScottBlazorLibrary.UseCase.ServerSideRendering.Components.Pages
{
    public partial class Test : ComponentBase
    {
        private ScottButton DefaultButton { get; set; }
        private ScottButton CancelButton { get; set; }
        private string CancelButtonText = "Cancel";
        private ScottButton DisabledDefaultButton { get; set; }
        private ScottButton DisabledCancelButton { get; set; }

        public Test()
        {
        }

        protected override void OnInitialized() { }

        private void Clicked()
        {
            Task.Delay(550);
        }

        private void MouseDown(MouseEventArgs e)
        {
            CancelButtonText = "Yo!";
        }

        private void MouseUp(MouseEventArgs e)
        {
            CancelButtonText = "Cancel";
        }
    }
}
