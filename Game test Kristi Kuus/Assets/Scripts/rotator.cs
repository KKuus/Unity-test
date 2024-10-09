using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotator : MonoBehaviour
{
    public float RotatonSpeed1;
    public float RotatonSpeed2;
    public float RotatonSpeed3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotatonSpeed1*Time.deltaTime, RotatonSpeed2*Time.deltaTime, RotatonSpeed3*Time.deltaTime, Space.World);
    }
}
