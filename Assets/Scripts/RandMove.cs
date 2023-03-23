using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMove : MonoBehaviour
{
    public static GameObject block1;
    public static GameObject block2;
    public static GameObject block3;
    public static GameObject block4;
    public static GameObject block5;
    public static GameObject block6;
    public static GameObject block7;
    public static GameObject block8;
    GameObject[] blocks = new GameObject[8];

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

    int moves;
    int empty = 8;
    int selection = 0;

    bool[] checkposition = { false, false, false, false, false, false, false, false, false };

    // Start is called before the first frame update
    void Start()
    {
        getBlocks();
        positions[0] = position1;
        positions[1] = position2;
        positions[2] = position3;
        positions[3] = position4;
        positions[4] = position5;
        positions[5] = position6;
        positions[6] = position7;
        positions[7] = position8;
        positions[8] = position9;

        for (moves = Random.Range(100, 200); moves > 0; moves--)
        {
            if (empty == 0)
            {
                selection = Random.Range(0, 1);
                if (selection == 0)
                {
                    movedown();
                }
                if (selection == 1)
                {
                    moveright();
                }
            }
            if (empty == 1)
            {
                selection = Random.Range(0, 2);
                if (selection == 0)
                {
                    movedown();
                }
                if (selection == 1)
                {
                    moveright();
                }
                if (selection == 2)
                {
                    moveleft();
                }

            }
            if (empty == 2)
            {
                selection = Random.Range(0, 1);
                if (selection == 0)
                {
                    movedown();
                }
                if (selection == 1)
                {
                    moveleft();
                }
            }
            if (empty == 3)
            {
                selection = Random.Range(0, 2);
                if (selection == 0)
                {
                    movedown();
                }
                if (selection == 1)
                {
                    moveright();
                }
                if (selection == 2)
                {
                    moveup();
                }
            }
            if (empty == 4)
            {
                selection = Random.Range(0, 3);
                if (selection == 0)
                {
                    movedown();
                }
                if (selection == 1)
                {
                    moveright();
                }
                if (selection == 2)
                {
                    moveleft();
                }
                if (selection == 3)
                {
                    moveup();
                }
            }
            if (empty == 5)
            {
                selection = Random.Range(0, 2);
                if (selection == 0)
                {
                    movedown();
                }
                if (selection == 1)
                {
                    moveleft();
                }
                if (selection == 2)
                {
                    moveup();
                }
            }
            if (empty == 6)
            {
                selection = Random.Range(0, 1);
                if (selection == 0)
                {
                    moveup();
                }
                if (selection == 1)
                {
                    moveright();
                }
            }
            if (empty == 7)
            {
                selection = Random.Range(0, 2);
                if (selection == 0)
                {
                    moveleft();
                }
                if (selection == 1)
                {
                    moveright();
                }
                if (selection == 2)
                {
                    moveup();
                }
            }
            if (empty == 8)
            {
                selection = Random.Range(0, 1);
                if (selection == 0)
                {
                    moveup();
                }
                if (selection == 1)
                {
                    moveleft();
                }
            }
            //want to pick a random one and prevent some from being selected
        }
    }

    void moveup()
    {
        int block;
        empty -= 3;
        block = SearchForBlock(positions[empty]);
        if (block != -1)
        {
            blocks[block].transform.position = positions[empty + 3];
        }
    }

    void movedown()
    {
        int block;
        empty += 3;
        block = SearchForBlock(positions[empty]);
        if (block != -1)
        {
            blocks[block].transform.position = positions[empty - 3];
        }
    }

    void moveleft()
    {
        int block;
        empty -= 1;
        block = SearchForBlock(positions[empty]);
        if (block != -1)
        {
            blocks[block].transform.position = positions[empty + 1];
        }
    }

    void moveright()
    {
        int block;
        empty += 1;
        block = SearchForBlock(positions[empty]);
        if (block != -1)
        {
            blocks[block].transform.position = positions[empty - 1];
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

    public void getBlocks()
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
