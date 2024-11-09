using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Other objects/ ArtificalObject(old)")]
public class ArtificalObject : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private Action? action;
    [SerializeField] private double buffCoefficient;
    [SerializeField] private ThreatAndOpportunity? riskTarget;

    public string GetName()
    {
        return name;
    }

    public string GetAction()
    {
        return action != null ? $"������ �� �������� {action.ToString()}" : "�� ������ �� ��������";
    }

    public double GetCoefficient()
    {
        return buffCoefficient;
    }

    public string GetRisk()
    {
        return riskTarget != null ? $"������������ ���� {riskTarget.ToString()}" : "�� �������� ���������������";
    }
}
