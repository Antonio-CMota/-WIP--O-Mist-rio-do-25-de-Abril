using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTeste : MonoBehaviour
{
    public PickDrop pickDrop;
    public GameObject player1;
    public GameObject Canvas;
    public GameObject CanvasPonto;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (pickDrop.isCannvasGarcia)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }

        if (pickDrop.isCannvasSalazar)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }
        }

        if (pickDrop.isCannvasSalgueiro)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }

        if (pickDrop.isCannvasCosta)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }

        if (pickDrop.isCannvasMarcCae)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }

        if (pickDrop.isCannvasRamalho)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }

        if (pickDrop.isCannvasVasco)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }

        if (pickDrop.isCannvasOtelo)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }

        if (pickDrop.isCannvasMelo)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            Canvas.SetActive(true);
            CanvasPonto.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                player1.GetComponent<MouseLook>().enabled = true;
                player1.GetComponent<FPS_Control>().enabled = true;
                Canvas.SetActive(false);
                CanvasPonto.SetActive(true);


            }

        }
    }
}
