using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBase : MonoBehaviour
{
    // todo make them all lambdo like north
    private RoomBase north, East, South, West;
    public RoomBase North => north;
    private int roomNumber;

    public RoomBase(int num)
    {
        roomNumber = num;
        Console.WriteLine("Room " + num + " Created!");
    }

    public void SetRooms(RoomBase roomToTheNorth, RoomBase east, RoomBase south, RoomBase west)
    {
        north = roomToTheNorth;
        East = east;
        South = south;
        West = west;
    }
}