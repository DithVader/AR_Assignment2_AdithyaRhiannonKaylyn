using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaceObject : MonoBehaviour
{
    [SerializeField] public GameObject Obj;

    private GameObject spawnedObj;
    private ARRaycastManager _raycastmanager;
    private Vector2 touchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    private void Awake()
    {
        _raycastmanager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }
        touchPosition = default;
        return false;
    }



    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPosition))
            return;

        if (_raycastmanager.Raycast(touchPosition,hits, TrackableType.PlaneWithinPolygon))
        {
            var Hitpose = hits[0].pose;

            if (spawnedObj == null)
            {
                spawnedObj = Instantiate(Obj, Hitpose.position, Hitpose.rotation);
            }
            else
            {
                spawnedObj.transform.position = Hitpose.position;
            }

        }
    }
}
