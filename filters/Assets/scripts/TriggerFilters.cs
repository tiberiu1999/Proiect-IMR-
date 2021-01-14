using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.UI;

public class TriggerFilters : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject buterfly1;
    public GameObject buterfly2;
    public GameObject buterfly3;

    public Camera cam;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject spider;
    public GameObject bird;
    public Animator spider_anim;
    public Animator bird_anim;
    AugmentedFace face;

    public List<AugmentedFace> m_TempAugmentedFaces = new List<AugmentedFace>();
    public bool Option1 = false;
    public bool Option2 = false;
    public bool Option3 = false;
    public bool Option4 = false;
    int nr_b = 0;
    void Start()
    {
        cam = Camera.main;
        setFalse();

    }
    void setFalse()
    {
        Option1 = false;
        Option2 = false;
        Option3 = false;
        Option4 = false;
        bird.SetActive(false);
        buterfly2.SetActive(false);
        buterfly3.SetActive(false);
        buterfly1.SetActive(false);
        heart1.SetActive(false);
        heart2.SetActive(false);
        spider.SetActive(false);
        spider_anim.SetBool("Atack", false);
        bird_anim.SetBool("Fly", false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && Option1)//Checks to see if left mouse button was clicked.
        {
            nr_b++;
            buterfly2.SetActive(false);
            buterfly3.SetActive(false);
            buterfly1.SetActive(false);
            if (nr_b % 3 == 0)
                buterfly1.SetActive(true);
            if (nr_b % 3 == 1)
                buterfly2.SetActive(true);
            if (nr_b % 3 == 2)
                buterfly3.SetActive(true);
        }
        Session.GetTrackables<AugmentedFace>(m_TempAugmentedFaces, TrackableQueryFilter.All);

        if (m_TempAugmentedFaces.Count > 0)
        {

            face = m_TempAugmentedFaces[0];

            List<Vector3> meshVertices = new List<Vector3>();
            face.GetVertices(meshVertices);


            if (Option2)
            {
                float dist = Vector3.Distance(meshVertices[13], meshVertices[14]);

                if (dist > 0.02)
                {
                    heart1.SetActive(true);
                    heart2.SetActive(true);
                }
                else
                {
                    heart1.SetActive(false);
                    heart2.SetActive(false);
                }
            }
            if (Option3)
            {
                spider.SetActive(true);
                float dist_eye1 = Vector3.Distance(meshVertices[27], meshVertices[23]);
                float dist_eye2 = Vector3.Distance(meshVertices[257], meshVertices[253]);

                if (dist_eye1 >= 0.018 & dist_eye2 >= 0.018)
                {

                    spider_anim.SetBool("Atack", true);
                    spider_anim.Play("Spider | Attack");
                }
                else
                { spider_anim.SetBool("Atack", false); }

            }
            if (Option4)
            {
                bird.SetActive(true);
                float dist = Vector3.Distance(meshVertices[13], meshVertices[14]);

                if (dist > 0.02)
                {

                    bird_anim.SetBool("Fly", true);
                }
                else
                {
                    bird_anim.SetBool("Fly", false);
                }
            }





        }
    }
    public void select1()
    {
        setFalse();
        Option1 = true;
    }
    public void select2()
    {
        setFalse();
        Option2 = true;
    }
    public void select3()
    {
        setFalse();
        Option3 = true;
    }
    public void select4()
    {
        setFalse();
        Option4 = true;
    }

}
