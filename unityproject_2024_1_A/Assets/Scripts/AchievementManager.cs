using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour
{
    public static AchievementManager instance;
    public List<Achievement> achievements;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddProgress(string achivementName, int amount)
    {
        Achievement achievement = achievements.Find(a => a.name == achivementName);
        if(achievement !=null)
        {
            achievement.AddProgress(amount);
        }
    }

}
