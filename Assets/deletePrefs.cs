using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deletePrefs : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        PlayerPrefs.DeleteAll();
    }
}
