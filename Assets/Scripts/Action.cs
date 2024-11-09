using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;

[CreateAssetMenu(menuName = "Other objects/ Action")]
public class Action : ScriptableObject
{
    [SerializeField] private List<InanimateObject> targetAction = new List<InanimateObject>();
    [SerializeField] private List<Location> locationsForWork = new List<Location>();
    [SerializeField] private string name;
    [SerializeField] private Human worker;
    [SerializeField] private InanimateObject tool;
    [SerializeField] private double toolProductivity;
    [SerializeField] private double timeRequired;

    // ������� ��� ������
    [SerializeField] private InanimateObject? toolStipulation;
    // �������������
    [SerializeField] private InanimateObject? toolNeutralizer;
    [SerializeField] private double toolNeutralizerProductivity;
    [SerializeField] private double toolNeutralizerTimeRequired;
    [SerializeField] private InanimateObject? toolNeutralizerStipulation;
    // ������� ������ � ����������
    [SerializeField] private Human? stipulation;

    [SerializeField] private double coefficient;

    public string GetName()
    {
        return name;
    }

    public List<InanimateObject> GetTargets()
    {
        return targetAction;
    }

    public double GetCoefficient()
    {
        return coefficient;
    }
}
