using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

	public static float bottomY = -20f;

	void Update () {
		if (transform.position.y < bottomY) {
			Destroy(this.gameObject);
		
			Apple_Picker apScript = Camera.main.GetComponent<Apple_Picker>();
			apScript.AppleDestroyed();
		}
}
}
