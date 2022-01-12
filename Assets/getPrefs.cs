using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class getPrefs : MonoBehaviour
{
    public AudioMixer audioMixer;
    void Start()
    {
        
        float master = PlayerPrefs.GetFloat("master");

        audioMixer.SetFloat("masterVolume", master);

        float musica = PlayerPrefs.GetFloat("music");

        audioMixer.SetFloat("musicVolume", musica);

        float effects = PlayerPrefs.GetFloat("effects");

        audioMixer.SetFloat("effectsVolume", effects);

        int quality = PlayerPrefs.GetInt("quality");
        QualitySettings.SetQualityLevel(quality);
    }

}
