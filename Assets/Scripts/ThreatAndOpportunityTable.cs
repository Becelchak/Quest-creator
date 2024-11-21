using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Tables/ ThreatAndOpportunityTable")]
public class ThreatAndOpportunityTable : ScriptableObject
{
    [SerializeField] private List<ThreatAndOpportunity> table;
    public void AddLocation(string assetName)
    {
        var ThreatAndOpportunityNew = AssetDatabase.LoadAssetAtPath<ThreatAndOpportunity>($"Assets/Scripts/Other/ThreatAndOpportunity/{assetName}.asset");
        if (!table.Contains(ThreatAndOpportunityNew))
        {
            table.Add(ThreatAndOpportunityNew);
        }

    }

    public ThreatAndOpportunity GetObject(string assetName)
    {
        foreach (ThreatAndOpportunity obj in table)
        {
            if (obj.name == assetName)
            {
                return obj;
            }
        }

        return null;
    }

    public List<ThreatAndOpportunity> GetTable() { return table; }
}
