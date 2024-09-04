using System;
using System.Drawing;
using System.Windows.Forms;

public class UtiDetailsFormPreference1 : Form
{
    public UtiDetailsFormPreference1()
    {
        // Initialize components and form properties
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        // Example: Adding jurisdictions and corresponding labels/textboxes
        string[] jurisdictions = { "ASIC", "EMIR", "FCA", "MAS", "HKMA" };

        this.Text = "Add UTI Details";
        this.Size = new Size(600, 400);
        this.FormBorderStyle = FormBorderStyle.Sizable;

        int yPos = 10;  // Starting Y position

        foreach (var jurisdiction in jurisdictions)
        {
            Label lblTradeId = new Label();
            lblTradeId.Text = $"{jurisdiction}_UTI_Trade_Id:";
            lblTradeId.Location = new Point(10, yPos);
            lblTradeId.AutoSize = true;

            TextBox txtTradeId = new TextBox();
            txtTradeId.Location = new Point(200, yPos);
            txtTradeId.Width = 300;

            Label lblIssuer = new Label();
            lblIssuer.Text = $"{jurisdiction}_UTI_Issuer:";
            lblIssuer.Location = new Point(10, yPos + 30);
            lblIssuer.AutoSize = true;

            TextBox txtIssuer = new TextBox();
            txtIssuer.Location = new Point(200, yPos + 30);
            txtIssuer.Width = 300;

            Label lblGenerator = new Label();
            lblGenerator.Text = $"{jurisdiction}_UTI_Generator:";
            lblGenerator.Location = new Point(10, yPos + 60);
            lblGenerator.AutoSize = true;

            TextBox txtGenerator = new TextBox();
            txtGenerator.Location = new Point(200, yPos + 60);
            txtGenerator.Width = 300;

            // Add controls to the form
            this.Controls.Add(lblTradeId);
            this.Controls.Add(txtTradeId);
            this.Controls.Add(lblIssuer);
            this.Controls.Add(txtIssuer);
            this.Controls.Add(lblGenerator);
            this.Controls.Add(txtGenerator);

            yPos += 100;  // Move down for the next jurisdiction
        }

        // Add a Save button
        Button btnSave = new Button();
        btnSave.Text = "Save";
        btnSave.Location = new Point(250, yPos);
        btnSave.Click += new EventHandler(Save_Click);
        this.Controls.Add(btnSave);
    }

    private void Save_Click(object sender, EventArgs e)
    {
        // Implement saving logic here
        MessageBox.Show("Details saved!");
    }
}
//Assumptions:
  Preference 1: Shows a list of different jurisdictions with their corresponding UTI Trade IDs, Issuers, and Generators.
  Preference 2: Includes a dropdown to select the jurisdiction and then shows the corresponding fields to input UTI Trade ID, Issuer, and Generator.
  Implementing Preference 1:
  Create the New Form Layout:
  For Preference 1, you would create a list of labels and textboxes for each jurisdiction.