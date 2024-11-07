using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPos : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Shader.SetGlobalVector("_ObjectPos", new Vector4(this.transform.position.x, this.transform.position.y, this.transform.position.z, this.transform.localScale.x));
    }
}
