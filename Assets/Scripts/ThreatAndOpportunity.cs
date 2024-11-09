using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Other objects/ ThreatAndOpportunity")]
public class ThreatAndOpportunity : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private Type typeObject;

    //Воздействие на затраты времени
    [SerializeField] private double changeTimeAction;
    //Влияние на количество
    [SerializeField] private double changeCount;
    // Инструмент НА
    [SerializeField] private InanimateObject neutralizer;
    // Коэффицент воздействия на влияние УВ ???
    [SerializeField] private double changeUV;
    //Коэффицент на вероятность появления
    [SerializeField] private double probability;
    // Персонаж воздействия
    [SerializeField] private GameObject trigger;




    public enum Type{
        threat = 0,
        opportunity = 1,
    }
}
