using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private RectTransform[] pictures; //Com esta variavel vamos conseguir introduzir as imagnes

    [SerializeField]
    public static bool youWin; //Bool para verificar a nossa condiçao de vitoria

    public Canvas Puzzel1;
    public GameObject player1;
    public GameObject quadro1;

    void Start()
    {
        Puzzel1.gameObject.SetActive(false);
        youWin = false; //Como ainda nao completamos o puzzle o jogo esta com a condição de vitora falsa
    }


    void Update() //Aqui no update vamos verificar o estado de rotaçao as imagens. Se o Z de todas tiver a 0 completamos o jogo.
    {
        if (pictures[0].eulerAngles.z == 0 &&
           pictures[1].eulerAngles.z == 0 &&
           pictures[2].eulerAngles.z == 0 &&
           pictures[3].eulerAngles.z == 0 &&
           pictures[4].eulerAngles.z == 0 &&
           pictures[5].eulerAngles.z == 0
          )
        {
            youWin = true;
            PointHandler.pointCounter++;
            PickDrop.isPuzzle = false;
            player1.GetComponent<MouseLook>().enabled = true;
            player1.GetComponent<FPS_Control>().enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Destroy(Puzzel1.gameObject);
            Destroy(gameObject);
            quadro1.gameObject.SetActive(false);

        }
    }
}