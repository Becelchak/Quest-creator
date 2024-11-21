using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

[CreateAssetMenu(menuName = "Other objects/ InanimateObject")]
public class InanimateObject : ScriptableObject
{
    [SerializeField] private string name;
    // ����������� ��� ������������� ������
    [SerializeField] private InanimateType inanimateType;
    // � ����� �������� ���������?
    [SerializeField] private List<Location> locations;

    // ����� �������� ����
    [SerializeField] private Action? action;
    // ��� �������� �����-���� ��������
    [SerializeField] private double buffCoefficient;

    // ����� ������?
    [SerializeField] private ThreatAndOpportunity? threat;
    // ����� �����������?
    [SerializeField] private ThreatAndOpportunity? opportunity;

    // ?????
    //[SerializeField] private double probability;

    //����� �������� �������
    [SerializeField] private Action? needAction;
    // ������� �������� ��� 1 ��� 2?
    [SerializeField] private int slots;
    // ������� �������� � ������?
    [SerializeField] private int numberOfAvailable;

    public InanimateObject(string name, InanimateType type, List<Location> locations, Action? action, double buffCoefficient, ThreatAndOpportunity? threat, ThreatAndOpportunity? opportunity, Action? needAction, int slots, int numberOfAvailable)
    {
        this.name = name;
        this.inanimateType = type;
        this.locations = locations;
        this.action = action;
        this.buffCoefficient = buffCoefficient;
        this.threat = threat;
        this.opportunity = opportunity;
        this.needAction = needAction;
        this.slots = slots;
        this.numberOfAvailable = numberOfAvailable;
    }

    public string GetName()
    {
        return name;
    }

    public string GetAction()
    {
        return action != null ? $"������ �� �������� {action.ToString()}" : "�� ������ �� ��������";
    }

    public string GetNeedAction()
    {
        return needAction != null ? $"������� �������� {needAction.ToString()}" : "";
    }

    public double GetCoefficient()
    {
        return buffCoefficient;
    }

    public string GetOpportunity()
    {
        return opportunity != null ? $"���� ����������� {opportunity.ToString()}" : "�� �������� ������������";
    }

    public string GetThreat()
    {
        return threat != null ? $"����� � ���� ���� {threat.ToString()}" : "�� ����� � ���� �����";
    }

    public List<Location> GetLocations()
    {
        return locations;
    }

    public int GetSlotSize()
    {
        return slots;
    }

    // ?????
    //public double GetProbability()
    //{
    //    return probability;
    //}

    public enum InanimateType
    {
        Calculable = 0,
        Uncountable = 1,
    }
}
