using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //1. 사다리를 타고 열쇠를 먹는다
    //2. 열쇠를 먹고 문을 연다
    //3. 문을 열고 나무판자를 집는다.
    //4. 나무판자를 잡고, 사다리를 타고 , 나무판자를 놓는다. => 잡고 움직이기
    //5. 나무판자를 타고 다리를 건너면 씨앗을 먹는다
    //6. 씨앗을 가지고 다시 내려와서 밭에 씨앗을 놓는다?
    //7. 씨앗을 밭에 놓으면 콩나무가 자라는 애니메이션? 연출이 일어난다.

    public static ItemManager instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] bool isKey;    //열쇠를 먹었는가
    [SerializeField] bool isSeed;   //씨앗을 먹었는가
    [SerializeField] bool isLadder; //사다리
    [SerializeField] bool isWoodPlank; //나무판자를 잡았는가
    [SerializeField] bool isDoor;    //문을 열었는가
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
