using Zenject;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal_listener : IInitializable, IDisposable
{
	readonly SignalBus signal;

	public Signal_listener(SignalBus _signal)
	{
		signal = _signal;
	}

	public void Initialize()
	{
		signal.Subscribe<Signal_test_nums>(Speak);
	}


	public void Dispose()
	{
		signal.Unsubscribe<Signal_test_nums>(Speak);
	}

	private void Speak(Signal_test_nums args)
	{
		int count = args.count;
		string msg = args.msg;

		for(int i = 0; i < count; i++)
		{
			Debug.Log(msg);
		}
	}

	
}
