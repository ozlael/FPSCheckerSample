using UnityEngine;
using UnityEngine.UI;

public class DisplayFPS : MonoBehaviour {

	[SerializeField]
	Text text;

	float frames = 0f;
	float timeElap = 0f;

	void Start() {
	}

	void Update() {
		frames++;
		timeElap += Time.unscaledDeltaTime;
		if (timeElap > 1f) {
			timeElap -= 1f;
			UpdateText ();
			frames =0;
		}
	}

	void UpdateText() {
		text.text = string.Format (
			"FPS : {0}, FrameTime : {1:F2} ms",
			frames, Time.unscaledDeltaTime * 1000.0f);
	}
}
