using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    private string name;
    private string[] theOpenDoors = new string[2];
    private int howManyOpenDoors = 0;
    private string[] visitedRooms = new string[2];

    public Room(string name)
    {
        this.name = name;
    }

    public void setOpenDoor(string direction)
    {
        this.theOpenDoors[this.howManyOpenDoors] = direction;
        this.howManyOpenDoors++;
    }

    public bool isOpenDoor(string direction)
    {
        for (int i = 0; i < this.howManyOpenDoors; i++)
        {
            if (direction.Equals(this.theOpenDoors[i]))
            {
                return true;
            }
        }
        return false;
    }
    public void AddVisitedRoom(string roomName)
    {
        for (int i = 0; i < visitedRooms.Length; i++)
        {
            if (visitedRooms[i] == null)
            {
                visitedRooms[i] = roomName;
                return;
            }
        }
    }

}
