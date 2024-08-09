using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class newTaskCreate : MonoBehaviour
{
    public Button btnClick;
    public InputField inputName;


    private void Start()
    {
        btnClick.onClick.AddListener(GetInputOnClickhandler);
    }

    public void newTask() 
    {


    
    }

    public void GetInputOnClickhandler()
    {

        Debug.Log("Log input" + inputName.text);
    }
}
