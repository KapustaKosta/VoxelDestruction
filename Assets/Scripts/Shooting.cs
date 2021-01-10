using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject BulletInstance;
            BulletInstance = Instantiate(bullet, this.transform.position + new Vector3(0, 0, -0.6f), Quaternion.identity);
            BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
        }
    }
}
