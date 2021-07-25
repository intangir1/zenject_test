using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greeter
{
    public void Greet(Signal_test signal_test)
	{
		Debug.Log(signal_test.greeting);
	}
}
