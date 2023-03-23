using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
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

    GameObject cursorup;
    GameObject cursordown;
    GameObject cursorleft;
    GameObject cursorright;


    int positionindex;

    bool initial = true;

    // Start is called before the first frame update
    void Start()
    {
        //first find the starting position
        positions[0] = position1;
        positions[1] = position2;
        positions[2] = position3;
        positions[3] = position4;
        positions[4] = position5;
        positions[5] = position6;
        positions[6] = position7;
        positions[7] = position8;
        positions[8] = position9;
        GetObjects();
    }

    // Update is called once per frame
    void Update()
    {
        int block = -1;
        if (initial)
        {
            int index = 0;
            int i = -1;
            while (index != -1)
            {
                i++;
                index = SearchForBlock(positions[i]);
            }
            positionindex = i;
            initial = false;
            MoveCursor(positionindex);
        }
        if (Input.GetKeyUp("up") && positionindex > 2)
        {
            positionindex -= 3;
            block = SearchForBlock(positions[positionindex]);
            if (block != -1)
            {
                blocks[block].transform.position = positions[positionindex+3];
                MoveCursor(positionindex);
                CheckWin();
            }
        }
        if (Input.GetKeyUp("down") && positionindex < 6)
        {
            positionindex += 3;
            block = SearchForBlock(positions[positionindex]);
            if (block != -1)
            {
                blocks[block].transform.position = positions[positionindex - 3];
                MoveCursor(positionindex);
                CheckWin();
            }
        }
        if (Input.GetKeyUp("left") && positionindex % 3 != 0)
        {
            positionindex -= 1;
            block = SearchForBlock(positions[positionindex]);
            if (block != -1)
            {
                blocks[block].transform.position = positions[positionindex + 1];
                MoveCursor(positionindex);
                CheckWin();
            }
        }
        if (Input.GetKeyUp("right") && positionindex % 3 != 2)
        {
            positionindex += 1;
            block = SearchForBlock(positions[positionindex]);
            if (block != -1)
            {
                blocks[block].transform.position = positions[positionindex - 1];
                MoveCursor(positionindex);
                CheckWin();
            }
        }
    }

    void CheckWin()
    {
        bool win = true;
        int block = -1;
        for (int i = 0; i < 8; i++)
        {
            block = SearchForBlock(positions[i]);
            if (block != i)
            {
                win = false;
            }
        }
        if (win == true)
        {
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    int SearchForBlock(Vector3 pos)
    {
        //check a given position to see if there is a block there
        int index = -1;
        for (int i = 0; i < 8; i++)
        {
            if (blocks[i].transform.position == pos)
            {
                index = i;
            }
        }
        return index;
    }

    void GetObjects()
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
        cursorup = GameObject.Find("Triangle");
        cursordown = GameObject.Find("Triangle down");
        cursorleft = GameObject.Find("Triangle left");
        cursorright = GameObject.Find("Triangle right");
    }

    void MoveCursor(int location)
    {
        Vector3 position = positions[location];
        position.y += 0.75f;
        cursorup.transform.position = position;
    }

}
