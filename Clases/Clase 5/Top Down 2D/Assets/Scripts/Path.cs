﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDown.AI{
    public enum PathType{
        pingpong,
        loop
    }
    public class Path : MonoBehaviour{
        
        public List<Vector3> points;

        public bool isClose = false;
        public PathType type = PathType.loop;

        // Start is called before the first frame update
        void Start()
        {
            points = new List<Vector3>();

            foreach (Transform child in transform)
            {
                points.Add(child.position);
            }
        }


        void OnDrawGizmos()
        {
            Gizmos.color = Color.blue;

            Vector3 from;
            Vector3 to;

            for (int i = 1; i < transform.childCount; i++)
            {
                from = transform.GetChild(i - 1).position;
                to = transform.GetChild(i).position;
                Gizmos.DrawLine(from, to);

            }

            if (isClose)
            {
                from = transform.GetChild(transform.childCount - 1).position;
                to = transform.GetChild(0).position;
                Gizmos.DrawLine(from, to);
            }


            //from = transform
        }
    }
}
