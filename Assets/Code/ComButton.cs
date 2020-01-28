using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ComButton : MonoBehaviour {
	public Action OnPress;
	void OnMouseDown() {
		OnPress ();
	}
}
