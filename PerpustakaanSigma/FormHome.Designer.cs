namespace PerpustakaanSigma
{
    partial class FormHome
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnDeleteAnggota = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DataGridViewAnggota = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.anggotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perpustakaanDataSet = new PerpustakaanSigma.perpustakaanDataSet();
            this.anggotasTableAdapter = new PerpustakaanSigma.perpustakaanDataSetTableAdapters.anggotasTableAdapter();
            this.LabelActionAnggota = new Bunifu.UI.WinForms.BunifuLabel();
            this.TextBoxAnggotaNama = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TextBoxAnggotaAlamat = new Bunifu.UI.WinForms.BunifuTextBox();
            this.TextBoxAnggotaNoTelp = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnActionAnggota = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAnggota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anggotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 619);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnActionAnggota);
            this.tabPage1.Controls.Add(this.TextBoxAnggotaNoTelp);
            this.tabPage1.Controls.Add(this.TextBoxAnggotaAlamat);
            this.tabPage1.Controls.Add(this.TextBoxAnggotaNama);
            this.tabPage1.Controls.Add(this.LabelActionAnggota);
            this.tabPage1.Controls.Add(this.BtnDeleteAnggota);
            this.tabPage1.Controls.Add(this.DataGridViewAnggota);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anggota";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnDeleteAnggota
            // 
            this.BtnDeleteAnggota.AllowAnimations = true;
            this.BtnDeleteAnggota.AllowMouseEffects = true;
            this.BtnDeleteAnggota.AllowToggling = false;
            this.BtnDeleteAnggota.AnimationSpeed = 200;
            this.BtnDeleteAnggota.AutoGenerateColors = false;
            this.BtnDeleteAnggota.AutoRoundBorders = false;
            this.BtnDeleteAnggota.AutoSizeLeftIcon = true;
            this.BtnDeleteAnggota.AutoSizeRightIcon = true;
            this.BtnDeleteAnggota.BackColor = System.Drawing.Color.Transparent;
            this.BtnDeleteAnggota.BackColor1 = System.Drawing.Color.Crimson;
            this.BtnDeleteAnggota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDeleteAnggota.BackgroundImage")));
            this.BtnDeleteAnggota.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteAnggota.ButtonText = "Hapus";
            this.BtnDeleteAnggota.ButtonTextMarginLeft = 0;
            this.BtnDeleteAnggota.ColorContrastOnClick = 45;
            this.BtnDeleteAnggota.ColorContrastOnHover = 45;
            this.BtnDeleteAnggota.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnDeleteAnggota.CustomizableEdges = borderEdges2;
            this.BtnDeleteAnggota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDeleteAnggota.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteAnggota.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteAnggota.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteAnggota.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnDeleteAnggota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDeleteAnggota.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAnggota.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDeleteAnggota.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnDeleteAnggota.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnDeleteAnggota.IconMarginLeft = 11;
            this.BtnDeleteAnggota.IconPadding = 10;
            this.BtnDeleteAnggota.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDeleteAnggota.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnDeleteAnggota.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnDeleteAnggota.IconSize = 25;
            this.BtnDeleteAnggota.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnDeleteAnggota.IdleBorderRadius = 1;
            this.BtnDeleteAnggota.IdleBorderThickness = 1;
            this.BtnDeleteAnggota.IdleFillColor = System.Drawing.Color.Crimson;
            this.BtnDeleteAnggota.IdleIconLeftImage = null;
            this.BtnDeleteAnggota.IdleIconRightImage = null;
            this.BtnDeleteAnggota.IndicateFocus = false;
            this.BtnDeleteAnggota.Location = new System.Drawing.Point(29, 545);
            this.BtnDeleteAnggota.Name = "BtnDeleteAnggota";
            this.BtnDeleteAnggota.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDeleteAnggota.OnDisabledState.BorderRadius = 1;
            this.BtnDeleteAnggota.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteAnggota.OnDisabledState.BorderThickness = 1;
            this.BtnDeleteAnggota.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDeleteAnggota.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDeleteAnggota.OnDisabledState.IconLeftImage = null;
            this.BtnDeleteAnggota.OnDisabledState.IconRightImage = null;
            this.BtnDeleteAnggota.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnDeleteAnggota.onHoverState.BorderRadius = 1;
            this.BtnDeleteAnggota.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteAnggota.onHoverState.BorderThickness = 1;
            this.BtnDeleteAnggota.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnDeleteAnggota.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAnggota.onHoverState.IconLeftImage = null;
            this.BtnDeleteAnggota.onHoverState.IconRightImage = null;
            this.BtnDeleteAnggota.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnDeleteAnggota.OnIdleState.BorderRadius = 1;
            this.BtnDeleteAnggota.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteAnggota.OnIdleState.BorderThickness = 1;
            this.BtnDeleteAnggota.OnIdleState.FillColor = System.Drawing.Color.Crimson;
            this.BtnDeleteAnggota.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAnggota.OnIdleState.IconLeftImage = null;
            this.BtnDeleteAnggota.OnIdleState.IconRightImage = null;
            this.BtnDeleteAnggota.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnDeleteAnggota.OnPressedState.BorderRadius = 1;
            this.BtnDeleteAnggota.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDeleteAnggota.OnPressedState.BorderThickness = 1;
            this.BtnDeleteAnggota.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnDeleteAnggota.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAnggota.OnPressedState.IconLeftImage = null;
            this.BtnDeleteAnggota.OnPressedState.IconRightImage = null;
            this.BtnDeleteAnggota.Size = new System.Drawing.Size(129, 39);
            this.BtnDeleteAnggota.TabIndex = 1;
            this.BtnDeleteAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDeleteAnggota.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDeleteAnggota.TextMarginLeft = 0;
            this.BtnDeleteAnggota.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnDeleteAnggota.UseDefaultRadiusAndThickness = true;
            this.BtnDeleteAnggota.Click += new System.EventHandler(this.BtnDeleteAnggota_Click);
            // 
            // DataGridViewAnggota
            // 
            this.DataGridViewAnggota.AllowCustomTheming = false;
            this.DataGridViewAnggota.AllowUserToAddRows = false;
            this.DataGridViewAnggota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewAnggota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAnggota.AutoGenerateColumns = false;
            this.DataGridViewAnggota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewAnggota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewAnggota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewAnggota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAnggota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAnggota.ColumnHeadersHeight = 40;
            this.DataGridViewAnggota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTelpDataGridViewTextBoxColumn});
            this.DataGridViewAnggota.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DataGridViewAnggota.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewAnggota.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewAnggota.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridViewAnggota.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewAnggota.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DataGridViewAnggota.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridViewAnggota.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridViewAnggota.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewAnggota.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewAnggota.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DataGridViewAnggota.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewAnggota.CurrentTheme.Name = null;
            this.DataGridViewAnggota.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewAnggota.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridViewAnggota.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewAnggota.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DataGridViewAnggota.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewAnggota.DataSource = this.anggotasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAnggota.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewAnggota.EnableHeadersVisualStyles = false;
            this.DataGridViewAnggota.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DataGridViewAnggota.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DataGridViewAnggota.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridViewAnggota.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridViewAnggota.Location = new System.Drawing.Point(329, 6);
            this.DataGridViewAnggota.Name = "DataGridViewAnggota";
            this.DataGridViewAnggota.ReadOnly = true;
            this.DataGridViewAnggota.RowHeadersVisible = false;
            this.DataGridViewAnggota.RowTemplate.Height = 40;
            this.DataGridViewAnggota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewAnggota.Size = new System.Drawing.Size(685, 578);
            this.DataGridViewAnggota.TabIndex = 0;
            this.DataGridViewAnggota.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DataGridViewAnggota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAnggota_CellClick);
            // 
            // anggotasBindingSource
            // 
            this.anggotasBindingSource.DataMember = "anggotas";
            this.anggotasBindingSource.DataSource = this.perpustakaanDataSet;
            // 
            // perpustakaanDataSet
            // 
            this.perpustakaanDataSet.DataSetName = "perpustakaanDataSet";
            this.perpustakaanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anggotasTableAdapter
            // 
            this.anggotasTableAdapter.ClearBeforeFill = true;
            // 
            // LabelActionAnggota
            // 
            this.LabelActionAnggota.AllowParentOverrides = false;
            this.LabelActionAnggota.AutoEllipsis = false;
            this.LabelActionAnggota.CursorType = System.Windows.Forms.Cursors.Default;
            this.LabelActionAnggota.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LabelActionAnggota.Location = new System.Drawing.Point(104, 6);
            this.LabelActionAnggota.Name = "LabelActionAnggota";
            this.LabelActionAnggota.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelActionAnggota.Size = new System.Drawing.Size(119, 21);
            this.LabelActionAnggota.TabIndex = 2;
            this.LabelActionAnggota.Text = "Tambah Anggota";
            this.LabelActionAnggota.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelActionAnggota.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TextBoxAnggotaNama
            // 
            this.TextBoxAnggotaNama.AcceptsReturn = false;
            this.TextBoxAnggotaNama.AcceptsTab = false;
            this.TextBoxAnggotaNama.AnimationSpeed = 200;
            this.TextBoxAnggotaNama.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxAnggotaNama.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxAnggotaNama.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxAnggotaNama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxAnggotaNama.BackgroundImage")));
            this.TextBoxAnggotaNama.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxAnggotaNama.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxAnggotaNama.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBoxAnggotaNama.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxAnggotaNama.BorderRadius = 1;
            this.TextBoxAnggotaNama.BorderThickness = 1;
            this.TextBoxAnggotaNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxAnggotaNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaNama.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxAnggotaNama.DefaultText = "";
            this.TextBoxAnggotaNama.FillColor = System.Drawing.Color.White;
            this.TextBoxAnggotaNama.HideSelection = true;
            this.TextBoxAnggotaNama.IconLeft = null;
            this.TextBoxAnggotaNama.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaNama.IconPadding = 10;
            this.TextBoxAnggotaNama.IconRight = null;
            this.TextBoxAnggotaNama.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaNama.Lines = new string[0];
            this.TextBoxAnggotaNama.Location = new System.Drawing.Point(29, 33);
            this.TextBoxAnggotaNama.MaxLength = 32767;
            this.TextBoxAnggotaNama.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxAnggotaNama.Modified = false;
            this.TextBoxAnggotaNama.Multiline = false;
            this.TextBoxAnggotaNama.Name = "TextBoxAnggotaNama";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaNama.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxAnggotaNama.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaNama.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaNama.OnIdleState = stateProperties12;
            this.TextBoxAnggotaNama.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxAnggotaNama.PasswordChar = '\0';
            this.TextBoxAnggotaNama.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxAnggotaNama.PlaceholderText = "Nama";
            this.TextBoxAnggotaNama.ReadOnly = false;
            this.TextBoxAnggotaNama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAnggotaNama.SelectedText = "";
            this.TextBoxAnggotaNama.SelectionLength = 0;
            this.TextBoxAnggotaNama.SelectionStart = 0;
            this.TextBoxAnggotaNama.ShortcutsEnabled = true;
            this.TextBoxAnggotaNama.Size = new System.Drawing.Size(263, 37);
            this.TextBoxAnggotaNama.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxAnggotaNama.TabIndex = 3;
            this.TextBoxAnggotaNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxAnggotaNama.TextMarginBottom = 0;
            this.TextBoxAnggotaNama.TextMarginLeft = 3;
            this.TextBoxAnggotaNama.TextMarginTop = 0;
            this.TextBoxAnggotaNama.TextPlaceholder = "Nama";
            this.TextBoxAnggotaNama.UseSystemPasswordChar = false;
            this.TextBoxAnggotaNama.WordWrap = true;
            // 
            // TextBoxAnggotaAlamat
            // 
            this.TextBoxAnggotaAlamat.AcceptsReturn = false;
            this.TextBoxAnggotaAlamat.AcceptsTab = false;
            this.TextBoxAnggotaAlamat.AnimationSpeed = 200;
            this.TextBoxAnggotaAlamat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxAnggotaAlamat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxAnggotaAlamat.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxAnggotaAlamat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxAnggotaAlamat.BackgroundImage")));
            this.TextBoxAnggotaAlamat.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxAnggotaAlamat.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxAnggotaAlamat.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBoxAnggotaAlamat.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxAnggotaAlamat.BorderRadius = 1;
            this.TextBoxAnggotaAlamat.BorderThickness = 1;
            this.TextBoxAnggotaAlamat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxAnggotaAlamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaAlamat.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxAnggotaAlamat.DefaultText = "";
            this.TextBoxAnggotaAlamat.FillColor = System.Drawing.Color.White;
            this.TextBoxAnggotaAlamat.HideSelection = true;
            this.TextBoxAnggotaAlamat.IconLeft = null;
            this.TextBoxAnggotaAlamat.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaAlamat.IconPadding = 10;
            this.TextBoxAnggotaAlamat.IconRight = null;
            this.TextBoxAnggotaAlamat.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaAlamat.Lines = new string[0];
            this.TextBoxAnggotaAlamat.Location = new System.Drawing.Point(29, 76);
            this.TextBoxAnggotaAlamat.MaxLength = 32767;
            this.TextBoxAnggotaAlamat.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxAnggotaAlamat.Modified = false;
            this.TextBoxAnggotaAlamat.Multiline = false;
            this.TextBoxAnggotaAlamat.Name = "TextBoxAnggotaAlamat";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaAlamat.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxAnggotaAlamat.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaAlamat.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaAlamat.OnIdleState = stateProperties8;
            this.TextBoxAnggotaAlamat.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxAnggotaAlamat.PasswordChar = '\0';
            this.TextBoxAnggotaAlamat.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxAnggotaAlamat.PlaceholderText = "Alamat";
            this.TextBoxAnggotaAlamat.ReadOnly = false;
            this.TextBoxAnggotaAlamat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAnggotaAlamat.SelectedText = "";
            this.TextBoxAnggotaAlamat.SelectionLength = 0;
            this.TextBoxAnggotaAlamat.SelectionStart = 0;
            this.TextBoxAnggotaAlamat.ShortcutsEnabled = true;
            this.TextBoxAnggotaAlamat.Size = new System.Drawing.Size(263, 37);
            this.TextBoxAnggotaAlamat.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxAnggotaAlamat.TabIndex = 4;
            this.TextBoxAnggotaAlamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxAnggotaAlamat.TextMarginBottom = 0;
            this.TextBoxAnggotaAlamat.TextMarginLeft = 3;
            this.TextBoxAnggotaAlamat.TextMarginTop = 0;
            this.TextBoxAnggotaAlamat.TextPlaceholder = "Alamat";
            this.TextBoxAnggotaAlamat.UseSystemPasswordChar = false;
            this.TextBoxAnggotaAlamat.WordWrap = true;
            // 
            // TextBoxAnggotaNoTelp
            // 
            this.TextBoxAnggotaNoTelp.AcceptsReturn = false;
            this.TextBoxAnggotaNoTelp.AcceptsTab = false;
            this.TextBoxAnggotaNoTelp.AnimationSpeed = 200;
            this.TextBoxAnggotaNoTelp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBoxAnggotaNoTelp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBoxAnggotaNoTelp.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxAnggotaNoTelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextBoxAnggotaNoTelp.BackgroundImage")));
            this.TextBoxAnggotaNoTelp.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextBoxAnggotaNoTelp.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TextBoxAnggotaNoTelp.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextBoxAnggotaNoTelp.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextBoxAnggotaNoTelp.BorderRadius = 1;
            this.TextBoxAnggotaNoTelp.BorderThickness = 1;
            this.TextBoxAnggotaNoTelp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextBoxAnggotaNoTelp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaNoTelp.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TextBoxAnggotaNoTelp.DefaultText = "";
            this.TextBoxAnggotaNoTelp.FillColor = System.Drawing.Color.White;
            this.TextBoxAnggotaNoTelp.HideSelection = true;
            this.TextBoxAnggotaNoTelp.IconLeft = null;
            this.TextBoxAnggotaNoTelp.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaNoTelp.IconPadding = 10;
            this.TextBoxAnggotaNoTelp.IconRight = null;
            this.TextBoxAnggotaNoTelp.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxAnggotaNoTelp.Lines = new string[0];
            this.TextBoxAnggotaNoTelp.Location = new System.Drawing.Point(29, 119);
            this.TextBoxAnggotaNoTelp.MaxLength = 32767;
            this.TextBoxAnggotaNoTelp.MinimumSize = new System.Drawing.Size(1, 1);
            this.TextBoxAnggotaNoTelp.Modified = false;
            this.TextBoxAnggotaNoTelp.Multiline = false;
            this.TextBoxAnggotaNoTelp.Name = "TextBoxAnggotaNoTelp";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaNoTelp.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TextBoxAnggotaNoTelp.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaNoTelp.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextBoxAnggotaNoTelp.OnIdleState = stateProperties4;
            this.TextBoxAnggotaNoTelp.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxAnggotaNoTelp.PasswordChar = '\0';
            this.TextBoxAnggotaNoTelp.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextBoxAnggotaNoTelp.PlaceholderText = "No Telp";
            this.TextBoxAnggotaNoTelp.ReadOnly = false;
            this.TextBoxAnggotaNoTelp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxAnggotaNoTelp.SelectedText = "";
            this.TextBoxAnggotaNoTelp.SelectionLength = 0;
            this.TextBoxAnggotaNoTelp.SelectionStart = 0;
            this.TextBoxAnggotaNoTelp.ShortcutsEnabled = true;
            this.TextBoxAnggotaNoTelp.Size = new System.Drawing.Size(263, 37);
            this.TextBoxAnggotaNoTelp.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TextBoxAnggotaNoTelp.TabIndex = 5;
            this.TextBoxAnggotaNoTelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxAnggotaNoTelp.TextMarginBottom = 0;
            this.TextBoxAnggotaNoTelp.TextMarginLeft = 3;
            this.TextBoxAnggotaNoTelp.TextMarginTop = 0;
            this.TextBoxAnggotaNoTelp.TextPlaceholder = "No Telp";
            this.TextBoxAnggotaNoTelp.UseSystemPasswordChar = false;
            this.TextBoxAnggotaNoTelp.WordWrap = true;
            // 
            // BtnActionAnggota
            // 
            this.BtnActionAnggota.AllowAnimations = true;
            this.BtnActionAnggota.AllowMouseEffects = true;
            this.BtnActionAnggota.AllowToggling = false;
            this.BtnActionAnggota.AnimationSpeed = 200;
            this.BtnActionAnggota.AutoGenerateColors = false;
            this.BtnActionAnggota.AutoRoundBorders = false;
            this.BtnActionAnggota.AutoSizeLeftIcon = true;
            this.BtnActionAnggota.AutoSizeRightIcon = true;
            this.BtnActionAnggota.BackColor = System.Drawing.Color.Transparent;
            this.BtnActionAnggota.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.BtnActionAnggota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnActionAnggota.BackgroundImage")));
            this.BtnActionAnggota.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnActionAnggota.ButtonText = "Tambah";
            this.BtnActionAnggota.ButtonTextMarginLeft = 0;
            this.BtnActionAnggota.ColorContrastOnClick = 45;
            this.BtnActionAnggota.ColorContrastOnHover = 45;
            this.BtnActionAnggota.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnActionAnggota.CustomizableEdges = borderEdges1;
            this.BtnActionAnggota.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnActionAnggota.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnActionAnggota.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnActionAnggota.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnActionAnggota.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnActionAnggota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnActionAnggota.ForeColor = System.Drawing.Color.White;
            this.BtnActionAnggota.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActionAnggota.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnActionAnggota.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnActionAnggota.IconMarginLeft = 11;
            this.BtnActionAnggota.IconPadding = 10;
            this.BtnActionAnggota.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnActionAnggota.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnActionAnggota.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnActionAnggota.IconSize = 25;
            this.BtnActionAnggota.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnActionAnggota.IdleBorderRadius = 1;
            this.BtnActionAnggota.IdleBorderThickness = 1;
            this.BtnActionAnggota.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.BtnActionAnggota.IdleIconLeftImage = null;
            this.BtnActionAnggota.IdleIconRightImage = null;
            this.BtnActionAnggota.IndicateFocus = false;
            this.BtnActionAnggota.Location = new System.Drawing.Point(85, 162);
            this.BtnActionAnggota.Name = "BtnActionAnggota";
            this.BtnActionAnggota.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnActionAnggota.OnDisabledState.BorderRadius = 1;
            this.BtnActionAnggota.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnActionAnggota.OnDisabledState.BorderThickness = 1;
            this.BtnActionAnggota.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnActionAnggota.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnActionAnggota.OnDisabledState.IconLeftImage = null;
            this.BtnActionAnggota.OnDisabledState.IconRightImage = null;
            this.BtnActionAnggota.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnActionAnggota.onHoverState.BorderRadius = 1;
            this.BtnActionAnggota.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnActionAnggota.onHoverState.BorderThickness = 1;
            this.BtnActionAnggota.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnActionAnggota.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnActionAnggota.onHoverState.IconLeftImage = null;
            this.BtnActionAnggota.onHoverState.IconRightImage = null;
            this.BtnActionAnggota.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnActionAnggota.OnIdleState.BorderRadius = 1;
            this.BtnActionAnggota.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnActionAnggota.OnIdleState.BorderThickness = 1;
            this.BtnActionAnggota.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnActionAnggota.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnActionAnggota.OnIdleState.IconLeftImage = null;
            this.BtnActionAnggota.OnIdleState.IconRightImage = null;
            this.BtnActionAnggota.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnActionAnggota.OnPressedState.BorderRadius = 1;
            this.BtnActionAnggota.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnActionAnggota.OnPressedState.BorderThickness = 1;
            this.BtnActionAnggota.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnActionAnggota.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnActionAnggota.OnPressedState.IconLeftImage = null;
            this.BtnActionAnggota.OnPressedState.IconRightImage = null;
            this.BtnActionAnggota.Size = new System.Drawing.Size(150, 39);
            this.BtnActionAnggota.TabIndex = 6;
            this.BtnActionAnggota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnActionAnggota.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnActionAnggota.TextMarginLeft = 0;
            this.BtnActionAnggota.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnActionAnggota.UseDefaultRadiusAndThickness = true;
            this.BtnActionAnggota.Click += new System.EventHandler(this.BtnActionAnggota_Click);
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            this.noTelpDataGridViewTextBoxColumn.DataPropertyName = "NoTelp";
            this.noTelpDataGridViewTextBoxColumn.HeaderText = "NoTelp";
            this.noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            this.noTelpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 643);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAnggota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anggotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perpustakaanDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridViewAnggota;
        private perpustakaanDataSet perpustakaanDataSet;
        private System.Windows.Forms.BindingSource anggotasBindingSource;
        private perpustakaanDataSetTableAdapters.anggotasTableAdapter anggotasTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnDeleteAnggota;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxAnggotaNama;
        private Bunifu.UI.WinForms.BunifuLabel LabelActionAnggota;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxAnggotaAlamat;
        private Bunifu.UI.WinForms.BunifuTextBox TextBoxAnggotaNoTelp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnActionAnggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
    }
}