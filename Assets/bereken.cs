using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class bereken : MonoBehaviour {


	public InputField getal1;
	public InputField getal2;

	int welke = 0;

	public void plus()
	{

		welke = 1;

	}

	public void min()
	{
		welke = 2;
	}


	public void keer()
	{
		welke = 3;

	}




	public void bereken_som()
	{

		String de_getal1_text = getal1.text;
		String de_getal2_text = getal2.text;
	


		int de_getal1_nummer = int.Parse (de_getal1_text);
		int de_getal2_nummer = int.Parse (de_getal2_text);

		int som_plus = de_getal1_nummer + de_getal2_nummer;


		if (welke == 1) {
			print (som_plus);
		} else {
			print("Kies een operator");
		}



	}




}
