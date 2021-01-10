using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    SaveEntity saveEntity;

    // Start is called before the first frame update
    void Start()
    {
        // 设置不销毁
        
        // 读取存档文件
        string savePath = "Save/save";
        TextAsset text = Resources.Load<TextAsset>(savePath);
        string json = text.text;
        saveEntity = SaveEntity.fromJson(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
