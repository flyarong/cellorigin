﻿// Generated by github.com/davyxu/cellorigin UICodeGen
using UnityEngine;
using UnityEngine.UI;

public partial class CreateCharUI : MonoBehaviour
{
	void Awake( )
	{
		InitUI( );
        gameObject.SetActive(false);

        EventEmiiter.Instance.Add<Event.CreateChar>(ev =>
        {
            gameObject.SetActive(true);
        });
	}
	
	// Button @ SelectCharA
	void SelectCharA_Click( )
	{
	
	}
	
	// Button @ SelectCharB
	void SelectCharB_Click( )
	{
	
	}
	
	// Button @ CreateChar
	void CreateChar_Click( )
	{
	
	}
	
}