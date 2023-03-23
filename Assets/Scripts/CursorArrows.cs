using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorArrows : MonoBehaviour
{
    Vector3 position1 = new Vector3(-2.1f, 2.1f, 0);
    Vector3 position2 = new Vector3(0, 2.1f, 0);
    Vector3 position3 = new Vector3(2.1f, 2.1f, 0);
    Vector3 position4 = new Vector3(-2.1f, 0, 0);
    Vector3 position5 = new Vector3(0, 0, 0);
    Vector3 position6 = new Vector3(2.1f, 0, 0);
    Vector3 position7 = new Vector3(-2.1f, -2.1f, 0);
    Vector3 position8 = new Vector3(0, -2.1f, 0);
    Vector3 position9 = new Vector3(2.1f, -2.1f, 0);
    Vector3[] positions = new Vector3[9];

    public static GameObject block1;
    public static GameObject block2;
    public static GameObject block3;
    public static GameObject block4;
    public static GameObject block5;
    public static GameObject block6;
    public static GameObject block7;
    public static GameObject block8;
    GameObject[] blocks = new GameObject[8];
    // Start is called before the first frame update
    void Start()
    {
        GetBlocks();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void GetBlocks()
    {
        block1 = GameObject.Find("Square 1");
        blocks[0] = block1;
        block2 = GameObject.Find("Square 2");
        blocks[1] = block2;
        block3 = GameObject.Find("Square 3");
        blocks[2] = block3;
        block4 = GameObject.Find("Square 4");
        blocks[3] = block4;
        block5 = GameObject.Find("Square 5");
        blocks[4] = block5;
        block6 = GameObject.Find("Square 6");
        blocks[5] = block6;
        block7 = GameObject.Find("Square 7");
        blocks[6] = block7;
        block8 = GameObject.Find("Square 8");
        blocks[7] = block8;
    }
}
