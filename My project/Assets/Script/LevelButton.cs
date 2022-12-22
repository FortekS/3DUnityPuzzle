using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public LevelSelectMenu menu;

    public Sprite lockSprite;

    public Text levelText;

    public GameObject levelStarPrefabs;

    private int level = 0;

    private Button button;

    private Image image;

    private LevelStar levelStar;
    
    void OnEnable()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
        levelStar = Instantiate(levelStarPrefabs, gameObject.transform).GetComponent<LevelStar>();
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Setup(int level, int star, bool isUnlock)
    {
        this.level = level;
        levelText.text = level.ToString();

        if(isUnlock)
        {
            image.sprite = null;
            button.enabled = true;
            levelText.gameObject.SetActive(true);
            levelStar.SetStarSprite(star);
            levelStar.gameObject.SetActive(true);
        }
        else
        {
            image.sprite = lockSprite;
            button.enabled = false;
            levelText.gameObject.SetActive(false);
            levelStar.gameObject.SetActive(false);
        }
    }

    public void OnClick()
    {
        menu.StartLevel(level);
    }

}
