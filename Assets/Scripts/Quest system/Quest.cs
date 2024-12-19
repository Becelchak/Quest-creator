using AYellowpaper.SerializedCollections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest system/ Quest")]
public class Quest : ScriptableObject
{
    // Квесты параметры
    [SerializeField] private string name;
    [SerializeField] private string description;
    [SerializeField] private int hourInDay;

    // Локации квеста
    [SerializeField] private List<Location> locations = new List<Location>();

    // Персонажи квеста
    [SerializeField] private List<Human> characters = new List<Human>();

    // Цели заказчиков квеста
    [SerializeField] private List<Target> targets = new List<Target>();

    // Задачи квеста
    [SerializeField] private List<Task> tasks = new List<Task>();
    //[SerializeField] private List<Action> works = new List<Action>();

    // Инструменты квеста
    [SerializeField] private List<InanimateObject> tools = new List<InanimateObject>();

    // УВ квеста (не требуют задачи)
    [SerializeField] private List<ThreatAndOpportunity> UV = new List<ThreatAndOpportunity>();

    // Вопросы для квеста
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
