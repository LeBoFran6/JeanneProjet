using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

	public float vitesse = 0.1f;
	public string dialogue;
	private string Text = "";

	// Use this for initialization
	void Start () {
		StartCoroutine(ShowText());
	}
	
	IEnumerator ShowText(){
		for(int i = 0; i < dialogue.Length; i++){
			Text = dialogue.Substring(0,i);
			this.GetComponent<Text>().text = Text;
			yield return new WaitForSeconds(vitesse);
		}
	}
}
