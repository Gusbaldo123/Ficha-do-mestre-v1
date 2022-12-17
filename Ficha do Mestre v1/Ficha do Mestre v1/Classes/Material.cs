using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ficha_do_Mestre_v1.Informations
{
    public enum ItemQuality { Common, Rare, Epic, Legendary, Divine }
    public enum ItemStatus { Strength, Dexterity, Intelligence, Wisdom, Armor, Constitution, Luck, Faith }
    public enum ItemSlot { Head, Torso, Leggings, Feet, Collar, HandSingle, HandDual }

    public class Status
    {
        public Status(float t_percentageGain, ItemStatus t_itemStatus)
        {
            percentageGain = t_percentageGain;
            itemStatus = t_itemStatus;
        }
        public float percentageGain;
        public ItemStatus itemStatus;
    }
    public class Material
    {
        public Material(string t_itemName, bool t_isEffectPassive, string t_effectCost, string t_effectName, string t_itemEffect, List<Status> t_statuses,ItemSlot t_itemSlot, ItemQuality t_itemQuality)
        {
            itemName = t_itemName;
            itemEffect = t_itemEffect;
            effectCost = t_effectCost;
            effectName = t_effectName;
            isEffectPassive = t_isEffectPassive;
            statuses = t_statuses;
            itemSlot = t_itemSlot;
            itemQuality = t_itemQuality;
        }
        public List<Status> statuses = new List<Status>();
        public ItemSlot itemSlot;
        public ItemQuality itemQuality;
        public bool isEffectPassive;
        public string itemName, effectCost, effectName, itemEffect;
    }

    public class MaterialList
    {
        public MaterialList()
        {
            string jsonString = File.ReadAllText(@"../../Informations/MaterialList.json");
            dynamic JsonMaterials = JObject.Parse(jsonString);

            foreach (var material in JsonMaterials.MaterialList)
            {
                string itemName = material.itemName;
                string itemEffect = material.itemEffect.effectText, effectCost = material.itemEffect.effectCost, effectName = material.itemEffect.effectName;
                bool isEffectPassive = material.itemEffect.isEffectPassive;
                List<Status> statuses = new List<Status>();
                ItemSlot itemSlot = (ItemSlot)material.itemSlot;
                ItemQuality itemQuality = (ItemQuality)material.itemQuality;

                for (int i = 0; i < Enum.GetNames(typeof(ItemStatus)).Length; i++)
                {
                    statuses.Add(new Status(0, (ItemStatus)i));
                }

                foreach (var materialStatuses in material.statuses)
                {
                    statuses[(int)materialStatuses.itemStatus] = new Status((float)materialStatuses.percentageGain, (ItemStatus)materialStatuses.itemStatus);
                }
                materialList.Add(new Material(itemName, isEffectPassive, effectCost, effectName, itemEffect, statuses, itemSlot, itemQuality));
            }
        }
        public static List<Material> materialList = new List<Material>();
    }
}