using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderController : MonoBehaviour {
	Slider Slider;
	public InputField Text;
	// Use this for initialization
	void Start () {
		Slider = GetComponent<Slider>();
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
