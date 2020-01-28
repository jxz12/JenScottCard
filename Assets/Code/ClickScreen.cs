using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickScreen : MonoBehaviour {
	void OnMouseDown() {
		GameManager.clicked = true;
	}

}
