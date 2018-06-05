using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class Quest
    {
        public int Id { get; set; }
        public string Description { get; set; }             //description of quest that goes into journal  
        public string QuestName { get; set; }               //Name of the quest - to journal
        public double QuestXp { get; set; }                 //base Xp reward for completing
        public double QuestMoneyReward { get; set; }        //base money reward for completing
        public double StaminaRequirement { get; set; }      //calculate stamina required

        public bool Completed { get; set; }

        public Quest(string _qdescription, string _qname, double _qxp, double _qmoney, double _stamReq)
        {
            Description = _qdescription;
            QuestName = _qname;
            QuestXp = _qxp;
            QuestMoneyReward = _qmoney;
            StaminaRequirement = _stamReq;
        }

        public void CompleteQuest()
        {
            Completed = true;
        }
    }
}
