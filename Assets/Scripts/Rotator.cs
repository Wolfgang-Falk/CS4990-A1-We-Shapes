/* ****************************************************
 * File:		Rotator
 * Purpose:		To constantly rotate Pick Up
 * Programmer:	Wade Falk
 * Date:		September 24th, 2020
 *************************************************** */

using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{

	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime);
	} // end Update ()
} // end Rotator
