using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Checks to see if the enemy can see the player and turns the enemy to a hostile state if so
public class ViewCone : MonoBehaviour
{
    
    //Hold onto player transform
    private Transform playerTransform;
    
    //Public variables
    public float viewAngle = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("PlayerShip").transform; //initialize playerTransform
    }

    // Update is called once per frame
    void Update()
    {
        ViewCheck();
    }

    //Checks to see if the player is within a cone of view width viewAngle degrees
    private void ViewCheck()
    {
        var cone = Mathf.Cos(viewAngle * Mathf.Deg2Rad);
        var heading = (playerTransform.position - transform.position).normalized;

        if (Vector3.Dot(transform.up, heading) > cone)
        {
            Debug.Log("Player Spotted!");
        }
    }
}
