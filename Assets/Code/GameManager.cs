using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static bool clicked, puzzledone;
	public TextMesh instructions;
	public Combination combo;
	public GameObject winScreen;
	public GameObject boom;

	// Use this for initialization
	void Start () {
		clicked = puzzledone = false;
		StartCoroutine (PlayGame ());
	}

	IEnumerator PlayGame() {
		while (!clicked) yield return null;
		clicked = false;

		instructions.characterSize = .15f;
		instructions.text = 
@"This card is like a virtual escape room!
you have 3 puzzles to solve with combination
solutions. Good luck!";

		while (!clicked) yield return null;
		clicked = false;

		instructions.GetComponent<Animator> ().SetTrigger ("sub");
		instructions.characterSize = .12f;
		instructions.text = 
@"The first should be simple. Add together two
numbers that both of you should remember!";

		combo.gameObject.SetActive (true);
		combo.ans1 = 3;
		combo.ans2 = 9;
		combo.ans3 = 8;
		combo.ans4 = 4;

		while (!puzzledone) yield return null;
		puzzledone = false;

		instructions.text = 
@"each letter in the alphabet corresponds to its
position's unit digit. What does jennifer think is gr8?";

		combo.ans1 = 2;
		combo.ans2 = 1;
		combo.ans3 = 0;
		combo.ans4 = 0;

		while (!puzzledone)	yield return null;
		puzzledone = false;

		instructions.text = 
@"last one! Scott clearly loves Jennifer, but
just how much? In a unit of measurement:
:) without the 's'";
		combo.ans1 = 3;
		combo.ans2 = 7;
		combo.ans3 = 5;
		combo.ans4 = 7;

		while (!puzzledone)	yield return null;

		instructions.text =
@"CONGRATS YOU ESCAPED THE CARD/ROOM!
Enjoy being married!
HOPE YOU LIVE HAPPILY EVER AFTER :D";

		Instantiate (boom);
		combo.gameObject.SetActive (false);
		winScreen.SetActive (true);
	}
	
	void Update () {
		
	}
}
