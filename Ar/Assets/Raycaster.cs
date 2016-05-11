using UnityEngine;
using System.Collections;

public class Raycaster : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        var up = transform.TransformDirection(Vector3.up);
        RaycastHit hit;

        Debug.DrawRay(transform.position, up * 2, Color.green);
        if (Physics.Raycast(transform.position, up, out hit,0.1f))
        {
     

            if (hit.collider.gameObject.name == "Cube")
            {
                Debug.Log("Hit");
        
            }
        }

	}
}
