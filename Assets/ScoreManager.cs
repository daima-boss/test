using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public GameObject score_object = null; //Text�I�u�W�F�N�g
    public int score_num = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        //�e�L�X�g�̕\�������ւ���
        score_text.text = "Score" + score_num;
        score_num += 1; //�Ƃ肠�����P���Z�������Ă݂�
    }
}
