using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraController : MonoBehaviour
{
    public GameObject ObjectoAseguir;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // position camera - player1
        offset = transform.position - ObjectoAseguir.transform.position;
        Debug.Log("offset:" +offset.magnitude);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ObjectoAseguir.transform.position + offset;
        
    }


}