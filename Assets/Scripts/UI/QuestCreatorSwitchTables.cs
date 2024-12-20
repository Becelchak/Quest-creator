using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestCreatorSwitchTables : MonoBehaviour
{
    private TMP_Dropdown dropdown;
    [SerializeField] private CanvasGroup tempTable;
    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }

    public void Switch()
    {
        var nameTable = dropdown.options[dropdown.value].text;
        tempTable.alpha = 0;
        tempTable.interactable = false;
        tempTable.blocksRaycasts = false;

        switch (nameTable)
        {
            case "������� ������":
                var locations = GameObject.Find("LocationsTable");
                tempTable = locations.GetComponent<CanvasGroup>();
                break;
            case "���� ������":
                var targets = GameObject.Find("TargetTable");
                tempTable = targets.GetComponent<CanvasGroup>();
                break;
            case "������ ������":
                var tasks = GameObject.Find("TaskTable");
                tempTable = tasks.GetComponent<CanvasGroup>();
                break;
            case "����������� ������":
                var tools = GameObject.Find("ToolsTable");
                tempTable = tools.GetComponent<CanvasGroup>();
                break;
            case "������/����������� ������":
                var tao = GameObject.Find("TAOTable");
                tempTable = tao.GetComponent<CanvasGroup>();
                break;
            default:
                break;
        }

        tempTable.alpha = 1;
        tempTable.interactable = true;
        tempTable.blocksRaycasts = true;
    }
}
