using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GrabObj : MonoBehaviour
{
	[SerializeField]
	private Camera charCam;

	[SerializeField]
	private Transform slot;

	public GameObject slotObj;

	public GameObject hand;

	private Pickable picked;

	public GameObject joaquino;

	//public Image image1;

	//public Sprite sprite;

	public bool segurando = false;

	public GameObject obj;

	public int itemAtual;

	public List<GameObject> itens;

	private void Update()
	{

		

		if (Input.GetKeyDown("y"))
		{
			Debug.Log(itemAtual + "itemAtual");
			Debug.Log(itens.Count + "Count");

		}	
		if (picked)
		{
			/*if (itens.Count == 0)
			{
				Debug.Log("Nao ha itens no inventario");
			}
			if (itens.Count == 1)
			{
				Debug.Log("So tens um Item no Inventario");
			}*/
			if (itens.Count == 2)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{

					mudarItem(0);
					itemAtual = 0;

				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{

					mudarItem(1);
					itemAtual = 1;

				}
			}
			if (itens.Count == 3)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{

					mudarItem(0);
					itemAtual = 0;

				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{

					mudarItem(1);
					itemAtual = 1;

				}
				if (Input.GetKeyDown(KeyCode.Alpha3))
				{

					mudarItem(2);
					itemAtual = 2;

				}
			}
			if (itens.Count == 4)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{

					mudarItem(0);
					itemAtual = 0;

				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{

					mudarItem(1);
					itemAtual = 1;

				}
				if (Input.GetKeyDown(KeyCode.Alpha3))
				{

					mudarItem(2);
					itemAtual = 2;

				}
				if (Input.GetKeyDown(KeyCode.Alpha4))
				{

					mudarItem(3);
					itemAtual = 3;

				}
			}
			if (itens.Count == 5)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{

					mudarItem(0);
					itemAtual = 0;

				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{

					mudarItem(1);
					itemAtual = 1;

				}
				if (Input.GetKeyDown(KeyCode.Alpha3))
				{

					mudarItem(2);
					itemAtual = 2;

				}
				if (Input.GetKeyDown(KeyCode.Alpha4))
				{

					mudarItem(3);
					itemAtual = 3;

				}
				if (Input.GetKeyDown(KeyCode.Alpha5))
				{

					mudarItem(4);
					itemAtual = 4;

				}
			}
			if (itens.Count == 6)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{

					mudarItem(0);
					itemAtual = 0;

				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{

					mudarItem(1);
					itemAtual = 1;

				}
				if (Input.GetKeyDown(KeyCode.Alpha3))
				{

					mudarItem(2);
					itemAtual = 2;

				}
				if (Input.GetKeyDown(KeyCode.Alpha4))
				{

					mudarItem(3);
					itemAtual = 3;

				}
				if (Input.GetKeyDown(KeyCode.Alpha5))
				{

					mudarItem(4);
					itemAtual = 4;

				}
				if (Input.GetKeyDown(KeyCode.Alpha6))
				{

					mudarItem(5);
					itemAtual = 5;

				}
			}
			if (itens.Count == 7)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{

					mudarItem(0);
					itemAtual = 0;

				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{

					mudarItem(1);
					itemAtual = 1;

				}
				if (Input.GetKeyDown(KeyCode.Alpha3))
				{

					mudarItem(2);
					itemAtual = 2;

				}
				if (Input.GetKeyDown(KeyCode.Alpha4))
				{

					mudarItem(3);
					itemAtual = 3;

				}
				if (Input.GetKeyDown(KeyCode.Alpha5))
				{

					mudarItem(4);
					itemAtual = 4;

				}
				if (Input.GetKeyDown(KeyCode.Alpha6))
				{

					mudarItem(5);
					itemAtual = 5;

				}
				if (Input.GetKeyDown(KeyCode.Alpha7))
				{

					mudarItem(6);
					itemAtual = 6;

				}
			}
			if (itens.Count == 8)
			{
				if (Input.GetKeyDown(KeyCode.Alpha1))
				{

					mudarItem(0);
					itemAtual = 0;

				}
				if (Input.GetKeyDown(KeyCode.Alpha2))
				{

					mudarItem(1);
					itemAtual = 1;

				}
				if (Input.GetKeyDown(KeyCode.Alpha3))
				{

					mudarItem(2);
					itemAtual = 2;

				}
				if (Input.GetKeyDown(KeyCode.Alpha4))
				{

					mudarItem(3);
					itemAtual = 3;

				}
				if (Input.GetKeyDown(KeyCode.Alpha5))
				{

					mudarItem(4);
					itemAtual = 4;

				}
				if (Input.GetKeyDown(KeyCode.Alpha6))
				{

					mudarItem(5);
					itemAtual = 5;

				}
				if (Input.GetKeyDown(KeyCode.Alpha7))
				{

					mudarItem(6);
					itemAtual = 6;

				}
				if (Input.GetKeyDown(KeyCode.Alpha8))
				{

					mudarItem(7);
					itemAtual = 7;

				}
			}














		}

		if (Input.GetKeyDown("e"))
		{
			var ray = charCam.ViewportPointToRay(Vector3.one * 0.5f);
			RaycastHit hit;
			Debug.Log(itens.Count);

			if (Physics.Raycast(ray, out hit, 10f))
			{
				if(hit.transform.gameObject.tag == "puzzle")
				{

					SceneManager.LoadScene(1);
					
				}
				var pickable = hit.transform.GetComponent<Pickable>();
				obj = hit.transform.GetComponent<GameObject>();

				if (pickable && hit.transform.parent != slot)
				{
					if (slot.childCount > 0)
					{
						itens[itemAtual].SetActive(false);
						itemAtual++;
					}
					this.transform.SetParent(joaquino.transform);
					PickUp(pickable);
					itens.Add(hit.transform.gameObject);
					segurando = true;
					itens[itemAtual].layer = 2;
					//image1.sprite = sprite;

				}
			}

		}



		if (Input.GetKeyDown("g"))
		{

			GameObject objeto = itens[itemAtual];

			if (objeto.activeInHierarchy == true)
			{
				DropItem();
				segurando = false;


			}

		}
	}

	private void PickUp(Pickable item)
	{
		picked = item;

		item.Rb.isKinematic = true;
		item.Rb.velocity = Vector3.zero;
		item.Rb.angularVelocity = Vector3.zero;

		item.transform.SetParent(slot);
		item.transform.localPosition = Vector3.zero;
		item.transform.localEulerAngles = Vector3.zero;
	}

	private void DropItem()
	{
		Rigidbody rb = itens[itemAtual].GetComponent<Rigidbody>();
		picked = null;
		itens[itemAtual].transform.SetParent(null);
		rb.isKinematic = false;
		rb.AddForce(itens[itemAtual].transform.forward * 20, ForceMode.VelocityChange);
		itens[itemAtual].layer = 0;

		if (itens.Count > 0)
		{
			itens.RemoveAt(itemAtual);

			if (itemAtual > 0)
				itemAtual--;



			if (itens.Count > 0)
			{

				itens[itemAtual].SetActive(true);
			}
		}
	}


	public void mudarItem(int num)
	{

		itemAtual = num;

		for (int i = 0; i < itens.Count; i++)
		{
			if (picked)
			{
				if (i == num)
				{
					itens[i].gameObject.SetActive(true);
				}
				else
				{
					itens[i].gameObject.SetActive(false);
				}
			}

		}


	}


}





