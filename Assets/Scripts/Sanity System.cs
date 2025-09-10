using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanitySystem : MonoBehaviour
{
    public float sanity;
    public Slider sanityMeter;
    public float drainAmount;
    public LayerMask sanityDrain;
    // Start is called before the first frame update
    void Start()
    {
        sanity = 1;
    }

    // Update is called once per frame
    void Update()
    {
        sanityMeter.value = sanity;
        sanity -= drainAmount * Time.deltaTime;

        Collider[] colliderArray = Physics.OverlapBox(transform.position, transform.localScale, Quaternion.identity, sanityDrain);
        if (colliderArray.Length > 0)
            drainAmount = 0.05f;
        else drainAmount = 0f;

    }
}
