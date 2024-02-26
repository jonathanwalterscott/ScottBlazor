﻿using Microsoft.AspNetCore.Components;

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
    }
}