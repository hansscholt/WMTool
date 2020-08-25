using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORLDMAXTOOL
{
    public static class Mission
    {
        public static MissionData[] allMissionData;
       

        public static void ReadMisson(byte[] enc)
        {
            List<MissionData> allMission = new List<MissionData>();
            //List<string> idLists = new List<string>();
            //List<int> idListi = new List<int>();
            //andamiro usa una especie de JSON propio, no me voy a calentar en eso simplemente leeré linea por linea
            string[] lines = File.ReadAllLines("other/misson.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "\t*NX_MISSION" && lines[i + 1] == "\t{")
                {
                    //if (lines[i + 7] == "\t\tTYPE\t\t\"일반\"" || //normal
                    //    lines[i + 7] == "\t\tTYPE\t\t\"중간보스\"" || //subboss
                    //    lines[i + 7] == "\t\tTYPE\t\t\"보스\"" ||
                    //    lines[i + 7] == "\t\tTYPE\t\t\"Hidden\"")   //boss                    

                    if (!lines[i + 6].StartsWith("\t\tMILEAGE\t\t0") || lines[i+15].StartsWith("\t\tNAME\t\t\"PhantomOS\""))                  
                    {
                        //buscar
                        if (lines[i + 20].StartsWith("\t\tSTEP"))
                        {
                            string sType = "thefuck";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"일반\"")
                                sType = "NORMAL";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"중간보스\"")
                                sType = "SUBBOSS";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"보스\"")
                                sType = "BOSS";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"Hidden\"")
                                sType = "HIDDEN";

                            int iId = int.Parse(lines[i + 20].Substring(11, 3));
                            string sID = lines[i + 20].Substring(9, 5);
                            string sLand = lines[i + 16].Replace("\t\tLAND\t\t\"", string.Empty);
                            sLand = sLand.Replace("\"", string.Empty);
                            string sName = lines[i + 15].Replace("\t\tNAME\t\t\"", string.Empty);
                            sName = sName.Replace("\"", string.Empty);

                            MissionData mAdd = new MissionData();
                            mAdd.sType = sType;
                            mAdd.iId = iId;
                            mAdd.sId = sID;
                            mAdd.sLand = sLand;
                            mAdd.sName = sName;

                            mAdd.bClear = false;
                            mAdd.bPass = false;

                            int iBaseM = 384;
                            int iBaseI = 5504;

                            //pasar todas(o casi todas)

                            mAdd.bClear = enc[iBaseM + iId] != 0 ? true : false;
                            mAdd.bPass = enc[iBaseI + (iId * 4)] >= 3 ? true : false;

                            //if (mAdd.bClear)
                            //    mAdd.bPass = true;

                            allMission.Add(mAdd);
                        }
                    }
                }
            }
            allMission.RemoveAt(631);//N
            allMission.RemoveAt(631);
            allMission.RemoveAt(631);

            allMission.RemoveAt(632);//W
            allMission.RemoveAt(632);
            allMission.RemoveAt(632);

            allMission.RemoveAt(633);//S
            allMission.RemoveAt(633);
            allMission.RemoveAt(633);

            allMission.RemoveAt(634);//E
            allMission.RemoveAt(634);

            allMissionData = allMission.ToArray();
        }
    }

    public struct MissionData
    {
        public string sType;
        public int iId;
        public string sId;
        public string sLand;
        public string sName;
        public bool bPass;
        public bool bClear;
    }
}
