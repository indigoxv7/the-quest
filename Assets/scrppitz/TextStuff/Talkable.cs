using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable : MonoBehaviour, IUsable
{

    private TextDisplayer display;
    public TextBox firstText;
    public User talkingTo;

    public void Use(User u)
    {
        //display = u.GetComponent<TextDisplayer>();
       //u = 
       if(talkingTo == u)
        {
        }
        else
        {
            if (display != null)
            {

                talkingTo = u;
                display.Activate(firstText);

            }
        }
        

    }

    // Use this for initialization
    void Start()
    {
        display = FindObjectOfType<TextDisplayer>();
        talkingTo = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (talkingTo != null)
        {
            if (display)
            {
                if (Vector3.Distance(transform.position, talkingTo.transform.position) > 10)
                {
                    Debug.Log("UR TOO FAR TO HEAR them ");
                    display.Clear();
                    talkingTo = null;
                }
            }
        }
    }
}
