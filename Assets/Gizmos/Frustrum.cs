using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frustrum : MonoBehaviour {
    public float fov = 60;
    public Vector2 range;
    public float aspectRatio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDrawGizmos()
    {
        Gizmos.DrawFrustum(transform.position,fov, range.x, range.y, aspectRatio);
    }
}
