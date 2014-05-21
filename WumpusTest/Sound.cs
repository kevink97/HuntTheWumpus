using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WumpusTest
{    public enum Continuous {background,trivia, menu, carnivalBackground}
     public enum soundEffects{bats, wumpusClown, movingForward, fallIntoPit, victory, babysneeze}
    class Sound
    {
        private WMPLib.WindowsMediaPlayer soundEffectsPlayer;

        public  Sound() { 
            this.soundEffectsPlayer = new WMPLib.WindowsMediaPlayer();
           
            
        }
    
        // Start background music
        // Enum for multiple sound effects: menu, bats, wumpus, moving forward, falling into pit, victory 
        // Pause background music
        // play sound method enum, no return

        // when playing background, stop, and play again.

        // if statements, set URL filenames
        public void playSound(soundEffects shortsound){
          
            if (shortsound == soundEffects.bats){
                soundEffectsPlayer.URL = "chimes.wav";
            }

            if (shortsound == soundEffects.wumpusClown){
                soundEffectsPlayer.URL = "tada.wav";
            }

            if (shortsound == soundEffects.babysneeze) {
                soundEffectsPlayer.URL = "babysneeze";
            }


        }

        public void playBackgroundMusic(Continuous background){
            
            if (background == Continuous.carnivalBackground){
                soundEffectsPlayer.URL = "carnivalBackground";
            }
        
        }

        // 

    }
}
