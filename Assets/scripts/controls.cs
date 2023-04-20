using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class controls : MonoBehaviour
{
    void Awake()
    {
        ConfigureUI();
    }

    private void ConfigureUI()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        VisualElement buttonsContainer = root.Q<VisualElement>("buttons-container");
        //  Get references to the buttons in the UI document.
        Button button1 = buttonsContainer.Q<Button>("scale");
        Button button2 = buttonsContainer.Q<Button>("action");

        button1.clicked += () => Debug.Log("action 1");
        button2.clicked += () => Debug.Log("action 2");

        // for testing purposes
        // root.Add(new ScalePopup());
    }
}
