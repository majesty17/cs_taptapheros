using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;

namespace cs_taptapheros
{
    class Hero
    {
        //static string HeroFile = @"Heros.json";

        public static Hero FromJSON<Hero>(string input)
        {
            try
            {
                return JsonConvert.DeserializeObject<Hero>(input);
            }
            catch (Exception ex)
            {
                return default(Hero);
            }
        }

        public static List<Hero> FromJSONArr<Hero>()
        {
            try
            {
                string input = Resource.HEROS;
                return JsonConvert.DeserializeObject<List<Hero>>(input);
            }
            catch (Exception ex)
            {
                return default(List<Hero>);
            }
        }

        public Color getColor()
        {
            if (camp == "联盟") return Color.DeepSkyBlue;
            if (camp == "部落") return Color.OrangeRed;
            if (camp == "精灵") return Color.DarkOrchid;
            if (camp == "不死") return Color.ForestGreen;
            if (camp == "天堂") return Color.Gold;
            if (camp == "地狱") return Color.SlateGray;


            return Color.White;
        }


        /// <summary>
        /// 阿尔题吗
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 天堂
        /// </summary>
        public string camp { get; set; }
        /// <summary>
        /// 牧师
        /// </summary>
        public string major { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int stars { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int maxlvl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int score { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Status status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SkillsItem> skills { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string howtoget { get; set; }
    }



    public class Status
    {
        /// <summary>
        /// 
        /// </summary>
        public int hp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int att { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int speed { get; set; }
    }

    public class SkillsItem
    {
        /// <summary>
        /// 星爆II
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 主动
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 后排xxxxx
        /// </summary>
        public string info { get; set; }
    }


}
