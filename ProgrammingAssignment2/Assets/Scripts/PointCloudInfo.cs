using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine;


public class PointCloudInfo : MonoBehaviour
{
    ARPointCloud myPointCloud;

    public Text myText;


    private void OnEnable()
    {
        myPointCloud = GetComponent<ARPointCloud>();
        //myPointCloud.updated
    }

    void Update()
    {
        
    }
}
