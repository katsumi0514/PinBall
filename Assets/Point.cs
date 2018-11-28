using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Point : MonoBehaviour {
	public Text ScoreText;
	private int score = 0; 

	void Start()
	{
		score = 0;
		SetScore ();  
	}

		void OnCollisionEnter( Collision other )
		{
			string yourTag  = other.gameObject.tag;

			if( yourTag == "SmallStarTag" )
			{
				score += 100;
			}
			else if(yourTag == "LargeStarTag"){

				score += 200;
			}

			SetScore();
		}

	void SetScore(){
	ScoreText.text = string.Format( "Score:{0}", score );
		}
	}
