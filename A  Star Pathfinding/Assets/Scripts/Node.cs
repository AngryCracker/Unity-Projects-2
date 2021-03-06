﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : IHeapItem<Node> {

    public bool walkable;
    public Vector3 worldposition;
    public int gCost;
    public int hCost;
    public int gridX;
    public int gridY;
    public Node parent;
    int heapIndex;

    public Node(bool _walkable, Vector3 _worldPosition, int _gridX, int _gridY)
    {
        this.walkable = _walkable;
        this.worldposition = _worldPosition;
        this.gridX = _gridX;
        this.gridY = _gridY;
    }

    // We are doing this because we never really need to assign to fCost
    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
        // We don't need a set method
    }

    public int HeapIndex
    {
        get
        {
            return heapIndex;
        }
        set
        {
            heapIndex = value;
        }
    }

    public int CompareTo (Node nodeToCompare)
    {
        int compare = fCost.CompareTo(nodeToCompare.fCost);
        if (compare == 0)
        {
            compare = hCost.CompareTo(nodeToCompare.hCost);
        }
        return -compare;
    }
}
