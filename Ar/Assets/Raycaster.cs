using UnityEngine;
using System.Collections;

public class Raycaster : MonoBehaviour {

	// Use this for initialization
    public float colorChangeDelay = 1f;
    private float currentDelay = 0f;
   

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        var up = transform.TransformDirection(Vector3.up);
        RaycastHit hit;

        Debug.DrawRay(transform.position, up * 2, Color.green);
        if (Physics.Raycast(transform.position, up, out hit))
        {
     

            if (hit.collider.gameObject.name == "Cube")
            {
                Debug.Log("Hit");
            }
        }

	}
}
