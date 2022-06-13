using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climbing : MonoBehaviour
{
    /*// State 설정 하기
    public enum LiftState
    {
        Ready,
        Movingup,
        Movingdown,
        Up
    }
    public LiftState lState;
    void Start()
    {
     lState = LiftState.Ready;
    }
    private IEnumerator MovingUp()
    {
        yield return new WaitForSeconds(1f);
        this.transform.Translate(Vector2.up * 5 * Time.deltaTime);
        if (this.transform.position.y==5f)
        {
            lState = LiftState.Up;
        }
    }
    private IEnumerator MovingDown()
    {
        yield return new WaitForSeconds(1f);
        this.transform.Translate(Vector2.down * 5 * Time.deltaTime);
        if (this.transform.position.y <= 0f)
        {
            lState = LiftState.Ready;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (lState == LiftState.Movingup)
        {
            lState = LiftState.Movingup;
            this.transform.Translate(Vector2.up * 5 * Time.deltaTime);
            if (this.transform.position.y == 5f)
            {
                lState = LiftState.Up;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && lState == LiftState.Ready)
        {
            lState = LiftState.Movingup;
        }

        if (other.gameObject.tag == "Player" && lState == LiftState.Up)
        {
            lState = LiftState.Movingdown;
        }
    }*/
    public Transform desPos;
    public Transform startPos;
    public Transform endPos;
    public float speed;

    public float delay = 3.0f;
    private float currentDelay = 0.0f;

    private void Start()
    {
        transform.position = startPos.position;
        desPos = endPos;
    }

    private void FixedUpdate()
    {
        currentDelay -= Time.deltaTime;
        if (currentDelay < 0)
        {
            currentDelay = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, desPos.position, Time.deltaTime * speed);
        if (currentDelay > 0)
        {
            return;
        }
        if (Vector2.Distance(transform.position, desPos.position) <= 0.05f)
        {
            if (desPos == endPos)
            {
                desPos = startPos;
            }
            else desPos = endPos;
        }
 
        currentDelay = delay;
    }
}
