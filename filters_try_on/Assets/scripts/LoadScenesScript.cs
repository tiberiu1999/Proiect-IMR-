using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenesScript : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(2);
    }
}
