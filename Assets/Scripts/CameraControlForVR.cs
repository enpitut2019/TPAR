using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CameraControlForVR : MonoBehaviour
{
    [SerializeField] Camera target;

    // Start is called before the first frame update
    void Start()
    {

        XRDevice.DisableAutoXRCameraTracking(target, false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
