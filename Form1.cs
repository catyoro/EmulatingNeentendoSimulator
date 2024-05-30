namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        int amount = 0;
        string[] gameName = new string[] {"Super Miguel Bros.zip", "Pokemoan.zip", "Street Smasher Ultimate.iso", "Legs.iso", "Witch May Cry.iso",
            "Dunky Kung Cuntrie.zip", "Legend of Zoe.rar", "Kick Out!.zip", "Miguel Kart Deluxe.iso", "Wee Sports.iso", "Wee Fat.iso", "F-MinusOne.rar",
            "Kirbo.zip", "Joshi's Island.rar", "Dino's Quest.rar", "Cunky Bad Fur Month.rar", "Bagpipe Kazooie.zip", "Splatonic.iso", "Meh-troid.rar",
            "Water Emblem.7z", "Star Vixen.7z", "Father 3.rar", "Earthbend.zip", "Teen Icarus.7z", "Ice Diggers.rar", "Wigel Land.7z", 
            "Migel and Sanic at Olympics.iso", "Migel vs Dunky Kung.zip", "Super Migel RPG.7z", "Neentendoggos.rar", "Silvereye 006.7z", "Cruisi'n Canada.iso",
            "Murder Instinct.iso", "Supaman 63.rar", "GamePrismBIOS.rar", "WeeBIOS.zip", "WeeooBIOS.7z", "NeentendoSweetBIOS.rar", "DolpheenEmulator.zip",
            "YuzoEmulator.rar", "Grand Thief Auto Chinatown Conflict.zip", "Goose Hunt.rar", "Project63.zip", "Sanic Colors.iso", "Homiebrew Channel.zip", "Super Miguel All Stars.wad",
            "Dance Dance Dance Dance Evolution Miguel Mix.wad"};

        public Form1()
        {
            InitializeComponent();
            numberOfGames.Text = amount.ToString();
            piratingAlarm.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pirateButton_Click(object sender, EventArgs e)
        {
            amount++;
            numberOfGames.Text = amount.ToString();
            piratingAlarm.Text = "DOWNLOAD COMPLETE:\n" + gameName[new Random().Next(0, gameName.Length)];
        }
    }
}