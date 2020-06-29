using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offcut : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(ab());

    }
    IEnumerator ab()
    {
        yield return new WaitForSeconds(5);
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(-1, 1, -2.5f), 2f * Time.deltaTime);
        
        yield return new WaitForSeconds(2);
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(-1, 50, -2.5f), 5f * Time.deltaTime);
    }
}
