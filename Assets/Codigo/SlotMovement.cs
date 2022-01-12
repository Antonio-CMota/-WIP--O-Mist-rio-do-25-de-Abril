using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMovement : MonoBehaviour
{

    public Transform hand;

    // Update is called once per frame
    void Update()
    {
        transform.position = hand.transform.position;
    }
}
