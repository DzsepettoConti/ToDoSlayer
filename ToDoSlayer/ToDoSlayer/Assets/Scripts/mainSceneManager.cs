using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainSceneManager : MonoBehaviour
{
    public void totaskAddScnene()
    {
        string sceneName = "TaskAdd";
        SceneManager.LoadSceneAsync(sceneName);
    }
    
}
