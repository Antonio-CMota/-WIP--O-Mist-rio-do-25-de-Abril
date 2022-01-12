using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animacaomenu : MonoBehaviour
{

    public Animator animacao_;
    public bool _isjogar = false;
    public bool _isopcoes = false;
    public bool _iscreditos = false;
    public bool isanim = false;

    public Canvas Jogo;
    public Canvas Creditos;
    public Canvas Opcoes;
    public Canvas SairCanvas;



    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.transform != null)
                {

                    SairCanvas.gameObject.SetActive(false);

                    //MostrarNome(hit.transform.gameObject);
                    if (hit.transform.name == "Jogar")
                    {
                        if (isanim == false)
                        {
                            animacao_.SetBool("isJogar", true);
                            _isjogar = true;
                            isanim = true;
                            Debug.Log(_isjogar);
                            Jogo.gameObject.SetActive(true);
                        }
                    }
                    else if (hit.transform.name == "Créditos")
                    {
                        if (isanim == false)
                        {
                            animacao_.SetBool("isCreditos", true);
                            _iscreditos = true;
                            isanim = true;
                            Debug.Log(_iscreditos);
                            Creditos.gameObject.SetActive(true);
                        }
                    }
                    else if (hit.transform.name == "Opções")
                    {
                        if (isanim == false)
                        {
                            animacao_.SetBool("isOpcoes", true);
                            _isopcoes = true;
                            isanim = true;
                            Debug.Log(_isopcoes);
                            Opcoes.gameObject.SetActive(true);
                        }
                    }
                }
            }
        }
        if (Input.GetKeyDown("escape"))
        {
            VoltarAnimacao();
        }
    }

    public void VoltarAnimacao()
    {
        if (_isjogar == true && isanim == true)
        {
            animacao_.SetBool("isJogar", false);
            Jogo.gameObject.SetActive(false);
            _isjogar = false;
            isanim = false;
            Debug.Log(_isjogar);
        }
        if (_isopcoes == true && isanim == true)
        {
            animacao_.SetBool("isOpcoes", false);
            Opcoes.gameObject.SetActive(false);
            _isopcoes = false;
            isanim = false;
            Debug.Log(_isopcoes);
        }
        if (_iscreditos == true && isanim == true)
        {
            animacao_.SetBool("isCreditos", false);
            Creditos.gameObject.SetActive(false);
            _iscreditos = false;
            isanim = false;
            Debug.Log(_iscreditos);
        }

        SairCanvas.gameObject.SetActive(true);
    }


    public void irJogo()
    {
        SceneManager.LoadScene(1);
    }

    public void Sair()
    {
        Application.Quit();
    }
}
