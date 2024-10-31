using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map 
{



    // Start is called before the first frame update
    int mapSize = 3;
    public int Mapsize => mapSize;
    RoomManager[] Rooms;

    public Map()
    {
        CreateMap();
        VisualizeMap();
    }
    private void CreateMap() { }

    private void VisualizeMap()
    {
        for (int x = 0; x < mapSize; x++)
        {
            for (int z = 0; z < mapSize; z++)
            {

                var mapRoomRepresentation = GameObject.CreatePrimitive(PrimitiveType.Cube);
                mapRoomRepresentation.transform.position = new Vector3(x, 0, z);
                mapRoomRepresentation.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            }
        }
    }

}
