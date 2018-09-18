using UnityEngine;
using System.Collections;


public class FollowCam : MonoBehaviour {
    static public GameObject POI;

    [Header("Set in Insepector")]
    public float easing = 0.05f;

    [Header("Set Dynamically")]
    public float camZ;

    private void Awake()
    {
        camZ = this.transform.position.z;
    }

    private void FixedUpdate()
    {
        if (POI == null) return;

        Vector3 destination = POI.transform.position;
        destination = Vector3.Lerp(transform.position, destination, easing);
        destination.z = camZ;
        transform.position = destination;
    }
}
