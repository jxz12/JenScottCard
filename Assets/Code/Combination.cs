using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combination : MonoBehaviour {
	public ComButton up1, down1, up2, down2, up3, down3, up4, down4, submit;
	public int ans1, ans2, ans3, ans4;

	public int num1, num2, num3, num4;
	public TextMesh txt1, txt2, txt3, txt4;

	public GameObject right, wrong;

	public Animator cursor;
	// Use this for initialization
	void Start () {
		up1.OnPress = () => num1++;
		down1.OnPress = () => num1--;
		up2.OnPress = () => num2++;
		down2.OnPress = () => num2--;
		up3.OnPress = () => num3++;
		down3.OnPress = () => num3--;
		up4.OnPress = () => num4++;
		down4.OnPress = () => num4--;

		submit.OnPress = Submit;
	}
	
	// Update is called once per frame
	void Update () {
		if (num1 < 0) num1 += 10;
		if (num1 >= 10) num1 -= 10;
		if (num2 < 0) num2 += 10;
		if (num2 >= 10) num2 -= 10;
		if (num3 < 0) num3 += 10;
		if (num3 >= 10) num3 -= 10;
		if (num4 < 0) num4 += 10;
		if (num4 >= 10) num4 -= 10;

		txt1.text = num1.ToString ();
		txt2.text = num2.ToString ();
		txt3.text = num3.ToString ();
		txt4.text = num4.ToString ();
	}

	void Submit() {
		if (num1 == ans1 && num2 == ans2 && num3 == ans3 && num4 == ans4) {
			GameManager.puzzledone = true;
			num1 = num2 = num3 = num4 = 0;
			Instantiate (right);
			cursor.SetTrigger ("happy");
		} else {
			Instantiate (wrong);
			cursor.SetTrigger ("sad");
		}
	}
		
}
