using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTexture : MonoBehaviour {
    public Texture texture;
    public Rect rect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnDrawGizmos()
    {
        if(texture!=null)
        {
            Gizmos.DrawGUITexture(rect, texture);
        }
    }
}
