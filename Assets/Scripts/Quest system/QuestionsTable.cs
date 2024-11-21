using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

[CreateAssetMenu(menuName = "Quest system/ QuestionsTable")]
public class QuestionsTable : ScriptableObject
{
    [SerializeField] private List<Quest> table;
    public List<Quest> GetTable() { return table; }
}
