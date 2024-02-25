namespace DotNet_Keygen_Music_Player
{
    public partial class Form_DotNet_Keygen_Music_Player : Form
    {
        public Form_DotNet_Keygen_Music_Player()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DotNet_Keygen_Music_Player));
            flowLayoutPanelMusic = new FlowLayoutPanel();
            buttonOpenMusic = new Button();
            buttonPlayMusic = new Button();
            buttonStopMusic = new Button();
            buttonResetMusic = new Button();
            flowLayoutPanelMusic.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelMusic
            // 
            resources.ApplyResources(flowLayoutPanelMusic, "flowLayoutPanelMusic");
            flowLayoutPanelMusic.Controls.Add(buttonOpenMusic);
            flowLayoutPanelMusic.Controls.Add(buttonPlayMusic);
            flowLayoutPanelMusic.Controls.Add(buttonStopMusic);
            flowLayoutPanelMusic.Controls.Add(buttonResetMusic);
            flowLayoutPanelMusic.Name = "flowLayoutPanelMusic";
            // 
            // buttonOpenMusic
            // 
            resources.ApplyResources(buttonOpenMusic, "buttonOpenMusic");
            buttonOpenMusic.BackColor = Color.FromArgb(198, 198, 198);
            buttonOpenMusic.FlatAppearance.BorderColor = Color.Black;
            buttonOpenMusic.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 68, 68);
            buttonOpenMusic.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 122, 122);
            buttonOpenMusic.ForeColor = Color.Black;
            buttonOpenMusic.Name = "buttonOpenMusic";
            buttonOpenMusic.UseVisualStyleBackColor = false;
            buttonOpenMusic.Click += ButtonOpenMusic_Click;
            // 
            // buttonPlayMusic
            // 
            resources.ApplyResources(buttonPlayMusic, "buttonPlayMusic");
            buttonPlayMusic.BackColor = Color.FromArgb(198, 198, 198);
            buttonPlayMusic.FlatAppearance.BorderColor = Color.Black;
            buttonPlayMusic.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 68, 68);
            buttonPlayMusic.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 122, 122);
            buttonPlayMusic.ForeColor = Color.Black;
            buttonPlayMusic.Name = "buttonPlayMusic";
            buttonPlayMusic.UseVisualStyleBackColor = false;
            buttonPlayMusic.Click += ButtonPlayMusic_Click;
            // 
            // buttonStopMusic
            // 
            resources.ApplyResources(buttonStopMusic, "buttonStopMusic");
            buttonStopMusic.BackColor = Color.FromArgb(198, 198, 198);
            buttonStopMusic.FlatAppearance.BorderColor = Color.Black;
            buttonStopMusic.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 68, 68);
            buttonStopMusic.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 122, 122);
            buttonStopMusic.ForeColor = Color.Black;
            buttonStopMusic.Name = "buttonStopMusic";
            buttonStopMusic.UseVisualStyleBackColor = false;
            buttonStopMusic.Click += buttonStopMusicClick;
            // 
            // buttonResetMusic
            // 
            resources.ApplyResources(buttonResetMusic, "buttonResetMusic");
            buttonResetMusic.BackColor = Color.FromArgb(198, 198, 198);
            buttonResetMusic.FlatAppearance.BorderColor = Color.Black;
            buttonResetMusic.FlatAppearance.MouseDownBackColor = Color.FromArgb(68, 68, 68);
            buttonResetMusic.FlatAppearance.MouseOverBackColor = Color.FromArgb(122, 122, 122);
            buttonResetMusic.ForeColor = Color.Black;
            buttonResetMusic.Name = "buttonResetMusic";
            buttonResetMusic.UseVisualStyleBackColor = false;
            buttonResetMusic.Click += ButtonResetMusic_Click;
            // 
            // FormKeygenMusic_UnitTest
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            resources.ApplyResources(this, "$this");
            Controls.Add(flowLayoutPanelMusic);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormKeygenMusic_UnitTest";
            flowLayoutPanelMusic.ResumeLayout(false);
            ResumeLayout(false);
        }

        private FlowLayoutPanel flowLayoutPanelMusic;
        private Button buttonOpenMusic;
        private Button buttonPlayMusic;
        private Button buttonStopMusic;
        private Button buttonResetMusic;

        private void ButtonOpenMusic_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Opening MusicManager...");
            musicManager.OpenMusicDialog();
        }

        private void ButtonPlayMusic_Click(object sender, EventArgs e)
        {
            musicManager.PlayMusic();
            Console.WriteLine($"Playing music: {musicManager.musicName}");
        }

        private void buttonStopMusicClick(object sender, EventArgs e)
        {
            Console.WriteLine("Stopping MusicManager...");
            musicManager.StopMusic();
        }

        private void ButtonResetMusic_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Reset to Default MusicManager...");
            musicManager.ResetMusic(this);
            Console.WriteLine($"Playing music: {musicManager.musicName}");
        }
    }
}
