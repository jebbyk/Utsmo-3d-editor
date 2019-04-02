using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class GenerateMesh : MonoBehaviour
{
    // Start is called before the first frame update
    Mesh mesh;
    MeshFilter meshFilter;
    MeshRenderer meshRenderer;

    Vector3[] vertices;
    int[] tris;

    Vector3Int[] trisCombined;

    struct poly{

    }


    void Start()
    {
        mesh = new Mesh();
        meshFilter = GetComponent<MeshFilter>();
        vertices = new Vector3[]{
            new Vector3(0,0,0),
            new Vector3(0,0,1),
            new Vector3(1,0,0),
            new Vector3(1,0,1),
        };

        tris = new int[]{
            0,1,2,
            1,3,2
        };

        mesh.vertices = vertices;
        mesh.triangles = tris;

        meshFilter.mesh = mesh;
    }
    void Update()
    {
        
    }
}
