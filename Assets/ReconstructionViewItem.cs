﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class for reconstruction view from JSON
[Serializable]
public class ReconstructionViewItem
    {
    public ReconstructionCamera[] views;
    }



[Serializable]
public class ReconstructionCamera
{
    public float[] position;
    public float[] rotation;
    public bool estimated;
    public int imageid;
}