using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioSettingsUI : MonoBehaviour
{

	[SerializeField]
	protected Slider masterSlider;
    protected Slider sfxSlider;
    protected Slider musicSlider;


	private void Start()
	{
		GetMasterVolume();
        GetSfxVolume();
	}

	/// <summary>
	/// Gets thesaved playerprefs value of the Master volume and sets the slider value to be equal to that
	/// Also sets the actual master volume
	/// </summary>
	public void GetMasterVolume()
	{
		if (AudioManager.instance != null)
		{
			//this can break if keys arent created
			if (PlayerPrefs.HasKey(AudioManager.instance.masterVolume))
			{
				float savedValue = PlayerPrefs.GetFloat(AudioManager.instance.masterVolume);
				print(savedValue);
				masterSlider.value = savedValue;
				AudioManager.instance.SetMasterVolume(masterSlider.value);
			}
			else
			{
				Debug.LogError("No Volume Key");
			}
		}
	}

    public void GetSfxVolume()
    {
        if (AudioManager.instance != null)
        {
            if (PlayerPrefs.HasKey(AudioManager.instance.sfxVolume))
            {
                float savedValue = PlayerPrefs.GetFloat(AudioManager.instance.sfxVolume);
                print(savedValue);
                sfxSlider.value = savedValue;
                AudioManager.instance.SetMasterVolume(sfxSlider.value);
            }
            else
            {
                Debug.LogError("No Volume Key");
            }
        }
    }

    // do the other methods for the other settings!
}
