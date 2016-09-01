namespace RemoteSurf
{
    partial class RemoteSurf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteSurf));
            this.OrientationGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LiveReportGroup = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.deviation_progress = new System.Windows.Forms.ProgressBar();
            this.total_deviation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviationGroup = new System.Windows.Forms.GroupBox();
            this.dev_x = new System.Windows.Forms.TextBox();
            this.dev_y = new System.Windows.Forms.TextBox();
            this.dev_z = new System.Windows.Forms.TextBox();
            this.NominalGroup = new System.Windows.Forms.GroupBox();
            this.nom_x = new System.Windows.Forms.TextBox();
            this.nom_y = new System.Windows.Forms.TextBox();
            this.nom_z = new System.Windows.Forms.TextBox();
            this.ActiveDeviceCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MeasureGroup = new System.Windows.Forms.GroupBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.SplineButton = new System.Windows.Forms.Button();
            this.SlotButton = new System.Windows.Forms.Button();
            this.PlaneButton = new System.Windows.Forms.Button();
            this.SphereButton = new System.Windows.Forms.Button();
            this.Cylinder = new System.Windows.Forms.Button();
            this.ConeButton = new System.Windows.Forms.Button();
            this.CancelMeasureButton = new System.Windows.Forms.Button();
            this.CADViewGroup = new System.Windows.Forms.GroupBox();
            this.button21 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.ConnectionGroup = new System.Windows.Forms.GroupBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommandText = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.OrientationGroup.SuspendLayout();
            this.LiveReportGroup.SuspendLayout();
            this.DeviationGroup.SuspendLayout();
            this.NominalGroup.SuspendLayout();
            this.MeasureGroup.SuspendLayout();
            this.CADViewGroup.SuspendLayout();
            this.ConnectionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrientationGroup
            // 
            this.OrientationGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OrientationGroup.Controls.Add(this.button1);
            this.OrientationGroup.Controls.Add(this.button2);
            this.OrientationGroup.Controls.Add(this.button3);
            this.OrientationGroup.Controls.Add(this.button4);
            this.OrientationGroup.Location = new System.Drawing.Point(180, 158);
            this.OrientationGroup.Name = "OrientationGroup";
            this.OrientationGroup.Size = new System.Drawing.Size(177, 127);
            this.OrientationGroup.TabIndex = 2;
            this.OrientationGroup.TabStop = false;
            this.OrientationGroup.Text = "Orientation";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(65, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.Tag = "orientation";
            this.button1.Text = "ISO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(9, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 1;
            this.button2.Tag = "orientation";
            this.button2.Text = "Front";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(65, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 1;
            this.button3.Tag = "orientation";
            this.button3.Text = "Top";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(121, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 1;
            this.button4.Tag = "orientation";
            this.button4.Text = "Right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // LiveReportGroup
            // 
            this.LiveReportGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveReportGroup.Controls.Add(this.RefreshButton);
            this.LiveReportGroup.Controls.Add(this.deviation_progress);
            this.LiveReportGroup.Controls.Add(this.total_deviation);
            this.LiveReportGroup.Controls.Add(this.label2);
            this.LiveReportGroup.Controls.Add(this.DeviationGroup);
            this.LiveReportGroup.Controls.Add(this.NominalGroup);
            this.LiveReportGroup.Controls.Add(this.ActiveDeviceCombo);
            this.LiveReportGroup.Controls.Add(this.label1);
            this.LiveReportGroup.Location = new System.Drawing.Point(180, 290);
            this.LiveReportGroup.Name = "LiveReportGroup";
            this.LiveReportGroup.Size = new System.Drawing.Size(360, 240);
            this.LiveReportGroup.TabIndex = 4;
            this.LiveReportGroup.TabStop = false;
            this.LiveReportGroup.Text = "Live Report";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(150, 36);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(55, 23);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Clicked);
            // 
            // deviation_progress
            // 
            this.deviation_progress.Location = new System.Drawing.Point(18, 201);
            this.deviation_progress.MarqueeAnimationSpeed = 50;
            this.deviation_progress.Maximum = 500;
            this.deviation_progress.Name = "deviation_progress";
            this.deviation_progress.Size = new System.Drawing.Size(134, 23);
            this.deviation_progress.Step = 1;
            this.deviation_progress.TabIndex = 5;
            this.deviation_progress.Value = 250;
            // 
            // total_deviation
            // 
            this.total_deviation.AutoSize = true;
            this.total_deviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_deviation.Location = new System.Drawing.Point(164, 178);
            this.total_deviation.Name = "total_deviation";
            this.total_deviation.Size = new System.Drawing.Size(178, 55);
            this.total_deviation.TabIndex = 4;
            this.total_deviation.Text = "0.0000";
            this.total_deviation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "3D Distance";
            // 
            // DeviationGroup
            // 
            this.DeviationGroup.Controls.Add(this.dev_x);
            this.DeviationGroup.Controls.Add(this.dev_y);
            this.DeviationGroup.Controls.Add(this.dev_z);
            this.DeviationGroup.Location = new System.Drawing.Point(18, 123);
            this.DeviationGroup.Name = "DeviationGroup";
            this.DeviationGroup.Size = new System.Drawing.Size(324, 52);
            this.DeviationGroup.TabIndex = 3;
            this.DeviationGroup.TabStop = false;
            this.DeviationGroup.Text = "Deviation";
            // 
            // dev_x
            // 
            this.dev_x.Location = new System.Drawing.Point(6, 20);
            this.dev_x.Name = "dev_x";
            this.dev_x.ReadOnly = true;
            this.dev_x.Size = new System.Drawing.Size(100, 20);
            this.dev_x.TabIndex = 0;
            this.dev_x.Text = "0.0000";
            this.dev_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dev_y
            // 
            this.dev_y.Location = new System.Drawing.Point(113, 20);
            this.dev_y.Name = "dev_y";
            this.dev_y.ReadOnly = true;
            this.dev_y.Size = new System.Drawing.Size(100, 20);
            this.dev_y.TabIndex = 0;
            this.dev_y.Text = "0.0000";
            this.dev_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dev_z
            // 
            this.dev_z.Location = new System.Drawing.Point(219, 20);
            this.dev_z.Name = "dev_z";
            this.dev_z.ReadOnly = true;
            this.dev_z.Size = new System.Drawing.Size(100, 20);
            this.dev_z.TabIndex = 0;
            this.dev_z.Text = "0.0000";
            this.dev_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NominalGroup
            // 
            this.NominalGroup.Controls.Add(this.nom_x);
            this.NominalGroup.Controls.Add(this.nom_y);
            this.NominalGroup.Controls.Add(this.nom_z);
            this.NominalGroup.Location = new System.Drawing.Point(18, 65);
            this.NominalGroup.Name = "NominalGroup";
            this.NominalGroup.Size = new System.Drawing.Size(324, 52);
            this.NominalGroup.TabIndex = 2;
            this.NominalGroup.TabStop = false;
            this.NominalGroup.Text = "Nominal";
            // 
            // nom_x
            // 
            this.nom_x.Location = new System.Drawing.Point(6, 20);
            this.nom_x.Name = "nom_x";
            this.nom_x.ReadOnly = true;
            this.nom_x.Size = new System.Drawing.Size(100, 20);
            this.nom_x.TabIndex = 0;
            this.nom_x.Text = "0.0000";
            this.nom_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nom_y
            // 
            this.nom_y.Location = new System.Drawing.Point(113, 20);
            this.nom_y.Name = "nom_y";
            this.nom_y.ReadOnly = true;
            this.nom_y.Size = new System.Drawing.Size(100, 20);
            this.nom_y.TabIndex = 0;
            this.nom_y.Text = "0.0000";
            this.nom_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nom_z
            // 
            this.nom_z.Location = new System.Drawing.Point(219, 20);
            this.nom_z.Name = "nom_z";
            this.nom_z.ReadOnly = true;
            this.nom_z.Size = new System.Drawing.Size(100, 20);
            this.nom_z.TabIndex = 0;
            this.nom_z.Text = "0.0000";
            this.nom_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ActiveDeviceCombo
            // 
            this.ActiveDeviceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveDeviceCombo.FormattingEnabled = true;
            this.ActiveDeviceCombo.Location = new System.Drawing.Point(18, 37);
            this.ActiveDeviceCombo.Name = "ActiveDeviceCombo";
            this.ActiveDeviceCombo.Size = new System.Drawing.Size(125, 21);
            this.ActiveDeviceCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active Device";
            // 
            // MeasureGroup
            // 
            this.MeasureGroup.Controls.Add(this.BuildButton);
            this.MeasureGroup.Controls.Add(this.PointButton);
            this.MeasureGroup.Controls.Add(this.LineButton);
            this.MeasureGroup.Controls.Add(this.CircleButton);
            this.MeasureGroup.Controls.Add(this.EllipseButton);
            this.MeasureGroup.Controls.Add(this.SplineButton);
            this.MeasureGroup.Controls.Add(this.SlotButton);
            this.MeasureGroup.Controls.Add(this.PlaneButton);
            this.MeasureGroup.Controls.Add(this.SphereButton);
            this.MeasureGroup.Controls.Add(this.Cylinder);
            this.MeasureGroup.Controls.Add(this.ConeButton);
            this.MeasureGroup.Controls.Add(this.CancelMeasureButton);
            this.MeasureGroup.Location = new System.Drawing.Point(12, 6);
            this.MeasureGroup.Name = "MeasureGroup";
            this.MeasureGroup.Size = new System.Drawing.Size(158, 524);
            this.MeasureGroup.TabIndex = 1;
            this.MeasureGroup.TabStop = false;
            this.MeasureGroup.Text = "Measure";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(10, 20);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(142, 35);
            this.BuildButton.TabIndex = 0;
            this.BuildButton.Tag = "build";
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // PointButton
            // 
            this.PointButton.Location = new System.Drawing.Point(10, 61);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(142, 35);
            this.PointButton.TabIndex = 0;
            this.PointButton.Tag = "measure";
            this.PointButton.Text = "Point";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(10, 102);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(142, 35);
            this.LineButton.TabIndex = 0;
            this.LineButton.Tag = "measure";
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(10, 143);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(142, 35);
            this.CircleButton.TabIndex = 0;
            this.CircleButton.Tag = "measure";
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(10, 185);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(142, 35);
            this.EllipseButton.TabIndex = 0;
            this.EllipseButton.Tag = "measure";
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // SplineButton
            // 
            this.SplineButton.Location = new System.Drawing.Point(10, 225);
            this.SplineButton.Name = "SplineButton";
            this.SplineButton.Size = new System.Drawing.Size(142, 35);
            this.SplineButton.TabIndex = 0;
            this.SplineButton.Tag = "measure";
            this.SplineButton.Text = "Spline";
            this.SplineButton.UseVisualStyleBackColor = true;
            this.SplineButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // SlotButton
            // 
            this.SlotButton.Location = new System.Drawing.Point(10, 266);
            this.SlotButton.Name = "SlotButton";
            this.SlotButton.Size = new System.Drawing.Size(142, 35);
            this.SlotButton.TabIndex = 0;
            this.SlotButton.Tag = "measure";
            this.SlotButton.Text = "Slot";
            this.SlotButton.UseVisualStyleBackColor = true;
            this.SlotButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // PlaneButton
            // 
            this.PlaneButton.Location = new System.Drawing.Point(10, 307);
            this.PlaneButton.Name = "PlaneButton";
            this.PlaneButton.Size = new System.Drawing.Size(142, 35);
            this.PlaneButton.TabIndex = 0;
            this.PlaneButton.Tag = "measure";
            this.PlaneButton.Text = "Plane";
            this.PlaneButton.UseVisualStyleBackColor = true;
            this.PlaneButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // SphereButton
            // 
            this.SphereButton.Location = new System.Drawing.Point(10, 348);
            this.SphereButton.Name = "SphereButton";
            this.SphereButton.Size = new System.Drawing.Size(142, 35);
            this.SphereButton.TabIndex = 0;
            this.SphereButton.Tag = "measure";
            this.SphereButton.Text = "Sphere";
            this.SphereButton.UseVisualStyleBackColor = true;
            this.SphereButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // Cylinder
            // 
            this.Cylinder.Location = new System.Drawing.Point(10, 389);
            this.Cylinder.Name = "Cylinder";
            this.Cylinder.Size = new System.Drawing.Size(142, 35);
            this.Cylinder.TabIndex = 0;
            this.Cylinder.Tag = "measure";
            this.Cylinder.Text = "Cylinder";
            this.Cylinder.UseVisualStyleBackColor = true;
            this.Cylinder.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // ConeButton
            // 
            this.ConeButton.Location = new System.Drawing.Point(10, 430);
            this.ConeButton.Name = "ConeButton";
            this.ConeButton.Size = new System.Drawing.Size(142, 35);
            this.ConeButton.TabIndex = 0;
            this.ConeButton.Tag = "measure";
            this.ConeButton.Text = "Cone";
            this.ConeButton.UseVisualStyleBackColor = true;
            this.ConeButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // CancelMeasureButton
            // 
            this.CancelMeasureButton.BackColor = System.Drawing.Color.LightPink;
            this.CancelMeasureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelMeasureButton.Location = new System.Drawing.Point(10, 483);
            this.CancelMeasureButton.Name = "CancelMeasureButton";
            this.CancelMeasureButton.Size = new System.Drawing.Size(142, 35);
            this.CancelMeasureButton.TabIndex = 0;
            this.CancelMeasureButton.Tag = "cancel";
            this.CancelMeasureButton.Text = "Cancel Measure";
            this.CancelMeasureButton.UseVisualStyleBackColor = false;
            this.CancelMeasureButton.Click += new System.EventHandler(this.MeasureButton_Clicked);
            // 
            // CADViewGroup
            // 
            this.CADViewGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CADViewGroup.Controls.Add(this.button21);
            this.CADViewGroup.Controls.Add(this.button17);
            this.CADViewGroup.Controls.Add(this.button18);
            this.CADViewGroup.Controls.Add(this.button19);
            this.CADViewGroup.Controls.Add(this.button22);
            this.CADViewGroup.Controls.Add(this.button20);
            this.CADViewGroup.Location = new System.Drawing.Point(363, 158);
            this.CADViewGroup.Name = "CADViewGroup";
            this.CADViewGroup.Size = new System.Drawing.Size(177, 127);
            this.CADViewGroup.TabIndex = 3;
            this.CADViewGroup.TabStop = false;
            this.CADViewGroup.Text = "CAD View";
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button21.Location = new System.Drawing.Point(9, 15);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 50);
            this.button21.TabIndex = 0;
            this.button21.Tag = "zoom";
            this.button21.Text = "In";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button17
            // 
            this.button17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button17.Location = new System.Drawing.Point(121, 71);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 1;
            this.button17.Tag = "pan";
            this.button17.Text = "Right";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button18.Location = new System.Drawing.Point(65, 71);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 1;
            this.button18.Tag = "pan";
            this.button18.Text = "Down";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button19.Location = new System.Drawing.Point(9, 71);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 1;
            this.button19.Tag = "pan";
            this.button19.Text = "Left";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Location = new System.Drawing.Point(121, 15);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(50, 50);
            this.button22.TabIndex = 0;
            this.button22.Tag = "zoom";
            this.button22.Text = "Out";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button20.Location = new System.Drawing.Point(65, 15);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 50);
            this.button20.TabIndex = 0;
            this.button20.Tag = "pan";
            this.button20.Text = "Up";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.CADViewButton_Clicked);
            // 
            // ConnectionGroup
            // 
            this.ConnectionGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionGroup.BackColor = System.Drawing.SystemColors.Window;
            this.ConnectionGroup.Controls.Add(this.ErrorLabel);
            this.ConnectionGroup.Controls.Add(this.label6);
            this.ConnectionGroup.Controls.Add(this.ConnectionStatus);
            this.ConnectionGroup.Controls.Add(this.label4);
            this.ConnectionGroup.Controls.Add(this.CommandText);
            this.ConnectionGroup.Controls.Add(this.SendButton);
            this.ConnectionGroup.Controls.Add(this.ConnectButton);
            this.ConnectionGroup.Location = new System.Drawing.Point(180, 6);
            this.ConnectionGroup.Name = "ConnectionGroup";
            this.ConnectionGroup.Size = new System.Drawing.Size(360, 144);
            this.ConnectionGroup.TabIndex = 0;
            this.ConnectionGroup.TabStop = false;
            this.ConnectionGroup.Text = "Connection";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(6, 84);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(35, 13);
            this.ErrorLabel.TabIndex = 3;
            this.ErrorLabel.Text = "Error: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Version: 0";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.AutoSize = true;
            this.ConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ConnectionStatus.Location = new System.Drawing.Point(43, 48);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(103, 16);
            this.ConnectionStatus.TabIndex = 1;
            this.ConnectionStatus.Text = "Disconnected";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status:";
            // 
            // CommandText
            // 
            this.CommandText.Location = new System.Drawing.Point(9, 20);
            this.CommandText.Name = "CommandText";
            this.CommandText.Size = new System.Drawing.Size(264, 20);
            this.CommandText.TabIndex = 5;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(279, 19);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 22);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendCommand_Clicked);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConnectButton.Location = new System.Drawing.Point(6, 106);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(142, 27);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.Connect_Clicked);
            // 
            // RemoteSurf
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(552, 539);
            this.Controls.Add(this.ConnectionGroup);
            this.Controls.Add(this.MeasureGroup);
            this.Controls.Add(this.LiveReportGroup);
            this.Controls.Add(this.CADViewGroup);
            this.Controls.Add(this.OrientationGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RemoteSurf";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RemoteSurf";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLoad);
            this.OrientationGroup.ResumeLayout(false);
            this.LiveReportGroup.ResumeLayout(false);
            this.LiveReportGroup.PerformLayout();
            this.DeviationGroup.ResumeLayout(false);
            this.DeviationGroup.PerformLayout();
            this.NominalGroup.ResumeLayout(false);
            this.NominalGroup.PerformLayout();
            this.MeasureGroup.ResumeLayout(false);
            this.CADViewGroup.ResumeLayout(false);
            this.ConnectionGroup.ResumeLayout(false);
            this.ConnectionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrientationGroup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox LiveReportGroup;
        private System.Windows.Forms.GroupBox DeviationGroup;
        private System.Windows.Forms.TextBox dev_z;
        private System.Windows.Forms.TextBox dev_y;
        private System.Windows.Forms.TextBox dev_x;
        private System.Windows.Forms.GroupBox NominalGroup;
        private System.Windows.Forms.TextBox nom_z;
        private System.Windows.Forms.TextBox nom_y;
        private System.Windows.Forms.TextBox nom_x;
        private System.Windows.Forms.ComboBox ActiveDeviceCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar deviation_progress;
        private System.Windows.Forms.Label total_deviation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox MeasureGroup;
        private System.Windows.Forms.Button CancelMeasureButton;
        private System.Windows.Forms.Button ConeButton;
        private System.Windows.Forms.Button Cylinder;
        private System.Windows.Forms.Button SphereButton;
        private System.Windows.Forms.Button PlaneButton;
        private System.Windows.Forms.Button SlotButton;
        private System.Windows.Forms.Button SplineButton;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.GroupBox CADViewGroup;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.GroupBox ConnectionGroup;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox CommandText;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ConnectionStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RefreshButton;
    }
}

