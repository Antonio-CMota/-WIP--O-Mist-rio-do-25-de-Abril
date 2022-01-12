using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SettingsMenu : MonoBehaviour
{

	public AudioMixer audioMixer;

	public TMP_Dropdown resDrop;

	Resolution[] resolutions;

	private void Start()
	{

		resolutions = Screen.resolutions;

		resDrop.ClearOptions();

		List<string> options = new List<string>();

		int currentResIndex = 0;

		for (int i = 0; i < resolutions.Length; i++)
		{

			string option = resolutions[i].width + "x" + resolutions[i].height;
			options.Add(option);

			if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
			{

				currentResIndex = i;

			}
		}

		resDrop.AddOptions(options);
		resDrop.value = currentResIndex;
		resDrop.RefreshShownValue();
	}

	

	public void SetResolution (int resIndex)
	{

		Resolution resolution = resolutions[resIndex];
		Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

	}

	public void SetMasterVolume (float masterVolume)
	{

		audioMixer.SetFloat("masterVolume", masterVolume);
		PlayerPrefs.SetFloat("master", masterVolume);

	}

	public void SetMusicVolume(float musicVolume)
	{

		audioMixer.SetFloat("musicVolume", musicVolume);
		PlayerPrefs.SetFloat("music", musicVolume);

	}

	public void SetEffectVolume(float effectsVolume)
	{

		audioMixer.SetFloat("effectsVolume", effectsVolume);
		PlayerPrefs.SetFloat("effects", effectsVolume);

	}

	


	public void SetQuality (int qualityIndex)
	{

		QualitySettings.SetQualityLevel(qualityIndex);
		PlayerPrefs.SetInt("quality", qualityIndex);
	}


	public void SetFullscreen (bool isFullscreen)
	{

		Screen.fullScreen = isFullscreen;
		

	}



}
