using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoClass : MonoBehaviour {


    public void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawCube(Vector3.zero, Vector3.one);
    }
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, Vector3.one);
    }
}
