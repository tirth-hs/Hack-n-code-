using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class scr : MonoBehaviour, IVirtualButtonEventHandler 
{
    public GameObject iB;
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        Panel.gameObject.SetActive(false);
        iB = GameObject.Find("VirtualButton");
        iB.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);  
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Panel.gameObject.SetActive(true);
        Debug.Log("Button Pressed");
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Panel.gameObject.SetActive(false);
        Debug.Log("Button Released");
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}