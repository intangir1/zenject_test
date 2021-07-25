using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : IInfo
{
    private int test = 123454321;

	public int Get_num()
	{
		return test;
	}

	public void Set_num(int _num)
	{
		test = _num;
	}
}
