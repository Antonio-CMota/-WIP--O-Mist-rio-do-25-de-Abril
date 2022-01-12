using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbriPorta : MonoBehaviour
{
    public Animator abrirPorta1;
    public Animator abrirPorta2;
    public GameObject chave1;
    public new GameObject collider;
    public GrabObj grabObj;

    public Collider player;

    public AudioSource porta;

    public bool isOpen;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerStay(Collider player)
    {
        if (chave1.transform.parent != null & chave1.activeInHierarchy == true)
        {
            if (Input.GetKeyDown("e"))
            {
                
                abrirPorta1.SetBool("porta1", true);
                abrirPorta2.SetBool("porta2", true);
                porta.Play();
                Destroy(collider);

                isOpen = true;
                



            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(picked);
    }
}

