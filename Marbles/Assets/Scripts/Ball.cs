using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Transform aimingArrow;

    Rigidbody rg;


    [SerializeField] float power;
    [SerializeField] float powerAccelerator = 0.01f;
    [SerializeField] float maxPower = 10f;


    // Touch
    private Vector3 screenPoint;
    private Vector3 offset;

    void Start () {
        rg = GetComponent<Rigidbody>();
        ShowAimingArrow(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
        }

        if (Input.GetButton("Fire1")) {
        }

        if (Input.GetButtonUp("Fire1")) {
        }


        if (Input.GetKey(KeyCode.Space)) {
            AddPower();
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            RotateArrowRight();
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            RotateArrowLeft();
        }

	}

    public void AddPower() {
        if (power > maxPower)
        {
            power = maxPower;
        }
        power += powerAccelerator;
    }

    public void RotateArrowRight() {
        aimingArrow.Rotate(0, -1f, 0);
    }

    public void RotateArrowLeft() {
        aimingArrow.Rotate(0, 1f, 0);

    }

    private void FixedUpdate() {
        if (Input.GetKeyUp(KeyCode.Space)) {
            rg.AddForce(Vector3.forward * power * 10);
            power = 0;
        }
    }

    void ShowAimingArrow(bool _show){
        aimingArrow.gameObject.SetActive(_show);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Hole")
        {
            print("Victory");
        }
    }

}
