using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.UI;

public class DetectingOpeningMouth : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject FaceAttachment;
    AugmentedFace face;
    public Text text;
    public List<AugmentedFace> m_TempAugmentedFaces = new List<AugmentedFace>();
    void Start()
    {

        heart1.SetActive(false);
        heart2.SetActive(false);
        FaceAttachment = GameObject.Find("FaceAttachement");
    }

    // Update is called once per frame
    void Update()
    {
        Session.GetTrackables<AugmentedFace>(m_TempAugmentedFaces, TrackableQueryFilter.All);

        if (m_TempAugmentedFaces.Count > 0)
        {

            face = m_TempAugmentedFaces[0];

            List<Vector3> meshVertices = new List<Vector3>();
            face.GetVertices(meshVertices);

            
            float dist_mouth = Vector3.Distance(meshVertices[13], meshVertices[14]);
            float dist_eye1 = Vector3.Distance(meshVertices[386], meshVertices[374]);
            float dist_eye2 = Vector3.Distance(meshVertices[159], meshVertices[145]);
            if (dist_mouth > 0.03)
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

    }
}
