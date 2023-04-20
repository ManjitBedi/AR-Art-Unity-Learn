using System.Collections;
using System.Collections.Generic;
using CustomControls;
using UnityEngine;
using UnityEngine.UIElements;

public class controls : MonoBehaviour
{
    GameObject meshGameObject;

    [SerializeField]
    float maxScale = 2.0f;

    [SerializeField]
    float minScale = 0.25f;

    void Awake()
    {
        ConfigureUI();
    }

    private void Start()
    {

    }

    private void ConfigureUI()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        VisualElement buttonsContainer = root.Q<VisualElement>("buttons-container");
        //  Get references to the buttons in the UI document.
        Button button1 = buttonsContainer.Q<Button>("scale-up");
        Button button2 = buttonsContainer.Q<Button>("scale-down");
        Button button3 = buttonsContainer.Q<Button>("action");

        button1.clicked += () => ScaleUp();
        button2.clicked += () => ScaleDown();
        button3.clicked += () => Debug.Log("action 3 - coming soon");

        // for testing purposes
        root.Add(new ScaleMeshPopup());
    }

    #region button actions

    private void ScaleUp()
    {
        Debug.Log("action 1");
        if (meshGameObject == null)
        {
            meshGameObject = GameObject.FindGameObjectWithTag("ar-game-object");
        }

        var currentScale = meshGameObject.transform.localScale.x;
        if (currentScale < maxScale)
        {
            meshGameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }

    }

    private void ScaleDown()
    {
        Debug.Log("action 2");
        if (meshGameObject == null)
        {
            meshGameObject = GameObject.FindGameObjectWithTag("ar-game-object");
        }

        var currentScale = meshGameObject.transform.localScale.x;
        if (currentScale > minScale)
        {
            meshGameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
    }

    #endregion
}
