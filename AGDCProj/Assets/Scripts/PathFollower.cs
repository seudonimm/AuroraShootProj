using UnityEngine;

public class PathFollower : MonoBehaviour
{
    //array for nodes
    Node[] PathNode;

    //object that will follow node
    public GameObject follower;

    //speed of Follower along path
    public float moveSpeed;

    //default time
    float timer;
    int CurrentNode;
    
    //holds current Node position
    static Vector3 currentPositionHolder;
    static Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        PathNode = GetComponentsInChildren<Node>();


        for(int i = 0; i < PathNode.Length -1; i++)
        {
            
            Debug.Log(i);
        }

        CheckNode();

    }

    //checks current node and moves to it
    void CheckNode()
    {
        if (CurrentNode < PathNode.Length - 1)
        {
            timer = 0;
        }
        //holds currentNode position to CurrentPositionHolder
        currentPositionHolder = PathNode[CurrentNode].transform.position;
        startPosition = follower.transform.position;
    }

    //draws a line from PathNode[0] to next node until end
    void DrawLine()
    {
        for(int i = 0; i < PathNode.Length - 1; i++)
        {
            Debug.DrawLine(PathNode[i].transform.position, PathNode[i+1].transform.position, Color.green);

        }
    }
    // Update is called once per frame
    void Update()
    {
        DrawLine();
        Debug.Log(CurrentNode);
        //will make path move
        timer += Time.deltaTime * moveSpeed;

        //if follower is not equal to Node pos, move follower to node
        if(follower.transform.position != currentPositionHolder)
        {
            //follower.transform.position = Vector3.Lerp(follower.transform.position, currentPositionHolder, timer);    //moves node by node stopping at every node
            follower.transform.position = Vector3.Lerp(startPosition, currentPositionHolder, timer);
        }
        else//go to next node
        {
            if (CurrentNode < PathNode.Length - 1)
            {
                CurrentNode++;
                CheckNode();
            }
        }
    }
}
