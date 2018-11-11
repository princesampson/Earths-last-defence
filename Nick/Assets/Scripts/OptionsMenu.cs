using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void SettingMenu()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Single); //Loads the option menu
    }
}
