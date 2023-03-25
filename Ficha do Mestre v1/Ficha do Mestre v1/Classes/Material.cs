using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Collections.Specialized;
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
        public Material(string t_itemName, bool t_isEffectPassive, string t_effectCost, string t_effectName, string t_itemEffect, List<Status> t_statuses, ItemSlot t_itemSlot, ItemQuality t_itemQuality)
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
        bool error = false;
        public MaterialList()
        {
            materialList = new List<Material>();
            GetAllItems();

            //string jsonString = File.ReadAllText(@"../../Informations/MaterialList.json");
            dynamic JsonMaterials = JObject.Parse(responseString);

            if (error) return;

            try
            {
                string message = JsonMaterials.data;
                error = true;
            }
            catch
            {
                InsertIntoList(JsonMaterials.data);
            }
        }
        void InsertIntoList(dynamic materialPart)
        {
            string RemoveSpaces(string strExtraSpaces)
            {
                if (strExtraSpaces == null) return "";
                while (strExtraSpaces[strExtraSpaces.Length - 1] == ' ')
                {
                    strExtraSpaces = strExtraSpaces.Remove(strExtraSpaces.Length - 1, 1);
                }
                return strExtraSpaces;
            }

            foreach (var material in materialPart)
            {
                string itemName = RemoveSpaces((string)material.itemname);

                string? itemEffect = RemoveSpaces((string)material.itemeffecteffecttext), effectCost = RemoveSpaces((string)material.itemeffecteffectcost), effectName = RemoveSpaces((string)material.itemeffecteffectname);
                if (itemEffect == null) itemEffect = "";
                if (effectCost == null) effectCost = "";
                if (effectName == null) effectName = "";

                bool isEffectPassive = material.itemeffectiseffectpassive;
                List<Status> statuses = new List<Status>();
                ItemSlot itemSlot = material.itemslot;
                ItemQuality itemQuality = (ItemQuality)material.itemquality;

                float[] gainStatus = new float[] { (float)material.gainstr, (float)material.gaindex, (float)material.gainint, (float)material.gainwis, (float)material.gainarm, (float)material.gaincon, (float)material.gainluk, (float)material.gainfai };

                for (int i = 0; i < gainStatus.Length; i++)
                {
                    statuses.Add(new Status(gainStatus[i], (ItemStatus)i));
                }
                materialList.Add(new Material(itemName, isEffectPassive, effectCost, effectName, itemEffect, statuses, itemSlot, itemQuality));
            }
        }
        public static List<Material> materialList = new List<Material>();

        public string responseString;


        public void GetAllItems()
        {
            //Insert(new Material("Bronze Helmet",false,null,null,null, new List<Status> { new Status(0, (ItemStatus)0), new Status(0, (ItemStatus)1), new Status(0, (ItemStatus)2), new Status(0, (ItemStatus)3), new Status(0, (ItemStatus)4), new Status(0, (ItemStatus)5), new Status(0, (ItemStatus)6), new Status(0, (ItemStatus)7) };, ItemSlot.Head, ItemQuality.Common));
            //Update(1, new Material("Bronze Helmet", false, null, null, null, statuses, ItemSlot.Head, ItemQuality.Rare));
            //Select(1);

            //Apagar daqui
            {
                {
                    var statuses = new List<Status> {
                    new Status(-0.1f, ItemStatus.Strength),
                    new Status(0.5f, ItemStatus.Dexterity),
                    new Status(0.1f, ItemStatus.Intelligence),
                    new Status(0f, ItemStatus.Wisdom),
                    new Status(0.35f, ItemStatus.Armor),
                    new Status(0.15f, ItemStatus.Constitution),
                    new Status(0f, ItemStatus.Luck),
                    new Status(-0.1f, ItemStatus.Faith) };

                    //Insert(new Material("Flechas de Manari", true, null, "Pedra encantada", "Ao atirar, regenere 3 Mp pelos próximos 2 turnos. Set Bônus(3 peças): Regenere 10+10%Mp atual", statuses, ItemSlot.Collar, ItemQuality.Rare));
                }
            }
            //Até aqui

            SelectAll();
            //Delete(2);
        }
        void Select(int id)
        {
            using (var wb = new WebClient())
            {
                var Request = new NameValueCollection();
                Request["class"] = "RpgItemList";
                Request["method"] = "Select";
                Request["id"] = id.ToString();

                Request["itemName"] = "";
                Request["itemQuality"] = "";
                Request["itemSlot"] = "";
                Request["itemEffectisEffectPassive"] = "";

                Request["itemEffecteffectCost"] = "";
                Request["itemEffecteffectName"] = "";
                Request["itemEffecteffectText"] = "";

                Request["gainStr"] = "";
                Request["gainDex"] = "";
                Request["gainInt"] = "";
                Request["gainWis"] = "";
                Request["gainArm"] = "";
                Request["gainCon"] = "";
                Request["gainLuk"] = "";
                Request["gainFai"] = "";

                var response = wb.UploadValues("http://gusbaldo.com/RpgItemList/Rest.php", "POST", Request);
                responseString = Encoding.UTF8.GetString(response);
            }
        }
        void SelectAll()
        {
            if (error) return;
            using (var wb = new WebClient())
            {
                var Request = new NameValueCollection();
                Request["class"] = "RpgItemList";
                Request["method"] = "SelectAll";
                Request["id"] = "0";

                Request["itemName"] = "";
                Request["itemQuality"] = "";
                Request["itemSlot"] = "";
                Request["itemEffectisEffectPassive"] = "";

                Request["itemEffecteffectCost"] = "";
                Request["itemEffecteffectName"] = "";
                Request["itemEffecteffectText"] = "";

                Request["gainStr"] = "";
                Request["gainDex"] = "";
                Request["gainInt"] = "";
                Request["gainWis"] = "";
                Request["gainArm"] = "";
                Request["gainCon"] = "";
                Request["gainLuk"] = "";
                Request["gainFai"] = "";

                var response = wb.UploadValues("http://gusbaldo.com/RpgItemList/Rest.php", "POST", Request);
                responseString = Encoding.UTF8.GetString(response);
            }
        }
        void Insert(Material material)
        {
            if (error) return;
            using (var wb = new WebClient())
            {
                var Request = new NameValueCollection();
                Request["class"] = "RpgItemList";
                Request["method"] = "Insert";
                Request["id"] = "0";

                Request["itemName"] = material.itemName;
                Request["itemQuality"] = ((int)material.itemQuality).ToString();
                Request["itemSlot"] = ((int)material.itemSlot).ToString();

                Request["itemEffectisEffectPassive"] = material.isEffectPassive.ToString();
                Request["itemEffecteffectCost"] = material.effectCost != null ? material.effectCost : null;
                Request["itemEffecteffectName"] = material.effectName != null ? material.effectName : null;
                Request["itemEffecteffectText"] = material.itemEffect != null ? material.itemEffect : null;

                string[] txts = new string[] { "gainStr", "gainDex", "gainInt", "gainWis", "gainArm", "gainCon", "gainLuk", "gainFai" };

                for (int i = 0; i < material.statuses.Count; i++)
                {
                    string val = material.statuses[i].percentageGain.ToString();
                    string removal = val.Replace("f", "").Replace(",", ".");

                    Request[txts[i]] = removal;
                }

                var response = wb.UploadValues("http://gusbaldo.com/RpgItemList/Rest.php", "POST", Request);
                responseString = Encoding.UTF8.GetString(response);
            }
        }
        void Update(int id, Material material)
        {
            using (var wb = new WebClient())
            {
                var Request = new NameValueCollection();
                Request["class"] = "RpgItemList";
                Request["method"] = "Update";
                Request["id"] = id.ToString();

                Request["itemName"] = material.itemName;
                Request["itemQuality"] = ((int)material.itemQuality).ToString();
                Request["itemSlot"] = ((int)material.itemSlot).ToString();

                Request["itemEffectisEffectPassive"] = material.isEffectPassive.ToString();
                Request["itemEffecteffectCost"] = material.effectCost != null ? material.effectCost : null;
                Request["itemEffecteffectName"] = material.effectName != null ? material.effectName : null;
                Request["itemEffecteffectText"] = material.itemEffect != null ? material.itemEffect : null;

                string[] txts = new string[] { "gainStr", "gainDex", "gainInt", "gainWis", "gainArm", "gainCon", "gainLuk", "gainFai" };

                for (int i = 0; i < material.statuses.Count; i++)
                {
                    string val = material.statuses[i].percentageGain.ToString();
                    string removal = val.Replace("f", "");

                    Request[txts[i]] = removal;
                }

                var response = wb.UploadValues("http://gusbaldo.com/RpgItemList/Rest.php", "POST", Request);
                responseString = Encoding.UTF8.GetString(response);
            }
        }
        void Delete(int id)
        {
            using (var wb = new WebClient())
            {
                var Request = new NameValueCollection();
                Request["class"] = "RpgItemList";
                Request["method"] = "Delete";
                Request["id"] = id.ToString();

                Request["itemName"] = "";
                Request["itemQuality"] = "";
                Request["itemSlot"] = "";
                Request["itemEffectisEffectPassive"] = "";

                Request["itemEffecteffectCost"] = "";
                Request["itemEffecteffectName"] = "";
                Request["itemEffecteffectText"] = "";

                Request["gainStr"] = "";
                Request["gainDex"] = "";
                Request["gainInt"] = "";
                Request["gainWis"] = "";
                Request["gainArm"] = "";
                Request["gainCon"] = "";
                Request["gainLuk"] = "";
                Request["gainFai"] = "";

                var response = wb.UploadValues("http://gusbaldo.com/RpgItemList/Rest.php", "POST", Request);
                responseString = Encoding.UTF8.GetString(response);
            }
        }
    }
}