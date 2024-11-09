using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Other objects/ Animal")]
public class Animal : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private List<Action> actions = new List<Action>();
    [SerializeField] private ThreatAndOpportunity? risk;
    [SerializeField] private bool isTarget;
    // ��� ��?
    [SerializeField] private bool isTO;
    [SerializeField] private bool isFalseTarget;

    public string GetName()
    {
        return name;
    }

    public List<Action> GetActions()
    {
        return actions;
    }

    public string GetRisk()
    {
        return risk != null ? risk.ToString() : "��� ������";
    }
}
