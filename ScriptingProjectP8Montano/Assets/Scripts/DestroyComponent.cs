using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class DestroyComponent : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer>());
        }
    }
}
