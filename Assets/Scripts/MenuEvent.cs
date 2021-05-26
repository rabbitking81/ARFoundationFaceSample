using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class MenuEvent : MonoBehaviour
{
    static void LoadScene(string sceneName)
    {
        LoaderUtility.Initialize();
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void onClickFaceMesh()
    {
        Debug.Log("onClick Face Mesh");
        LoadScene("FaceMeshScene");
    }
}
