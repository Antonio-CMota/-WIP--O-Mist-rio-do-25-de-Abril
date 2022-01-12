using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageFlip : MonoBehaviour
{

    public Sprite[] pagEsquerda;
    public Sprite[] pagDireita;

    public Image esquerda;
    public Image direita;

    public GameObject player1;
    public GameObject playerCam;
    public GameObject bookCam;

    public PickDrop pickDrop;

    int iPagina = 0;
    

    void Start()
    {
        esquerda.sprite = pagEsquerda[iPagina];
        direita.sprite = pagDireita[iPagina];
    }

    // Update is called once per frame
    void Update()
    {
        
        if(pickDrop.isBook)
		{

            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            playerCam.GetComponent<Camera>().enabled = false;
            bookCam.SetActive(true);

            if(Input.GetKeyDown(KeyCode.Escape))
			{
                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                playerCam.GetComponent<Camera>().enabled = true;
                bookCam.SetActive(false);
                pickDrop.isBook = false;
            }

            if (iPagina < pagEsquerda.Length - 1 && Input.GetKeyDown("d"))
			{

                iPagina++;
                esquerda.sprite = pagEsquerda[iPagina];
                direita.sprite = pagDireita[iPagina];

            }

            if (iPagina > 0 && Input.GetKeyDown("a"))
            {

                iPagina--;
                esquerda.sprite = pagEsquerda[iPagina];
                direita.sprite = pagDireita[iPagina];

            }

        }

    }
}
