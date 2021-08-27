using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionPopup : MonoBehaviour
{
    public InputField inputText;
    public Text titleText;

    public GameObject toggle_cast;
    Toggle toggleTest;

    // Start is called before the first frame update
    void Start()
    {
        toggleTest = toggle_cast.GetComponent<Toggle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnOkButton()
    {
        gameObject.SetActive(false);    
    }

    void OnTextChanged()
    {
        titleText.text = inputText.text;
    }

    void OnTextEditEnd()
    {
        titleText.text = inputText.text;
    }
    void OntogglePopup()
    { 
        if(toggleTest.isOn)
        {
            titleText.text = "toggle_on";
        }
        else
        {
            titleText.text = "toggle_off";
        }
    }
}
