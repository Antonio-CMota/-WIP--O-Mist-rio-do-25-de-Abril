using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlineCheck : MonoBehaviour
{

	public Camera cam;
	public GameObject unitSelected;

	// Update is called once per frame
	void FixedUpdate()
	{
		RaycastHit hit;
		var ray = cam.ViewportPointToRay(Vector3.one * 0.5f);

		if (Physics.Raycast(ray, out hit))
		{
			var pickable = hit.transform.GetComponent<Pickable>();

			if (pickable)
			{
				Debug.DrawLine(transform.position, hit.point, Color.cyan);
				unitSelected = hit.transform.gameObject;
				Debug.Log(unitSelected);
				hit.transform.gameObject.GetComponent<Outline>().enabled = true;

			}
		}
		if(hit.transform.gameObject != unitSelected)
		{
			
				unitSelected.GetComponent<Outline>().enabled = false;
				unitSelected = null;
			
		}
	}
}

