using System;
using System.IO;
using System.Text;

namespace achievementsystem{
    public class AchievementHandler{
        public string CreateAchievement(string name, string a){
            string path = "achievements/" + name + ".txt";
            using(StreamWriter sw = File.CreateText(path)){
                sw.Write(a);
            }
            return a;
        }
        public string ReadAchievements(){
            StringBuilder sb = new StringBuilder();
            foreach (string txtName in Directory.GetFiles("achievements/","*.txt"))
            {
                using (StreamReader sr = new StreamReader(txtName))
                {
                    sb.AppendLine("|========"+txtName.ToString()+"========|");
                    sb.Append(" "+sr.ReadToEnd());
                    sb.AppendLine();
                    sb.AppendLine();   
                }
            }
            return sb.ToString();
        }
        public void MarkAsCompleted(string name){
            StringBuilder sb = new StringBuilder();
            string text = string.Empty;
            foreach(string txtName in Directory.GetFiles("achievements/","*.txt")){
                string path = "achievements/" + name + ".txt";
                var n = Path.GetFileName(txtName);
                if(name+".txt" == n){
                    using(StreamReader sr = new StreamReader(txtName)){
                        text = (sr.ReadToEnd() + " -- COMPLETED AT -- " + DateTime.Now);
                    }
                }
                if(text != string.Empty){
                    using(StreamWriter sw = File.CreateText(path)){
                        sw.Write(text);
                    }
                }
            }
        }
    }
}