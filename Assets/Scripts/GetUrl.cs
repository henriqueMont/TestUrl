using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetUrl : MonoBehaviour
{ 
    private string urlAbsolute;
    public delegate void UrlLoadedHandler(string url);
    public event UrlLoadedHandler UrlLoaded;
    

    void Start()
    {
        GetAbsoluteUrl();  
    }

    void GetAbsoluteUrl()
    {
        urlAbsolute = Application.absoluteURL;
        UrlLoaded?.Invoke(urlAbsolute);
    }

}
