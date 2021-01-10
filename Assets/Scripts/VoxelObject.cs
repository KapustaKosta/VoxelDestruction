using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoxelObject
{
    public int height;
    public int lenght;
    public int weight;

    private GameObject[,,] voxels;

    private float voxelSizeX = 0f;
    private float voxelSizeY = 0f;
    private float voxelSizeZ = 0f;

    public VoxelObject(int height, int lenght, int weight, GameObject voxel)
    {
        this.height = height;
        this.lenght = lenght;
        this.weight = weight;
        voxels = new GameObject[height, lenght, weight];

        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < lenght; j++)
            {
                for(int k  = 0; k < weight; k++)
                {
                    voxels[i, j, k] = voxel;
                }
            }
        }

        voxelSizeX = voxel.transform.localScale.x;
        voxelSizeY = voxel.transform.localScale.y;
        voxelSizeZ = voxel.transform.localScale.z;
    }

    public void Spawn(Vector3 spawnPlace)
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < lenght; j++)
            {
                for (int k = 0; k < weight; k++)
                {
                    Object.Instantiate(
                        voxels[i, j, k], 
                        new Vector3(spawnPlace.x + voxelSizeX * j, spawnPlace.y + voxelSizeY * i, spawnPlace.z + voxelSizeZ * k),
                        Quaternion.identity);
                }
            }
        }
    }
}
