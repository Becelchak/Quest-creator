using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : ScriptableObject
{
    [SerializeField] private GameObject nameObject;
    [SerializeField] private bool Limited;
    [SerializeField] private int LimitedCount;

    [SerializeField] private int RequiredForQuest;
    [SerializeField] private bool FalseTarget;
}
