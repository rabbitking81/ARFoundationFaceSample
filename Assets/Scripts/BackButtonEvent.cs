using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class BackButtonEvent : MonoBehaviour
{
    public void onClickBackButton()
    {
        LoaderUtility.Initialize();
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}
