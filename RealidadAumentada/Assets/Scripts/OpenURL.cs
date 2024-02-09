using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    [SerializeField] private string UrlObj;
    public void LaURL()
    {
        Application.OpenURL(UrlObj);
    }
}
