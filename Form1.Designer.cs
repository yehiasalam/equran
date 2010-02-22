namespace eQuran
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mextension = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.spcQuran = new System.Windows.Forms.SplitContainer();
            this.cntleft = new System.Windows.Forms.SplitContainer();
            this.pnla = new eQuran.PanelEx();
            this.clrPainter = new eQuran.ColorPainter();
            this.txtpnla = new eQuran.TextBoxEx();
            this.pnlb = new eQuran.PanelEx();
            this.txtpnlb = new eQuran.TextBoxEx();
            this.cntright = new System.Windows.Forms.SplitContainer();
            this.panelBase1 = new eQuran.PanelBase();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbrecitors = new System.Windows.Forms.ComboBox();
            this.QuranVolume = new eQuran.VolumeBar();
            this.cmdstop = new eQuran.MediaControls();
            this.cmdpause = new eQuran.MediaControls();
            this.cmdplay = new eQuran.MediaControls();
            this.lblnowplaying = new System.Windows.Forms.Label();
            this.qv = new eQuran.qViewer();
            this.lblresultcount = new System.Windows.Forms.Label();
            this.cmdsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lstsearch = new System.Windows.Forms.ListView();
            this.chSouraID = new System.Windows.Forms.ColumnHeader();
            this.chSouraName = new System.Windows.Forms.ColumnHeader();
            this.chAyaID = new System.Windows.Forms.ColumnHeader();
            this.chAyaText = new System.Windows.Forms.ColumnHeader();
            this.bExpand = new System.Windows.Forms.ToolStripButton();
            this.pnlQuranTools = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.chkSingleline = new System.Windows.Forms.CheckBox();
            this.chkMultiline = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFontName = new System.Windows.Forms.ComboBox();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.chkExpanded = new System.Windows.Forms.CheckBox();
            this.cmbSoura = new System.Windows.Forms.ComboBox();
            this.spcHadeeth = new System.Windows.Forms.SplitContainer();
            this.hdtViewer = new eQuran.HadeethViewer();
            this.trvHadeeth = new eQuran.TreeViewEx();
            this.pnlHadeethTools = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdhdtSearch = new System.Windows.Forms.Button();
            this.cmbhdtSearchScope = new System.Windows.Forms.ComboBox();
            this.cmbhdtSearch = new System.Windows.Forms.ComboBox();
            this.pnlcolors = new eQuran.PanelBase();
            this.lblcoloremerald = new System.Windows.Forms.Label();
            this.lblcolorbday = new System.Windows.Forms.Label();
            this.lblcolorgreen = new System.Windows.Forms.Label();
            this.lblcolorgigi = new System.Windows.Forms.Label();
            this.picHeader1 = new eQuran.picHeader();
            this.pnlStatus = new eQuran.PanelBase();
            this.lblabout = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.spcQuran.Panel1.SuspendLayout();
            this.spcQuran.Panel2.SuspendLayout();
            this.spcQuran.SuspendLayout();
            this.cntleft.Panel1.SuspendLayout();
            this.cntleft.Panel2.SuspendLayout();
            this.cntleft.SuspendLayout();
            this.pnla.SuspendLayout();
            this.pnlb.SuspendLayout();
            this.cntright.Panel1.SuspendLayout();
            this.cntright.Panel2.SuspendLayout();
            this.cntright.SuspendLayout();
            this.panelBase1.SuspendLayout();
            this.pnlQuranTools.SuspendLayout();
            this.spcHadeeth.Panel1.SuspendLayout();
            this.spcHadeeth.Panel2.SuspendLayout();
            this.spcHadeeth.SuspendLayout();
            this.pnlHadeethTools.SuspendLayout();
            this.pnlcolors.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mextension
            // 
            this.mextension.Name = "contextMenuStrip1";
            this.mextension.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mextension.Size = new System.Drawing.Size(61, 4);
            // 
            // spcQuran
            // 
            this.spcQuran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.spcQuran.Location = new System.Drawing.Point(0, 87);
            this.spcQuran.Name = "spcQuran";
            // 
            // spcQuran.Panel1
            // 
            this.spcQuran.Panel1.Controls.Add(this.cntleft);
            // 
            // spcQuran.Panel2
            // 
            this.spcQuran.Panel2.Controls.Add(this.cntright);
            this.spcQuran.Size = new System.Drawing.Size(903, 390);
            this.spcQuran.SplitterDistance = 311;
            this.spcQuran.TabIndex = 0;
            // 
            // cntleft
            // 
            this.cntleft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntleft.Location = new System.Drawing.Point(0, 0);
            this.cntleft.Name = "cntleft";
            this.cntleft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cntleft.Panel1
            // 
            this.cntleft.Panel1.Controls.Add(this.pnla);
            // 
            // cntleft.Panel2
            // 
            this.cntleft.Panel2.Controls.Add(this.pnlb);
            this.cntleft.Size = new System.Drawing.Size(311, 390);
            this.cntleft.SplitterDistance = 193;
            this.cntleft.TabIndex = 0;
            // 
            // pnla
            // 
            this.pnla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnla.ColorPainter = this.clrPainter;
            this.pnla.Controls.Add(this.txtpnla);
            this.pnla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnla.ForeColor = System.Drawing.Color.White;
            this.pnla.IconVisible = false;
            this.pnla.Location = new System.Drawing.Point(7, 9);
            this.pnla.Name = "pnla";
            this.pnla.PanelIcon = null;
            this.pnla.SelectedText = "";
            this.pnla.Size = new System.Drawing.Size(301, 180);
            this.pnla.TabIndex = 17;
            this.pnla.UseHeaderColor = false;
            this.pnla.MoveRight += new eQuran.PanelEx.MoveRightEvent(this.pnl_MoveRight);
            this.pnla.MoveDown += new eQuran.PanelEx.MoveDownEvent(this.pnl_MoveDown);
            this.pnla.MoveLeft += new eQuran.PanelEx.MoveLeftEvent(this.pnl_MoveLeft);
            // 
            // clrPainter
            // 
            this.clrPainter.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(26)))));
            this.clrPainter.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.clrPainter.HeaderText = System.Drawing.Color.White;
            // 
            // txtpnla
            // 
            this.txtpnla.BackColor = System.Drawing.SystemColors.Window;
            this.txtpnla.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtpnla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpnla.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtpnla.Location = new System.Drawing.Point(1, 23);
            this.txtpnla.Multiline = true;
            this.txtpnla.Name = "txtpnla";
            this.txtpnla.ReadOnly = true;
            this.txtpnla.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtpnla.Size = new System.Drawing.Size(299, 155);
            this.txtpnla.TabIndex = 0;
            // 
            // pnlb
            // 
            this.pnlb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlb.ColorPainter = this.clrPainter;
            this.pnlb.Controls.Add(this.txtpnlb);
            this.pnlb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.pnlb.ForeColor = System.Drawing.Color.White;
            this.pnlb.IconVisible = false;
            this.pnlb.Location = new System.Drawing.Point(7, 6);
            this.pnlb.Name = "pnlb";
            this.pnlb.PanelIcon = null;
            this.pnlb.SelectedText = "";
            this.pnlb.Size = new System.Drawing.Size(300, 184);
            this.pnlb.TabIndex = 0;
            this.pnlb.UseHeaderColor = false;
            this.pnlb.MoveRight += new eQuran.PanelEx.MoveRightEvent(this.pnl_MoveRight);
            this.pnlb.MoveDown += new eQuran.PanelEx.MoveDownEvent(this.pnl_MoveDown);
            this.pnlb.MoveLeft += new eQuran.PanelEx.MoveLeftEvent(this.pnl_MoveLeft);
            // 
            // txtpnlb
            // 
            this.txtpnlb.BackColor = System.Drawing.SystemColors.Window;
            this.txtpnlb.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtpnlb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpnlb.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtpnlb.Location = new System.Drawing.Point(1, 25);
            this.txtpnlb.Multiline = true;
            this.txtpnlb.Name = "txtpnlb";
            this.txtpnlb.ReadOnly = true;
            this.txtpnlb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtpnlb.Size = new System.Drawing.Size(298, 157);
            this.txtpnlb.TabIndex = 0;
            // 
            // cntright
            // 
            this.cntright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cntright.Location = new System.Drawing.Point(0, 0);
            this.cntright.Name = "cntright";
            this.cntright.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cntright.Panel1
            // 
            this.cntright.Panel1.Controls.Add(this.panelBase1);
            this.cntright.Panel1.Controls.Add(this.qv);
            // 
            // cntright.Panel2
            // 
            this.cntright.Panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cntright.Panel2.Controls.Add(this.lblresultcount);
            this.cntright.Panel2.Controls.Add(this.cmdsearch);
            this.cntright.Panel2.Controls.Add(this.txtsearch);
            this.cntright.Panel2.Controls.Add(this.lstsearch);
            this.cntright.Size = new System.Drawing.Size(588, 390);
            this.cntright.SplitterDistance = 253;
            this.cntright.TabIndex = 0;
            // 
            // panelBase1
            // 
            this.panelBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.panelBase1.ColorPainter = this.clrPainter;
            this.panelBase1.Controls.Add(this.label2);
            this.panelBase1.Controls.Add(this.cmbrecitors);
            this.panelBase1.Controls.Add(this.QuranVolume);
            this.panelBase1.Controls.Add(this.cmdstop);
            this.panelBase1.Controls.Add(this.cmdpause);
            this.panelBase1.Controls.Add(this.cmdplay);
            this.panelBase1.Controls.Add(this.lblnowplaying);
            this.panelBase1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBase1.Location = new System.Drawing.Point(0, 225);
            this.panelBase1.Name = "panelBase1";
            this.panelBase1.Size = new System.Drawing.Size(588, 28);
            this.panelBase1.TabIndex = 1;
            this.panelBase1.UseHeaderColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "| Reciter:";
            // 
            // cmbrecitors
            // 
            this.cmbrecitors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbrecitors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrecitors.FormattingEnabled = true;
            this.cmbrecitors.Location = new System.Drawing.Point(404, 1);
            this.cmbrecitors.Name = "cmbrecitors";
            this.cmbrecitors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbrecitors.Size = new System.Drawing.Size(172, 25);
            this.cmbrecitors.TabIndex = 5;
            // 
            // QuranVolume
            // 
            this.QuranVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuranVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.QuranVolume.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.QuranVolume.ColorPainter = this.clrPainter;
            this.QuranVolume.ForeColor = System.Drawing.Color.White;
            this.QuranVolume.Location = new System.Drawing.Point(214, 6);
            this.QuranVolume.MinimumSize = new System.Drawing.Size(60, 20);
            this.QuranVolume.Name = "QuranVolume";
            this.QuranVolume.Position = 0;
            this.QuranVolume.Size = new System.Drawing.Size(114, 22);
            this.QuranVolume.TabIndex = 4;
            this.QuranVolume.VolumeChanged += new eQuran.VolumeBar.VolumeChangedEvent(this.QuranVolume_VolumeChanged);
            // 
            // cmdstop
            // 
            this.cmdstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.cmdstop.ButtonGlyph = eQuran.MediaControls.ButtonType.Stop;
            this.cmdstop.ColorPainter = this.clrPainter;
            this.cmdstop.ForeColor = System.Drawing.Color.White;
            this.cmdstop.Location = new System.Drawing.Point(69, 3);
            this.cmdstop.Name = "cmdstop";
            this.cmdstop.Size = new System.Drawing.Size(20, 20);
            this.cmdstop.TabIndex = 3;
            this.cmdstop.Text = "mediaButton3";
            this.cmdstop.Click += new System.EventHandler(this.cmdstop_Click);
            // 
            // cmdpause
            // 
            this.cmdpause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.cmdpause.ButtonGlyph = eQuran.MediaControls.ButtonType.Pause;
            this.cmdpause.ColorPainter = this.clrPainter;
            this.cmdpause.ForeColor = System.Drawing.Color.White;
            this.cmdpause.Location = new System.Drawing.Point(43, 3);
            this.cmdpause.Name = "cmdpause";
            this.cmdpause.Size = new System.Drawing.Size(20, 20);
            this.cmdpause.TabIndex = 2;
            this.cmdpause.Text = "mediaButton2";
            this.cmdpause.Click += new System.EventHandler(this.cmdpause_Click);
            // 
            // cmdplay
            // 
            this.cmdplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.cmdplay.ButtonGlyph = eQuran.MediaControls.ButtonType.Play;
            this.cmdplay.ColorPainter = this.clrPainter;
            this.cmdplay.ForeColor = System.Drawing.Color.White;
            this.cmdplay.Location = new System.Drawing.Point(18, 1);
            this.cmdplay.Name = "cmdplay";
            this.cmdplay.Size = new System.Drawing.Size(22, 22);
            this.cmdplay.TabIndex = 1;
            this.cmdplay.Text = "mediaButton1";
            this.cmdplay.Click += new System.EventHandler(this.cmdplay_Click);
            // 
            // lblnowplaying
            // 
            this.lblnowplaying.ForeColor = System.Drawing.Color.White;
            this.lblnowplaying.Location = new System.Drawing.Point(101, 4);
            this.lblnowplaying.Name = "lblnowplaying";
            this.lblnowplaying.Size = new System.Drawing.Size(260, 17);
            this.lblnowplaying.TabIndex = 0;
            this.lblnowplaying.Text = "Now Playing";
            // 
            // qv
            // 
            this.qv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.qv.BackColor = System.Drawing.Color.White;
            this.qv.Font = new System.Drawing.Font("Arial", 16F);
            this.qv.Location = new System.Drawing.Point(3, 9);
            this.qv.Name = "qv";
            this.qv.ScrollPosition = 0;
            this.qv.SelectedAya = null;
            this.qv.SelectedIndex = -1;
            this.qv.SelectedSoura = null;
            this.qv.Size = new System.Drawing.Size(582, 214);
            this.qv.TabIndex = 0;
            this.qv.Text = "qViewer1";
            this.qv.ViewMode = eQuran.qViewer.ViewModeFlags.SingleLine;
            this.qv.AyaSoundClick += new eQuran.qViewer.AyaClickEvent(this.qv_AyaSoundClick);
            this.qv.SouraSoundClick += new eQuran.qViewer.SouraClickEvent(this.qv_SouraSoundClick);
            this.qv.ItemClick += new eQuran.qViewer.ItemClickEvent(this.qv_ItemClick);
            // 
            // lblresultcount
            // 
            this.lblresultcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblresultcount.AutoSize = true;
            this.lblresultcount.Location = new System.Drawing.Point(12, 111);
            this.lblresultcount.Name = "lblresultcount";
            this.lblresultcount.Size = new System.Drawing.Size(145, 17);
            this.lblresultcount.TabIndex = 21;
            this.lblresultcount.Text = "0 occurrence(s) found";
            // 
            // cmdsearch
            // 
            this.cmdsearch.Image = ((System.Drawing.Image)(resources.GetObject("cmdsearch.Image")));
            this.cmdsearch.Location = new System.Drawing.Point(10, 5);
            this.cmdsearch.Name = "cmdsearch";
            this.cmdsearch.Size = new System.Drawing.Size(79, 24);
            this.cmdsearch.TabIndex = 20;
            this.cmdsearch.Text = "Search";
            this.cmdsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdsearch.UseVisualStyleBackColor = true;
            this.cmdsearch.Click += new System.EventHandler(this.cmdsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtsearch.Location = new System.Drawing.Point(104, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(472, 27);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lstsearch
            // 
            this.lstsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstsearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSouraID,
            this.chSouraName,
            this.chAyaID,
            this.chAyaText});
            this.lstsearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lstsearch.FullRowSelect = true;
            this.lstsearch.GridLines = true;
            this.lstsearch.Location = new System.Drawing.Point(10, 35);
            this.lstsearch.MultiSelect = false;
            this.lstsearch.Name = "lstsearch";
            this.lstsearch.ShowItemToolTips = true;
            this.lstsearch.Size = new System.Drawing.Size(566, 74);
            this.lstsearch.TabIndex = 18;
            this.lstsearch.UseCompatibleStateImageBehavior = false;
            this.lstsearch.View = System.Windows.Forms.View.Details;
            this.lstsearch.Resize += new System.EventHandler(this.lstsearch_Resize);
            this.lstsearch.DoubleClick += new System.EventHandler(this.lstsearch_DoubleClick);
            // 
            // chSouraID
            // 
            this.chSouraID.Text = "#";
            this.chSouraID.Width = 24;
            // 
            // chSouraName
            // 
            this.chSouraName.Text = "Soura";
            this.chSouraName.Width = 56;
            // 
            // chAyaID
            // 
            this.chAyaID.Text = "Aya";
            // 
            // chAyaText
            // 
            this.chAyaText.Text = "Result";
            this.chAyaText.Width = 220;
            // 
            // bExpand
            // 
            this.bExpand.Name = "bExpand";
            this.bExpand.Size = new System.Drawing.Size(23, 23);
            // 
            // pnlQuranTools
            // 
            this.pnlQuranTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(26)))));
            this.pnlQuranTools.Controls.Add(this.chkSearch);
            this.pnlQuranTools.Controls.Add(this.chkSingleline);
            this.pnlQuranTools.Controls.Add(this.chkMultiline);
            this.pnlQuranTools.Controls.Add(this.label1);
            this.pnlQuranTools.Controls.Add(this.cmbFontName);
            this.pnlQuranTools.Controls.Add(this.cmbFontSize);
            this.pnlQuranTools.Controls.Add(this.chkExpanded);
            this.pnlQuranTools.Controls.Add(this.cmbSoura);
            this.pnlQuranTools.Location = new System.Drawing.Point(22, 60);
            this.pnlQuranTools.Name = "pnlQuranTools";
            this.pnlQuranTools.Size = new System.Drawing.Size(741, 25);
            this.pnlQuranTools.TabIndex = 29;
            // 
            // chkSearch
            // 
            this.chkSearch.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSearch.FlatAppearance.BorderSize = 0;
            this.chkSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSearch.ForeColor = System.Drawing.Color.White;
            this.chkSearch.Image = global::eQuran.Properties.Resources.find;
            this.chkSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkSearch.Location = new System.Drawing.Point(3, 3);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(82, 23);
            this.chkSearch.TabIndex = 8;
            this.chkSearch.Text = "Search";
            this.chkSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSearch.UseVisualStyleBackColor = true;
            this.chkSearch.CheckedChanged += new System.EventHandler(this.chkSearch_CheckedChanged);
            // 
            // chkSingleline
            // 
            this.chkSingleline.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSingleline.FlatAppearance.BorderSize = 0;
            this.chkSingleline.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSingleline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSingleline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSingleline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSingleline.ForeColor = System.Drawing.Color.White;
            this.chkSingleline.Image = global::eQuran.Properties.Resources.singleline_icon;
            this.chkSingleline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkSingleline.Location = new System.Drawing.Point(91, 3);
            this.chkSingleline.Name = "chkSingleline";
            this.chkSingleline.Size = new System.Drawing.Size(96, 23);
            this.chkSingleline.TabIndex = 9;
            this.chkSingleline.Text = "SingleLine";
            this.chkSingleline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSingleline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkSingleline.UseVisualStyleBackColor = true;
            this.chkSingleline.Click += new System.EventHandler(this.chkSingleline_Click);
            // 
            // chkMultiline
            // 
            this.chkMultiline.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMultiline.FlatAppearance.BorderSize = 0;
            this.chkMultiline.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkMultiline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkMultiline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkMultiline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMultiline.ForeColor = System.Drawing.Color.White;
            this.chkMultiline.Image = global::eQuran.Properties.Resources.multiline_icon;
            this.chkMultiline.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkMultiline.Location = new System.Drawing.Point(193, 3);
            this.chkMultiline.Name = "chkMultiline";
            this.chkMultiline.Size = new System.Drawing.Size(97, 23);
            this.chkMultiline.TabIndex = 10;
            this.chkMultiline.Text = "MultiLine";
            this.chkMultiline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkMultiline.UseVisualStyleBackColor = true;
            this.chkMultiline.Click += new System.EventHandler(this.chkMultiline_Click);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Viewer Font";
            // 
            // cmbFontName
            // 
            this.cmbFontName.FormattingEnabled = true;
            this.cmbFontName.Location = new System.Drawing.Point(381, 3);
            this.cmbFontName.Name = "cmbFontName";
            this.cmbFontName.Size = new System.Drawing.Size(113, 25);
            this.cmbFontName.TabIndex = 5;
            this.cmbFontName.SelectedIndexChanged += new System.EventHandler(this.bfontname_SelectedIndexChanged);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40",
            "42"});
            this.cmbFontSize.Location = new System.Drawing.Point(500, 3);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(51, 25);
            this.cmbFontSize.TabIndex = 6;
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.bfontsize_SelectedIndexChanged);
            // 
            // chkExpanded
            // 
            this.chkExpanded.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkExpanded.FlatAppearance.BorderSize = 0;
            this.chkExpanded.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkExpanded.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkExpanded.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkExpanded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkExpanded.ForeColor = System.Drawing.Color.White;
            this.chkExpanded.Image = ((System.Drawing.Image)(resources.GetObject("chkExpanded.Image")));
            this.chkExpanded.Location = new System.Drawing.Point(557, 3);
            this.chkExpanded.Name = "chkExpanded";
            this.chkExpanded.Size = new System.Drawing.Size(23, 23);
            this.chkExpanded.TabIndex = 11;
            this.chkExpanded.UseVisualStyleBackColor = true;
            this.chkExpanded.Click += new System.EventHandler(this.chkExpanded_Click);
            // 
            // cmbSoura
            // 
            this.cmbSoura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSoura.BackColor = System.Drawing.SystemColors.Info;
            this.cmbSoura.FormattingEnabled = true;
            this.cmbSoura.Location = new System.Drawing.Point(586, 3);
            this.cmbSoura.Name = "cmbSoura";
            this.cmbSoura.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSoura.Size = new System.Drawing.Size(148, 25);
            this.cmbSoura.TabIndex = 4;
            this.cmbSoura.SelectedIndexChanged += new System.EventHandler(this.cmbSoura_SelectedIndexChanged);
            // 
            // spcHadeeth
            // 
            this.spcHadeeth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcHadeeth.Location = new System.Drawing.Point(0, 90);
            this.spcHadeeth.Name = "spcHadeeth";
            // 
            // spcHadeeth.Panel1
            // 
            this.spcHadeeth.Panel1.Controls.Add(this.hdtViewer);
            // 
            // spcHadeeth.Panel2
            // 
            this.spcHadeeth.Panel2.Controls.Add(this.trvHadeeth);
            this.spcHadeeth.Size = new System.Drawing.Size(903, 393);
            this.spcHadeeth.SplitterDistance = 577;
            this.spcHadeeth.TabIndex = 30;
            // 
            // hdtViewer
            // 
            this.hdtViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hdtViewer.Font = new System.Drawing.Font("ae_AlArabiya", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.hdtViewer.Location = new System.Drawing.Point(25, 18);
            this.hdtViewer.Name = "hdtViewer";
            this.hdtViewer.ShowSource = false;
            this.hdtViewer.Size = new System.Drawing.Size(536, 345);
            this.hdtViewer.TabIndex = 0;
            this.hdtViewer.Text = "hdtViewer";
            // 
            // trvHadeeth
            // 
            this.trvHadeeth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trvHadeeth.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.trvHadeeth.Font = new System.Drawing.Font("ae_AlArabiya", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.trvHadeeth.Location = new System.Drawing.Point(12, 51);
            this.trvHadeeth.Name = "trvHadeeth";
            this.trvHadeeth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trvHadeeth.RightToLeftLayout = true;
            this.trvHadeeth.Size = new System.Drawing.Size(298, 312);
            this.trvHadeeth.TabIndex = 0;
            this.trvHadeeth.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvHadeeth_AfterSelect);
            // 
            // pnlHadeethTools
            // 
            this.pnlHadeethTools.Controls.Add(this.cmdhdtSearch);
            this.pnlHadeethTools.Controls.Add(this.cmbhdtSearchScope);
            this.pnlHadeethTools.Controls.Add(this.cmbhdtSearch);
            this.pnlHadeethTools.Location = new System.Drawing.Point(60, 60);
            this.pnlHadeethTools.Name = "pnlHadeethTools";
            this.pnlHadeethTools.Size = new System.Drawing.Size(513, 26);
            this.pnlHadeethTools.TabIndex = 31;
            // 
            // cmdhdtSearch
            // 
            this.cmdhdtSearch.Location = new System.Drawing.Point(3, 3);
            this.cmdhdtSearch.Name = "cmdhdtSearch";
            this.cmdhdtSearch.Size = new System.Drawing.Size(87, 23);
            this.cmdhdtSearch.TabIndex = 1;
            this.cmdhdtSearch.Text = "Search";
            this.cmdhdtSearch.UseVisualStyleBackColor = true;
            this.cmdhdtSearch.Click += new System.EventHandler(this.cmdhdtSearch_Click);
            // 
            // cmbhdtSearchScope
            // 
            this.cmbhdtSearchScope.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhdtSearchScope.FormattingEnabled = true;
            this.cmbhdtSearchScope.Location = new System.Drawing.Point(96, 3);
            this.cmbhdtSearchScope.Name = "cmbhdtSearchScope";
            this.cmbhdtSearchScope.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbhdtSearchScope.Size = new System.Drawing.Size(119, 25);
            this.cmbhdtSearchScope.TabIndex = 2;
            // 
            // cmbhdtSearch
            // 
            this.cmbhdtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbhdtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbhdtSearch.FormattingEnabled = true;
            this.cmbhdtSearch.Location = new System.Drawing.Point(221, 3);
            this.cmbhdtSearch.Name = "cmbhdtSearch";
            this.cmbhdtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbhdtSearch.Size = new System.Drawing.Size(265, 25);
            this.cmbhdtSearch.TabIndex = 3;
            // 
            // pnlcolors
            // 
            this.pnlcolors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlcolors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.pnlcolors.ColorPainter = this.clrPainter;
            this.pnlcolors.Controls.Add(this.lblcoloremerald);
            this.pnlcolors.Controls.Add(this.lblcolorbday);
            this.pnlcolors.Controls.Add(this.lblcolorgreen);
            this.pnlcolors.Controls.Add(this.lblcolorgigi);
            this.pnlcolors.Location = new System.Drawing.Point(824, 13);
            this.pnlcolors.Name = "pnlcolors";
            this.pnlcolors.Size = new System.Drawing.Size(76, 22);
            this.pnlcolors.TabIndex = 28;
            this.pnlcolors.UseHeaderColor = true;
            // 
            // lblcoloremerald
            // 
            this.lblcoloremerald.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(200)))));
            this.lblcoloremerald.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcoloremerald.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcoloremerald.Location = new System.Drawing.Point(57, 5);
            this.lblcoloremerald.Name = "lblcoloremerald";
            this.lblcoloremerald.Size = new System.Drawing.Size(12, 12);
            this.lblcoloremerald.TabIndex = 4;
            this.lblcoloremerald.Tag = "emerald";
            this.lblcoloremerald.Click += new System.EventHandler(this.lblcoloremerald_Click);
            // 
            // lblcolorbday
            // 
            this.lblcolorbday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(60)))), ((int)(((byte)(34)))));
            this.lblcolorbday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcolorbday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcolorbday.Location = new System.Drawing.Point(39, 5);
            this.lblcolorbday.Name = "lblcolorbday";
            this.lblcolorbday.Size = new System.Drawing.Size(12, 12);
            this.lblcolorbday.TabIndex = 3;
            this.lblcolorbday.Tag = "bday";
            this.lblcolorbday.Click += new System.EventHandler(this.lblcolorbday_Click);
            // 
            // lblcolorgreen
            // 
            this.lblcolorgreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(26)))));
            this.lblcolorgreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcolorgreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcolorgreen.Location = new System.Drawing.Point(21, 5);
            this.lblcolorgreen.Name = "lblcolorgreen";
            this.lblcolorgreen.Size = new System.Drawing.Size(12, 12);
            this.lblcolorgreen.TabIndex = 2;
            this.lblcolorgreen.Tag = "green";
            this.lblcolorgreen.Click += new System.EventHandler(this.lblcolorgreen_Click);
            // 
            // lblcolorgigi
            // 
            this.lblcolorgigi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(98)))));
            this.lblcolorgigi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcolorgigi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcolorgigi.Location = new System.Drawing.Point(3, 5);
            this.lblcolorgigi.Name = "lblcolorgigi";
            this.lblcolorgigi.Size = new System.Drawing.Size(12, 12);
            this.lblcolorgigi.TabIndex = 1;
            this.lblcolorgigi.Tag = "gigi";
            this.lblcolorgigi.Click += new System.EventHandler(this.lblcolorgigi_Click);
            // 
            // picHeader1
            // 
            this.picHeader1.ColorPainter = this.clrPainter;
            this.picHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader1.Font = new System.Drawing.Font("Haettenschweiler", 30F);
            this.picHeader1.Location = new System.Drawing.Point(0, 0);
            this.picHeader1.Name = "picHeader1";
            this.picHeader1.SelectedIdentity = eQuran.IdentityEnum.Quran;
            this.picHeader1.Size = new System.Drawing.Size(903, 90);
            this.picHeader1.TabIndex = 23;
            this.picHeader1.Text = "picHeader1";
            this.picHeader1.SelectedIdentityChanged += new System.EventHandler(this.picHeader1_SelectedIdentityChanged);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.pnlStatus.ColorPainter = this.clrPainter;
            this.pnlStatus.Controls.Add(this.lblabout);
            this.pnlStatus.Controls.Add(this.lblstatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatus.Location = new System.Drawing.Point(0, 483);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Padding = new System.Windows.Forms.Padding(3);
            this.pnlStatus.Size = new System.Drawing.Size(903, 22);
            this.pnlStatus.TabIndex = 26;
            this.pnlStatus.UseHeaderColor = true;
            // 
            // lblabout
            // 
            this.lblabout.AutoSize = true;
            this.lblabout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.lblabout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblabout.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblabout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblabout.ForeColor = System.Drawing.Color.White;
            this.lblabout.Location = new System.Drawing.Point(846, 3);
            this.lblabout.Name = "lblabout";
            this.lblabout.Size = new System.Drawing.Size(54, 21);
            this.lblabout.TabIndex = 28;
            this.lblabout.Text = "A&bout";
            this.lblabout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblabout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoEllipsis = true;
            this.lblstatus.BackColor = System.Drawing.Color.Transparent;
            this.lblstatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblstatus.ForeColor = System.Drawing.Color.White;
            this.lblstatus.Location = new System.Drawing.Point(3, 3);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(700, 16);
            this.lblstatus.TabIndex = 23;
            this.lblstatus.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 505);
            this.Controls.Add(this.pnlcolors);
            this.Controls.Add(this.pnlHadeethTools);
            this.Controls.Add(this.spcHadeeth);
            this.Controls.Add(this.spcQuran);
            this.Controls.Add(this.pnlQuranTools);
            this.Controls.Add(this.picHeader1);
            this.Controls.Add(this.pnlStatus);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "Form1";
            this.Text = "eQuran";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.spcQuran.Panel1.ResumeLayout(false);
            this.spcQuran.Panel2.ResumeLayout(false);
            this.spcQuran.ResumeLayout(false);
            this.cntleft.Panel1.ResumeLayout(false);
            this.cntleft.Panel2.ResumeLayout(false);
            this.cntleft.ResumeLayout(false);
            this.pnla.ResumeLayout(false);
            this.pnla.PerformLayout();
            this.pnlb.ResumeLayout(false);
            this.pnlb.PerformLayout();
            this.cntright.Panel1.ResumeLayout(false);
            this.cntright.Panel2.ResumeLayout(false);
            this.cntright.Panel2.PerformLayout();
            this.cntright.ResumeLayout(false);
            this.panelBase1.ResumeLayout(false);
            this.panelBase1.PerformLayout();
            this.pnlQuranTools.ResumeLayout(false);
            this.spcHadeeth.Panel1.ResumeLayout(false);
            this.spcHadeeth.Panel2.ResumeLayout(false);
            this.spcHadeeth.ResumeLayout(false);
            this.pnlHadeethTools.ResumeLayout(false);
            this.pnlcolors.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ColorPainter clrPainter;        
        private System.Windows.Forms.ContextMenuStrip mextension;
        private System.Windows.Forms.SplitContainer spcQuran;
        private System.Windows.Forms.SplitContainer cntleft;
        private PanelEx pnla;
        private TextBoxEx txtpnla;
        private PanelEx pnlb;
        private TextBoxEx txtpnlb;
        private System.Windows.Forms.SplitContainer cntright;
        private System.Windows.Forms.Button cmdsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ListView lstsearch;
        private System.Windows.Forms.ColumnHeader chSouraName;
        private System.Windows.Forms.ColumnHeader chAyaID;
        private System.Windows.Forms.ColumnHeader chAyaText;
        private System.Windows.Forms.ColumnHeader chSouraID;
        private System.Windows.Forms.Label lblresultcount;
        private picHeader picHeader1;
        private System.Windows.Forms.ToolStripButton bExpand;
        private PanelBase pnlStatus;
        private System.Windows.Forms.Label lblstatus;
        private eQuran.qViewer qv;
        private PanelBase panelBase1;
        private System.Windows.Forms.Label lblnowplaying;
        private MediaControls cmdpause;
        private MediaControls cmdplay;
        private MediaControls cmdstop;
        private VolumeBar QuranVolume;
        private System.Windows.Forms.Label lblcolorgigi;
        private System.Windows.Forms.Label lblcolorgreen;
        private System.Windows.Forms.Label lblcolorbday;
        private PanelBase pnlcolors;
        private System.Windows.Forms.Label lblcoloremerald;
        private System.Windows.Forms.FlowLayoutPanel pnlQuranTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.ComboBox cmbFontName;
        private System.Windows.Forms.ComboBox cmbSoura;
        private System.Windows.Forms.CheckBox chkSearch;
        private System.Windows.Forms.CheckBox chkSingleline;
        private System.Windows.Forms.CheckBox chkMultiline;
        private System.Windows.Forms.Label lblabout;
        private System.Windows.Forms.SplitContainer spcHadeeth;
        private TreeViewEx trvHadeeth;
        private HadeethViewer hdtViewer;
        private System.Windows.Forms.CheckBox chkExpanded;
        private System.Windows.Forms.FlowLayoutPanel pnlHadeethTools;
        private System.Windows.Forms.Button cmdhdtSearch;
        private System.Windows.Forms.ComboBox cmbhdtSearchScope;
        private System.Windows.Forms.ComboBox cmbhdtSearch;
        private System.Windows.Forms.ComboBox cmbrecitors;
        private System.Windows.Forms.Label label2;
    }
}

