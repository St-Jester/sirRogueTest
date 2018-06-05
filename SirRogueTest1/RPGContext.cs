using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RPGClassLibrary;

namespace SirRogueTest1
{
    public class RPGContext:DbContext
    {
        public DbSet<Quest> Quests { get; set; }
    }
}
