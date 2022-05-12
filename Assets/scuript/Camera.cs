using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Camera : MonoBehaviour
{
    public static Camera Instance { get; private set; }

    // 現在のカメラ位置名
    public string CurrentPositionName { get; private set;}

    public GameObject ButtonLeft;
    public GameObject ButtonRight;
    public GameObject ButtonBack;
    
/// カメラ情報クラス
    private class CameraPositionInfo
    {
        /// 位置
        public Vector3 Position { get; set; }
        /// 角度
        public Vector3 Rotate { get; set; }
        /// 移動先
        public MoveNames MoveNames { get; set;}
    }

    // ボタン移動先
    private class MoveNames
    {
        // 左ボタンを押した時の位置
        public string Left { get; set; }
        // 右ボタンを押した時の位置
        public string Right { get; set; }
        // 戻るボタンを押した時の位置
        public string Back { get; set; }
    }

    // 全カメラ位置情報
    private Dictionary<string, CameraPositionInfo> _CameraPositionInfoes = new Dictionary<string, CameraPositionInfo>
    {
        {
            "Door", //位置名
            new CameraPositionInfo
            {
                Position = new Vector3(3,1.3f,-0.1f),
                Rotate = new Vector3(0,745,0),
                MoveNames = new MoveNames
                {
                    Left = "RoomLeft",
                    Right = "RoomRight",
                }
            }
        },
        {
            "RoomLeft", //位置名
            new CameraPositionInfo
            {
                Position = new Vector3(2.5f,1.3f,0.5f),
                Rotate = new Vector3(0,680,0),
                MoveNames = new MoveNames
                {
                    Right = "Door",
                }
            }
        },
        {
            "RoomRight", //位置名
            new CameraPositionInfo
            {
                Position = new Vector3(3,1,1),
                Rotate = new Vector3(0,830,0),
                MoveNames = new MoveNames
                {
                    Left = "Door",
                }
            }
        },
    };


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        ChangeCameraPosition("Door");
        
        ButtonBack.GetComponent<Button>().onClick.AddListener(() =>
        {
             ChangeCameraPosition(_CameraPositionInfoes[CurrentPositionName].MoveNames.Back);
        });
        ButtonLeft.GetComponent<Button>().onClick.AddListener(() =>
        {
             ChangeCameraPosition(_CameraPositionInfoes[CurrentPositionName].MoveNames.Left);
        });
        ButtonRight.GetComponent<Button>().onClick.AddListener(() =>
        {
             ChangeCameraPosition(_CameraPositionInfoes[CurrentPositionName].MoveNames.Right);
        });
    }

    // カメラ移動
    public void ChangeCameraPosition(string PositionName)
    {
        if (PositionName == null) return;

        CurrentPositionName = PositionName;

        GetComponent<Camera>().transform.position = _CameraPositionInfoes[CurrentPositionName].Position;
        GetComponent<Camera>().transform.rotation = Quaternion.Euler(_CameraPositionInfoes[CurrentPositionName].Rotate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
