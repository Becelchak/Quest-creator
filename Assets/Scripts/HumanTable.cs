using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Tables/ HumanTable")]
public class HumanTable : Table
{
    [SerializeField] private List<Human> table;

    public void AddHuman(string assetName)
    {
        var humanNew = AssetDatabase.LoadAssetAtPath<Human>($"Assets/Scripts/Other/Human/{assetName}.asset");
        if(!table.Contains(humanNew))
        {
            table.Add(humanNew);
        }
    }

    public List<Human> GetTable() { return table; }
}
