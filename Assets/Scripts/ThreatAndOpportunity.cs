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
    [SerializeField] private GameObject trigger;




    public enum Type{
        threat = 0,
        opportunity = 1,
    }
}
