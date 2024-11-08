using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBase : MonoBehaviour
{
    [SerializeField] public GameObject NorthDoorway, EastDoorway, SouthDoorway, WestDoorway;

    public void SetRoomLocation(Vector2 coordinates)
    {   // Sets the room locations
        transform.position = new Vector3(coordinates.x, 0, coordinates.y); 
    }
   

}
