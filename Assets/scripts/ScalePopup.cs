using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScalePopup : VisualElement
{
    public new class UxmlFactory : UxmlFactory<ScalePopup> { }

    private const string styleResource = "ColorPanel";

    public ScalePopup()
    {
        // load a style sheet
        styleSheets.Add(Resources.Load<StyleSheet>(styleResource));
        VisualElement panel = new VisualElement();

        panel.style.width = 200;
        panel.style.height = 100;

        // apply the style sheet to this custom component - note the name;
        // this is definied in the uss.
        panel.AddToClassList("default_panel");

        hierarchy.Add(panel);
    }
}
