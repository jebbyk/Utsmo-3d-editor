using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexSelect : MonoBehaviour
{
    public GenerateMesh g;
    public Color color;
    static Material lineMaterial;
    static void CreateLineMaterial()
    {
        if (!lineMaterial)
        {
            // Unity has a built-in shader that is useful for drawing
            // simple colored things.
            Shader shader = Shader.Find("Hidden/Internal-Colored");
            lineMaterial = new Material(shader);
            lineMaterial.hideFlags = HideFlags.HideAndDontSave;
            // Turn on alpha blending
            lineMaterial.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
            lineMaterial.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
            // Turn backface culling off
            lineMaterial.SetInt("_Cull", (int)UnityEngine.Rendering.CullMode.Off);
            // Turn off depth writes
            lineMaterial.SetInt("_ZWrite", 0);
        }
    }

    // Will be called after all regular rendering is done
  /*   public void OnRenderObject()
    {
        CreateLineMaterial();
        // Apply the line material
        lineMaterial.SetPass(0);

        GL.PushMatrix();
        // Set transformation matrix for drawing to
        // match our transform
        GL.MultMatrix(g.transform.localToWorldMatrix);

        // Draw lines
        GL.Begin(GL.LINES);
        for(int i = 0; i < g.trianglesList.Length; i++)
        {
            GenerateMesh.triangle t = g.trianglesList[i];
            // Vertex colors black
            GL.Color(color);
            GL.Vertex3(t.v1.x, t.v1.y, t.v1.z);
            GL.Vertex3(t.v2.x, t.v2.y, t.v2.z);
            GL.Vertex3(t.v3.x, t.v3.y, t.v3.z);
            GL.Vertex3(t.v1.x, t.v1.y, t.v1.z);
        }
        GL.End();
        GL.PopMatrix();
    }*/

    public void OnPostRender()
    {
        CreateLineMaterial();
        // Apply the line material
        lineMaterial.SetPass(0);

        GL.PushMatrix();
        // Set transformation matrix for drawing to
        // match our transform
        GL.MultMatrix(transform.localToWorldMatrix);

        // Draw lines
        GL.Begin(GL.LINES);
      /*   for(int i = 0; i < g.trianglesList.Length; i++)
        {
            GenerateMesh.triangle t = g.trianglesList[i];
            // Vertex colors black
            GL.Color(color);
            GL.Vertex3(t.v1.x, t.v1.y, t.v1.z);
            GL.Vertex3(t.v2.x, t.v2.y, t.v2.z);
            GL.Vertex3(t.v3.x, t.v3.y, t.v3.z);
            GL.Vertex3(t.v1.x, t.v1.y, t.v1.z);
        } */

         GL.Color(color);
         GL.Vertex3(0, 0, 0);
         GL.Vertex3(2, 2, 2);

        GL.End();
        GL.PopMatrix();
    }
}
