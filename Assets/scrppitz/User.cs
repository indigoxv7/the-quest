using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour {

    public float reach;

    private Ray r;

    private void Update()
    {

        if (Input.GetButtonDown("Use"))
        {
            Debug.Log("tryting to raycast");
            r = new Ray(transform.position + Vector3.up, transform.rotation * Vector3.forward);

            RaycastHit hit;
            if (Physics.Raycast(r, out hit,reach))
            {
                Debug.Log("i think i hit something " + hit.collider.gameObject.name);
                IUsable u = hit.collider.GetComponent<IUsable>();
                if(u != null)
                {
                    Debug.Log("using ");
                    u.Use(this);
                }
                // hit.collider.gameObject.SetActive(false);
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(r);
    }
}
