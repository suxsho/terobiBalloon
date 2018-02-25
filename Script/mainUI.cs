using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

//主界面UI
public class mainUI : MonoBehaviour {
    public GameObject socres;           //把UI中的scores拖进来
    public GameObject gameoverUI;       //拖入gameoverUI

    //HP替换功能
    public GameObject hp1, hp2, hp3;
    public Sprite hp0;

    // Use this for initialization
    void Start () {
        //让失败按钮消失于屏幕
        gameoverUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(9999, 9999);
        //按钮功能
        List<string> btnsName = new List<string>();

        btnsName.Add("overBtn");

        foreach (string btnName in btnsName)
        {
            GameObject btnObj = GameObject.Find(btnName);
            Button btn = btnObj.GetComponent<Button>();
            btn.onClick.AddListener(delegate ()
            {
                this.OnClick(btnObj);
            });
        }
    }

    public void OnClick(GameObject sender)
    {
        switch (sender.name)
        {
            case "overBtn":
                if (gameConfig.hp <= 0)
                {
                    ballFly.speedY = 1;
                    gameoverUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(9999, 9999);
                    gameConfig.hp = 3;
                    gameConfig.scores = 0;
                    SceneManager.LoadScene("main");
                }
                    
                break;
        }
    }

                // Update is called once per frame
        void Update () {
        socres.GetComponent<Text>().text = gameConfig.scores.ToString();
        gameOverMode();
        HPMode();

    }

    //gameover功能
    void gameOverMode()
    {
        if(gameConfig.hp <= 0)
        gameoverUI.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -18.6f);
    }

    //HP功能
    void HPMode()
    {
        if (gameConfig.hp == 2)
            hp3.GetComponent<Image>().sprite = hp0;

        if (gameConfig.hp == 1)
        {
            hp2.GetComponent<Image>().sprite = hp0;
        }
        if (gameConfig.hp == 0)
        {
            hp1.GetComponent<Image>().sprite = hp0;
        }
    }
}
