using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject voxel;

    void Start()
    {
        VoxelObject example = new VoxelObject(10, 10, 10, voxel);
        example.Spawn(new Vector3(0, 0, 0));
    }

}
