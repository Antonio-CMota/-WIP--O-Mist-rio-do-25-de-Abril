using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FPS_Control : MonoBehaviour
{

    public CharacterController controlador;

    public float rapidez = 10;
    public float gravidade = -9.8f;
    public Transform checkChao;
    public float distanciaChao;
    public LayerMask maskChao;

    public PickDrop pickDrop;

    Vector3 velocidade;
    bool noChao;


    void Update()
    {
        noChao = Physics.CheckSphere(checkChao.position, distanciaChao, maskChao);

        //if(!PickDrop.isPuzzle)
        if (noChao && velocidade.y < 0)
        {

            velocidade.y = -2f;

        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        if (!PickDrop.isPuzzle)
            controlador.Move(move * rapidez * Time.deltaTime);

        velocidade.y += gravidade * Time.deltaTime;

        controlador.Move(velocidade * Time.deltaTime);
    }
}
