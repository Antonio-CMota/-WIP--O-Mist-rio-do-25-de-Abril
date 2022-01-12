using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasIntroduzirNomes : MonoBehaviour
{

    public PickDrop pickDrop;
    public GameObject player1;
    public GameObject Canvas;
    public GameObject CanvasPonto;
    public GameObject InputField;

    public static bool salgueiro;
    public static bool costa;
    public static bool vasco;
    public static bool melo;
    public static bool garcia;
    public static bool salazar;
    public static bool marcelo;
    public static bool ramalho;
    public static bool otelo;
  
    



    public Button BotaoVerificação;



    void Start()
    {
        Button btn = BotaoVerificação.GetComponent<Button>();
        btn.onClick.AddListener(VerificarNomeSalgueiro);
       
    }


    void Update()
    {
        if (pickDrop.isSuporteSalgueiro)

        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {

            player1.GetComponent<MouseLook>().enabled = true;
            player1.GetComponent<FPS_Control>().enabled = true;
            Canvas.SetActive(false);
            CanvasPonto.SetActive(true);


        }






    }

    public void VerificarNomeSalgueiro()
    {
        if (InputField.GetComponent<Text>().text == "Salgueiro Maia")
        {
            salgueiro = true;
            
            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
           
        }
    }

    public void VerificarNomeOtelo()
    {
        if (InputField.GetComponent<Text>().text == "Otelo Carvalho")
        {

            otelo = true;
            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
         
        }
    }

    public void VerificarNomeVasco()
    {
        if (InputField.GetComponent<Text>().text == "Vasco Gonçalves")
        {

            vasco = true;
            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
          
        }
    }

    public void VerificarNomeSalazar()
    {
        if (InputField.GetComponent<Text>().text == "Antonio Salazar")
        {
            salazar = true;

            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
            
        }
    }

    public void VerificarNomeCosta()
    {
        if (InputField.GetComponent<Text>().text == "Costa Gomes")
        {

            costa = true;
            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
        }
    }

    public void VerificarNomeCaetano()
    {
        if (InputField.GetComponent<Text>().text == "Marcelo Caetano")
        {

            marcelo = true;
            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
        }
    }

    public void VerificarNomeRamalho()
    {
        if (InputField.GetComponent<Text>().text == "Ramalho Eanes")
        {

            ramalho = true;
            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
        }
    }

    public void VerificarNomeGarcia()
    {
        if (InputField.GetComponent<Text>().text == "Garcia dos Santos")
        {

            garcia = true;
            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
        }
    }

    public void VerificarNomeMelo()
    {
        if (InputField.GetComponent<Text>().text == "Melo Antunes")
        {
            melo = true;

            Debug.Log("Certo");
        }

        else
        {
            Debug.Log("Errado");
        }
    }

}

