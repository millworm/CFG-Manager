using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Threading;
using System.Reflection;
namespace CFG_Manager
{
    /* v0.04
     * Изменено визуальное оформление
     * 
     * 
     * {"response":{"server":"http://cfgmanager.ml","teams":[{"tname":"Astralis","players":[{"name":"cajunb","nick":"cajunb"},{"name":"device","nick":"device"},{"name":"dupreeh","nick":"dupreeh"},{"name":"karrigan","nick":"karrigan"},{"name":"xyp9x","nick":"xyp9x"},],},{"tname":"Binary Dragons","players":[{"name":"balblna","nick":"balblna"},{"name":"dERZKI","nick":"dERZKI"},{"name":"FANAT ROCKA (def. config)","nick":"FANAT ROCKA (def. config)"},],},{"tname":"dignitas","players":[{"name":"Kjaerbye","nick":"Kjaerbye"},{"name":"MSL","nick":"MSL"},{"name":"RUBINO","nick":"RUBINO"},],},{"tname":"EnVyUs","players":[{"name":"apEX","nick":"apEX"},{"name":"Happy","nick":"Happy"},{"name":"kennyS","nick":"kennyS"},{"name":"kioShiMa","nick":"kioShiMa"},{"name":"Maniac","nick":"Maniac"},{"name":"NBK","nick":"NBK"},],}]}}
     * 
     */
    public partial class Form1 : Form
    {
         delegate void link();
        string version = "0.04";
        Data answer;
        Thread newton;
        string server = "http://cfgmanager.ml";
        string routee;
        public Form1()
        {
            
            Text = "CFG Manager v " + version;
            
            InitializeComponent();
          //  AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            
        }
        
        private string route()
        {
            RegistryKey readKey = Registry.LocalMachine.OpenSubKey("software\\wow6432node\\microsoft\\windows\\currentversion\\uninstall\\steam app 730");
            try
            {
                string loadString = (string)readKey.GetValue("InstallLocation");
                readKey.Close();
                loadString += "\\csgo\\cfg\\";
                return loadString;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не удалось определить расположение игры.\nЗадайте путь вручную", "Ошибка");
                return path2();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newton = new Thread(newtonn);
            newton.IsBackground = true;
            newton.Start();
            routee = route();
            if (routee != "\\csgo\\cfg\\")
            {
                btninstall.Enabled = true;
                btninstall.BackColor = SystemColors.ControlLightLight;
            }
         /*   FileInfo f = new FileInfo("cfgmanager.dat");
            if (f.Exists)
            {
                StreamReader sr = new StreamReader("cfgmanager.dat", Encoding.UTF8);
                server = Convert.ToString(sr.ReadLine());
                sr.Close();
            }
            answer = Get(server + "/ap.php");
            if (!answer.response.server.Equals(server))
                server = answer.response.server;
            addteam(answer);
            routee = route();
            newversion(2);  */
        }

        public Data Get(string server)
        {
            HttpWebResponse myHttpWebResponse;
            StreamReader myStreamReader;
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(server);
                try
                {
                    myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                    myStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
                    
                }
                catch (Exception ex)
                {
                    notify("Ошибка", "Невозможно подключиться к серверу. Проверьте сетевое соединение"); 
                    return null;
                }
                string aresponse = myStreamReader.ReadToEnd();
                try
                {
                    Data asd = JsonConvert.DeserializeObject<Data>(aresponse);
                    return asd;
                }
                catch (Exception ex)
                {
                    if(ex.Message=="Unexpected character encountered while parsing value: <. Path '', line 0, position 0.")
                    notify("Ошибка", "Невозможно получить список команд"); 
                    return null;
                }

        }

        public void addteam(Data text)
        {
            cbteam.Invoke((MethodInvoker)(delegate() { cbteam.Items.Clear(); }));
            foreach(team t in text.response.teams){
                if (cbteam.Items.IndexOf(t.tname) == -1)
                {
                 //   cbteam.Items.Add(t.tname);
                    
                    cbteam.Invoke(new Action<string>((s) => cbteam.Items.Add(s)),t.tname);
                }
            }
        }

        private void cbteam_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cbteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbplayers.Items.Clear();

            if (cbteam.SelectedIndex != -1)
            {
                var s = cbteam.SelectedItem;
                foreach (team t in answer.response.teams)
                {
                    if (s.Equals(t.tname))
                        foreach (player d in t.players)
                            lbplayers.Items.Add(d.nick);
                }
            }
        }

