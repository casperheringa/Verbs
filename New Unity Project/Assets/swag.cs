    using UnityEngine;
using System.Collections;
public class PngReader : MonoBehaviour
{
    [SerializeField]
    private Texture2D image;
    [SerializeField]
    private GameObject cube;
    // Use this for initialization
    void Start()
    {
        for (int x = 0; x < image.width; x++)
        {
            for (int y = 0; y < image.height; y++)
            {
                Color color = image.GetPixel(x, y);
                float z = color.a + color.b + color.g + color.r;
                GameObject c = Instantiate(cube, new Vector3(x, z, y), Quaternion.identity) as GameObject;
                c.GetComponent<Renderer>().material.color = color;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}