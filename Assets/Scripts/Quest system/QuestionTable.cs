using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quest system/ QuestionTable")]
public class QuestionTable : Table
{
    public int ID;
    public List<Quest> Questions;

    public Quest GetQuest(int id)
    {
        return Questions[id];
    }

    public List<Quest> GetTable()
    {
        return Questions;
    }
}
