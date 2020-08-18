using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class basicmover : MonoBehaviour
{
    // Start is called before the first frame update
    public float spinSpeed = 180.0f;
    public float motionMagni = 0.1f;
    public bool doSpin = true;
    public bool doMotion = true;
    // Update is called once per frame
    void Update()
    {
        //rotate around y axis
        if (doSpin)
        { gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime); }
        //move up and down
        if (doMotion)
        { gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagni); }
    }
}
