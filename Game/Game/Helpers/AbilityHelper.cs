﻿using Game.Models;
using System;
using System.Collections.Generic;

namespace Game.Helpers
{
    /// <summary>
    /// Helper for ability functionality
    /// </summary>
    public static class AbilityHelper
    {
        public static void AddAbilitiesBasedOnJob(Dictionary<AbilityEnum, int> AbilityTracker, CharacterJobEnum job, int level)
        {
            if(AbilityTracker == null || level < 1)
            {
                return;
            }
            switch (job)
            {
                case CharacterJobEnum.Cleric:

                    foreach (var item in AbilityEnumHelper.GetListCleric)
                    {
                        if (AbilityTracker.ContainsKey(AbilityEnumHelper.ConvertStringToEnum(item)))
                        {
                            AbilityTracker[AbilityEnumHelper.ConvertStringToEnum(item)] += level;
                        }
                        else
                        {
                            AbilityTracker.Add(AbilityEnumHelper.ConvertStringToEnum(item), level);
                        }
                    }
                    break;

                case CharacterJobEnum.Fighter:
                    foreach (var item in AbilityEnumHelper.GetListFighter)
                    {
                        if (AbilityTracker.ContainsKey(AbilityEnumHelper.ConvertStringToEnum(item)))
                        {
                            AbilityTracker[AbilityEnumHelper.ConvertStringToEnum(item)] += level;
                        }
                        else
                        {
                            AbilityTracker.Add(AbilityEnumHelper.ConvertStringToEnum(item), level);
                        }
                    }
                    break;

                default:
                    foreach (var item in AbilityEnumHelper.GetListOthers)
                    {
                        if(AbilityTracker.ContainsKey(AbilityEnumHelper.ConvertStringToEnum(item)))
                        {
                            AbilityTracker[AbilityEnumHelper.ConvertStringToEnum(item)] += level;
                        }
                        else
                        {
                            AbilityTracker.Add(AbilityEnumHelper.ConvertStringToEnum(item), level);
                        }
                    }
                    break;
            }
        }
    }
}