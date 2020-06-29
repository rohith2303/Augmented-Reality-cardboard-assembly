using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class side12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ab());

    }
    IEnumerator ab()
    {
        yield return new WaitForSeconds(12);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(0, 0, -90),  Time.deltaTime);
    }
}
