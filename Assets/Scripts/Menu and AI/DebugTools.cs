using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTools : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mask = LayerMask.GetMask("myLayer");
        Debug.Log(mask.ToString());
    }
}
