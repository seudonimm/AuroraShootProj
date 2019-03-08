using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleShot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject spawn;
    GameObject shot;
    [SerializeField] float projSpeed;
    [SerializeField] int bulletNum = 4;

    [SerializeField] float xCircleMultiplier = 1f;
    [SerializeField] float yCircleMultiplier = 1f;

    [SerializeField] float xCircleAdder = 0f;
    [SerializeField] float yCircleAdder = 0f;

    [SerializeField] float radius = 2f;

    float angle = 0;
    Vector3 beginPosition;
    float beginPositionx;
    float beginPositiony;

    //Vector2[] projVelocity;
    //GameObject[] shotHolder;

    //float timeStamp = Time.time + 3;

    // Start is called before the first frame update
    void Start()
    {
        beginPosition = spawn.transform.position;
        beginPositionx = spawn.transform.position.x;
        beginPositiony = spawn.transform.position.y;
        //float timeStamp = Time.time + 3;

        Fire();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Fire();

    }

    void Expand()
    {
        
    }

    void Fire()
    {
        //float radius = 2f;
        
        float x = beginPositionx + Mathf.Cos(angle) * radius;
        float y = beginPositiony + Mathf.Sin(angle) * radius;

        float xRot = transform.rotation.x;
        float yRot = transform.rotation.y;

        Vector3 circle;
        Vector3 center;
        Vector2 expand;
        float angleA = 0;

        Vector2[] projVelocity = new Vector2[360/bulletNum];
        GameObject[] shotHolder = new GameObject[360/bulletNum];

        float xSpread;
        float ySpread;

        for (int i = 0; i < bulletNum; i++)
        {
                
            //x = x + Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
            //y = y + Mathf.Sin(angle * Mathf.Deg2Rad) * radius;
            //circle = new Vector3(x, y);
            center = transform.position;
            circle = Circle(center, radius);                
                
            angleA = angleA + (360 / bulletNum);

            xSpread = Mathf.Cos(angleA);
            ySpread = Mathf.Sin(angleA);


            //expand = new Vector2(angleA * Mathf.PI/180, angleA * Mathf.PI / 180);

            projVelocity[i] = new Vector2(xSpread * xCircleMultiplier + xCircleAdder, ySpread * yCircleMultiplier + yCircleAdder);
                
            //Quaternion rotation = Quaternion.Euler(xRot, yRot, angleA);

            shot = Instantiate(bullet, circle, transform.rotation) as GameObject;

            shotHolder[i] = shot;

            //shot.GetComponent<Rigidbody2D>().velocity = -beginPosition;
            //shot.GetComponent<Rigidbody2D>().velocity = expand * projSpeed * Time.deltaTime; 

            //shot.GetComponent<Rigidbody2D>().rotation = Quaternion.EulerRotation(newX,newY,0);
        }
        

        for(int i = 0; i < bulletNum; i++)
        {
            shotHolder[i].GetComponent<Rigidbody2D>().velocity = projVelocity[i] * projSpeed * Time.deltaTime;
        }

        //shot = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        //shot.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed);

        //shot.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projSpeed);




        //X:= originX + cos(angle) * radius;
        //Y:= originY + sin(angle) * radius;


    }

    Vector3 Circle(Vector3 center, float radius)
    {
        angle = angle + (360 / bulletNum);
        Vector3 pos;
        pos.x = center.x + Mathf.Cos(angle * Mathf.Deg2Rad) * radius;
        pos.y = center.y + Mathf.Sin(angle * Mathf.Deg2Rad) * radius;
        pos.z = center.z;

        return pos;
    }
}
