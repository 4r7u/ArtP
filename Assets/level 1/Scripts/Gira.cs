using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gira : MonoBehaviour
{
    private void Update()
    {

            transform.Rotate (0.0f, 0.2f, 0.0f, Space.Self);
        
    }
}
