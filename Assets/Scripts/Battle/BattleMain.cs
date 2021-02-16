using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMain : BattleBase
{

    protected int _sceneTask;

    // Use this for initialization
    void Start()
    {
        // 配置するプレハブの読み込み 
        GameObject prefab = (GameObject)Resources.Load("Objects/GrassTile");
        // 配置元のオブジェクト指定 
        GameObject stageObject = GameObject.FindWithTag("Stage");
        // タイル配置
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {

                Vector3 tile_pos = new Vector3(
                    0 + prefab.transform.localScale.x * i,
                    0,
                    0 + prefab.transform.localScale.z * j

                  );

                if (prefab != null)
                {
                    // プレハブの複製 
                    GameObject instant_object =
                      (GameObject)GameObject.Instantiate(prefab,
                                                          tile_pos, Quaternion.identity);
                    // 生成元の下に複製したプレハブをくっつける 
                    instant_object.transform.parent = stageObject.transform;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}