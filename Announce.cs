using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoreAudio;

namespace TOBU_Railway
{
    internal class Announce
    {
        static bool playing = true;
        public static void DoAnnounce(string trackNum, string type, string dest, string carsNum)
        {
            List<string> announceWord = ["まもなく"];
            string voiceFolderName = "voices";

            // 番線に
            announceWord.Add(trackNum + "番線に");
            announceWord.Add(type);
            announceWord.Add(dest + "行きが");
            announceWord.Add(carsNum + "両編成で");
            announceWord.Add("参ります");
            announceWord.Add("wait 600");
            announceWord.Add("安全のため");
            announceWord.Add("黄色い点字ブロックの後ろまで"); 
            announceWord.Add("お下がりください");

            Player player = new Player();
            player.PlaybackFinished += Player_PlaybackFinished;
            foreach (string word in announceWord)
            {
                if(word.Contains("wait"))
                {
                    Thread.Sleep(int.Parse(word.Split(" ")[1]));
                } else
                {
                    player.Play(Path.Combine(voiceFolderName, word) + ".wav");
                    playing = true;
                    Console.WriteLine("{0}を再生中", word + ".wav");
                    while (playing)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine("waiting");
                    }
                }
            }
        }

        public static void Player_PlaybackFinished(object? sender, EventArgs e)
        {
            playing = false;
        }
    }
}
