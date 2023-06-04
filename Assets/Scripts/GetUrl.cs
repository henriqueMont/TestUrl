using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetUrl : MonoBehaviour
{ 
    private static string urlAbsolute;
    public delegate void UrlLoadedHandler(string url);
    public event UrlLoadedHandler UrlLoaded;
    

    void Start()
    {
        GetAbsoluteUrl();  
    }

    void GetAbsoluteUrl()
    {
        urlAbsolute = Application.absoluteURL;
        if(UrlLoaded != null)
        {
            UrlLoaded(urlAbsolute);
        }
    }

}
