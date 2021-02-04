using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSetActive : MonoBehaviour
{
    public GameObject panel;
    public void showPanel()
    {
        panel.gameObject.SetActive(true);
    }
}
