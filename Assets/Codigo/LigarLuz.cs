using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigarLuz : MonoBehaviour
{

    public new Light light;
    [SerializeField] private Material luz;

    public GameObject grabobjeto;
    public Transform lampada;
    public GameObject lampadaObj;
    public bool picked = false;
    public bool estaligado = true;


    void start()
    {
        light = GetComponent<Light>();
    }


    
    void Update()
    {

        picked = grabobjeto.GetComponent<GrabObj>().segurando;

        if(lampada.parent != null & lampadaObj.activeInHierarchy == true)
        {
            if (Input.GetKeyDown("f"))
            {
                light.enabled = !light.enabled;

                if (!light.enabled)
                {
                    luz.SetColor("_EmissionColor", Color.grey);
                    estaligado = false;
                }
                else if (light.enabled)
                {
                    luz.SetColor("_EmissionColor", Color.yellow);
                    estaligado = true;
                }
            }
        }
    }
}
