using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    
    public GetUrl getUrl;
    public DisplayUrl displayUrl;

    void Awake()
    {
        getUrl = FindObjectOfType<GetUrl>();
        displayUrl = FindObjectOfType<DisplayUrl>();

        getUrl.UrlLoaded += displayUrl.OnUrlLoaded;
    }
}
