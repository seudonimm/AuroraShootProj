using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    [SerializeField] string followerTag;

    //array for Nodes
    Node[] PathNode;

    //tells which node by index of array
    int currentNode;

    //object that will follow node path
    [SerializeField] GameObject follower;
    
    //current position of follower object
    Vector2 currentPosition;
    
    //the next node the follower object should move to
    Vector2 destinationPosition;

    //personal note: between nodes or entire path
    [SerializeField] float moveSpeed;

    //i'm not entirely sure what this does yet
    [SerializeField] float time;

    // Start is called before the first frame update
    void Start()
    {
        follower = GameObject.FindGameObjectWithTag(followerTag);

        //adds children of game object this script is attached to to this array
        PathNode = GetComponentsInChildren<Node>();

        //loop for a debug statement to show how many element in PathNode array
        for (int i = 0; i < PathNode.Length; i++)
        {

            Debug.Log(i);
        }

        //puts follower object at the position of first node in the array which is the beginning of the path

        CheckNode();

        Invoke("Die", 10);
    }

    // Update is called once per frame
    void Update()
    {
        

        //will make path move somehow i'll figure it out
        time += Time.deltaTime * moveSpeed;

        DrawLine();
        if (!follower)
        {
            //if follower no longer exists, destroy path
            Destroy(gameObject);
        }else if ((Vector2)follower.transform.position != destinationPosition)
        {
            //if follower object is not at the destinationPostion vector then move it there
            follower.transform.position = Vector2.Lerp(currentPosition, destinationPosition, time);
            Debug.Log("if");        
        }
        else
        {
            Debug.Log("else");
            if (currentNode < PathNode.Length)
            {
                //see method
                CheckNode();
                Debug.Log("else if");
            }
        }

        
    }

    void CheckNode()
    {
        //sets current position vector to the position of the follower object
        currentPosition = follower.transform.position;
        //sets destinationPostion vector to postion of the specified node in the array
        destinationPosition = PathNode[currentNode].transform.position;
        //next node index
        currentNode++;
        //yes
        time = 0;
    }

    //draw path between nodes during playmode in editor
    void DrawLine()
    {
        for (int i = 0; i < PathNode.Length - 1; i++)
        {
            Debug.DrawLine(PathNode[i].transform.position, PathNode[i + 1].transform.position, Color.green);

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}



//currentPosition = PathNode[0].transform.position;
//follower.transform.position = currentPosition;