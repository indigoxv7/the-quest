using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplayer : MonoBehaviour {

    public TextBox currentBox;
    private Text[] txt;
    private Image img;


    private void Start()
    {
        txt = GetComponentsInChildren<Text>();

        img = GetComponentInChildren<Image>();
        //UpdateText(currentBox);

        Clear();
    }


    public void UpdateText(TextBox t)
    {
        if (t != null)
        {
            currentBox = t;
            Debug.Log("trying to update " + txt.Length);

            for (int i = 0; i < 3; i++)
            {
                if (i < currentBox.textBody.Length)
                {
                    Debug.Log("doign the " + i + "th one");
                    txt[i].text = currentBox.textBody[i];
                }
                else
                {
                    txt[i].text = "";
                }


            }
        }
        else
        {
            Clear();
        }

    }


    public void Clear()
    {
        foreach (var item in txt)
        {
            item.text = "";
        }
        currentBox = null;
        img.gameObject.SetActive(false);
    }

    public void Activate(TextBox t)
    {
        img.gameObject.SetActive(true);
       // currentBox = t;
       UpdateText( t);
    }

    private void Update()
    {
        if (currentBox)
        {
            if (currentBox.ChoiceBox)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (Input.GetButtonDown("Option" + i))
                    {
                        Debug.Log("you just hit the " + i);
                        if (currentBox.textBody[i] != null)
                        {
                            if (currentBox.next[i] == null)
                            {
                                Clear();
                            }
                            else
                            {
                                UpdateText(currentBox.next[i]);
                            }

                        }

                    }
                }

            }
            else
            {
                if (Input.GetButtonDown("Use"))
                {
                    UpdateText(currentBox.next[0]);
                }
            }

        }


    }

}
