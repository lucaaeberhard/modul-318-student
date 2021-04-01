using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;

namespace SwissTransportGui
{
    public partial class Form1 : Form
    {

        ITransport transport = new Transport();

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = startStationTextBox;
        }

        private void connectionSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string startStation = startStationTextBox.Text;
                string endStation = endStationTextBox.Text;
                Connections connections = transport.GetConnections(startStation, endStation);
                foreach (Connection connection in connections.ConnectionList)
                {
                    connectionsDataGridView.Rows.Add(
                        connection.From.Departure,
                        connection.To.Arrival,
                        connection.Duration,
                        connection.To.Platform
                        );
                }
                suggestedStartListBox.Visible = false;
                suggestedEndListBox.Visible = false;
                sendMailButton.Visible = true;
            }
            catch
            {
                MessageBox.Show("Es konnten keine Verbindungen gefunden werden", "Warnung",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void stationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                stationsListBox.Items.Clear();
                autoComplete(stationSearchTextBox, stationsListBox);
            }
            catch
            {
                return;
            }
        }

        private void destinationBoardSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                stationBoardDataGridView.Rows.Clear();
                string startStation = destinationBoardStationTextBox.Text;
                StationBoardRoot stationboards = transport.GetStationBoard(startStation);
                foreach (StationBoard stationboard in stationboards.Entries)
                {
                    stationBoardDataGridView.Rows.Add(
                        stationboard.To,
                        stationboard.Stop.Departure.ToString("HH:mm"),
                        stationboard.Category + stationboard.Number
                        );
                }
                suggestedStationsListBox.Visible = false;
            }
            catch
            {
                MessageBox.Show("Es konnten keine Verbindungen gefunden werden", "Warnung",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void switchStationsButton_Click(object sender, EventArgs e)
        {
            string clipBoard = startStationTextBox.Text;
            startStationTextBox.Text = endStationTextBox.Text;
            endStationTextBox.Text = clipBoard;
        }

        private void startStationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                suggestedStartListBox.Items.Clear();
                suggestedStartListBox.Visible = true;
                autoComplete(startStationTextBox, suggestedStartListBox);
            }
            catch
            {
                return;
            }
        }

        private void endStationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                suggestedEndListBox.Items.Clear();
                suggestedEndListBox.Visible = true;
                autoComplete(endStationTextBox, suggestedEndListBox);
            }
            catch
            {
                return;
            }
        }

        private void startStationDestinationBoardTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                suggestedStationsListBox.Items.Clear();
                suggestedStationsListBox.Visible = true;
                autoComplete(destinationBoardStationTextBox, suggestedStationsListBox);
            }
            catch
            {
                return;
            }
        }

        private void autoComplete(TextBox textBoxName, ListBox listBoxName)
        {
            if (textBoxName.Text == "")
            {
                listBoxName.Visible = false;
            }
            else
            {
                Stations stations = transport.GetStations(textBoxName.Text);
                foreach (Station station in stations.StationList)
                {
                    listBoxName.Items.Add(station.Name);
                }
            }
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Wird ohne for-Schleife gemacht, da ich unten eine Nachricht zusammenstelle
                string departure = connectionsDataGridView.Rows[0].Cells[0].Value.ToString();
                string arrival = connectionsDataGridView.Rows[1].Cells[1].Value.ToString();
                string duration = connectionsDataGridView.Rows[2].Cells[2].Value.ToString();
                string station = connectionsDataGridView.Rows[3].Cells[3].Value.ToString();
                MailForm mail = new MailForm();
                mail.emailAddress = mailReceiverTextBox.Text;
                mail.body = "Abfahrt: " + departure + "\n Ankunft: " + arrival + "\n Dauer: " + duration + "\n Kante/Gleis: " + station;
                mail.sendMail();
            }
            catch
            {
                MessageBox.Show("Das Mail konnte nicht versendet werden", "Warnung",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showMapButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://map.search.ch/" + stationSearchTextBox.Text + "-haltestelle");
            }
            catch
            {
                MessageBox.Show("Die Karte konnte nicht geöffnet werden", "Warnung",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void suggestedStartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startStationTextBox.Text = suggestedStartListBox.Text;
            this.ActiveControl = startStationTextBox;
        }

        private void suggestedStationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            destinationBoardStationTextBox.Text = suggestedStationsListBox.Text;
            this.ActiveControl = destinationBoardStationTextBox;
        }

        private void suggestedEndListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            endStationTextBox.Text = suggestedEndListBox.Text;
            this.ActiveControl = endStationTextBox;
        }
    }
}
