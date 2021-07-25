using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Some_object : MonoBehaviour
{
	[Inject]
	private IInfo info;

	[Inject(Id = "ID-TEST-TEXT")]
	private string text;

	[Inject(Id = "ID-TEST-NUM")]
	private int num;
	
	[Inject(Id = "ID-PREFAB-TEXT")]
	private string pref_text;

	[Inject(Id = "ID-PREFAB-NUM")]
	private int pref_num;

	// Start is called before the first frame update
	void Start()
    {
        //info.Set_num(69);
  //      Debug.Log(info.Get_num());
		//Debug.Log(text);


		for(int i = 0; i < num; i++)
		{
			Debug.Log(text);
		}
		
		for(int i = 0; i < pref_num; i++)
		{
			Debug.Log(pref_text);
		}

	}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(info.Get_num());
    }
}
