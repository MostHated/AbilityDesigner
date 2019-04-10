﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MB.AbilityDesigner.Phases
{
    [PhaseIcon("{SkinIcons}Condition")]
    [PhaseCategory("Shared Variables")]
    [DefaultSubInstanceLinkOnly]
    public class CompareSharedGameObject : Phase
    {
        public SharedGameObject m_InputValue;
        public GameObject m_CompareValue;

        protected override Result OnUpdate()
        {
            if (m_InputValue != null)
            {
                return Result.Fail;
            }
            return m_InputValue.Value == m_CompareValue ? Result.Success : Result.Fail;
        }

        // Does not need any cache or reset
        protected override void OnCache()
        {
        }

        protected override void OnReset()
        {
        }
    }
}