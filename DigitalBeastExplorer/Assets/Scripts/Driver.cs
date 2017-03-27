using UnityEngine;
using System.Collections.Generic;
/************
*日期：2017.3.17
*作者：chenfuling
*功能：游戏驱动器
*************/
public class Driver : MonoBehaviour 
{
    private static Driver m_sInstance;

    void Awake()
    {
        m_sInstance = this;
        Application.targetFrameRate = 60;
    }
	void Start ()
	{
	
	}
	void Update () 
	{
	
	}
}
