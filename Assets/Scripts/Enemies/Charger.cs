﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AI_OOP_GUI
{


    public class Charger : Enemy
    {
        [Header("Charger")]
        public float impactForce = 10f;
        public float knockback = 5f;

        private Rigidbody chargerRigid;

        protected override void Awake()
        {
            base.Awake();
        }
        protected override void Attack()
        {
            //Add force to selfs
            chargerRigid.AddForce(transform.forward * knockback, ForceMode.Impulse);
        }


        void OnCollisionEnter(Collision col)
        {
            //if collision hits player
            if (col.gameObject != null && gameObject.tag == "Player")
            {
                Rigidbody r = col.collider.GetComponent<Rigidbody>();
                // Add impactForce to player
                r.AddForce(transform.forward * impactForce, ForceMode.Impulse);
            }


        }

    }
}
