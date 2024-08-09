using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class addTaskSceneManager : MonoBehaviour
{
    public void backtoMainScreen() 
    {
        string sceneName = "mainScene";
        SceneManager.LoadSceneAsync(sceneName);
    }
}
