using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    public GameObject StartUI;
    public Text IPText, PortText;
    public static bool AllowStart = false;
    public static string IP = "";
    public static ushort PORT = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ConnectToServer()
    {
        Debug.Log("Connect");
        ushort.TryParse(PortText.text, out PORT);
        IP = IPText.text;
        AllowStart = true;

        StartUI.SetActive(false);
    }
}
