using GoogleMobileAds.Api;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class admob2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize((initStatus) =>
        {
            // SDK initialization is complete
        });
    }

}
