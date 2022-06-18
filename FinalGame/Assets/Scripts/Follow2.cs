using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follow2 : MonoBehaviour
{
    public GameObject bat;
    // Start is called before the first frame update
  public PathCreator pathCreator;
  public float speed = 3f;
  float distanceTravelled;

    // Update is called once per frame
    void Update()
    {
        
        distanceTravelled += speed * Time.deltaTime;
        transform.position =pathCreator.path.GetPointAtDistance(distanceTravelled);
    
        if(bat.transform.position.y < -1.20 )
        {
            bat.transform.localScale = new Vector3(1,1,1);
            
        }
        else if(bat.transform.position.y > -1.20)
        {
            bat.transform.localScale = new Vector3(-1,1,1);
        }
    }

    
}
