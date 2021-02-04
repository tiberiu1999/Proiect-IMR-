using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryOnFilters : MonoBehaviour
{
    public List<GameObject> filtre = new List<GameObject>();
    public GameObject cap;
    public GameObject sun1;
    public GameObject crown;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("/FaceAttachement/Canvas/Text").GetComponent<Text>();
        Debug.Log("Merge");
        text.text = "Merge";
        cap = GameObject.Find("/FaceAttachement/all/BaseballCap");
        filtre[0] = cap;
        Debug.Log("Merge");
        sun1 = GameObject.Find("/FaceAttachement/all/Sunglasses1");
        crown = GameObject.Find("/FaceAttachement/all/Diamond_Crown");
        filtre[1] = sun1;
        filtre[2] = crown;
        filtre[3] = GameObject.Find("/FaceAttachement/all/ClassicHat");
        filtre[4] = GameObject.Find("/FaceAttachement/all/Blue_glasses");
        filtre[5] = GameObject.Find("/FaceAttachement/all/Glasses");
        filtre[6] = GameObject.Find("/FaceAttachement/all/GraduateHat");
        filtre[7] = GameObject.Find("/FaceAttachement/all/Heart_Glasses");
        filtre[8] = GameObject.Find("/FaceAttachement/all/Sunglasses2");
        filtre[9] = GameObject.Find("/FaceAttachement/all/Earrings2");
        SetFalse();
        Debug.Log("Merge");
    }
    public void SetFalse()
    {
        for (int i = 0; i < 10; i++)
            filtre[index: i].SetActive(false);
    }
    public void Set_Cap()
    {
        SetFalse();
        filtre[0].SetActive(true);
    }
    public void Set_Crown()
    {
        text.text = "crown";
       // SetFalse();
        crown.SetActive(true);
        filtre[2].SetActive(true);
    }
    public void Set_Sunglasses1()
    {
        SetFalse();
        sun1.SetActive(true);
        filtre[1].SetActive(true);
    }
    public void Set_Sunglasses2()
    {
        SetFalse();
        filtre[8].SetActive(true);
    }
    public void Set_Earrings2()
    {
        SetFalse();
        filtre[9].SetActive(true);
    }
    public void Set_Hat()
    {
        SetFalse();
        filtre[3].SetActive(true);
    }
    public void Set_BlueG()
    {
        SetFalse();
        filtre[4].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
