using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CadeadoCamera : MonoBehaviour
{
    public GameObject player1;
    public GameObject playerCam;
    public GameObject cadeadoCam;

    public PickDrop pickDrop;


    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    // Update is called once per frame
    void Update()
    {
        if (pickDrop.isCadeado)
        {
            player1.GetComponent<MouseLook>().enabled = false;
            player1.GetComponent<FPS_Control>().enabled = false;
            playerCam.GetComponent<Camera>().enabled = false;
            
            cadeadoCam.SetActive(true);
        }
    }
}
