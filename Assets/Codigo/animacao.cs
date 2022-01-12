using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacao : MonoBehaviour
{
    public Animator animator;
    public Transform jogador;
    public GameObject movimento3Pessoa;
    public Vector3 direcao1;
    public Transform slot;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        direcao1 = movimento3Pessoa.GetComponent<Movimento3Pessoa>().direcao;


        //Debug.Log(direcao1);

        if (direcao1.x != 0 | direcao1.z != 0 && slot.childCount == 0)
        {
            animator.SetBool("isWalk", true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }


        if (Input.GetKey("1"))
        {
            animator.SetBool("Danca1", true);
        }
        else
        {
            animator.SetBool("Danca1", false);
        }

        if (Input.GetKey("2"))
        {
            animator.SetBool("Danca2", true);
        }
        else
        {
            animator.SetBool("Danca2", false);
        }

        if (Input.GetKey("3"))
        {
            animator.SetBool("Flexoes", true);
        }
        else
        {
            animator.SetBool("Flexoes", false);
        }

        if (direcao1.x != 0 | direcao1.z != 0 && slot.childCount == 0 | slot.childCount >= 1)
        {
            animator.SetBool("isHandWalk", true);
        }
        else
        {
            animator.SetBool("isHandWalk", false);
        }


        if (slot.childCount >= 1)
        {

            animator.SetBool("isHandIdle", true);
        }
        else
        {
            animator.SetBool("isHandIdle", false);
        }
    }
}
