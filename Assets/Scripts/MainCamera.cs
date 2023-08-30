using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [SerializeField] private float _cameraSpeed;
    private Transform target;

    void Start()
    {
        target = PlayerControl.instance.transform;
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 poz = target.position;
        poz.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, poz, _cameraSpeed * Time.deltaTime);
    }
}
