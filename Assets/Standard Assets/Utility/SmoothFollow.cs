using UnityEngine;

namespace UnityStandardAssets.Utility
{
	public class SmoothFollow : MonoBehaviour
	{

		public float speedMoveCameraY;

		// Use this for initialization
		void Start() { 
			speedMoveCameraY = 0.01f;
			
		}

		// Update is called once per frame
		void LateUpdate()
		{
			
			// Set the height of the camera
			transform.position = new Vector3(this.transform.position.x ,this.transform.position.y+speedMoveCameraY, this.transform.position.z);

		}
	}
}