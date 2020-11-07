using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatUser : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(2 * transform.position - target.transform.position, transform.up);
    }
}
