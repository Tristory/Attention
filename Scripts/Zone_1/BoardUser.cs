using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardUser : MonoBehaviour
{
    public Player player;
    public BattleTrigger battleTrigger;
    public GameObject distractorBoard, saveBoard;

    void Start()
    {
        player = GetComponent<Player>();  
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(player.distractors.Count > 0)
            {
                battleTrigger = player.distractors[0].gameObject.GetComponent<BattleTrigger>();

                if(battleTrigger.isDangerous)
                {
                    battleTrigger.LoadBattle();
                }
                else
                {
                    distractorBoard.GetComponent<DistractorBoard>().playerStatus = player.playerStatus;
                    distractorBoard.GetComponent<DistractorBoard>().distractor = (PropertyD)player.distractors[0];

                    distractorBoard.SetActive(!distractorBoard.activeInHierarchy);
                }                
            }
        }
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            saveBoard.SetActive(!saveBoard.activeInHierarchy);
        }
    }
}
