using System;
using System.Drawing;
using System.Windows.Forms;

public class UtiDetailsFormPreference2 : Form
{
    private ComboBox cbJurisdiction;
    private TextBox txtTradeId, txtIssuer, txtGenerator;

    public UtiDetailsFormPreference2()
    {
        // Initialize components and form properties
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Add UTI Details";
        this.Size = new Size(600, 300);
        this.FormBorderStyle = FormBorderStyle.Sizable;

        Label lblJurisdiction = new Label();
        lblJurisdiction.Text = "Jurisdiction:";
        lblJurisdiction.Location = new Point(10, 10);
        lblJurisdiction.AutoSize = true;

        cbJurisdiction = new ComboBox();
        cbJurisdiction.Items.AddRange(new string[] { "ASIC", "EMIR", "FCA", "MAS", "HKMA" });
        cbJurisdiction.Location = new Point(150, 10);
        cbJurisdiction.SelectedIndexChanged += new EventHandler(Jurisdiction_SelectedIndexChanged);

        Label lblTradeId = new Label();
        lblTradeId.Text = "UTI Trade Id:";
        lblTradeId.Location = new Point(10, 50);
        lblTradeId.AutoSize = true;

        txtTradeId = new TextBox();
        txtTradeId.Location = new Point(150, 50);
        txtTradeId.Width = 300;

        Label lblIssuer = new Label();
        lblIssuer.Text = "UTI Issuer:";
        lblIssuer.Location = new Point(10, 90);
        lblIssuer.AutoSize = true;

        txtIssuer = new TextBox();
        txtIssuer.Location = new Point(150, 90);
        txtIssuer.Width = 300;

        Label lblGenerator = new Label();
        lblGenerator.Text = "UTI Generator:";
        lblGenerator.Location = new Point(10, 130);
        lblGenerator.AutoSize = true;

        txtGenerator = new TextBox();
        txtGenerator.Location = new Point(150, 130);
        txtGenerator.Width = 300;

        // Add controls to the form
        this.Controls.Add(lblJurisdiction);
        this.Controls.Add(cbJurisdiction);
        this.Controls.Add(lblTradeId);
        this.Controls.Add(txtTradeId);
        this.Controls.Add(lblIssuer);
        this.Controls.Add(txtIssuer);
        this.Controls.Add(lblGenerator);
        this.Controls.Add(txtGenerator);

        // Add a Save button
        Button btnSave = new Button();
        btnSave.Text = "Save";
        btnSave.Location = new Point(250, 170);
        btnSave.Click += new EventHandler(Save_Click);
        this.Controls.Add(btnSave);
    }

    private void Jurisdiction_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Handle logic for when a jurisdiction is selected
        // For now, just display a message
        MessageBox.Show("Jurisdiction selected: " + cbJurisdiction.SelectedItem.ToString());
    }

    private void Save_Click(object sender, EventArgs e)
    {
        // Implement saving logic here
        MessageBox.Show("Details saved!");
    }
}
//Implementing Preference 2:
  Create the Form Layout:
  For Preference 2, you would create a dropdown to select the jurisdiction, and then show the corresponding textboxes.

  Explanation:
  Preference 1: This example creates a form that displays all jurisdictions at once, with corresponding fields for Trade ID, Issuer, and Generator.
  Preference 2: This example uses a dropdown to select the jurisdiction and then shows fields related to that jurisdiction.
  Deployment:
  Replace the existing form with one of these implementations, depending on which preference you want to use.
  Integrate the form into your existing application logic where necessary.
  This should provide a good foundation for building the UTI details popup as specified in the images you uploaded. Adjust the code based on your specific requirements and integrate it into your project as needed.