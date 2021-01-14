using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filtersTryOn : MonoBehaviour
{
    public GameObject ear1;
    public GameObject ear12;
    public GameObject ear21;
    public GameObject ear22;
    public GameObject ear31;
    public GameObject ear32;
    public GameObject sun1;
    public GameObject sun2;
    public GameObject sun3;
    public GameObject sun4;
    public GameObject crown;
    public GameObject hat;
    public GameObject cap;
    public GameObject grad;
    // Start is called before the first frame update
    void Start()
    {
        ear1 = GameObject.Find("/FaceAttachement/all/earings_v1_L");
        ear12 = GameObject.Find("/FaceAttachement/all/earings_v1_R");
        ear21 = GameObject.Find("/FaceAttachement/all/Earings2");
        ear22 = GameObject.Find("/FaceAttachement/all/Earings2R");
        ear31 = GameObject.Find("/FaceAttachement/all/EARINGS3R");
        ear32 = GameObject.Find("/FaceAttachement/all/EARINGS3");
        sun1 = GameObject.Find("/FaceAttachement/all/Sunglasses1");
        sun2 = GameObject.Find("/FaceAttachement/all/Heart_Glasses");
        sun3 = GameObject.Find("/FaceAttachement/all/Glasses");
        hat = GameObject.Find("/FaceAttachement/all/ClassicHat");
        cap = GameObject.Find("/FaceAttachement/all/BaseballCap");

        ear1.SetActive(false);
        ear12.SetActive(false);
        HideAll();
       
    }
    public void HideAll()
    {
        ear1.SetActive(false);
        ear12.SetActive(false);
        ear21.SetActive(false);
        ear22.SetActive(false);
        ear31.SetActive(false);
        ear32.SetActive(false);
        cap.SetActive(false);
        hat.SetActive(false);
        grad.SetActive(false);
        sun1.SetActive(false);
        sun2.SetActive(false);
        sun3.SetActive(false);
        crown.SetActive(false);

    }
    public void Ear1()
    {
        HideAll();
        ear12.SetActive(true);
        ear1.SetActive(true);
        Debug.Log("e1");
    }
    public void Ear2()
    {
        HideAll();
        ear21.SetActive(true);
        ear22.SetActive(true);
        Debug.Log("e2");
    }
    public void Ear3()
    {
        HideAll();
        ear31.SetActive(true);
        ear32.SetActive(true);
        Debug.Log("e2");
    }
    public void Sun1()
    {
        HideAll();
        sun1.SetActive(true);
    }
    public void Sun2()
    {
        HideAll();
        sun2.SetActive(true);
    }
    public void Sun3()
    {
        HideAll();
        sun3.SetActive(true);
    }
    public void Cap()
    {
        HideAll();
        cap.SetActive(true);
    }
    public void Hat()
    {
        HideAll();
        hat.SetActive(true);
    }
    public void Grad()
    {
        HideAll();
        grad.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
