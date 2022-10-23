using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR;



public class ImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;


    private void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();

    }

    public void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;

    }

    public void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;

    }


    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var VARIABLE in args.added)
        {
            Debug.Log(_arTrackedImage.name);
        }

    }


  
}
