using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hut_script : MonoBehaviour

{
    public GameObject cube5 ;
    public GameObject cube4;

    // Start is called before the first frame update
    void Start()
    {
        cube4 = GameObject.Find("ImageTarget/house/parts/hut/Cube_004");
        cube5 = GameObject.Find("ImageTarget/house/parts/hut/Cube_005");
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position=(cube.position+cube_002.position)/ 2;
        StartCoroutine(ab());

    }
    IEnumerator ab()
    {
        yield return new WaitForSeconds(15);
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(transform.localPosition.x, 1.866f, transform.localPosition.z), 0.5f * Time.deltaTime);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(180, 0, 0), 0.5f * Time.deltaTime);
        transform.localPosition = Vector3.MoveTowards(transform.localPosition,new Vector3(0f,1.866f,-0.9f),0.5f*Time.deltaTime);
        yield return new WaitForSeconds(5);
        cube4.transform.localRotation = Quaternion.Slerp(cube4.transform.localRotation, Quaternion.Euler(0, 0, 49), Time.deltaTime);
        cube5.transform.localRotation = Quaternion.Slerp(cube5.transform.localRotation, Quaternion.Euler(0, 0, -49), Time.deltaTime);
        //transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(-90, 0, 0), 2 * Time.deltaTime);
    }
}
