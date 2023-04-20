using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

// Not being used at this time
namespace CustomControls
{

    /// <summary>
    /// Not being used at this time
    /// </summary>
    public class ColorPopup : VisualElement
    {
        public new class UxmlFactory : UxmlFactory<ColorPopup> { }

        private const string styleResource = "ColorPanel";

        public ColorPopup()
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

    /// <summary>
    /// Displays a popup panel with some buttons to adjust the scale of the displayed mesh.
    /// Not being used at this time.
    /// </summary>
    public class ScaleMeshPopup : VisualElement
    {
        public new class UxmlFactory : UxmlFactory<ScaleMeshPopup> { }

        private const string styleResource = "PopupPanel";

        public ScaleMeshPopup()
        {
            VisualElement window = new VisualElement();
            hierarchy.Add(window);

            // load a style sheet
            styleSheets.Add(Resources.Load<StyleSheet>(styleResource));
            window.AddToClassList("popup_container");

            // we are creating two visual elements
            // - the text prompt
            // - the controls buttons
            VisualElement horizontalContainertText = new VisualElement();
            Label promptLabel = new Label();
            promptLabel.text = "Scale the mesh.";
            horizontalContainertText.Add(promptLabel);

            VisualElement horizontalContainerButtons = new VisualElement();
            Button increaseButton = new Button() { text = "+" };
            Button decreaseButton = new Button() { text = "-" };
            Button dismissButton = new Button() { text = "dismiss" };
            horizontalContainerButtons.Add(increaseButton);
            horizontalContainerButtons.Add(decreaseButton);
            horizontalContainerButtons.Add(dismissButton);

            window.Add(horizontalContainertText);
            window.Add(horizontalContainerButtons);
        }
    }
}
