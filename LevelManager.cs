using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    
	public static LevelManager main;

	public Transform startPoint;
	public Transform[] path;

	public int currency;

	[SerializeField] private int startingCurrency = 100;

	private void Awake() {
		main = this;
	}

	private void Start() {
		currency = startingCurrency;
	}

	public void IncreaseCurrency(int amount) {
		currency += amount;
	}

	public bool SpendCurrency(int amount) {
		if (amount <= currency){
			currency -= amount;
			return true;
		} else {
			Debug.Log("You do not have enough to purchase this item");
			return false;
		}
	}

}
