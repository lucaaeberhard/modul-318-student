
namespace SwissTransportGui
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionsGroupBox = new System.Windows.Forms.GroupBox();
            this.endStationLabel = new System.Windows.Forms.Label();
            this.startStationLabel = new System.Windows.Forms.Label();
            this.suggestedEndListBox = new System.Windows.Forms.ListBox();
            this.suggestedStartListBox = new System.Windows.Forms.ListBox();
            this.switchStationsButton = new System.Windows.Forms.Button();
            this.connectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionSearchButton = new System.Windows.Forms.Button();
            this.endStationTextBox = new System.Windows.Forms.TextBox();
            this.startStationTextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.stationsGroupBox = new System.Windows.Forms.GroupBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.showMapButton = new System.Windows.Forms.Button();
            this.stationsListBox = new System.Windows.Forms.ListBox();
            this.stationSearchTextBox = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mailGroupBox = new System.Windows.Forms.GroupBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.mailReceiverTextBox = new System.Windows.Forms.TextBox();
            this.sendMailButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stationBoardGroupBox = new System.Windows.Forms.GroupBox();
            this.stationBoardLabel = new System.Windows.Forms.Label();
            this.suggestedStationsListBox = new System.Windows.Forms.ListBox();
            this.stationBoardDataGridView = new System.Windows.Forms.DataGridView();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showDestinationBoardButton = new System.Windows.Forms.Button();
            this.destinationBoardStationTextBox = new System.Windows.Forms.TextBox();
            this.connectionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).BeginInit();
            this.stationsGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mailGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.stationBoardGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionsGroupBox
            // 
            this.connectionsGroupBox.Controls.Add(this.endStationLabel);
            this.connectionsGroupBox.Controls.Add(this.startStationLabel);
            this.connectionsGroupBox.Controls.Add(this.suggestedEndListBox);
            this.connectionsGroupBox.Controls.Add(this.suggestedStartListBox);
            this.connectionsGroupBox.Controls.Add(this.switchStationsButton);
            this.connectionsGroupBox.Controls.Add(this.connectionsDataGridView);
            this.connectionsGroupBox.Controls.Add(this.connectionSearchButton);
            this.connectionsGroupBox.Controls.Add(this.endStationTextBox);
            this.connectionsGroupBox.Controls.Add(this.startStationTextBox);
            this.connectionsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.connectionsGroupBox.Name = "connectionsGroupBox";
            this.connectionsGroupBox.Size = new System.Drawing.Size(732, 346);
            this.connectionsGroupBox.TabIndex = 0;
            this.connectionsGroupBox.TabStop = false;
            this.connectionsGroupBox.Text = "Verbindungen suchen";
            // 
            // endStationLabel
            // 
            this.endStationLabel.AutoSize = true;
            this.endStationLabel.Location = new System.Drawing.Point(194, 34);
            this.endStationLabel.Name = "endStationLabel";
            this.endStationLabel.Size = new System.Drawing.Size(33, 13);
            this.endStationLabel.TabIndex = 9;
            this.endStationLabel.Text = "Nach";
            // 
            // startStationLabel
            // 
            this.startStationLabel.AutoSize = true;
            this.startStationLabel.Location = new System.Drawing.Point(0, 34);
            this.startStationLabel.Name = "startStationLabel";
            this.startStationLabel.Size = new System.Drawing.Size(26, 13);
            this.startStationLabel.TabIndex = 8;
            this.startStationLabel.Text = "Von";
            // 
            // suggestedEndListBox
            // 
            this.suggestedEndListBox.FormattingEnabled = true;
            this.suggestedEndListBox.Location = new System.Drawing.Point(197, 83);
            this.suggestedEndListBox.Name = "suggestedEndListBox";
            this.suggestedEndListBox.ScrollAlwaysVisible = true;
            this.suggestedEndListBox.Size = new System.Drawing.Size(120, 95);
            this.suggestedEndListBox.TabIndex = 7;
            this.suggestedEndListBox.Visible = false;
            this.suggestedEndListBox.SelectedIndexChanged += new System.EventHandler(this.suggestedEndListBox_SelectedIndexChanged);
            // 
            // suggestedStartListBox
            // 
            this.suggestedStartListBox.FormattingEnabled = true;
            this.suggestedStartListBox.Location = new System.Drawing.Point(0, 83);
            this.suggestedStartListBox.Name = "suggestedStartListBox";
            this.suggestedStartListBox.ScrollAlwaysVisible = true;
            this.suggestedStartListBox.Size = new System.Drawing.Size(120, 95);
            this.suggestedStartListBox.TabIndex = 6;
            this.suggestedStartListBox.Visible = false;
            this.suggestedStartListBox.SelectedIndexChanged += new System.EventHandler(this.suggestedStartListBox_SelectedIndexChanged);
            // 
            // switchStationsButton
            // 
            this.switchStationsButton.Location = new System.Drawing.Point(122, 54);
            this.switchStationsButton.Name = "switchStationsButton";
            this.switchStationsButton.Size = new System.Drawing.Size(45, 23);
            this.switchStationsButton.TabIndex = 5;
            this.switchStationsButton.Text = "<->";
            this.switchStationsButton.UseVisualStyleBackColor = true;
            this.switchStationsButton.Click += new System.EventHandler(this.switchStationsButton_Click);
            // 
            // connectionsDataGridView
            // 
            this.connectionsDataGridView.AllowUserToDeleteRows = false;
            this.connectionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.connectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departure,
            this.arrival,
            this.duration,
            this.station});
            this.connectionsDataGridView.Location = new System.Drawing.Point(3, 150);
            this.connectionsDataGridView.Name = "connectionsDataGridView";
            this.connectionsDataGridView.ReadOnly = true;
            this.connectionsDataGridView.Size = new System.Drawing.Size(657, 150);
            this.connectionsDataGridView.TabIndex = 4;
            // 
            // departure
            // 
            this.departure.HeaderText = "Abfahrt";
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            // 
            // arrival
            // 
            this.arrival.HeaderText = "Ankunft";
            this.arrival.Name = "arrival";
            this.arrival.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "Dauer";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // station
            // 
            this.station.HeaderText = "Kante/Gleis";
            this.station.Name = "station";
            this.station.ReadOnly = true;
            // 
            // connectionSearchButton
            // 
            this.connectionSearchButton.Location = new System.Drawing.Point(333, 46);
            this.connectionSearchButton.Name = "connectionSearchButton";
            this.connectionSearchButton.Size = new System.Drawing.Size(83, 35);
            this.connectionSearchButton.TabIndex = 3;
            this.connectionSearchButton.Text = "Verbindungen suchen";
            this.connectionSearchButton.UseVisualStyleBackColor = true;
            this.connectionSearchButton.Click += new System.EventHandler(this.connectionSearchButton_Click);
            // 
            // endStationTextBox
            // 
            this.endStationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.endStationTextBox.Location = new System.Drawing.Point(197, 56);
            this.endStationTextBox.Name = "endStationTextBox";
            this.endStationTextBox.Size = new System.Drawing.Size(100, 20);
            this.endStationTextBox.TabIndex = 1;
            this.endStationTextBox.TextChanged += new System.EventHandler(this.endStationTextBox_TextChanged);
            // 
            // startStationTextBox
            // 
            this.startStationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.startStationTextBox.Location = new System.Drawing.Point(3, 54);
            this.startStationTextBox.Name = "startStationTextBox";
            this.startStationTextBox.Size = new System.Drawing.Size(100, 20);
            this.startStationTextBox.TabIndex = 0;
            this.startStationTextBox.TextChanged += new System.EventHandler(this.startStationTextBox_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 664);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1017, 11);
            this.label1.TabIndex = 2;
            // 
            // stationsGroupBox
            // 
            this.stationsGroupBox.Controls.Add(this.stationLabel);
            this.stationsGroupBox.Controls.Add(this.showMapButton);
            this.stationsGroupBox.Controls.Add(this.stationsListBox);
            this.stationsGroupBox.Controls.Add(this.stationSearchTextBox);
            this.stationsGroupBox.Location = new System.Drawing.Point(3, 371);
            this.stationsGroupBox.Name = "stationsGroupBox";
            this.stationsGroupBox.Size = new System.Drawing.Size(732, 255);
            this.stationsGroupBox.TabIndex = 5;
            this.stationsGroupBox.TabStop = false;
            this.stationsGroupBox.Text = "Stationen suchen";
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(6, 31);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(43, 13);
            this.stationLabel.TabIndex = 9;
            this.stationLabel.Text = "Station:";
            // 
            // showMapButton
            // 
            this.showMapButton.Location = new System.Drawing.Point(138, 31);
            this.showMapButton.Name = "showMapButton";
            this.showMapButton.Size = new System.Drawing.Size(98, 43);
            this.showMapButton.TabIndex = 2;
            this.showMapButton.Text = "Station auf Karte anzeigen";
            this.showMapButton.UseVisualStyleBackColor = true;
            this.showMapButton.Click += new System.EventHandler(this.showMapButton_Click);
            // 
            // stationsListBox
            // 
            this.stationsListBox.FormattingEnabled = true;
            this.stationsListBox.Location = new System.Drawing.Point(6, 85);
            this.stationsListBox.Name = "stationsListBox";
            this.stationsListBox.ScrollAlwaysVisible = true;
            this.stationsListBox.Size = new System.Drawing.Size(195, 134);
            this.stationsListBox.TabIndex = 3;
            // 
            // stationSearchTextBox
            // 
            this.stationSearchTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stationSearchTextBox.Location = new System.Drawing.Point(6, 54);
            this.stationSearchTextBox.Name = "stationSearchTextBox";
            this.stationSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.stationSearchTextBox.TabIndex = 1;
            this.stationSearchTextBox.TextChanged += new System.EventHandler(this.stationTextBox_TextChanged);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1024, 652);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mailGroupBox);
            this.tabPage1.Controls.Add(this.connectionsGroupBox);
            this.tabPage1.Controls.Add(this.stationsGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen und Stationen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mailGroupBox
            // 
            this.mailGroupBox.Controls.Add(this.toLabel);
            this.mailGroupBox.Controls.Add(this.mailReceiverTextBox);
            this.mailGroupBox.Controls.Add(this.sendMailButton);
            this.mailGroupBox.Location = new System.Drawing.Point(753, 9);
            this.mailGroupBox.Name = "mailGroupBox";
            this.mailGroupBox.Size = new System.Drawing.Size(245, 343);
            this.mailGroupBox.TabIndex = 6;
            this.mailGroupBox.TabStop = false;
            this.mailGroupBox.Text = "Verbindung mailen";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(6, 54);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 12;
            this.toLabel.Text = "An:";
            // 
            // mailReceiverTextBox
            // 
            this.mailReceiverTextBox.Location = new System.Drawing.Point(6, 80);
            this.mailReceiverTextBox.Name = "mailReceiverTextBox";
            this.mailReceiverTextBox.Size = new System.Drawing.Size(125, 20);
            this.mailReceiverTextBox.TabIndex = 1;
            // 
            // sendMailButton
            // 
            this.sendMailButton.Location = new System.Drawing.Point(152, 56);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(87, 57);
            this.sendMailButton.TabIndex = 2;
            this.sendMailButton.Text = "Verbindung per Mail senden";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Visible = false;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stationBoardGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stationBoardGroupBox
            // 
            this.stationBoardGroupBox.Controls.Add(this.stationBoardLabel);
            this.stationBoardGroupBox.Controls.Add(this.suggestedStationsListBox);
            this.stationBoardGroupBox.Controls.Add(this.stationBoardDataGridView);
            this.stationBoardGroupBox.Controls.Add(this.showDestinationBoardButton);
            this.stationBoardGroupBox.Controls.Add(this.destinationBoardStationTextBox);
            this.stationBoardGroupBox.Location = new System.Drawing.Point(6, 22);
            this.stationBoardGroupBox.Name = "stationBoardGroupBox";
            this.stationBoardGroupBox.Size = new System.Drawing.Size(732, 309);
            this.stationBoardGroupBox.TabIndex = 1;
            this.stationBoardGroupBox.TabStop = false;
            this.stationBoardGroupBox.Text = "Abfahrtstafel";
            // 
            // stationBoardLabel
            // 
            this.stationBoardLabel.AutoSize = true;
            this.stationBoardLabel.Location = new System.Drawing.Point(6, 29);
            this.stationBoardLabel.Name = "stationBoardLabel";
            this.stationBoardLabel.Size = new System.Drawing.Size(29, 13);
            this.stationBoardLabel.TabIndex = 6;
            this.stationBoardLabel.Text = "Von:";
            // 
            // suggestedStationsListBox
            // 
            this.suggestedStationsListBox.FormattingEnabled = true;
            this.suggestedStationsListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.suggestedStationsListBox.Location = new System.Drawing.Point(6, 86);
            this.suggestedStationsListBox.Name = "suggestedStationsListBox";
            this.suggestedStationsListBox.ScrollAlwaysVisible = true;
            this.suggestedStationsListBox.Size = new System.Drawing.Size(120, 95);
            this.suggestedStationsListBox.TabIndex = 5;
            this.suggestedStationsListBox.Visible = false;
            this.suggestedStationsListBox.SelectedIndexChanged += new System.EventHandler(this.suggestedStationsListBox_SelectedIndexChanged);
            // 
            // stationBoardDataGridView
            // 
            this.stationBoardDataGridView.AllowUserToDeleteRows = false;
            this.stationBoardDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stationBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationBoardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destination,
            this.depar,
            this.vehicle});
            this.stationBoardDataGridView.Location = new System.Drawing.Point(6, 107);
            this.stationBoardDataGridView.Name = "stationBoardDataGridView";
            this.stationBoardDataGridView.ReadOnly = true;
            this.stationBoardDataGridView.Size = new System.Drawing.Size(657, 150);
            this.stationBoardDataGridView.TabIndex = 4;
            // 
            // destination
            // 
            this.destination.HeaderText = "Nach";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // depar
            // 
            this.depar.HeaderText = "Abfahrt";
            this.depar.Name = "depar";
            this.depar.ReadOnly = true;
            // 
            // vehicle
            // 
            this.vehicle.HeaderText = "Bus/Zug/Schiff";
            this.vehicle.Name = "vehicle";
            this.vehicle.ReadOnly = true;
            // 
            // showDestinationBoardButton
            // 
            this.showDestinationBoardButton.Location = new System.Drawing.Point(139, 47);
            this.showDestinationBoardButton.Name = "showDestinationBoardButton";
            this.showDestinationBoardButton.Size = new System.Drawing.Size(83, 35);
            this.showDestinationBoardButton.TabIndex = 3;
            this.showDestinationBoardButton.Text = "Verbindungen suchen";
            this.showDestinationBoardButton.UseVisualStyleBackColor = true;
            this.showDestinationBoardButton.Click += new System.EventHandler(this.destinationBoardSearchButton_Click);
            // 
            // destinationBoardStationTextBox
            // 
            this.destinationBoardStationTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.destinationBoardStationTextBox.Location = new System.Drawing.Point(6, 55);
            this.destinationBoardStationTextBox.Name = "destinationBoardStationTextBox";
            this.destinationBoardStationTextBox.Size = new System.Drawing.Size(100, 20);
            this.destinationBoardStationTextBox.TabIndex = 0;
            this.destinationBoardStationTextBox.TextChanged += new System.EventHandler(this.startStationDestinationBoardTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.connectionSearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 664);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "M318 Applikation";
            this.connectionsGroupBox.ResumeLayout(false);
            this.connectionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).EndInit();
            this.stationsGroupBox.ResumeLayout(false);
            this.stationsGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mailGroupBox.ResumeLayout(false);
            this.mailGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.stationBoardGroupBox.ResumeLayout(false);
            this.stationBoardGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox connectionsGroupBox;
        private System.Windows.Forms.TextBox startStationTextBox;
        private System.Windows.Forms.TextBox endStationTextBox;
        private System.Windows.Forms.Button connectionSearchButton;
        private System.Windows.Forms.DataGridView connectionsDataGridView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox stationsGroupBox;
        private System.Windows.Forms.TextBox stationSearchTextBox;
        private System.Windows.Forms.ListBox stationsListBox;
        private System.Windows.Forms.Button switchStationsButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox stationBoardGroupBox;
        private System.Windows.Forms.DataGridView stationBoardDataGridView;
        private System.Windows.Forms.Button showDestinationBoardButton;
        private System.Windows.Forms.TextBox destinationBoardStationTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn depar;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicle;
        private System.Windows.Forms.ListBox suggestedEndListBox;
        private System.Windows.Forms.ListBox suggestedStartListBox;
        private System.Windows.Forms.ListBox suggestedStationsListBox;
        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.GroupBox mailGroupBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox mailReceiverTextBox;
        private System.Windows.Forms.Button showMapButton;
        private System.Windows.Forms.Label endStationLabel;
        private System.Windows.Forms.Label startStationLabel;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.Label stationBoardLabel;
    }
}

