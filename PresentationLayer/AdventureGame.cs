using System.Windows.Forms;

using BuildingHandler = BusinessLibrary.BuildingHandler;
using CombatHandler = BusinessLibrary.CombatHandler;

namespace PresentationLayer
{
    public partial class Program_Window : Form
    {
        public Program_Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Message_Log_Window.Text = "";

            OnRoomLoad();
        }

        /// <summary>
        /// Performs a single combat turn along with appropriate UI update events.
        /// </summary>
        private void Combat_Button_Attack_Click(object sender, System.EventArgs e)
        {
            CombatHandler.TakeCombatTurn();
            RefreshUI_CombatStats();
        }

        /// <summary>
        /// Tells the current player to move east and updates UI accordingly.
        /// </summary>
        private void Movement_Button_East_Click(object sender, System.EventArgs e)
        {
            this.Message_Log_Window.Text = "Moving East.";
            BuildingHandler.MovePlayer(Enums.CardinalDirection.East);
            OnRoomLoad();
        }

        /// <summary>
        /// Tells the current player to move north and updates UI accordingly.
        /// </summary>
        private void Movement_Button_North_Click(object sender, System.EventArgs e)
        {
            this.Message_Log_Window.Text = "Moving North.";
            BuildingHandler.MovePlayer(Enums.CardinalDirection.North);
            OnRoomLoad();
        }

        /// <summary>
        /// Tells the current player to move south and updates UI accordingly.
        /// </summary>
        private void Movement_Button_South_Click(object sender, System.EventArgs e)
        {
            this.Message_Log_Window.Text = "Moving South.";
            BuildingHandler.MovePlayer(Enums.CardinalDirection.South);
            OnRoomLoad();
        }

        /// <summary>
        /// Tells the current player to move west and updates UI accordingly.
        /// </summary>
        private void Movement_Button_West_Click(object sender, System.EventArgs e)
        {
            this.Message_Log_Window.Text = "Moving West.";
            BuildingHandler.MovePlayer(Enums.CardinalDirection.West);
            OnRoomLoad();
        }

        /// <summary>
        /// Event: called whenever the current room is changed
        /// </summary>
        private void OnRoomLoad()
        {
            //TODO: Custom Properties events?

            RefreshUI_MovementButtons();

            if (CombatHandler.EnemyIsPresent())
            {
                this.Message_Log_Window.Text += "\nEnemies are present.";
            }

            RefreshUI_CombatStats();

            RefreshUI_ItemList();
            RefreshUI_CurrentItemInfo(null, null);
        }

        private void RefreshUI_CombatStats()
        {
            this.Combat_Bar_Player.Maximum = CombatHandler.GetPlayerMaxHealth();
            this.Combat_Bar_Player.Value = CombatHandler.GetPlayerCurrentHealth();

            bool enemyIsPresent = CombatHandler.EnemyIsPresent();

            this.Combat_Button_Attack.Enabled = enemyIsPresent;
            this.Combat_Label_Enemy.Enabled = enemyIsPresent;
            this.Combat_Bar_Enemy.Enabled = enemyIsPresent;

            if (enemyIsPresent)
            {
                this.Combat_Bar_Enemy.Maximum = CombatHandler.GetEnemyMaxHealth();
                this.Combat_Bar_Enemy.Value = CombatHandler.GetEnemyCurrentHealth();
            }
        }

        /// <summary>
        /// Refreshes the UI list containing the items in the current room.
        /// </summary>
        private void RefreshUI_ItemList()
        {
            this.Item_List.Items.Clear();
            this.Item_List.Items.AddRange(BuildingHandler.GetItemNames());
        }

        /// <summary>
        /// Refreshes the UI buttons that represent available movement actions.
        /// </summary>
        private void RefreshUI_MovementButtons()
        {
            this.Movement_Button_North.Enabled = BuildingHandler.HasDoor(Enums.CardinalDirection.North);
            this.Movement_Button_South.Enabled = BuildingHandler.HasDoor(Enums.CardinalDirection.South);
            this.Movement_Button_East.Enabled = BuildingHandler.HasDoor(Enums.CardinalDirection.East);
            this.Movement_Button_West.Enabled = BuildingHandler.HasDoor(Enums.CardinalDirection.West);
        }

        /// <summary>
        /// Updates the visibility of a control object to represent its 'enabled' state.
        /// </summary>
        private void UI_SyncObjectVisibility(object sender, System.EventArgs e)
        {
            var senderObject = (Control)sender;
            senderObject.Visible = senderObject.Enabled;
        }

        /// <summary>
        /// Refreshes the UI elements which show the currently selected item's information.
        /// </summary>
        private void RefreshUI_CurrentItemInfo(object sender, System.EventArgs e)
        {
            if (this.Item_List.SelectedItem != null)
            {
                this.Item_Current_Label.Text = this.Item_List.SelectedItem as string;
                this.Item_Current_Description.Text = BuildingHandler
                    .GetItemDescription(this.Item_List.SelectedItem as string);
            }
            else
            {
                this.Item_Current_Label.Text = "Item Name";
                this.Item_Current_Description.Text = "No Item is currently selected.";
            }
        }
    }
}
