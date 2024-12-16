using Godot;
using System;

public class MainWindow : Control
{
	// Declare member variables here.
	
	// Node declaration.
	private Button analyzeButton;
	private Button primaryBrowseButton;
	private Button secondaryBrowseButton;
	private LineEdit primaryDirectoryBox;
	private LineEdit secondaryDirectoryBox;
	private LineEdit folderDirectoryBox;
	private FileDialog folderBrowser;
	private PopupPanel progressPanel;
	private Label progressLabel;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Retrieve nodes and signals.
		SyncNodesAndSignals();
	}
	
	// Sync all nodes and signals.
	private void SyncNodesAndSignals()
	{
		// Connect nodes.
		analyzeButton = (Button)GetNode("AnalyzeButton");
		primaryBrowseButton = (Button)GetNode("PrimaryBrowseButton");
		secondaryBrowseButton = (Button)GetNode("SecondaryBrowseButton");
		primaryDirectoryBox = (LineEdit)GetNode("PrimaryDirectoryBox");
		secondaryDirectoryBox = (LineEdit)GetNode("SecondaryDirectoryBox");
		folderBrowser = (FileDialog)GetNode("FolderBrowser");
		progressPanel = (PopupPanel)GetNode("ProgressPanel");
		progressLabel = (Label)GetNode("ProgressPanel/ProgressLabel");
		
		// Connect signals and c# functions.
		analyzeButton.Connect("pressed", this, "analyzeButton_pressed");
		primaryBrowseButton.Connect("pressed", this, "primaryBrowseButton_pressed");
		secondaryBrowseButton.Connect("pressed", this, "secondaryBrowseButton_pressed");
		folderBrowser.Connect("dir_selected", this, "folderBrowser_dir_selected");
	}
	
	// Function for pressing the button.
	public void analyzeButton_pressed()
	{
		// Enlarge the window.
		//EnlargeWindow();
		progressPanel.Visible = true;
		progressLabel.Text = "hi";
		
		
	}
	
	public void primaryBrowseButton_pressed()
	{
		// Retrieve the primary file path.
		folderDirectoryBox = primaryDirectoryBox;
		folderBrowser.Visible = true;
	}
	
	public void secondaryBrowseButton_pressed()
	{
		// Retrieve the secondary file path.
		folderDirectoryBox = secondaryDirectoryBox;
		folderBrowser.Visible = true;
	}
	
	public void folderBrowser_dir_selected(string dir)
	{
		// Set the current directory.
		folderDirectoryBox.Text = dir;
		
		// Check if both boxes have text in them.
		if ((primaryDirectoryBox.Text != "") && (secondaryDirectoryBox.Text != ""))
		{
			analyzeButton.Disabled = false;
		}
	}
	
	private void EnlargeWindow()
	{
		// Setup the window size and position variables.
		Vector2 newWindowResolution;
		Vector2 newWindowPosition;
		Vector2 oldWindowResolution = OS.GetWindowSize();
		Vector2 oldWindowPosition = OS.GetWindowPosition();
		
		// Make the new size.
		newWindowPosition.x = oldWindowPosition.x;
		newWindowPosition.y = 100;
		newWindowResolution.x = oldWindowResolution.x;
		newWindowResolution.y = 850;
		
		// Resize & reposition.
		OS.SetWindowSize(newWindowResolution);
		OS.SetWindowPosition(newWindowPosition);
	}
}
