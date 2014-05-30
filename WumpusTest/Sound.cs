using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{    public enum Continuous {background,trivia, menu}
     public enum soundEffects{ChipmunksBats, EvilLaughWumpusNear, AngryWumpusFar, movingForward, JellyFishDoors, FallIntoPit, ShootArrow, lost}
    class Sound
    {
       
       // private WMPLib.WindowsMediaPlayer soundEffectsPlayer;
       //public  Sound() { 
       //  this.soundEffectsPlayer = new WMPLib.WindowsMediaPlayer();   
       //}

        public void playSound(soundEffects shortsound){
          
            if (shortsound == soundEffects.ChipmunksBats){
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("ChipmunksBats.wav");
                player.Play();
                //soundEffectsPlayer.URL = "ChipmunksBats.wav";
            } else if (shortsound == soundEffects.EvilLaughWumpusNear){
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("EvilLaugh.wav");
                player.Play();
       
            } else if (shortsound == soundEffects.AngryWumpusFar)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Anger.wav");
                player.Play();

            }else if (shortsound == soundEffects.JellyFishDoors)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("JumpBounce.wav");
                player.Play();

            }else if (shortsound == soundEffects.movingForward)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("largeBubble.wav");
                player.Play();
               
            }else if (shortsound == soundEffects.FallIntoPit)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Fall.wav");
                player.Play();
             
            }else if (shortsound == soundEffects.ShootArrow)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("ShootArrow.wav");
                player.Play();
               
            } else if (shortsound == soundEffects.lost){
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("lost.wav");
                player.Play();
                
            }
          
        }

         WMPLib.WindowsMediaPlayer Player;

        public void PlayFile(String url)
        {
        Player = new WMPLib.WindowsMediaPlayer();
        Player.URL = url;
        Player.controls.play();
        }

         private void button10_Click(object sender, System.EventArgs e) {
             Player.URL = "Metal Gear Solid 4 - Encounter - Extension (Background).wav";
        }

    }
    }

