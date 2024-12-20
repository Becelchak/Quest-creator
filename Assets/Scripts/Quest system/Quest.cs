using AYellowpaper.SerializedCollections;
using System.Collections;
using System.Collections.Generic;
using System.Text;
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
    [SerializeField] private QuestionTable questions;

    // ??
    //[SerializeField] private string customer;
    //[SerializeField] private string target;
    //[SerializeField] private double deadline;

    public Quest(string name, string description, int hours, List<Location> locations, List<Target> targets, List<Task> tasks, List<InanimateObject> tools, List<ThreatAndOpportunity> UV, QuestionTable questions)
    {
        this.name = name;
        this.description = description;
        hourInDay = hours;
        this.locations = locations;
        this.targets = targets;
        this.tasks = tasks;
        this.tools = tools;
        this.UV = UV;
        this.questions = questions;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetStringHours()
    {
        return $"�������� ���� {hourInDay} �����";
    }

    public string GetStringLocations()
    {
        var strBuild = new StringBuilder();
        foreach (var location in locations)
        {
            strBuild.Append($"{location.ToString()};");
        }
        return $"����������� � ��������� ��������:{strBuild.ToString()}";
    }

    public string GetStringTasks()
    {
        var strBuild = new StringBuilder();
        foreach (var task in tasks)
        {
            strBuild.Append($"{task.ToString()};");
        }
        return $"������ � ������ ������:{strBuild.ToString()}";
    }

    public string GetStringTargets()
    {
        var strBuild = new StringBuilder();
        foreach (var target in targets)
        {
            strBuild.Append($"{target.ToString()};");
        }
        return $"���� � ������ ������:{strBuild.ToString()}";
    }

    public string GetStringTools()
    {
        var strBuild = new StringBuilder();
        foreach (var tool in tools)
        {
            strBuild.Append($"{tool.ToString()};");
        }
        return $"����������� � ������ ������:{strBuild.ToString()}";
    }

    public string GetStringTAO()
    {
        var strBuild = new StringBuilder();
        foreach (var itemUV in UV)
        {
            strBuild.Append($"{itemUV.ToString()};");
        }
        return $"������/�����������:{strBuild.ToString()}";
    }
}
