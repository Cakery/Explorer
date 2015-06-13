using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderController : MonoBehaviour {
	Slider Slider;
	public InputField Text;
	// Use this for initialization
	void Start () {
		Slider = GetComponent<Slider>();


		if (System.IO.File.Exists ("settings.cfg")) {
			string[] File = System.IO.File.ReadAllLines ("settings.cfg");
			float FOV=0;
			float MouseSens=0;
						foreach (string I in File) {
								string[] Values = I.Split ('=');
				
								if (Values [0] == "FOV") {
										FOV = float.Parse (Values [1]);
								}
								if (Values [0] == "MouseSens") {
										MouseSens = float.Parse (Values [1]);
								}
						}
			if (this.name=="FOV") {
			Slider.value = FOV;	
			} else {
				Slider.value=MouseSens;
			}
		}



	}
	public void TextChangeValue() {
				float Num = float.Parse (Text.text);
				if (Num >= Slider.minValue & Num <= Slider.maxValue) {
						Slider.value = Num;
				}
		}
	// Update is called once per frame
	public void SliderChangeValue() {
		print (Slider.value);
		Text.text = Slider.value.ToString();
	}
}
