using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class TextBox : ScriptableObject {

    public bool ChoiceBox = false;
    public string[] textBody;
    public TextBox[] next;


    public UserEffect effect;

    private void OnEnable()
    {
        if (textBody == null)
        {
            textBody = new string[1];
        }
        if (next == null)
        {
            next = new TextBox[1];
        }
    }


    //public string[] 
}
