using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SimpleRandomWalkParameters " ,menuName = "PCG/SinmpleRandomWalkData")]
public class SimpleRandomWalkSO : ScriptableObject
{
    public int interations = 10, walkLength = 10;
    public bool startRandomlyEachIteration = true;

}
