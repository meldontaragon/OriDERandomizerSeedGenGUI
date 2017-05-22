using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicVisualAid
{
    enum LogicModes
    {
        normal, //"casual"
        speed,
        lure,
        dboost,
        dbash,
        hard, //"challenge"
        hard_lure,
        hard_dboost,
        timed_level,
        glitched,
        softlock,
        ability_point,
        mapstones,
        plants,
        extra_pickups
    }
    struct RequirementItem
    {
        
    }
    class Requirement
    {
        private LogicModes mode;
        private Item[] item_list;

        public LogicModes Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public Item[] ItemList
        {
            get { return item_list; }
            set { ItemList = value; }
        }
    }
}
