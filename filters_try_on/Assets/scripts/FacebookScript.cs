using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FacebookScript : MonoBehaviour
{
    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/");
    }
}
