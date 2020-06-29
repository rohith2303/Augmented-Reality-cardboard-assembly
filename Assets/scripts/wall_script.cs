using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_script : MonoBehaviour
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
        yield return new WaitForSeconds(9);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(-90, 0, 0), 2 * Time.deltaTime);
    }
}
