using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(menuName = "Tables/ AnimalTable")]
public class AnimalTable : ScriptableObject
{
    [SerializeField] private List<Animal> table;

    public void AddAnimal(string assetName)
    {
        var animalNew = AssetDatabase.LoadAssetAtPath<Animal>($"Assets/Scripts/Other/Animal/{assetName}.asset");
        if (!table.Contains(animalNew))
        {
            table.Add(animalNew);
        }
    }

    public List<Animal> GetTable() { return table; }
}
