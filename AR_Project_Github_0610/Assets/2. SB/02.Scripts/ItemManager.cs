using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    //1. ��ٸ��� Ÿ�� ���踦 �Դ´�
    //2. ���踦 �԰� ���� ����
    //3. ���� ���� �������ڸ� ���´�.
    //4. �������ڸ� ���, ��ٸ��� Ÿ�� , �������ڸ� ���´�. => ��� �����̱�
    //5. �������ڸ� Ÿ�� �ٸ��� �ǳʸ� ������ �Դ´�
    //6. ������ ������ �ٽ� �����ͼ� �翡 ������ ���´�?
    //7. ������ �翡 ������ �ᳪ���� �ڶ�� �ִϸ��̼�? ������ �Ͼ��.

    public static ItemManager instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] bool isKey;    //���踦 �Ծ��°�
    [SerializeField] bool isSeed;   //������ �Ծ��°�
    [SerializeField] bool isLadder; //��ٸ�
    [SerializeField] bool isWoodPlank; //�������ڸ� ��Ҵ°�
    [SerializeField] bool isDoor;    //���� �����°�
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
