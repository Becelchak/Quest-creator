using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class ObjectCreatorItemListDropdownField : MonoBehaviour
{
    [SerializeField] private string NameSelectItem;
    [SerializeField] private GameObject prefabe;

    [SerializeField] private string pathFolder = "Assets/Scripts/Other/Quest system/Quests";
    private TMP_Dropdown dropdown;

    void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();

        var directory = new DirectoryInfo(pathFolder);
        var files = directory.GetFiles("*.asset");
        foreach(var file in files)
        {
            var name = file.Name.Split('.')[0];
            if(!name.Contains("Table"))
                dropdown.options.Add(new TMP_Dropdown.OptionData(name));
        }
    }
    void Update()
    {
        
    }

    public void AddItemInList()
    {
        NameSelectItem = dropdown.options[dropdown.value].text;

        var inst = GameObject.Instantiate(prefabe);
        var par = prefabe.transform.parent;
        var container = par.GetComponentInChildren<GridLayoutGroup>().gameObject;
        inst.name = NameSelectItem;
        inst.transform.SetParent(container.transform);

        inst.GetComponentInChildren<Text>().text = NameSelectItem;

        var canvasGroupe = inst.GetComponent<CanvasGroup>();
        canvasGroupe.alpha = 1;
        canvasGroupe.blocksRaycasts = true;
        canvasGroupe.interactable = true;

    }
}
