using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointHandler : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public static int pointCounter = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        pointText.text = pointCounter.ToString();
    }
}
