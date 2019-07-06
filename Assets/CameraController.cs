
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	public Transform planet;
	public float smoothSpeed = 0.125f;
	public float offsetMultiplier = 5000.0f;

	void Start() {
		//offset = transform.position - target.position;
	}

	void FixedUpdate ()
	{
		// Vector3 desiredPosition = target.position + offset;
		// Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		// transform.position = smoothedPosition;

		// transform.LookAt(target);

		Vector3 normal = Vector3.Normalize(target.position - planet.position);
		transform.position = target.position + (normal * offsetMultiplier);
		Debug.Log("offsetM: "+offsetMultiplier);
		Debug.Log(normal.magnitude + " | " + (normal * offsetMultiplier).magnitude);
		transform.LookAt(target);


	}

}