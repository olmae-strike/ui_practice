using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Buttonevent : MonoBehaviour
{
   // [HideInInspector]
    public Button btn;

    public InputField input;

    //[HideInInspector]
    public Text text;

    //public User user;
    void Start()
    {
        btn.onClick.AddListener(() => {
            text.text = "zinnotech";
        });
        input.onValueChanged.AddListener((temp) =>  {
            Debug.Log($"message {temp}");
        });
    }

    void Update()
    {
        
    }
}

public class TestClass : MonoBehaviour
{
    public TestClass()
    {
        Buttonevent be = new Buttonevent();
        //be.
    }
}

[Serializable]
public class User
{
    public string Name;
    public string Number;
}

