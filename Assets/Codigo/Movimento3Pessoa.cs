using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento3Pessoa : MonoBehaviour
{

    public CharacterController controlador;
    public Transform Cam;
    public Transform groundCheck;
    public LayerMask groundMask;

    public float speed = 6f;
    private float gravidade = -9.81f;
    public float groundDist = 0.2f;

    public float rodarSmooth = 0.1f;
    float rodarSmoothvel;
    private Vector3 velocidade;
    private bool isGrounded;
    public Vector3 direcao;

    public bool mouseVisi;

    public new GameObject camera;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    void Update()
    {

        if (Input.GetKeyDown("t"))
        {
            mouseVisi = !mouseVisi;
        }

        if (mouseVisi == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            camera.SetActive(false);
            
        }
        if (mouseVisi == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            camera.SetActive(true);
        }


            isGrounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);

            if (isGrounded && velocidade.y < 0)
            {
                velocidade.y = -2f;
            }

            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");

            direcao = new Vector3(horizontal, 0f, vertical).normalized;

            if (direcao.magnitude >= 0.1f)
            {
                float anguloalvo = Mathf.Atan2(direcao.x, direcao.z) * Mathf.Rad2Deg + Cam.eulerAngles.y;
                float angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, anguloalvo, ref rodarSmoothvel, rodarSmooth);
                transform.rotation = Quaternion.Euler(0f, angulo, 0f);

                Vector3 andardirec = Quaternion.Euler(0f, anguloalvo, 0f) * Vector3.forward;

                controlador.Move(andardirec.normalized * speed * Time.deltaTime);
            }

            velocidade.y += gravidade * Time.deltaTime;

            controlador.Move(velocidade * Time.deltaTime);

        

    }
}
