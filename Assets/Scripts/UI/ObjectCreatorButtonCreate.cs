using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEditor;
using UnityEngine;
using AYellowpaper.SerializedCollections;

public class ObjectCreatorButtonCreate : MonoBehaviour
{
    //[SerializeField] private TMP_Dropdown dropdownType;
    [SerializeField] private HumanTable humanTable;
    [SerializeField] private HumanTable characters;
    [SerializeField] private ActionTable actions;

    // Human
    [SerializeField] private string nameObject;
    [SerializeField] private List<Action> listActions = new List<Action>();
    [SerializeField] private SerializedDictionary<string, InanimateObject?> slots;
    [SerializeField] private InanimateObject toolNeutralization;
    [SerializeField] private bool isCharacter;
    [SerializeField] private List<Quest> quests = new List<Quest>();
    [SerializeField] private bool isCustomer;
    [SerializeField] private bool isTarget;
    [SerializeField] private bool isTO;
    [SerializeField] private bool isFalseTarget;



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

                if(AssetDatabase.LoadAssetAtPath<Human>($"Assets/Scripts/Other/Human/{newObj.GetName()}.asset") == null && newObj.IsCharacter() == "Это персонаж")
                {
                    AssetDatabase.CreateAsset(newObj, $"Assets/Scripts/Other/Human/{newObj.GetName()}.asset");
                    AssetDatabase.SaveAssets();
                    humanTable.AddHuman(newObj.GetName());
                }
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
}
