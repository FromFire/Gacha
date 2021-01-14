using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    // 个人存档
    static public SaveEntity saveEntity;
    // 卡集信息
    static public CardsInfoEntity cardsInfoEntity;
    // 是否已被初始化过
    static bool isInited = false;

    // Start is called before the first frame update
    void Start()
    {
        // 防止多次初始化
        if(!isInited) {
            Load();
            isInited = true;
        }
    }

    // 加载数据
    static public void Load() {
        // 读取存档文件
        string savePath = "Save/save";
        TextAsset text = Resources.Load<TextAsset>(savePath);
        string json = text.text;
        saveEntity = SaveEntity.fromJson(json);

        // 读取CardsInfo
        string cardsInfoPath = "Save/CardsInfo";
        text = Resources.Load<TextAsset>(cardsInfoPath);
        json = text.text;
        cardsInfoEntity = CardsInfoEntity.fromJson(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
