using UnityEngine;

public class God : MonoBehaviour {
	public UnityEngine.UI.Text Input;  //InputField
	public UnityEngine.UI.Text Output; //Text

	public void Generate () { //Converts input to acronym
		string Letters = null;
		for (int i = 0; i < Input.text.Length; i++) {
			if (Input.text[i] != ' ') { //Blank check
				if (Input.text[i-1] == ' ' || i == 0) { //Blank check before char
					Letters += Input.text[i];
				}
			}
		}
		Output.text = Letters.ToUpper();
	}
}
