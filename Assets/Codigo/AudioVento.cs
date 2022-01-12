using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVento : MonoBehaviour
{
	public AudioSource ventoSource1;
	public AudioSource ventoSource2;

	// Start is called before the first frame update
	private void OnTriggerStay(Collider other)
	{
		if(other.tag == "Player")
		{
			ventoSource1.volume = 0f;
			ventoSource2.volume = 0f;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			ventoSource1.volume = 0.195f;
			ventoSource2.volume = 0.195f;
		}
	}


}
