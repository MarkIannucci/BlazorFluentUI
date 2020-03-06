﻿using Microsoft.AspNetCore.Components.Rendering;
using System.Collections.Generic;

namespace BlazorFabric
{
    public class MessageBarButton : DefaultButton
    {
        protected override ICollection<Rule> CreateGlobalCss()
        {

            var rules = base.CreateGlobalCss();


            rules.Add(new Rule()
            {
                Selector = new CssStringSelector() { SelectorName = ".ms-Button.ms-Button--messageBar" },
                Properties = new CssString()
                {
                    Css = $"height:24px;" +
                          $"border-color:{Theme.Palette.NeutralTertiaryAlt};"
                }
            });


            return rules;
        }


        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            //base.BuildRenderTree(builder);

            builder.OpenComponent<GlobalCS>(0);
            builder.AddAttribute(1, "Component", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(this));
            builder.AddAttribute(2, "CreateGlobalCss", new System.Func<System.Collections.Generic.ICollection<BlazorFabric.Rule>>(CreateGlobalCss));
            builder.AddAttribute(3, "FixStyle", true);
            builder.CloseComponent();

            StartRoot(builder, "ms-Button--default ms-Button--messageBar");

        }

    }
}
