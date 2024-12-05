using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Other objects/ ThreatAndOpportunity")]
public class ThreatAndOpportunity : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private Type typeObject;

    //����������� �� ������� �������
    [SerializeField] private double changeTimeAction;
    //������� �� ����������
    [SerializeField] private double changeCount;
    // ���������� ��
    [SerializeField] private InanimateObject neutralizer;
    // ���������� ����������� �� ������� �� ???
    [SerializeField] private double changeUV;
    //���������� �� ����������� ���������
    [SerializeField] private double probability;
    // �������� �����������
    [SerializeField] private ScriptableObject trigger;


    public ThreatAndOpportunity(string name, Type typeObject, double changeTimeAction, double changeCount, InanimateObject neutralizer, double changeUV, double probability, ScriptableObject trigger)
    {
        this.name = name;
        this.typeObject = typeObject;
        this.changeTimeAction = changeTimeAction;
        this.changeCount = changeCount;
        this.neutralizer = neutralizer;
        this.changeUV = changeUV;
        this.probability = probability;
        this.trigger = trigger;
    }
    public string GetName()
    {
        return name;
    }

    public enum Type{
        threat = 0,
        opportunity = 1,
    }
}
