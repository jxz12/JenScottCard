using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		Vector2 screenPos = Input.mousePosition;
		Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
		GetComponent<TargetJoint2D>().target = worldPos;

		// transform.right = worldPos - (Vector2)transform.position;
	}
}
