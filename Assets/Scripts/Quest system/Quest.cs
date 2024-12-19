using AYellowpaper.SerializedCollections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest system/ Quest")]
public class Quest : ScriptableObject
{
    // ������ ���������
    [SerializeField] private string name;
    [SerializeField] private string description;
    [SerializeField] private int hourInDay;

    // ������� ������
    [SerializeField] private List<Location> locations = new List<Location>();

    // ��������� ������
    [SerializeField] private List<Human> characters = new List<Human>();

    // ���� ���������� ������
    [SerializeField] private List<Target> targets = new List<Target>();

    // ������ ������
    [SerializeField] private List<Task> tasks = new List<Task>();
    //[SerializeField] private List<Action> works = new List<Action>();

    // ����������� ������
    [SerializeField] private List<InanimateObject> tools = new List<InanimateObject>();

    // �� ������ (�� ������� ������)
    [SerializeField] private List<ThreatAndOpportunity> UV = new List<ThreatAndOpportunity>();

    // ������� ��� ������
    [SerializeField] private List<QuestionTable> questions = new List<QuestionTable>();

    // ??
    //[SerializeField] private string customer;
    //[SerializeField] private string target;
    //[SerializeField] private double deadline;

    public string GetName()
    {
        return name;
    }
}
