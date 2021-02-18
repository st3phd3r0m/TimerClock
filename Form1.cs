using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace TimerClock
{
    public partial class Form1 : Form
    {
        private int sec, min, hour, alarmHour, alarmMin;
        private bool timerTextBoxEnabled = true, alarmTextBoxEnabled = true;
        private TimeSpan interval;
        private string soundFileTimer, soundFileAlarm;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private DateTime alarmDate;

        public Form1()
        {
            InitializeComponent();
            FillTimerLabel();
            FillAlarmTextBoxes();
            timerLabel.Visible = false;
            SetDateTime();
            timer1.Interval = 1000;
            timer1.Start();
            soundFileTimer = ConfigurationManager.AppSettings.Get("soundFileTimer");
            soundFileAlarm = ConfigurationManager.AppSettings.Get("soundFileAlarm");
            timerSoundLabel.Text = (soundFileTimer==null)? "Aucun fichier sélectionné":soundFileTimer.Split('\\').Last();
            alarmSoundLabel.Text = (soundFileAlarm==null)? "Aucun fichier sélectionné":soundFileAlarm.Split('\\').Last();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SetDateTime();

           if (!alarmTextBoxEnabled && DateTime.Now.Hour.Equals(alarmDate.Hour) && DateTime.Now.Minute.Equals(alarmDate.Minute))
           {
                //MessageBox.Show("On se réveil");
                LaunchSound(soundFileAlarm);
           }
        }

        private void SetDateTime()
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void TimerSecTextBox_TextChanged(object sender, EventArgs e)
        {
            if ( int.TryParse(timerSecTextBox.Text, out sec) )
            {
                if(sec > 59)
                    timerSecTextBox.Text = "59";
                else if(sec<0)
                    timerSecTextBox.Text = "00";
            }
        }

        private void TimerMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(timerMinTextBox.Text, out min))
            {
                if (min > 59)
                    timerMinTextBox.Text = "59";
                else if (min < 0)
                    timerMinTextBox.Text = "00";
            }
        }

        private void TimerHourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(timerHourTextBox.Text, out hour))
            {
                if (hour > 99)
                    timerHourTextBox.Text = "99";
                else if (hour < 0)
                    timerHourTextBox.Text = "00";
            }
        }

        private void AlarmHourTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(alarmHourTextBox.Text, out alarmHour))
            {
                if (alarmHour > 23)
                    alarmHourTextBox.Text = "23";
                else if (alarmHour < 0)
                    alarmHourTextBox.Text = "00";
            }
        }

        private void AlarmMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(alarmMinTextBox.Text, out alarmMin))
            {
                if (alarmMin > 59)
                    alarmMinTextBox.Text = "59";
                else if (alarmMin < 0)
                    alarmMinTextBox.Text = "00";
            }
        }


        private void StartTimerButton_Click(object sender, EventArgs e)
        {
            if (timerTextBoxEnabled && ( hour!=0 || min!=0 || sec!=0 ) )
            {
                if ( soundFileTimer == null )
                {
                    MessageBox.Show("Veuillez sélectionner un fichier audio.");
                }
                else
                {
                    SwitchTimerSettings(false);
                    interval = new TimeSpan(hour, min, sec);
                    FillTimerLabel();
                    timer2.Interval = 1000;
                    timer2.Start();
                }
            }
            else if (!timerTextBoxEnabled)
            {
                timer2.Stop();
                if (outputDevice != null)
                {
                    StopSound();
                }
                SwitchTimerSettings(true);
                FillTimerTextBoxes();
            }
        }

        private void StartAlarmButton_Click(object sender, EventArgs e)
        {
            if (alarmTextBoxEnabled)
            {
                if (soundFileAlarm == null)
                {
                    MessageBox.Show("Veuillez sélectionner un fichier audio.");
                }
                else
                {
                    alarmDate = new DateTime(1,1,1,alarmHour,alarmMin,0);
                    SwitchAlarmSettings(false);
                }
            }
            else if (!alarmTextBoxEnabled)
            {
                if (outputDevice != null)
                {
                    StopSound();
                }
                SwitchAlarmSettings(true);
            }
        }

        private void SwitchTimerSettings(bool textBoxEnabled)
        {
            StartTimerButton.Text = textBoxEnabled? "Start the timer": "Stop";
            timerFeatureNameLabel.Text = textBoxEnabled ? "Timer" :"Timer programmé dans"; 
            timerHourTextBox.Visible = textBoxEnabled;
            timerMinTextBox.Visible = textBoxEnabled;
            timerSecTextBox.Visible = textBoxEnabled;
            timerLabel.Visible = !textBoxEnabled;
            timerTextBoxEnabled = textBoxEnabled;
            panel3.Enabled = textBoxEnabled;
        }

        private void SwitchAlarmSettings(bool textBoxEnabled)
        {
            startAlarmButton.Text = textBoxEnabled ? "Start the alarm" : "Stop";
            alarmFeatureNameLabel.Text = textBoxEnabled ? "Alarme" : "Alarme programmée pour";
            alarmHourTextBox.Enabled = textBoxEnabled;
            alarmMinTextBox.Enabled = textBoxEnabled;
            alarmTextBoxEnabled = textBoxEnabled;
            panel2.Enabled = textBoxEnabled;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (!timerTextBoxEnabled)
            {
                interval -= new TimeSpan(0, 0, 1);
                hour = (int)interval.TotalHours;
                min = interval.Minutes;
                sec = interval.Seconds;
                FillTimerLabel();
                if (interval.Equals(TimeSpan.Zero))
                {
                    LaunchSound(soundFileTimer);
                }
            }
        }

        private void FillTimerTextBoxes()
        {
            timerHourTextBox.Text = string.Format("{0:D2}", hour);
            timerMinTextBox.Text = string.Format("{0:D2}", min);
            timerSecTextBox.Text = string.Format("{0:D2}", sec);
        }

        private void FillAlarmTextBoxes()
        {
            DateTime now = DateTime.Now;
            alarmHour = now.Hour;
            alarmMin = now.Minute;
            alarmHourTextBox.Text = string.Format("{0:D2}", alarmHour);
            alarmMinTextBox.Text = string.Format("{0:D2}", alarmMin);
        }

        private void SoundFileOpenerTimer_Click(Object sender, EventArgs e)
        {
            // On interdit la sélection de plusieurs fichiers.
            openFileDialogTimer.Multiselect = false;
            // On supprime le nom de fichier, qui ici vaut "openFileDialog1" (avant sélection d'un fichier).
            openFileDialogTimer.FileName = string.Empty;
            // On met des filtres pour les types de fichiers : "Nom|*.extension|autreNom|*.autreExtension" (autant de filtres qu'on veut).
            openFileDialogTimer.Filter = "Fichiers Wav|*.wav|Fichiers mp3|*.mp3";
            // Le filtre sélectionné : le 2e (là on ne commence pas à compter à 0).
            openFileDialogTimer.FilterIndex = 2;
            // On affiche le dernier dossier ouvert.
            openFileDialogTimer.RestoreDirectory = true;

            // Si l'utilisateur clique sur "Ouvrir"...
            if (openFileDialogTimer.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (((System.Windows.Forms.Control)sender).Name == "soundFileOpenerTimer")
                    {
                        // On récupère le nom du fichier.
                        soundFileTimer = openFileDialogTimer.FileName;
                        timerSoundLabel.Text = soundFileTimer.Split('\\').Last();

                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings.Remove("soundFileTimer");
                        config.AppSettings.Settings.Add("soundFileTimer", soundFileTimer);
                        config.Save(ConfigurationSaveMode.Modified);

                    }
                    else if (((System.Windows.Forms.Control)sender).Name == "soundFileOpenerAlarm")
                    {
                        // On récupère le nom du fichier.
                        soundFileAlarm = openFileDialogTimer.FileName;
                        alarmSoundLabel.Text = soundFileAlarm.Split('\\').Last();
                        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings.Remove("soundFileAlarm");
                        config.AppSettings.Settings.Add("soundFileAlarm", soundFileAlarm);
                        config.Save(ConfigurationSaveMode.Modified);

                    }
                }
                // En cas d'erreur...
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur est survenue lors de l'ouverture du fichier : {0}.", ex.Message);
                }
            }
            openFileDialogTimer.Dispose();
        }

        private void FillTimerLabel()
        {
            timerLabel.Text = interval.ToString();
        }

        private void LaunchSound(string soundFile)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(soundFile);
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }

        private void StopSound()
        {
            outputDevice.Stop();
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

    }
}
