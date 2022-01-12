using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AdjustFrequency : MonoBehaviour
{

	public PickDrop pickDrop;

	public GameObject dial1;
	public GameObject dial2;
	public GameObject needle;
	public GameObject limiteEsq;
	public GameObject limiteDir;
	public GameObject playerCam;
	public GameObject radioCam;
	public GameObject player1;

	public bool rightFrequency;
	public bool entrevistaBool;
	public bool senhasBool;
	public bool adeusBool;

	public AudioSource staticRadio;
	public AudioSource musicaRadio;
	public AudioSource entrevista;
	public AudioSource depoisAdeus;
	public AudioSource senhas;


	public AudioMixer radioMixer;

	public float soundLevel;

	void Start()
	{
		soundLevel = -80f;
	}

	// Update is called once per frame
	void Update()
	{
		if (pickDrop.isRadio)

		{
			player1.GetComponent<MouseLook>().enabled = false;
			player1.GetComponent<FPS_Control>().enabled = false;
			playerCam.GetComponent<Camera>().enabled = false;
			radioCam.SetActive(true);

			if (Input.GetKeyDown(KeyCode.Escape) && !rightFrequency)
			{

				player1.GetComponent<MouseLook>().enabled = true;
				player1.GetComponent<FPS_Control>().enabled = true;
				playerCam.GetComponent<Camera>().enabled = true;
				radioCam.SetActive(false);
				pickDrop.isRadio = false;

			}




			if (Input.GetKey("d") && needle.transform.position.x > limiteDir.transform.position.x && staticRadio.volume > 0.15f)
			{

				dial1.transform.Rotate(0f, 0f, 0.5f);

				needle.transform.Translate(-0.0005f, 0f, 0f);

				staticRadio.volume = staticRadio.volume - 0.0009f;
				musicaRadio.volume = musicaRadio.volume + 0.0005f;

			}

			if (Input.GetKey("a") && needle.transform.position.x < limiteEsq.transform.position.x && staticRadio.volume > 0.15f)
			{

				dial1.transform.Rotate(0f, 0f, -0.5f);

				needle.transform.Translate(0.0005f, 0f, 0f);

				staticRadio.volume = staticRadio.volume + 0.0009f;
				musicaRadio.volume = musicaRadio.volume - 0.0005f;

			}

			if (staticRadio.volume <= 0.15f)
			{
				rightFrequency = true;
				StartCoroutine("Radio");				
			}

			if (Input.GetKey("j"))
			{

				dial2.transform.Rotate(0f, 0f, -0.5f);

				soundLevel = soundLevel - 0.5f;
				SetVolume();

			}

			if (Input.GetKey("k"))
			{

				dial2.transform.Rotate(0f, 0f, 0.5f);

				soundLevel = soundLevel + 0.5f;
				SetVolume();

			}
		}
	}

	public void SetVolume()
	{
		radioMixer.SetFloat("radioVolume", soundLevel);
	}

	IEnumerator Radio()
	{
		yield return new WaitForSeconds(7f);
		if (musicaRadio.isPlaying)
			musicaRadio.Stop();

		if (!entrevista.isPlaying && !entrevistaBool)
		{
			entrevista.Play();
			entrevistaBool = true;
		}

		if (!depoisAdeus.isPlaying && !adeusBool)
		{
			depoisAdeus.PlayDelayed(entrevista.clip.length + 2f);
			adeusBool = true;
		}

		if (!senhas.isPlaying && !senhasBool)
		{
			senhas.PlayDelayed(depoisAdeus.clip.length + 2f);
			senhasBool = true;
		}

		
		rightFrequency = false;
	}
}
