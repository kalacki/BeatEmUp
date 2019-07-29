using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunchButton : MonoBehaviour
{
    public Button button;
    Player p;
    void Start()
    {
        p = FindObjectOfType<Player>();
        button.onClick.AddListener(TaskOnClick);
    }
    private void Update()
    {

    }

    void TaskOnClick()
    {
        p.anim.SetTrigger("Attack");
    }
}
