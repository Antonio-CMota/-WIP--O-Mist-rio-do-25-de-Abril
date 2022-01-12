using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlterarCam : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    private Movimento3Pessoa mov3;   
    public GameObject joaquim;

    public GameObject mira;
    

    private bool camon = true;
    

	private void Start()
	{
        cam1 = GameObject.FindGameObjectWithTag("MainCamera");
        mov3 = GetComponent<Movimento3Pessoa>();        
    }


	void Update()
    {
        
        if (Input.GetKeyDown("tab"))
        {
            if (camon == true)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
                camon = false;
                mov3.enabled = false;

                //joaquim.SetActive(false);
 
                mira.SetActive(true);

            }
            else
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
                camon = true;
                mov3.enabled = true;

                joaquim.SetActive(true);

                mira.SetActive(false);
            }
        }
    }
}
