using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static Circuit_Solver_v2.Circuit;

namespace Circuit_Solver_v2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int[,]> circuitNames = new Dictionary<string, int[,]>();
        string[,] buttonNames = FillButtonNamesArray();

        private const int PaddingX = 12;
        private const int PaddingY = 12;
        private const int FormMainWidth = 300;
        private const int FormCircuitWidth = 500;
        private const int MainFormHeight = 300;
        private const int SubFormHeight = 680;
        private const int ButtonSizeX = 220;
        private const int ButtonSizeCircuitX = 150;
        private const int ButtonSizeY = 34;
        private const int QuitButtonLocationY = SubFormHeight - ButtonSizeY - 80;

        private const string TagMainMenu = "Main Menu";
        private const string TagBasicMenu = "Basic Menu";
        private const string TagDCMenu = "DC Menu";
        private const string TagACMenu = "AC Menu";
        private const string TagBasicChallenge = "Basic Circuit Challenge";
        private const string TagDCChallenge = "DC Circuit Challenge";
        private const string TagACChallenge = "AC Circuit Challenge";

        private Size buttonSizeMain = new Size(ButtonSizeX, ButtonSizeY);
        private Size buttonSizeCircuit = new Size(ButtonSizeCircuitX, ButtonSizeY);
        private Size formSizeMain = new Size(FormMainWidth, MainFormHeight);
        private Size formSizeSub = new Size(FormMainWidth, SubFormHeight);
        private Size formSizeCircuit = new Size(FormCircuitWidth, SubFormHeight);
        private Point buttonLocation = new Point(((FormMainWidth / 2) - (ButtonSizeX / 2) - 10), 45);
        private Point labelLocation = new Point(-5, 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = formSizeMain;
            FillDictionary();
            FillButtonNamesArray();
            CreateMainControls(buttonSizeMain, formSizeSub, buttonLocation, labelLocation);
            CreateBasicControls(buttonSizeMain, formSizeMain, buttonLocation, labelLocation);
            CreateDCControls(buttonSizeMain, formSizeMain, buttonLocation, labelLocation);
            CreateACControls(buttonSizeMain, formSizeMain, buttonLocation, labelLocation);

        }

        private void FillDictionary()
        {
            //Fill Basic Entries
            circuitNames.Add(buttonNames[0, 0],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 1],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 2],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 3],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 4],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 5],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 6],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 7],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 8],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 9],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 10], new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[0, 11], new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            //Fill DC Entries
            circuitNames.Add(buttonNames[1, 0],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 1],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 2],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 3],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 4],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 5],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 6],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 7],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 8],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 9],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 10], new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[1, 11], new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            //Fill AC Entries
            circuitNames.Add(buttonNames[2, 0],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 1],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 2],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 3],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 4],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 5],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 6],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 7],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 8],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 9],  new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 10], new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  2,  2,  2,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
            circuitNames.Add(buttonNames[2, 11], new int[,] { {10,  1,  2,  0,  5,  6,  7,  11,  12,  15,  16,  17  },
                                                              { 0,  3,  3,  3,  1,  1,  1,   0,   0,   4,   4,   4  },
                                                              { 0,  0,  0,  1,  1,  1,  1,   1,   1,   1,   1,   1  } });
        }
        private static string[,] FillButtonNamesArray()
        {
            string[,] buttonNames = { { "Color Codes", "Ohms Law I", "Ohms Law II", "Power I", "Power II", "Series Sources", "Basic Series One", "Basic Series Two", "Basic Parallel One", "Basic Parallel Two", "Basic Series-Parallel One", "Basic Series-Parallel Two"},
                                      { "DC Series One", "DC Series Two", "DC Series Three", "DC Parallel One", "DC Parallel Two", "DC Parallel Three", "Series-Parallel One", "Series-Parallel Two", "Series-Parallel Three", "Series-Parallel Four", "Series-Parallel Five", "Basic Networks"},
                                      { "Voltage Conversions", "Transformers", "Series and Pararel C", "Series and Parallel L", "RL Series Circuits", "RL Parallel Circuits", "RC Series Circuits", "RC Parallel Circuits", "RLC Series Circuits", "RLC Parallel Circuits", "Series Resonance", "Parallel Resonance"} };
            return buttonNames;
        }

        public void AdjustControls(string tagName)
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = ((string)control.Tag! == tagName) ? true : false;
            }
        }

        private void ClearTextBoxes()
        {
            foreach (TextBox t in Controls.OfType<TextBox>())
            {
                t.Text = string.Empty;
            }
        }
        //////////////////////////////////
        // Create Main Menu Controls
        private void CreateMainControls(Size buttonSize, Size formSize, Point adjustedLocation, Point labelLocation)
        {
            Label labelMain = new Label();
            labelMain.Size = new Size(FormMainWidth, 32);
            labelMain.Location = labelLocation;
            labelMain.Font = new Font("Segoe UI", 12);
            labelMain.Visible = true;
            labelMain.TextAlign = ContentAlignment.MiddleCenter;
            labelMain.Text = "Circuit Solver";
            labelMain.Tag = TagMainMenu;
            Controls.Add(labelMain);

            Button buttonBasic = new Button();
            buttonBasic.Location = adjustedLocation;
            buttonBasic.Size = buttonSize;
            buttonBasic.Visible = true;
            buttonBasic.Text = "Basic Circuit Challenges";
            buttonBasic.Tag = TagMainMenu;
            buttonBasic.Click += (sender, EventArgs) => { ButtonMenu_Click(sender, EventArgs, TagBasicMenu, formSize); };
            Controls.Add(buttonBasic);

            adjustedLocation.Y += 40;

            Button buttonDC = new Button();
            buttonDC.Location = adjustedLocation;
            buttonDC.Size = buttonSize;
            buttonDC.Visible = true;
            buttonDC.Text = "DC Circuit Challenges";
            buttonDC.Tag = TagMainMenu;
            buttonDC.Click += (sender, EventArgs) => { ButtonMenu_Click(sender, EventArgs, TagDCMenu, formSize); };
            Controls.Add(buttonDC);

            adjustedLocation.Y += 40;

            Button buttonAC = new Button();
            buttonAC.Location = adjustedLocation;
            buttonAC.Size = buttonSize;
            buttonAC.Visible = true;
            buttonAC.Text = "AC Circuit Challenges";
            buttonAC.Tag = TagMainMenu;
            buttonAC.Click += (sender, EventArgs) => { ButtonMenu_Click(sender, EventArgs, TagACMenu, formSize); };
            Controls.Add(buttonAC);

            adjustedLocation.Y += 40;

            Button buttonQuit = new Button();
            buttonQuit.Location = adjustedLocation;
            buttonQuit.Size = buttonSize;
            buttonQuit.Visible = true;
            buttonQuit.Text = "Quit";
            buttonQuit.Tag = TagMainMenu;
            buttonQuit.Click += new EventHandler(ButtonQuit_Click);
            Controls.Add(buttonQuit);
        }
        //////////////////////////////////
        // Create Basic Menu Controls
        private void CreateBasicControls(Size buttonSize, Size formSize, Point adjustedLocation, Point labelLocation)
        {
            Label labelBasic = new Label();
            labelBasic.Size = new Size(FormMainWidth, 32);
            labelBasic.Location = labelLocation;
            labelBasic.Font = new Font("Segoe UI", 12);
            labelBasic.Visible = false;
            labelBasic.Text = "Basic Circuit Challenges";
            labelBasic.TextAlign = ContentAlignment.MiddleCenter;
            labelBasic.Tag = TagBasicMenu;
            Controls.Add(labelBasic);

            for (int i = 0; i < buttonNames.GetLength(1); i++)
            {
                Button button = new Button();
                button.Location = adjustedLocation;
                button.Size = buttonSize;
                button.Visible = false;
                button.Text = buttonNames[0, i];
                button.Tag = TagBasicMenu;
                button.Click += (sender, EventArgs) => { ButtonCircuits_Click(sender, EventArgs, TagBasicMenu, button.Text); };
                Controls.Add(button);

                adjustedLocation.Y += 40;
            }

            Button buttonMainMenu = new Button();
            buttonMainMenu.Location = adjustedLocation;
            buttonMainMenu.Size = buttonSize;
            buttonMainMenu.Visible = false;
            buttonMainMenu.Text = "Main Menu";
            buttonMainMenu.Tag = TagBasicMenu;
            buttonMainMenu.Click += (sender, EventArgs) => { ButtonMenu_Click(sender, EventArgs, TagMainMenu, formSize); };
            Controls.Add(buttonMainMenu);

            adjustedLocation.Y += 40;

            Button buttonQuit = new Button();
            buttonQuit.Location = adjustedLocation;
            buttonQuit.Size = buttonSize;
            buttonQuit.Visible = false;
            buttonQuit.Text = "Quit";
            buttonQuit.Tag = TagBasicMenu;
            buttonQuit.Click += new EventHandler(ButtonQuit_Click);
            Controls.Add(buttonQuit);
        }
        //////////////////////////////////
        // Create DC Menu Controls
        private void CreateDCControls(Size buttonSize, Size formSize, Point adjustedLocation, Point labelLocation)
        {
            Label labelDC = new Label();
            labelDC.Size = new Size(FormMainWidth, 32);
            labelDC.Location = labelLocation;
            labelDC.Font = new Font("Segoe UI", 12);
            labelDC.Visible = false;
            labelDC.TextAlign = ContentAlignment.MiddleCenter;
            labelDC.Text = "DC Circuit Challenges";
            labelDC.Tag = TagDCMenu;
            Controls.Add(labelDC);

            for (int i = 0; i < buttonNames.GetLength(1); i++)
            {
                Button button = new Button();
                button.Location = adjustedLocation;
                button.Size = buttonSize;
                button.Visible = false;
                button.Text = buttonNames[1, i];
                button.Tag = TagDCMenu;
                button.Click += (sender, EventArgs) => { ButtonCircuits_Click(sender, EventArgs, TagDCMenu, button.Text); };
                Controls.Add(button);

                adjustedLocation.Y += 40;
            }

            Button buttonMainMenu = new Button();
            buttonMainMenu.Location = adjustedLocation;
            buttonMainMenu.Size = buttonSize;
            buttonMainMenu.Visible = false;
            buttonMainMenu.Text = "Main Menu";
            buttonMainMenu.Tag = TagDCMenu;
            buttonMainMenu.Click += (sender, EventArgs) => { ButtonMenu_Click(sender, EventArgs, TagMainMenu, formSize); };
            Controls.Add(buttonMainMenu);

            adjustedLocation.Y += 40;

            Button buttonQuit = new Button();
            buttonQuit.Location = adjustedLocation;
            buttonQuit.Size = buttonSize;
            buttonQuit.Visible = false;
            buttonQuit.Text = "Quit";
            buttonQuit.Tag = TagDCMenu;
            buttonQuit.Click += new EventHandler(ButtonQuit_Click);
            Controls.Add(buttonQuit);
        }
        //////////////////////////////////
        // Create AC Menu Controls
        private void CreateACControls(Size buttonSize, Size formSize, Point adjustedLocation, Point labelLocation)
        {
            Label labelAC = new Label();
            labelAC.Text = "AC Circuit Challenges";
            labelAC.Size = new Size(FormMainWidth, 32);
            labelAC.Location = labelLocation;
            labelAC.Font = new Font("Segoe UI", 12);
            labelAC.TextAlign = ContentAlignment.MiddleCenter;
            labelAC.Visible = false;
            labelAC.Tag = TagACMenu;
            Controls.Add(labelAC);

            for (int i = 0; i < buttonNames.GetLength(1); i++)
            {
                Button button = new Button();
                button.Location = adjustedLocation;
                button.Size = buttonSize;
                button.Visible = false;
                button.Text = buttonNames[2, i];
                button.Tag = TagACMenu;
                button.Click += (sender, EventArgs) => { ButtonCircuits_Click(sender, EventArgs, TagACMenu, button.Text); };
                Controls.Add(button);

                adjustedLocation.Y += 40;
            }

            Button buttonMainMenu = new Button();
            buttonMainMenu.Location = adjustedLocation;
            buttonMainMenu.Size = buttonSize;
            buttonMainMenu.Visible = false;
            buttonMainMenu.Text = "Main Menu";
            buttonMainMenu.Tag = TagACMenu;
            buttonMainMenu.Click += (sender, EventArgs) => { ButtonMenu_Click(sender, EventArgs, TagMainMenu, formSize); };
            Controls.Add(buttonMainMenu);

            adjustedLocation.Y += 40;

            Button buttonQuit = new Button();
            buttonQuit.Location = adjustedLocation;
            buttonQuit.Size = buttonSize;
            buttonQuit.Visible = false;
            buttonQuit.Text = "Quit";
            buttonQuit.Tag = TagACMenu;
            buttonQuit.Click += new EventHandler(ButtonQuit_Click);
            Controls.Add(buttonQuit);
        }
        //////////////////////////////////
        // 
        public void SetTextBoxesCircuits(int yCount0, int yCount1, int i, int[,] names, string tagName, string s)
        {
            int pointX = (names[2, i] * 250) + 50;
            int pointY = (names[2, i] == 0) ? yCount0 * 32 : yCount1 * 32;
            TextBox textBox = new TextBox();
            textBox.Location = new Point(pointX + PaddingX, pointY + PaddingY);
            textBox.ReadOnly = (names[2, i] == 1) ? true : false;
            textBox.Visible = true;
            textBox.Name = "textBox" + s;
            textBox.TabIndex = i;
            textBox.Tag = tagName + "C";
            Controls.Add(textBox);
        }
        public void SetLabelValuesCircuits(int yCount0, int yCount1, int i, int[,] names, string tagName, string s)
        {
            int pointX = (names[2, i] * 250);
            int pointY = (names[2, i] == 0) ? yCount0 * 32 : yCount1 * 32;
            Label label = new Label();
            label.Location = new Point(pointX + PaddingX, pointY + PaddingY);
            label.Visible = true;
            label.Text = s;
            label.Name = "label" + label.Text;
            label.Tag = tagName + "C";
            Controls.Add(label);
        }
        public void SetLabelMetricsCircuits(int yCount0, int yCount1, int i, int[,] names, string tagName, string s)
        {
            int pointX = (names[2, i] * 250) + 175;
            int pointY = (names[2, i] == 0) ? yCount0 * 32 : yCount1 * 32;
            Label label = new Label();
            label.Location = new Point(pointX + PaddingX, pointY + PaddingY);
            label.Size = new Size(32, 32);
            label.Visible = true;
            label.Text = s;
            label.Name = "label" + label.Text;
            label.Tag = tagName + "C";
            Controls.Add(label);
        }
        public void SetButtonsCircuits(Size buttonSize, String tagName, int buttonY, Size subMenuSize)
        {

            Button buttonBack = new Button();
            buttonBack.Location = new Point(PaddingX, buttonY);
            buttonBack.Size = buttonSize;
            buttonBack.Visible = false;
            buttonBack.Text = "Back";
            buttonBack.Tag = tagName + "C";
            buttonBack.Click += (sender, EventArgs) => { ButtonMenu_Click(sender, EventArgs, tagName, subMenuSize); };
            Controls.Add(buttonBack);

            Button buttonClear = new Button();
            buttonClear.Location = new Point((Width / 2) - (buttonSize.Width / 2) - PaddingX, buttonY);
            buttonClear.Size = buttonSize;
            buttonClear.Visible = false;
            buttonClear.Text = "Clear";
            buttonClear.Tag = tagName + "C";
            buttonClear.Click += ButtonClear_Click;
            Controls.Add(buttonClear);

            Button buttonQuit = new Button();
            buttonQuit.Location = new Point(Width - (buttonSize.Width + (PaddingX * 3)), buttonY);
            buttonQuit.Size = buttonSize;
            buttonQuit.Visible = false;
            buttonQuit.Text = "Quit";
            buttonQuit.Tag = tagName + "C";
            buttonQuit.Click += ButtonQuit_Click;
            Controls.Add(buttonQuit);
        }
        //////////////////////////////////
        // Button Click Methods
        public void ButtonMenu_Click(object? sender, EventArgs e, string TagName, Size formSize)
        {
            AdjustControls(TagName);
            this.Size = formSize;
            ClearTextBoxes();
        }
        public void ButtonQuit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
        public void ButtonClear_Click(object? sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void ButtonCircuits_Click(object? sender, EventArgs e, string TagName, string s)
        {
            Circuit circuit = new Circuit(circuitNames[s], this, TagName, FormCircuitWidth, QuitButtonLocationY, buttonSizeCircuit, formSizeSub);
            AdjustControls(TagName + "C");
        }
    }
}
