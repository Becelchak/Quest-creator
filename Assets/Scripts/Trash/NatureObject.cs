using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Other objects/ NatureObject(old)")]
public class NatureObject : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private Action needAction;
    [SerializeField] private ThreatAndOpportunity? risk;
    [SerializeField] private List<Location> locations;


    public string GetName()
    {
        return name;
    }

    public string GetAction()
    {
        return needAction != null ? $"������� �������� {needAction.ToString()}" : "";
    }

    public string GetRisk()
    {
        return risk != null ? $"��� ������ ����� ���� {risk.ToString()}" : "�� ����� ����� ��� ������";
    }

    public List<Location> GetLocations()
    {
        return locations;
    }
}
