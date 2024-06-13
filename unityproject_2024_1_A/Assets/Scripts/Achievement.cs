using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Achievement
{
    public string name;
    public string description;
    public bool isUnlocked;
    public int currentProgress;
    public int goal;

    public Achievement(string name, string description, int goal)
    {
        this.name = name;
        this.description = description;
        this.isUnlocked = false;
        this.currentProgress = 0;
        this.goal = goal;
    }

    public void AddProgress(int amount)
    {
        if(!isUnlocked)
        {
            currentProgress += amount;

            if(currentProgress >=goal)
            {
                isUnlocked = true;
                OnAxhivementUnlocked();
            }
        }
    }

    protected virtual void OnAxhivementUnlocked()
    {
        Debug.Log($"업적달성:{name}");
    }
}
