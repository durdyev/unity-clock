using UnityEngine;
using System.Collections;
using System;

public class ClockAnimator : MonoBehaviour {

	public GameObject minutes, hours, seconds;
	float secondsDegrees = 360f / 60f, minutesDegrees = 360f / 60f, hoursDegrees = 360f / 12f;

	void Update () {
		DateTime time = DateTime.Now;
		Debug.Log (time.Minute * minutesDegrees);
		seconds.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, time.Second * -secondsDegrees));
		minutes.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, time.Minute * -minutesDegrees));
		hours.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, time.Hour * -hoursDegrees));
	}
}
