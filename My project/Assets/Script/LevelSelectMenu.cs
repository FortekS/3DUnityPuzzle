using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public int totalLevel = 0;

    public int unlockedLevel = 1;

    private LevelButton[] levelButtons;

    private int totalPage = 0;

    private int page = 0;

    private int pageItem = 9;

    //public GameObject nextButton;

    //public GameObject backButton;

    void OnEnable()
    {
        levelButtons = GetComponentsInChildren<LevelButton>();
    }

    void Start()
    {
        Refresh();
    }

    public void StartLevel(int level)
    {
        if(level==unlockedLevel)
        {
            unlockedLevel += 1;
        }

        int star =GetStar(level);
        star = Mathf.Clamp(star + 1, 0, 3);
        SetStar(level, star);
        Refresh();

    }

    public void ClickNext()
    {
        page += 1;
        Refresh();
    }

    public void ClickBack()
    {
        page -= 1;
        Refresh();
    }

    public void Refresh()
    {
        totalPage = totalLevel / pageItem;

        int index = page * pageItem;

        for(int i =0;i<levelButtons.Length;i++)
        {
            int level = index + i + 1;

            if(level<=totalLevel)
            {
                levelButtons[i].gameObject.SetActive(true);
                levelButtons[i].Setup(level, GetStar(level), level <= unlockedLevel);
            }
            else
                levelButtons[i].gameObject.SetActive(false);
                
        }

        CheckButton();
    }

    private void CheckButton()
    {
        //backButton.SetActive(page > 0);
        //nextButton.SetActive(page < totalPage);
    }

    private void SetStar(int level, int starAmount)
    {
        PlayerPrefs.SetInt(GetKey(level), starAmount);
    }

    private int GetStar(int level)
    {
        return PlayerPrefs.GetInt(GetKey(level));
    }

    private string GetKey(int level)
    {
        // 3 Ziro4ki
        return "Level_" + level + "_Star";
    }
}
