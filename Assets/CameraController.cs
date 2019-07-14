
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	public Transform planet;
	public float offsetMultiplier = 5000.0f;
	public float offsetFPMultiplier = 20f;
	private bool firstPersonCamera = true;

	void LateUpdate ()
	{

		//Change camera angle
		if (Input.GetKeyDown("c")) {
			firstPersonCamera = !firstPersonCamera;
		}

		//Change offset
		if (Input.GetKey("=")) {
			if (firstPersonCamera) {
				if (offsetFPMultiplier > 5) {
					offsetFPMultiplier -= 1;
				}
			} else {
				if (offsetMultiplier > 10){
					offsetMultiplier -= 5;
				}
			}
		}
		if (Input.GetKey("-")) {
			if (firstPersonCamera) {
				offsetFPMultiplier += 1;
			} else {
				offsetMultiplier += 5;
			}
		}

		if (firstPersonCamera) {
			transform.position = target.position - target.forward * offsetFPMultiplier;
			transform.rotation = target.rotation;
		} else {
			Vector3 normal = Vector3.Normalize(target.position - planet.position);
			transform.position = target.position + (normal * offsetMultiplier);
			transform.LookAt(target);	
		}

	}

}