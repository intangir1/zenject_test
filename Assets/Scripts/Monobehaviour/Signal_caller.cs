using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Signal_caller : MonoBehaviour
{
    [Inject]
    SignalBus signal;

    // Start is called before the first frame update
    void Start()
    {
		signal.Fire(new Signal_test()
		{
			greeting = "Works!"
		});


		signal.Fire(new Signal_test_nums()
        {
            msg = "sup?",
            count = 4
        });

    }


}
