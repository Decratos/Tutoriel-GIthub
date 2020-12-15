using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] private Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation);
    }
}
