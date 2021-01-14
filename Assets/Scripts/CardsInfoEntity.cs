using UnityEngine;
using System;
using System.Collections.Generic;

[Serializable]
public class CardsInfoEntity
{
    public List<SetsItem> sets;

    //转化为json格式
    public string ToJson () {
        return JsonUtility.ToJson(this);
    }

    //读取自json格式
    public static CardsInfoEntity fromJson(string text) {
        return JsonUtility.FromJson<CardsInfoEntity>(text);
    }
}

// 单个卡集
[Serializable]
public class SetsItem
{
    // 卡集名称，如“永远的七日之都”
    public string name;
    // 卡集路径
    public string path;
    // 图片尺寸
    public int size_x;
    public int size_y;
    // 等级信息，如 ["S", "A", "B", "C"]
    public List<string> rank;
}
