using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming3_Port1_MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Linked List and node initated.
        LinkedList<string> songList = new LinkedList<string>();
        LinkedListNode<string> currentSong;
         
        private void addSong_Click(object sender, EventArgs e)
        {
            getFile();  
            displaySongs();
        }
        // Button to allow user to play the first song in list.
        private void playFirst_Click(object sender, EventArgs e)
        {
            if (songList.First != null)
            { 
                playSongMethod(songList.First.Value); 
            }
            else { 
                MessageBox.Show("No songs are in the list."); 
            }
        }
        // Button to allow user to play the last song in list.
        private void playLast_Click(object sender, EventArgs e)
        {
            if (songList.Last != null)
            { 
                playSongMethod(songList.Last.Value); 
            }
            else { 
                MessageBox.Show("No songs are in the list."); 
            }
        }
        // Button to allow user to play the next song in list. If Null plays first song. If all Null display Error Message.
        private void playNext_Click(object sender, EventArgs e)
        {
            if (currentSong == null)
            {
                if (songList.First != null)
                { 
                    playSongMethod(songList.First.Value); 
                }
                else { MessageBox.Show("No songs are in the list."); }
            }
            else
            {
                playSongMethod(currentSong.Next.Value);
            }
        }
        // Button to allow user to play the previous song in the list. If Null plays first song. If all Null display Error Message.
        private void playPrev_Click(object sender, EventArgs e)
        {
            if (currentSong == null)
            {
                if (songList.First != null)
                { 
                    playSongMethod(songList.First.Value); 
                }
                else
                {
                    MessageBox.Show("No songs are in the list.");
                }
            }
            else {
               
                playSongMethod(currentSong.Previous.Value);
            }

        }
        //Display songs in listbox
        public void displaySongs()
        {
            listBox1.Items.Clear();
            foreach (string song in songList)
            {
                listBox1.Items.Add(song);
            }   
        }

        // Allows the media player to accept a section of the file path + \music\ + user selected song.
        public void playSongMethod(string song)
        {
            axWindowsMediaPlayer1.URL = System.IO.Directory.GetCurrentDirectory() + "\\music\\" + song;
            currentSong = songList.Find(song);
            currentSongTB.Text = song;
        }
        // Method to allow File Explorer to open and allow user to select .MP3 file from local drive.
        public void getFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String files;
                files = ofd.SafeFileName; //Save names of songs in files array
                songList.AddLast(files);
                listBox1.Items.Add(songList.First.Value);

            }
        }
       
    }
}
