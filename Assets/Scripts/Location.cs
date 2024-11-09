using AYellowpaper.SerializedCollections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Other objects/ Location")]
public class Location : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private bool isTarget;
    [SerializeField] private SerializedDictionary<Location,double> locationsDistance;
    //[SerializeField] private NaturesEvent naturesEvents;

    public string GetName()
    {
        return name;
    }

    public string IsTarget()
    {
        return isTarget == false ? "��� ������� �� �������� �����" : "��� ������� �������� �����";
    }

    public string GetLocationsDistance()
    {
        var listDistance = new List<string>();
        foreach (var kvp in locationsDistance)
        {
            listDistance.Add($"�� ������� {kvp.Key.GetName()} ��������� {kvp.Value}");
        }

        return string.Join("; ", listDistance);
    }
}