using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEditor;
using UnityEngine;
using AYellowpaper.SerializedCollections;
using UnityEngine.UI;
using static InanimateObject;

public class ObjectCreatorButtonCreate : MonoBehaviour
{
    //[SerializeField] private TMP_Dropdown dropdownType;
    [SerializeField] private HumanTable humanTable;
    [SerializeField] private HumanTable characters;
    [SerializeField] private AnimalTable animals;
    [SerializeField] private ActionTable actions;
    [SerializeField] private QuestionsTable questionsTable;
    [SerializeField] private ToolsTable toolNeutralizationTable;
    [SerializeField] private ToolsTable toolTable;

    //Common
    [Header("Common")]
    [SerializeField] private string nameObject;
    [SerializeField] private List<Action> listActions = new List<Action>();
    [SerializeField] private bool isTarget;
    [SerializeField] private bool isTO;
    [SerializeField] private bool isFalseTarget;

    // Human
    [Header("Human")]
    [SerializeField] private SerializedDictionary<string, InanimateObject?> slots;
    [SerializeField] private InanimateObject toolNeutralization;
    [SerializeField] private bool isCharacter;
    [SerializeField] private List<Quest> quests = new List<Quest>();
    [SerializeField] private bool isCustomer;

    // Animal
    [Header("Animal")]
    [SerializeField] private ThreatAndOpportunity? TAO;

    // InanimateObject
    [Header("InanimateObject")]
    [SerializeField] private InanimateType inanimateType;
    [SerializeField] private List<Location> locations;
    [SerializeField] private Action? action;
    [SerializeField] private double buffCoefficient;
    [SerializeField] private ThreatAndOpportunity? threat;
    [SerializeField] private ThreatAndOpportunity? opportunity;
    [SerializeField] private Action? needAction;
    [SerializeField] private int slotsRequire;
    [SerializeField] private int numberOfAvailable;


    public void CreateObject(TMP_Dropdown dropdownType)
    {
        var typeObject = dropdownType.options[dropdownType.value].text;
        switch (typeObject)
        {
            case "Человек":

                //var tool = AssetDatabase.LoadAssetAtPath<InanimateObject>($"Assets/Scripts/Other/InanimateObject/Ножницы.asset");
                //var toolN = AssetDatabase.LoadAssetAtPath<InanimateObject>($"Assets/Scripts/Other/InanimateObject/Палка.asset");
                //SerializedDictionary<string, InanimateObject?> touple = new() { {"Slot 1", tool }, { "Slot 2", tool} };


                var newHuman = new Human(nameObject, listActions, slots, toolNeutralization, isCharacter, quests, isCustomer, isTarget, isTO, isFalseTarget);
                var newObj = ScriptableObject.CreateInstance<Human>();

                newObj = newHuman;

                if(AssetDatabase.LoadAssetAtPath<Human>($"Assets/Scripts/Other/Human/{newObj.GetName()}.asset") == null && newObj.IsCharacter() != "Это персонаж")
                {
                    AssetDatabase.CreateAsset(newObj, $"Assets/Scripts/Other/Human/{newObj.GetName()}.asset");
                    AssetDatabase.SaveAssets();
                    humanTable.AddHuman(newObj.GetName());
                }
                else if(AssetDatabase.LoadAssetAtPath<Human>($"Assets/Scripts/Other/Character/{newObj.GetName()}.asset") == null && newObj.IsCharacter() == "Это персонаж")
                {
                    AssetDatabase.CreateAsset(newObj, $"Assets/Scripts/Other/Character/{newObj.GetName()}.asset");
                    AssetDatabase.SaveAssets();
                    characters.AddHuman(newObj.GetName());
                }
                break;
            case "Животное":
                var newAnimal = new Animal(nameObject,listActions, TAO, isTarget, isTO, isFalseTarget);
                var newObj2 = ScriptableObject.CreateInstance<Animal>();
                newObj2 = newAnimal;

                if (AssetDatabase.LoadAssetAtPath<Animal>($"Assets/Scripts/Other/Animal/{newObj2.GetName()}.asset") == null)
                {
                    AssetDatabase.CreateAsset(newObj2, $"Assets/Scripts/Other/Animal/{newObj2.GetName()}.asset");
                    AssetDatabase.SaveAssets();
                    animals.AddAnimal(newObj2.GetName());
                }
                break;
            case "Неживой объект":
                var newInanimateObject = new InanimateObject(nameObject, inanimateType, locations, action, buffCoefficient, threat, opportunity, needAction, slotsRequire, numberOfAvailable);
                var newObj3 = ScriptableObject.CreateInstance<InanimateObject>();
                newObj3 = newInanimateObject;

                if (AssetDatabase.LoadAssetAtPath<InanimateObject>($"Assets/Scripts/Other/Animal/{newObj3.GetName()}.asset") == null)
                {
                    AssetDatabase.CreateAsset(newObj3, $"Assets/Scripts/Other/Animal/{newObj3.GetName()}.asset");
                    AssetDatabase.SaveAssets();
                    toolTable.AddObject(newObj3.GetName());
                }
                break;
            case "Локация":
                break;
            case "Угроза или возможность":
                break;
            case "Работа (Действие)":
                break;
            default:
                break;
        }
    }

    public void ChangeName(TMP_InputField newName)
    {
        nameObject = newName.text;
    }

    public void AddAction(TMP_Dropdown dropdown)
    {
        var nameAction = dropdown.options[dropdown.value].text;

        foreach (var action in actions.GetTable())
        {
            if (nameAction == action.GetName())
                listActions.Add(action);
        }
    }

    public void AddQuestAvialable(TMP_Dropdown dropdown)
    {
        var nameQuest = dropdown.options[dropdown.value].text;

        foreach (var quest in questionsTable.GetTable())
        {
            if (nameQuest == quest.GetName())
                quests.Add(quest);
        }
    }

    public void ToggleCharacter(Toggle point)
    {
        if (point.isOn)
        {
            isCharacter = true;
        }
        else
            isCharacter = false;
    }

    public void ToggleCustomer(Toggle point)
    {
        if (point.isOn)
        {
            isCustomer = true;
        }
        else
            isCustomer = false;
    }

    public void ToggleTO(Toggle point)
    {
        if (point.isOn)
        {
            isTO = true;
        }
        else
            isTO = false;
    }

    public void ToggleTarget(Toggle point)
    {
        if (point.isOn)
        {
            isTarget = true;
        }
        else
            isTarget = false;
    }

    public void ToggleFalseTarget(Toggle point)
    {
        if (point.isOn)
        {
            isFalseTarget = true;
        }
        else
            isFalseTarget = false;
    }

    public void ChangeSlot(ObjectCreatorSlots slotsInfo)
    {
        var fSlot = slotsInfo.GetFirstSlot();
        var sSlot = slotsInfo.GetSecondSlot();

        slots.Clear();
        slots.Add("Slot 1", fSlot.GetSelectObject());
        slots.Add("Slot 2", sSlot.GetSelectObject());
    }

    public void AddToolNeutralization(TMP_Dropdown dropdown)
    {
        var nameTool = dropdown.options[dropdown.value].text;

        foreach (var tool in toolNeutralizationTable.GetTable())
        {
            if (nameTool == tool.GetName())
                toolNeutralization = tool;
        }
    }
}
