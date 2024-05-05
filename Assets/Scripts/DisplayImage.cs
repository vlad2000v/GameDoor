using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    public enum State
    {
        normal, zoom, ChangedView,
        idle
    };
    public State CurrentState { get; set; }
    public int CurrentWall
    {
        get { return currentWall; }
        set
        {
            if (value == 4)
            {
                currentWall = 1;
            }
            else if (value == 0)
                currentWall = 3;
            else
                currentWall = value;
        }
    }
    private int currentWall;
    private int previouWall;

    private void Start()
    {
        previouWall = 0;
        currentWall = 1;

    }
    private void Update()
    {
        if (currentWall != previouWall)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Wall" + currentWall.ToString());
        }
        previouWall = currentWall;
    }


}
