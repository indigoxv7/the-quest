using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour , IUsable{

    private float open = 90;
    private float close = 180;

    public void Use(User u)
    {
        if( Mathf.Abs( transform.eulerAngles.y - open) < Mathf.Abs(transform.eulerAngles.y - close))
        {
            transform.eulerAngles = new Vector3(0, close, 0);

        }
        else
        {
            transform.eulerAngles = new Vector3(0, open, 0);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
