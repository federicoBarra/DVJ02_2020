using UnityEngine;

namespace DVJ02.Clase06
{
	public class QuaternionsExample : MonoBehaviour
	{
		[Header("Angle")]
		public Transform AngleBetween01;
		public Transform AngleBetween02;
		public float angle;

		[Header("MovingObjects")]
		public Transform pingPongTransform;
	    public Transform SetLookRotation;

	    [Header("RotateTowards")]
	    public Transform RotateTowards;
	    public Transform RotateTowardsDestiny;
	    public float RotateTowardsSpeed = 2;

	    [Header("Slerp")]
	    public Transform SlerpTarget;
	    public Transform SlerpFrom;
	    public Transform SlerpTo;

	    private void Update()
	    {
		    //Quaternion q02 = Quaternion.identity;
		    //q02.x = 0;
		    //q02.y = 0;
		    //q02.z = 0;
		    //q02.w = 0;

			//ANGLE BETWEEN TWO QUATERNIONS
			angle = Quaternion.Angle(AngleBetween01.rotation, AngleBetween02.rotation);

		    //MOVING OBJECT
			pingPongTransform.transform.position = new Vector3(Mathf.PingPong(Time.time, 2), Mathf.PingPong(Time.time, 5), Mathf.PingPong(Time.time, 10));

			//SET LOOK ROTATION USE
			Quaternion q01 = Quaternion.identity;
	        q01.SetLookRotation(pingPongTransform.position - SetLookRotation.position, Vector3.up); // similar to LookRotation
	        SetLookRotation.rotation = Quaternion.Slerp(SetLookRotation.rotation, q01, Time.deltaTime/5);

			//ROTATE TOWARDS
	        RotateTowards.rotation = Quaternion.RotateTowards(RotateTowards.rotation, RotateTowardsDestiny.rotation, RotateTowardsSpeed * Time.deltaTime);

		    //SLERP ROTATION
			SlerpTarget.rotation = Quaternion.Slerp(SlerpFrom.rotation, SlerpTo.rotation, Mathf.PingPong(Time.time, 2)/2);
	    }
	}
}
