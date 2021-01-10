using UnityEngine;

// 已有卡牌情况
[Serializable]
public class CardEntity{
    public string name;
    public int number;
}

// 存档数据
[Serializable]
public class SaveEntity
{
    public int points;
    public List<CardEntity> cards;

    //转化为json格式
    public string ToJson () {
        return JsonUtility.ToJson(entity);
    }

    //读取自json格式
    public static SaveEntity fromJson(string text) {
        return JsonUtility.FromJson<SaveEntity>(text);
    }
}
