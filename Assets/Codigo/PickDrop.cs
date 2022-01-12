using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PickDrop : MonoBehaviour
{

	[SerializeField]
	private Camera charCam;

	public Transform slot;

	public GameObject player;

	public GameObject player1;

	public GameObject playerCam;

	public GameObject bookCam;

	public GameObject radioCam;

	public GameObject cadeadoCam;

	public GameObject chave;

	public Canvas Puzzle1;

	public GameObject canvasGarcia;
	public GameObject canvasSalazar;
	public GameObject canvasSalgueiro;
	public GameObject canvasCosta;
	public GameObject canvasMarcCae;
	public GameObject canvasRamalho;
	public GameObject canvasVasco;
	public GameObject canvasOtelo;
	public GameObject canvasMelo;

	public GameObject suporteSalgueiro;
	public GameObject suporteSalazar;
	public GameObject suporteVasco;
	public GameObject suporteOtelo;
	public GameObject suporteRamalho;
	public GameObject suporteGarcia;
	public GameObject suporteCosta;
	public GameObject suporteMelo;
	public GameObject suporteMarcelo;

	public Letreiro letreiro;

	public bool isBook;


	public bool isRadio;

	public bool isCadeado;

	public bool isCannvasGarcia;
	public bool isCannvasSalazar;
	public bool isCannvasSalgueiro;
	public bool isCannvasCosta;
	public bool isCannvasMarcCae;
	public bool isCannvasRamalho;
	public bool isCannvasVasco;
	public bool isCannvasOtelo;
	public bool isCannvasMelo;

	public bool isGarcia;
	public bool isSalazar;
	public bool isSalgueiro;
	public bool isCosta;
	public bool isMarcCae;
	public bool isRamalho;
	public bool isVasco;
	public bool isOtelo;
	public bool isMelo;

	public bool isSuporteSalgueiro;

	public AbriPorta abrirPorta;

	private Pickable picked;

	public int itemAtual;

	public int contaLetras;

	public List<GameObject> itens;

	public static bool isPuzzle;
	public bool isCard;

	AudioSource audioSource;

	public AudioClip[] audioClips;

	public AudioSource carroSource;
	public AudioSource carLock;
	public AudioSource pide;
	public Canvas SairJogo;


	public GameObject manualRadio;
	public static bool isManual;
	// Start is called before the first frame update
	void Start()
	{
		audioSource = GetComponent<AudioSource>();

		itemAtual = -1;

		player.SetActive(true);
	}

	// Update is called once per frame
	void Update()
	{
		if(PointHandler.pointCounter == 12)
		{
			SceneManager.LoadScene(2);
		}

		if (contaLetras == 9)
		{
			contaLetras = 0;
			chave.SetActive(true);

			PointHandler.pointCounter++;

			audioSource.clip = audioClips[0];


			audioSource.Play();

		}


		//Debugging Key
		if (Input.GetKeyDown("y"))
		{
			Debug.Log(itemAtual + " Item Atual");
			Debug.Log(itens.Count + " Itens");
			Debug.Log(contaLetras);
			Debug.Log(abrirPorta.isOpen);
		}

		//Inputs para troca de itens, chamam o metodo 
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
			if (itens.Count == 9)
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
				if (Input.GetKeyDown(KeyCode.Alpha9))
				{

					mudarItem(8);
					itemAtual = 8;

				}

			}

		}

		if (isManual && Input.GetKeyDown(KeyCode.Escape))
		{
			manualRadio.SetActive(false);
			isManual = false;
		}

		if (Input.GetKeyDown("i"))
		{
			Debug.Log(isBook);
		}

		if (Input.GetKeyDown("e"))
		{


			var ray = charCam.ViewportPointToRay(Vector3.one * 0.5f);
			RaycastHit hit;


			if (Physics.Raycast(ray, out hit, 3f))
			{

				if (hit.transform.gameObject.tag == "Figuras" && CanvasIntroduzirNomes.garcia == true)
				{

					audioSource.clip = audioClips[8];

					if(!isGarcia)
					{
						PointHandler.pointCounter++;
						isGarcia = true;
					}

					audioSource.Play();

					canvasGarcia.SetActive(true);

					isCannvasGarcia = true;

				}

				if (hit.transform.gameObject.tag == "Figuras1" && CanvasIntroduzirNomes.salazar == true)
				{
					audioSource.clip = audioClips[1];

					if (!isSalazar)
					{
						PointHandler.pointCounter++;
						isSalazar = true;
					}

					audioSource.Play();
					canvasSalazar.SetActive(true);
					isCannvasSalazar = true;
				}

				if (hit.transform.gameObject.tag == "Figuras2" && CanvasIntroduzirNomes.salgueiro == true)
				{
					audioSource.clip = audioClips[9];

					if (!isSalgueiro)
					{
						PointHandler.pointCounter++;
						isSalgueiro = true;
					}

					audioSource.Play();
					canvasSalgueiro.SetActive(true);
					isCannvasSalgueiro = true;
				}

				if (hit.transform.gameObject.tag == "Figuras3" && CanvasIntroduzirNomes.costa == true)
				{
					audioSource.clip = audioClips[2];

					if (!isCosta)
					{
						PointHandler.pointCounter++;
						isCosta = true;
					}

					audioSource.Play();
					canvasCosta.SetActive(true);
					isCannvasCosta = true;
				}

				if (hit.transform.gameObject.tag == "Figuras4" && CanvasIntroduzirNomes.marcelo == true)
				{
					audioSource.clip = audioClips[3];

					if (!isMarcCae)
					{
						PointHandler.pointCounter++;
						isMarcCae = true;
					}

					audioSource.Play();
					canvasMarcCae.SetActive(true);
					isCannvasMarcCae = true;
				}

				if (hit.transform.gameObject.tag == "Figuras5" && CanvasIntroduzirNomes.ramalho == true)
				{
					audioSource.clip = audioClips[4];

					if (!isRamalho)
					{
						PointHandler.pointCounter++;
						isRamalho = true;
					}

					audioSource.Play();
					canvasRamalho.SetActive(true);
					isCannvasRamalho = true;
				}

				if (hit.transform.gameObject.tag == "Figuras6" && CanvasIntroduzirNomes.vasco == true)
				{
					audioSource.clip = audioClips[5];

					if (!isVasco)
					{
						PointHandler.pointCounter++;
						isVasco = true;
					}

					audioSource.Play();
					canvasVasco.SetActive(true);
					isCannvasVasco = true;
				}

				if (hit.transform.gameObject.tag == "Figuras7" && CanvasIntroduzirNomes.otelo == true)
				{
					audioSource.clip = audioClips[6];

					if (!isOtelo)
					{
						PointHandler.pointCounter++;
						isOtelo = true;
					}

					audioSource.Play();
					canvasOtelo.SetActive(true);
					isCannvasOtelo = true;
				}

				if (hit.transform.gameObject.tag == "Figuras8" && CanvasIntroduzirNomes.melo == true)
				{
					audioSource.clip = audioClips[7];

					if (!isMelo)
					{
						PointHandler.pointCounter++;
						isMelo = true;
					}

					audioSource.Play();
					canvasMelo.SetActive(true);
					isCannvasMelo = true;
				}

				if (hit.transform.gameObject.tag == "SuporteSalgueiro")
				{

					suporteSalgueiro.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteRamalho")
				{

					suporteRamalho.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteOtelo")
				{

					suporteOtelo.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteMelo")
				{

					suporteMelo.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteVasco")
				{

					suporteVasco.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteSalazar")
				{

					suporteSalazar.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteCosta")
				{

					suporteCosta.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteCaetano")
				{

					suporteMarcelo.SetActive(true);
					isSuporteSalgueiro = true;
				}
				if (hit.transform.gameObject.tag == "SuporteGarcia")
				{

					suporteGarcia.SetActive(true);
					isSuporteSalgueiro = true;
				}

			}

			

			if (Physics.Raycast(ray, out hit, 10f))
			{

				if(hit.transform.gameObject.tag == "card" && isCard == false)
				{
					PointHandler.pointCounter++;
					isCard = true;
					pide.Play();
				}

				

				if (hit.transform.gameObject.tag == "puzzle" && GameControl.youWin == false)
				{
					isPuzzle = true;
					player1.GetComponent<MouseLook>().enabled = false;
					//player1.GetComponent<FPS_Control>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
					Puzzle1.gameObject.SetActive(true);
				}

				if (hit.transform.gameObject.tag == "manual")
				{
					manualRadio.SetActive(true);
					isManual = true;
				}
				

				if (hit.transform.gameObject.tag == "book1")
				{

					bookCam = hit.transform.GetChild(0).gameObject;

					isBook = true;

				}

				if (hit.transform.gameObject.tag == "radio")
				{
					Debug.Log("sim");

					isRadio = true;

				}

				if (hit.transform.gameObject.tag == "carro")
				{
					carLock.Play();
					carroSource.Stop();
					SairJogo.gameObject.SetActive(true);
					player1.GetComponent<MouseLook>().enabled = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}

				if (hit.transform.gameObject.tag == "letreiro")
				{

					string tag = itens[itemAtual].tag;

					Debug.Log("letreiro");

					for (int i = 0; i < letreiro.letras.Length; i++)
					{

						//Debug.Log(letreiro.letras[i].tag);
						Debug.Log(itens[itemAtual].tag);

						if (letreiro.letras[i].tag == tag)
						{

							letreiro.letras[i].SetActive(true);
							Destroy(itens[itemAtual]);
							itens.RemoveAt(itemAtual);
							contaLetras++;

							if (itemAtual == 0 && itens.Count >= 1)
							{

								itens[itemAtual].SetActive(true);
							}
							else
							{
								itemAtual--;
								itens[itemAtual].SetActive(true);
							}






						}


					}

				}





				Pickable pickable = hit.transform.GetComponent<Pickable>();

				if (pickable && hit.transform.parent != slot)
				{

					if (slot.childCount > 0)
						itens[itemAtual].SetActive(false);

					this.transform.SetParent(player.transform);
					PickUp(pickable);


				}

			}

		}

		if (Input.GetKeyDown("g"))
		{

			GameObject objeto = itens[itemAtual];

			if (objeto.activeInHierarchy == true && objeto.transform.parent == slot)
			{
				DropItem();
			}

		}





		if (chave != null)
		{
			if (abrirPorta.isOpen == true && chave.transform.parent != null)
			{


				Destroy(itens[itemAtual]);
				itens.RemoveAt(itemAtual);


				if (itemAtual == 0 && itens.Count >= 1)
				{

					itens[itemAtual].SetActive(true);
				}
				else
				{
					itemAtual--;
					itens[itemAtual].SetActive(true);
				}

			}
		}

	}




	//Metodo responsavel por apanhar itens, tornando os filhos da slot, de modo a colocar o item na mao, e coloca os valores do rigidbody a zero para impedir movimento. este metodo e chamado quando o jogador carrega no e, e o raycast deteta um item pickable
	private void PickUp(Pickable item)
	{

		picked = item;

		item.transform.gameObject.layer = 2;
		itens.Add(item.transform.gameObject);
		itemAtual++;

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
		rb.isKinematic = false;
		rb.AddForce(itens[itemAtual].transform.forward * 500, ForceMode.VelocityChange);

		if (itemAtual >= 0)
		{
			itens[itemAtual].layer = 0;
			itens[itemAtual].transform.SetParent(null);
			itens.RemoveAt(itemAtual);

			if (itemAtual == 0 && slot.childCount >= 1)
			{

				itens[itemAtual].SetActive(true);
				//itemAtual--;

			}
			else if (itemAtual == 0 && slot.childCount == 0)
			{

				itemAtual--;

			}
			else if (itemAtual > 0)
			{

				itemAtual--;
				itens[itemAtual].SetActive(true);
			}
		}
	}

	void mudarItem(int num)
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

	public void Sair()
	{
		SceneManager.LoadScene(0);
	}
	public void Voltar()
	{
		SairJogo.gameObject.SetActive(false);
		player1.GetComponent<MouseLook>().enabled = true;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
	}



}