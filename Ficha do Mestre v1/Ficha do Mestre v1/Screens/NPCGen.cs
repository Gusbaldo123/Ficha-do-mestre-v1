using Ficha_do_Mestre_v1.Informations;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha_do_Mestre_v1
{
    public partial class NPCGen : Form
    {

        NPC npc;
        public NPCGen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GenerateNPC();
        }

        private void bt_Generate_Click(object sender, EventArgs e)
        {
            GenerateNPC();
        }
        private void bt_Copy_Click(object sender, EventArgs e)
        {
            string txtToCopy = $"{npc.breed} {npc.sex}\nAparência: {npc.hair}, {npc.eye}; {npc.job} e {npc.personality}\nÚnicas: ";
            for (int i = 0; i < npc.unique.Length; i++)
            {
                txtToCopy += npc.unique[i];
                if (i < npc.unique.Length-1) txtToCopy += ", ";
            }

            Clipboard.SetText(txtToCopy);
        }
        public void GenerateNPC()
        {
            Random rnd = new Random();
            npc = new NPC(rnd);

            txt_Breed.Text = npc.breed + " " + npc.sex;
            txt_Hair.Text = (npc.hair);
            txt_Eye.Text = (npc.eye);
            txt_Personality.Text = (npc.personality);
            txt_Job.Text = (npc.job);
            txt_Unique.Text = "";
            foreach (string unique in npc.unique)
            {
                txt_Unique.Text += (unique) + Environment.NewLine;
            }

            lbl_NPCLvl.Text = "Level "+npc.lvl.ToString();
            lbl_NPCStr.Text = npc.statuses[0].percentageGain.ToString();
            lbl_NPCDex.Text = npc.statuses[1].percentageGain.ToString();
            lbl_NPCInt.Text = npc.statuses[2].percentageGain.ToString();
            lbl_NPCWis.Text = npc.statuses[3].percentageGain.ToString();
            lbl_NPCArm.Text = npc.statuses[4].percentageGain.ToString();
            lbl_NPCCon.Text = npc.statuses[5].percentageGain.ToString();
            lbl_NPCLuk.Text = npc.statuses[6].percentageGain.ToString();
            lbl_NPCFai.Text = npc.statuses[7].percentageGain.ToString();
        }
        class NPC
        {
            public string sex, hair, eye, breed, personality, job;
            public string[] unique;
            bool isWoman;

            List<Option> sexList, hairList, eyeList, breedList, personalityList, jobList, uniqueList;
            public List<Status> statuses { get; private set; }
            public int lvl { get; private set; }
            Random rnd;
            public NPC(Random _rnd)
            {
                rnd = _rnd;
                GenerateVisuals();
                GenerateStatuses();
            }

            void GenerateVisuals()
            {
                string jsonString = File.ReadAllText(@"../../Informations/NPCOption.json");
                dynamic JsonParsed = JObject.Parse(jsonString);
                dynamic JsonMaterials = JsonParsed.NPCOption;

                sexList = new List<Option>();
                foreach (var sexOption in JsonMaterials.sexList)
                    sexList.Add(new Option((string)sexOption, 1));

                sex = GenerateOption(sexList);
                isWoman = sex == "Mulher" ? true : false;

                breedList = new List<Option>();
                foreach (var breedOption in JsonMaterials.breedList)
                    breedList.Add(new Option((string)breedOption.name, (int)breedOption.quantity));
                breed = GenerateOption(breedList);
                breed = breed.Replace("(o)", isWoman?"":"o").Replace("(a)", isWoman ? "a" : "");

                hairList = new List<Option>();
                foreach (var hairOption in JsonMaterials.hairList)
                    hairList.Add(new Option((string)hairOption.name, (int)hairOption.quantity));

                if (breed == "Draconat" + (isWoman ? "a" : "o"))
                    hair = "Careca";
                else hair = GenerateOption(hairList);

                eyeList = new List<Option>();
                foreach (var eyeOption in JsonMaterials.eyeList)
                    eyeList.Add(new Option((string)eyeOption.name, (int)eyeOption.quantity));
                eye = GenerateOption(eyeList);

                personalityList = new List<Option>();
                foreach (var personalityOption in JsonMaterials.personalityList)
                    personalityList.Add(new Option((string)personalityOption.name, (int)personalityOption.quantity));
                personality = GenerateOption(personalityList);

                jobList = new List<Option>();
                foreach (var jobOption in JsonMaterials.jobList)
                    jobList.Add(new Option((string)jobOption.name, (int)jobOption.quantity));
                job = GenerateOption(jobList);
                job = job.Replace("(o)", isWoman ? "" : "o").Replace("(a)", isWoman ? "a" : "");

                uniqueList = new List<Option>();
                foreach (var uniqueOption in JsonMaterials.uniqueList)
                    uniqueList.Add(new Option((string)uniqueOption, 1));
                int length = rnd.Next(2, 4);
                unique = new string[length];
                for (int i = 0; i < length; i++)
                {
                    string generate = GenerateOption(uniqueList);
                    generate = generate.Replace("(o)", isWoman ? "" : "o").Replace("(a)", isWoman ? "a" : "");
                    unique[i] = generate;
                }
            }
            void GenerateStatuses()
            {
                statuses = new List<Status>()
                {
                    new Status(0, (ItemStatus)0),
                    new Status(0, (ItemStatus)1),
                    new Status(0, (ItemStatus)2),
                    new Status(0, (ItemStatus)3),
                    new Status(0, (ItemStatus)4),
                    new Status(0, (ItemStatus)5),
                    new Status(0, (ItemStatus)6),
                    new Status(0, (ItemStatus)7),
                };

                lvl = new Random().Next(1, 30);
                int lvlUse = lvl + 15;

                var random = new Random();

                while (lvlUse > 0)
                {
                    lvlUse--;
                    statuses[random.Next(0, statuses.Count)].percentageGain += 1;
                }
            }
            string GenerateOption(List<Option> options)
            {
                List<Option> optFill = new List<Option>();
                foreach (Option opt in options)
                {
                    for (int i = 0; i < opt.prob; i++)
                    {
                        optFill.Add(opt);
                    }
                }
                int rng = rnd.Next(optFill.Count);

                return optFill[rng].type;
            }
        }
        public class Option
        {
            public Option(string _type, int _prob)
            {
                type = _type;
                prob = _prob;
            }
            public string type;
            public int prob;
        }
    }
}
