using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayUrl : MonoBehaviour
{
    private string urlAbsolute;
    public TMP_Text textUrlAbsolute;


    public void OnUrlLoaded(string url)
    {
        urlAbsolute = url;
        ShowUrl();
    }

    void ShowUrl()
    {
       textUrlAbsolute.text = urlAbsolute;
    }
}
