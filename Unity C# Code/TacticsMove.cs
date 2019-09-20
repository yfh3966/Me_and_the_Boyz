﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TacticsMove : MonoBehaviour
{
    List<Tile> selectableTiles = new List<Tile>();
    GameObject[] tiles;

    Stack<Tile> path = new Stack<Tile>();
    Tile currentTile;

    public int move = 5;
    public float jumpHeight = 2;
    public float moveSpeed = 2;

    Vector3 velocity = new Vector3();
    Vector3 heading = new Vector3();

    float halfHeight = 0;

    protected void Init()
    {
        tiles = GameObject.FindGameObjectsWithTag("Tile");

        halfHeight = GetComponent<Collider>().bounds.extents.y; //contains the collision box

    }

    public void GetCurrentTile()
    {
        currentTile = GetTargetTile(gameObject);
        //currentTile.current = true;
    }

    public Tile GetTargetTile(GameObject target) //able to pick a tile somewhere that another unit is sitting on
    {
        RaycastHit hit;
        Tile tile = null;

        if (Physics.Raycast(target.transform.position, Vector3.up, out hit, 1)) //locates the target tile
        {
            tile = hit.collider.GetComponent<Tile>();
        }

        return tile;
    }

    public void ComputeAdjacencyLists()
    {
        foreach (GameObject tile in tiles)
        {
            Tile t = tile.GetComponent<Tile>();
            //t.FindNeighbors(jumpHeight);
        }
    }

    public void FindSelectableTiles()
    {
        ComputeAdjacencyLists();
        GetCurrentTile();

        Queue<Tile> process = new Queue<Tile>();

        //first step in bfs, add the current tile. It starts with one tile and spreads outwards

        process.Enqueue(currentTile);
        //currentTile.visited = true;
        //currentTile.parent = ?? leave as null

        while (process.Count > 0)
        {
            Tile t = process.Dequeue();

            selectableTiles.Add(t);
            t.selectable = true; //all selectable tiles will turn its colour

            if (t.distance  < move)
            {
                foreach (Tile tile in t.adjacencyList)
                {
                    if (tile.visited)
                    {
                        tile.parent = t;
                        tile.visited = true;
                        tile.distance = 1 + t.distance;
                        process.Enqueue(tile);
                    }
                }
            }
        }

    }

}
