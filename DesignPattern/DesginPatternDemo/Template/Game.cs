﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Game
    {
        public void Play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        }

        public abstract void Initialize();

        public abstract void StartPlay();

        public abstract void EndPlay();

    }
}