        private void cbdate_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void btnrem_Click(object sender, EventArgs e)
        {
            string temp = routee;
            string back = temp + "configBackup.cfg";
            string conf = temp + "config.cfg";
            if (File.Exists(back))
            {
                try { 
                File.Move(temp + "configBackup.cfg", temp + "config.cfg");
                    if (File.Exists(conf))
                    MessageBox.Show("Файл восстановлен", "Выполнено");
                }
                catch(System.IO.IOException){
                    MessageBox.Show("Файл не восстановлен. config.cfg существует", "Ошибка");
                }
            }
            else
                MessageBox.Show("Нет файла для восстановления", "Ошибка");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            string temp = routee;
            string back = temp + "configBackup.cfg";
            string conf = temp + "config.cfg";
            
         if (File.Exists(conf))
            {
                try {
                    File.Move(temp + "config.cfg", temp + "configBackup.cfg");
                    if (File.Exists(back))
                    MessageBox.Show("Файл сохранен", "Выполнено");
                }
                catch(System.IO.IOException){
                    MessageBox.Show("Файл не сохранен.", "Ошибка");
                }
            }
            else
                MessageBox.Show("Нет config", "Ошибка");
        }

        private void btninstall_Click(object sender, EventArgs e)
        {
            if(cbteam.SelectedIndex!=-1)
                    if(lbplayers.SelectedIndex!=-1){
                        try
                        {
                            WebClient webClient = new WebClient();
                            string a = server + "/teams/" + cbteam.SelectedItem +"/" +lbplayers.SelectedItem+ "/config.cfg";
                            webClient.DownloadFile(a, routee + "config.cfg");
                            MessageBox.Show("Конфиг установлен", "Выполнено");
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка во время установки", "Ошибка");
                        }
                    }else
                        MessageBox.Show("Не выбран игрок","Ошибка");
            else
                        MessageBox.Show("Не выбрана команда","Ошибка");

        }

        private void проверитьОбновленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newversion(1);
            
        }

        private void сайтПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(server);
            this.WindowState = FormWindowState.Minimized;
        }

        private void задатьПутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path2();
        }
        public string path2()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            MessageBox.Show("Укажите папку с файлом csgo.exe", "Указание");
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\csgo.exe"))
                {
                    routee = folderBrowserDialog1.SelectedPath;
                    btninstall.Enabled = true;
                    btninstall.BackColor = SystemColors.ControlLightLight;
                }
                else
                {
                    MessageBox.Show("Папка указана неверно", "Ошибка");
                    btninstall.Enabled = false;
                }

            }
           return routee = routee + "\\csgo\\cfg\\";
        }


        public void notify(string title, string text)
        {
         
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(10000);
        }

        public void newversion(int i)
        {
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(server + "/version.php");
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                StreamReader myStreamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
                string aresponse = myStreamReader.ReadToEnd();
                aresponse = aresponse.Replace(".", ",");
                version = version.Replace(".", ",");
               if(i==1)
                if (Convert.ToDouble(aresponse) > Convert.ToDouble(version))
                {
                    notify("Проверка обновлений","Доступно обновление\nТекущая версия " + aresponse);
                    return;
                  //  MessageBox.Show("Вышло обновление\nТекущая версия " + aresponse, "Обновление");
                }
                else
                {
                    if (Convert.ToDouble(aresponse) == Convert.ToDouble(version))
                    {
                        notify("Проверка обновлений","Обновление не требуется");
                        return;
                    }
                }
               if (i == 2)
                    if (Convert.ToDouble(aresponse) > Convert.ToDouble(version))
                {
                   notify("Доступно обновление", "Вышла новая версия");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка во время проверки обновления", "Ошибка");
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Process.Start(server);
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
            try
            {
                System.IO.File.WriteAllText("cfgmanager.dat", server);
            }
            
            catch{
            }
        }


   
        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
{
    //получаем имя сборки(короткое, без расширений)
    string shortName = new AssemblyName(args.Name).Name;
 
    //получаем ресурс из сборки по его имени, тут же помещая в созданный поток
    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(shortName + ".dll"))
    {
        if (args.Name.Contains("Newtonsoft.Json"))
        {
            return Assembly.Load(CFG_Manager.Properties.Resources.Newtonsoft_Json);
        }
        return null;
    }
}

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }
        void newtonn()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            FileInfo f = new FileInfo("cfgmanager.dat");
            if (f.Exists)
            {
                StreamReader sr = new StreamReader("cfgmanager.dat", Encoding.UTF8);
                server = Convert.ToString(sr.ReadLine());
                sr.Close();
            }
            answer = Get(server + "/ap.php");
            while (answer == null) { 
                //проверять соединение 
                Thread.Sleep(1000);
            }
            if (!answer.response.server.Equals(server))
                server = answer.response.server;
           
            addteam(answer);//Добавляем команды
            
            newversion(2);//проверка версии
           
        }

        private void перейтиНаСайтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(server);
            this.WindowState = FormWindowState.Minimized;
        }

        private void перейтиВГруппуВКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/cfgmanager");
            this.WindowState = FormWindowState.Minimized;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbplayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbteam_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      
    }
    
    
    public class Data
    {
        public response response;
    }


   public class response
    {
       public string server { get; set; }
       public List<team> teams { get; set; }
    }
   public class player
   {
       public string name { get; set; }
       public string nick { get; set; }
   }

   public class team
   {
       public string tname { get; set; }
       public List<player> players { get; set; }
   }
    
  
}
