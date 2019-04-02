using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class GenerateMesh : MonoBehaviour
{
    // Start is called before the first frame update

    public class triangle{
        public Vector3 v1, v2, v3;
        public triangle(Vector3 _v1, Vector3 _v2, Vector3 _v3)
        {
            v1 = _v1;
            v2 = _v2;
            v3 = _v3;
        }
        
    }

    public triangle[] trianglesList;
    Mesh mesh;
    MeshFilter meshFilter;
    MeshRenderer meshRenderer;
    MeshCollider MeshCollider;

    Vector3[] vertices;

    Camera cam;
    int[] tris;



    Vector3Int[] trisCombined;

    struct poly{

    }


    void Start()
    {
        mesh = new Mesh();
        meshFilter = GetComponent<MeshFilter>();
        MeshCollider = GetComponent<MeshCollider>();
        cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

        vertices = new Vector3[]{
            new Vector3(-0.5f,0.5f,-0.5f),//0
            new Vector3(-0.5f,0.5f,0.5f),//1
            new Vector3(0.5f,0.5f,-0.5f),//2
            new Vector3(0.5f,0.5f,0.5f),//3

            new Vector3(-0.5f, -0.5f, -0.5f),//4
            new Vector3(0.5f, -0.5f, -0.5f),//5
            new Vector3(-0.5f, -0.5f, 0.5f),//6
            new Vector3(0.5f, -0.5f, 0.5f),//7

            new Vector3(-0.5f, -0.5f, -0.5f),//8
            new Vector3(-0.5f, 0.5f, -0.5f),//9
            new Vector3(0.5f, -0.5f, -0.5f),//10
            new Vector3(0.5f, 0.5f, -0.5f),//11

            new Vector3(0.5f, -0.5f, -0.5f),//12
            new Vector3(0.5f, 0.5f, -0.5f),//13
            new Vector3(0.5f, -0.5f, 0.5f),//14
            new Vector3(0.5f, 0.5f, 0.5f),//15

            new Vector3(-0.5f, -0.5f, 0.5f),//16
            new Vector3(-0.5f, 0.5f, 0.5f),//167
            new Vector3(-0.5f, -0.5f, -0.5f),//18
            new Vector3(-0.5f, 0.5f, -0.5f),//19

            new Vector3(0.5f, -0.5f, 0.5f),//20
            new Vector3(0.5f, 0.5f, 0.5f),//21
            new Vector3(-0.5f, -0.5f, 0.5f),//22
            new Vector3(-0.5f, 0.5f, 0.5f)//23

        };

        tris = new int[]{
            0,1,2,
            1,3,2,

            4,5,6,
            6,5,7,

            8,9,10,
            9,11,10,

            12,13,14,
            13,15,14,

            16,17,18,
            17,19,18,

            20,21,22,
            21,23,22
        };

        trianglesList = new triangle[]{
            new triangle(vertices[0], vertices[1], vertices[2]),
            new triangle(vertices[1], vertices[3], vertices[2]),

            new triangle(vertices[4], vertices[5], vertices[6]),
            new triangle(vertices[6], vertices[5], vertices[7]),

            new triangle(vertices[8], vertices[9], vertices[10]),
            new triangle(vertices[9], vertices[11], vertices[10]),

            new triangle(vertices[12], vertices[13], vertices[14]),
            new triangle(vertices[13], vertices[15], vertices[14]),

            new triangle(vertices[16], vertices[17], vertices[18]),
            new triangle(vertices[17], vertices[19], vertices[18]),

            new triangle(vertices[20], vertices[21], vertices[22]),
            new triangle(vertices[21], vertices[23], vertices[22])
        };
        

        mesh.vertices = vertices;
        mesh.triangles = tris;
        mesh.RecalculateNormals();
        mesh.RecalculateTangents();

        meshFilter.mesh = mesh;
        meshFilter.sharedMesh = mesh;
        MeshCollider.sharedMesh = mesh;
    }
    void Update()
    {
        /* for(int i = 0; i < trianglesList.Length; i++)
        {
            triangle t = trianglesList[i];
            Debug.DrawLine(transform.position + t.v1,transform.position + t.v2, Color.black, 0.5f);
            Debug.DrawLine(transform.position + t.v1,transform.position + t.v3, Color.black, 0.5f);
            Debug.DrawLine(transform.position + t.v2,transform.position + t.v2, Color.black, 0.5f);
        }*/
        
    }

}
