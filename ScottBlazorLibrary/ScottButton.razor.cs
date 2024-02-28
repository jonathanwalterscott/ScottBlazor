using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace ScottBlazorLibrary.Buttons
{
    public partial class ScottButton : ComponentBase
    {
        [Parameter]
        public string Text { get; set; }
        [Parameter]
        public ScottButtonStyle Style { get; set; }
        [Parameter]
        public bool Disabled { get; set; }
        [Parameter]
        public string Width { get; set; }

        public ScottButton()
        {
            Text = "";
            Style = ScottButtonStyle.Default;
            Disabled = false;
        }

        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClickCallback { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseDownCallback { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseUpCallback { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseOverCallback { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseOutCallback { get; set; }
        [Parameter]
        public EventCallback<MouseEventArgs> OnMouseWheelCallBack { get; set; }
    }
}
