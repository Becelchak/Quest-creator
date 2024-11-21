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
    // Продуктивность действия
    [SerializeField] private double toolProductivity;
    // Затраты времени на выполнение действия
    [SerializeField] private double timeRequired;

    // Условие для добычи
    [SerializeField] private InanimateObject? toolCondition;
    // Нейтрализатор
    [SerializeField] private InanimateObject? toolNeutralizer;
    [SerializeField] private double toolNeutralizerProductivity;
    [SerializeField] private double toolNeutralizerTimeRequired;
    //Условие для использования инструмента нейтрализатора
    [SerializeField] private InanimateObject? toolNeutralizerCondition;
    // Условие вместе с персонажем
    [SerializeField] private Human? сondition;

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
