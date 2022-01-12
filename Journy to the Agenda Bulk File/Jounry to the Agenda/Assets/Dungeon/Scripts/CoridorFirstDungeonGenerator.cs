using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoridorFirstDungeonGenerator : SimpleRandomWalkMapGenerator
{
    [SerializeField]
    private int coridorLength = 14, corridorCount = 5;
    [SerializeField]
    [Range(0.1f, 1)]
    private float roomPercent = 0.8f;
    [SerializeField]
    public SimpleRandomWalkSO roomGenerationParapmeters;
    protected override void RunProceduralGeneration()
    {
        corridorFirstGeneration();
    }

    private void corridorFirstGeneration()
    {
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();

        CreateCoridors(floorPositions);
        tileMapVisualizer.PaintFloorTiles(floorPositions);
        WallGenerator.CreateWalls(floorPositions, tileMapVisualizer);
    }

    private void CreateCoridors(HashSet<Vector2Int> floorPositions)
    {
        var currentPosition = startPosition;

        for (int i = 0; i < corridorCount; i++)
        {
            var coridor = ProceduralGenerationAlgorithems.RandomWalkCorridor(currentPosition, coridorLength);
            currentPosition = coridor[coridor.Count - 1];
            floorPositions.UnionWith(coridor);
        }
    }
}
