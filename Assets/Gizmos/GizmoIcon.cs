using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoIcon : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void OnDrawGizmos()
    {
        Gizmos.DrawIcon(transform.position, "icon.png.jpg",true);
    }
}
