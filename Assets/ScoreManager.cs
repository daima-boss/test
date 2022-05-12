using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public GameObject score_object = null; //Textオブジェクト
    public int score_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトからTextコンポーネントを取得
        Text score_text = score_object.GetComponent<Text>();
        //テキストの表示を入れ替える
        score_text.text = "Score" + score_num;
        score_num += 1; //とりあえず１加算し続けてみる
    }
}
