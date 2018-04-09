using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBezierOne : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;

    void OnDrawGizmos() {
       
        if (p1 == null || p2 == null || p3 == null) {
            return;
        }
        BezierOne bezierOne = new BezierOne(p1.transform.position,p2.transform.position,p3.transform.position);
        Vector3 startPoint = bezierOne.GetPointRange0_1(0f);
        Gizmos.color = Color.green;
        for (float i=0.1f;i<=1f;i+=0.03f) {
            Vector3 inPoint = bezierOne.GetPointRange0_1(i);
            Gizmos.DrawLine(startPoint,inPoint);
            startPoint = inPoint;
        }

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
