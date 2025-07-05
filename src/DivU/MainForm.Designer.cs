namespace DivU
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UinValue = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UoutValue = new System.Windows.Forms.TextBox();
            this.R1Value = new System.Windows.Forms.TextBox();
            this.R2Value = new System.Windows.Forms.TextBox();
            this.Uin = new System.Windows.Forms.RadioButton();
            this.Uout = new System.Windows.Forms.RadioButton();
            this.R1 = new System.Windows.Forms.RadioButton();
            this.R2 = new System.Windows.Forms.RadioButton();
            this.Calculate = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Solutions = new System.Windows.Forms.DataGridView();
            this.ColumnR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDiv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIOmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R1SelectBox = new System.Windows.Forms.GroupBox();
            this.R1SelectMaxBox = new System.Windows.Forms.GroupBox();
            this.R1ValueEnd = new System.Windows.Forms.ComboBox();
            this.R1FactorEnd = new System.Windows.Forms.ComboBox();
            this.R1SelectMinBox = new System.Windows.Forms.GroupBox();
            this.R1ValueBegin = new System.Windows.Forms.ComboBox();
            this.R1FactorBegin = new System.Windows.Forms.ComboBox();
            this.R2SelectBox = new System.Windows.Forms.GroupBox();
            this.R2SelectMaxBox = new System.Windows.Forms.GroupBox();
            this.R2ValueEnd = new System.Windows.Forms.ComboBox();
            this.R2FactorEnd = new System.Windows.Forms.ComboBox();
            this.R2SelectMinBox = new System.Windows.Forms.GroupBox();
            this.R2ValueBegin = new System.Windows.Forms.ComboBox();
            this.R2FactorBegin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Solutions)).BeginInit();
            this.R1SelectBox.SuspendLayout();
            this.R1SelectMaxBox.SuspendLayout();
            this.R1SelectMinBox.SuspendLayout();
            this.R2SelectBox.SuspendLayout();
            this.R2SelectMaxBox.SuspendLayout();
            this.R2SelectMinBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UinValue
            // 
            this.UinValue.ContextMenuStrip = this.contextMenuStrip1;
            this.UinValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UinValue.Location = new System.Drawing.Point(220, 12);
            this.UinValue.Name = "UinValue";
            this.UinValue.Size = new System.Drawing.Size(100, 23);
            this.UinValue.TabIndex = 0;
            this.UinValue.Text = "0";
            this.UinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UinValue.TextChanged += new System.EventHandler(this.ValueTextChanged);
            this.UinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueKeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UoutValue
            // 
            this.UoutValue.ContextMenuStrip = this.contextMenuStrip1;
            this.UoutValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UoutValue.Location = new System.Drawing.Point(220, 41);
            this.UoutValue.Name = "UoutValue";
            this.UoutValue.Size = new System.Drawing.Size(100, 23);
            this.UoutValue.TabIndex = 1;
            this.UoutValue.Text = "0";
            this.UoutValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UoutValue.TextChanged += new System.EventHandler(this.ValueTextChanged);
            this.UoutValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueKeyPress);
            // 
            // R1Value
            // 
            this.R1Value.ContextMenuStrip = this.contextMenuStrip1;
            this.R1Value.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R1Value.Location = new System.Drawing.Point(220, 70);
            this.R1Value.Name = "R1Value";
            this.R1Value.Size = new System.Drawing.Size(100, 23);
            this.R1Value.TabIndex = 2;
            this.R1Value.Text = "0";
            this.R1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.R1Value.TextChanged += new System.EventHandler(this.ValueTextChanged);
            this.R1Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueKeyPress);
            // 
            // R2Value
            // 
            this.R2Value.ContextMenuStrip = this.contextMenuStrip1;
            this.R2Value.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R2Value.Location = new System.Drawing.Point(220, 99);
            this.R2Value.Name = "R2Value";
            this.R2Value.Size = new System.Drawing.Size(100, 23);
            this.R2Value.TabIndex = 3;
            this.R2Value.Text = "0";
            this.R2Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.R2Value.TextChanged += new System.EventHandler(this.ValueTextChanged);
            this.R2Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueKeyPress);
            // 
            // Uin
            // 
            this.Uin.AutoSize = true;
            this.Uin.Location = new System.Drawing.Point(326, 14);
            this.Uin.Name = "Uin";
            this.Uin.Size = new System.Drawing.Size(41, 17);
            this.Uin.TabIndex = 4;
            this.Uin.Text = "Uin";
            this.Uin.UseVisualStyleBackColor = true;
            // 
            // Uout
            // 
            this.Uout.AutoSize = true;
            this.Uout.Checked = true;
            this.Uout.Location = new System.Drawing.Point(326, 43);
            this.Uout.Name = "Uout";
            this.Uout.Size = new System.Drawing.Size(48, 17);
            this.Uout.TabIndex = 5;
            this.Uout.TabStop = true;
            this.Uout.Text = "Uout";
            this.Uout.UseVisualStyleBackColor = true;
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Location = new System.Drawing.Point(326, 72);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(43, 17);
            this.R1.TabIndex = 6;
            this.R1.Text = "R1*";
            this.R1.UseVisualStyleBackColor = true;
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Location = new System.Drawing.Point(326, 101);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(39, 17);
            this.R2.TabIndex = 7;
            this.R2.Text = "R2";
            this.R2.UseVisualStyleBackColor = true;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(220, 128);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(100, 23);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.CalculateClick);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(220, 157);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(100, 23);
            this.Find.TabIndex = 10;
            this.Find.Text = "Find All";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.FindClick);
            // 
            // Solutions
            // 
            this.Solutions.AllowUserToAddRows = false;
            this.Solutions.AllowUserToDeleteRows = false;
            this.Solutions.AllowUserToResizeColumns = false;
            this.Solutions.AllowUserToResizeRows = false;
            this.Solutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Solutions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.Solutions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Solutions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Solutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Solutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnR1,
            this.ColumnR2,
            this.ColumnUin,
            this.ColumnUout,
            this.Column1,
            this.ColumnError,
            this.ColumnIDiv,
            this.ColumnIOmax});
            this.Solutions.GridColor = System.Drawing.Color.White;
            this.Solutions.Location = new System.Drawing.Point(12, 195);
            this.Solutions.Name = "Solutions";
            this.Solutions.ReadOnly = true;
            this.Solutions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Solutions.RowHeadersVisible = false;
            this.Solutions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Solutions.Size = new System.Drawing.Size(630, 183);
            this.Solutions.TabIndex = 11;
            // 
            // ColumnR1
            // 
            this.ColumnR1.Frozen = true;
            this.ColumnR1.HeaderText = "R1";
            this.ColumnR1.Name = "ColumnR1";
            this.ColumnR1.ReadOnly = true;
            this.ColumnR1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnR1.Width = 72;
            // 
            // ColumnR2
            // 
            this.ColumnR2.HeaderText = "R2";
            this.ColumnR2.Name = "ColumnR2";
            this.ColumnR2.ReadOnly = true;
            this.ColumnR2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnR2.Width = 72;
            // 
            // ColumnUin
            // 
            this.ColumnUin.HeaderText = "Uin";
            this.ColumnUin.Name = "ColumnUin";
            this.ColumnUin.ReadOnly = true;
            this.ColumnUin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnUin.Width = 73;
            // 
            // ColumnUout
            // 
            this.ColumnUout.HeaderText = "Uout";
            this.ColumnUout.Name = "ColumnUout";
            this.ColumnUout.ReadOnly = true;
            this.ColumnUout.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnUout.Width = 73;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ΔUout";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // ColumnError
            // 
            this.ColumnError.HeaderText = "δUout";
            this.ColumnError.Name = "ColumnError";
            this.ColumnError.ReadOnly = true;
            this.ColumnError.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnError.Width = 73;
            // 
            // ColumnIDiv
            // 
            this.ColumnIDiv.HeaderText = "I div.";
            this.ColumnIDiv.Name = "ColumnIDiv";
            this.ColumnIDiv.ReadOnly = true;
            this.ColumnIDiv.Width = 72;
            // 
            // ColumnIOmax
            // 
            this.ColumnIOmax.HeaderText = "I out(max)";
            this.ColumnIOmax.Name = "ColumnIOmax";
            this.ColumnIOmax.ReadOnly = true;
            // 
            // R1SelectBox
            // 
            this.R1SelectBox.Controls.Add(this.R1SelectMaxBox);
            this.R1SelectBox.Controls.Add(this.R1SelectMinBox);
            this.R1SelectBox.Location = new System.Drawing.Point(396, 13);
            this.R1SelectBox.Name = "R1SelectBox";
            this.R1SelectBox.Size = new System.Drawing.Size(120, 168);
            this.R1SelectBox.TabIndex = 12;
            this.R1SelectBox.TabStop = false;
            this.R1SelectBox.Text = "R1";
            // 
            // R1SelectMaxBox
            // 
            this.R1SelectMaxBox.Controls.Add(this.R1ValueEnd);
            this.R1SelectMaxBox.Controls.Add(this.R1FactorEnd);
            this.R1SelectMaxBox.Location = new System.Drawing.Point(6, 88);
            this.R1SelectMaxBox.Name = "R1SelectMaxBox";
            this.R1SelectMaxBox.Size = new System.Drawing.Size(108, 74);
            this.R1SelectMaxBox.TabIndex = 1;
            this.R1SelectMaxBox.TabStop = false;
            this.R1SelectMaxBox.Text = "End";
            // 
            // R1ValueEnd
            // 
            this.R1ValueEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R1ValueEnd.FormattingEnabled = true;
            this.R1ValueEnd.Location = new System.Drawing.Point(6, 46);
            this.R1ValueEnd.Name = "R1ValueEnd";
            this.R1ValueEnd.Size = new System.Drawing.Size(96, 21);
            this.R1ValueEnd.TabIndex = 1;
            // 
            // R1FactorEnd
            // 
            this.R1FactorEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R1FactorEnd.FormattingEnabled = true;
            this.R1FactorEnd.Items.AddRange(new object[] {
            "Units Ohm",
            "Tens of Ohm",
            "Hundreds of Ohm",
            "Units kOhm",
            "Tens of kOhm",
            "Hundreds of kOhm",
            "Units MOhm"});
            this.R1FactorEnd.Location = new System.Drawing.Point(6, 19);
            this.R1FactorEnd.Name = "R1FactorEnd";
            this.R1FactorEnd.Size = new System.Drawing.Size(96, 21);
            this.R1FactorEnd.TabIndex = 0;
            this.R1FactorEnd.SelectedIndexChanged += new System.EventHandler(this.R1FStopSelectedIndexChanged);
            // 
            // R1SelectMinBox
            // 
            this.R1SelectMinBox.Controls.Add(this.R1ValueBegin);
            this.R1SelectMinBox.Controls.Add(this.R1FactorBegin);
            this.R1SelectMinBox.Location = new System.Drawing.Point(6, 13);
            this.R1SelectMinBox.Name = "R1SelectMinBox";
            this.R1SelectMinBox.Size = new System.Drawing.Size(108, 74);
            this.R1SelectMinBox.TabIndex = 0;
            this.R1SelectMinBox.TabStop = false;
            this.R1SelectMinBox.Text = "Begin";
            // 
            // R1ValueBegin
            // 
            this.R1ValueBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R1ValueBegin.FormattingEnabled = true;
            this.R1ValueBegin.Location = new System.Drawing.Point(6, 46);
            this.R1ValueBegin.Name = "R1ValueBegin";
            this.R1ValueBegin.Size = new System.Drawing.Size(96, 21);
            this.R1ValueBegin.TabIndex = 1;
            // 
            // R1FactorBegin
            // 
            this.R1FactorBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R1FactorBegin.FormattingEnabled = true;
            this.R1FactorBegin.Items.AddRange(new object[] {
            "Units Ohm",
            "Tens of Ohm",
            "Hundreds of Ohm",
            "Units kOhm",
            "Tens of kOhm",
            "Hundreds of kOhm",
            "Units MOhm"});
            this.R1FactorBegin.Location = new System.Drawing.Point(6, 19);
            this.R1FactorBegin.Name = "R1FactorBegin";
            this.R1FactorBegin.Size = new System.Drawing.Size(96, 21);
            this.R1FactorBegin.TabIndex = 0;
            this.R1FactorBegin.SelectedIndexChanged += new System.EventHandler(this.R1FStartSelectedIndexChanged);
            // 
            // R2SelectBox
            // 
            this.R2SelectBox.Controls.Add(this.R2SelectMaxBox);
            this.R2SelectBox.Controls.Add(this.R2SelectMinBox);
            this.R2SelectBox.Location = new System.Drawing.Point(522, 13);
            this.R2SelectBox.Name = "R2SelectBox";
            this.R2SelectBox.Size = new System.Drawing.Size(120, 168);
            this.R2SelectBox.TabIndex = 13;
            this.R2SelectBox.TabStop = false;
            this.R2SelectBox.Text = "R2";
            // 
            // R2SelectMaxBox
            // 
            this.R2SelectMaxBox.Controls.Add(this.R2ValueEnd);
            this.R2SelectMaxBox.Controls.Add(this.R2FactorEnd);
            this.R2SelectMaxBox.Location = new System.Drawing.Point(6, 88);
            this.R2SelectMaxBox.Name = "R2SelectMaxBox";
            this.R2SelectMaxBox.Size = new System.Drawing.Size(108, 74);
            this.R2SelectMaxBox.TabIndex = 1;
            this.R2SelectMaxBox.TabStop = false;
            this.R2SelectMaxBox.Text = "End";
            // 
            // R2ValueEnd
            // 
            this.R2ValueEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R2ValueEnd.FormattingEnabled = true;
            this.R2ValueEnd.Location = new System.Drawing.Point(6, 46);
            this.R2ValueEnd.Name = "R2ValueEnd";
            this.R2ValueEnd.Size = new System.Drawing.Size(96, 21);
            this.R2ValueEnd.TabIndex = 1;
            // 
            // R2FactorEnd
            // 
            this.R2FactorEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R2FactorEnd.FormattingEnabled = true;
            this.R2FactorEnd.Items.AddRange(new object[] {
            "Units Ohm",
            "Tens of Ohm",
            "Hundreds of Ohm",
            "Units kOhm",
            "Tens of kOhm",
            "Hundreds of kOhm",
            "Units MOhm"});
            this.R2FactorEnd.Location = new System.Drawing.Point(6, 19);
            this.R2FactorEnd.Name = "R2FactorEnd";
            this.R2FactorEnd.Size = new System.Drawing.Size(96, 21);
            this.R2FactorEnd.TabIndex = 0;
            this.R2FactorEnd.SelectedIndexChanged += new System.EventHandler(this.R2FStopSelectedIndexChanged);
            // 
            // R2SelectMinBox
            // 
            this.R2SelectMinBox.Controls.Add(this.R2ValueBegin);
            this.R2SelectMinBox.Controls.Add(this.R2FactorBegin);
            this.R2SelectMinBox.Location = new System.Drawing.Point(6, 13);
            this.R2SelectMinBox.Name = "R2SelectMinBox";
            this.R2SelectMinBox.Size = new System.Drawing.Size(108, 74);
            this.R2SelectMinBox.TabIndex = 0;
            this.R2SelectMinBox.TabStop = false;
            this.R2SelectMinBox.Text = "Begin";
            // 
            // R2ValueBegin
            // 
            this.R2ValueBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R2ValueBegin.FormattingEnabled = true;
            this.R2ValueBegin.Location = new System.Drawing.Point(6, 46);
            this.R2ValueBegin.Name = "R2ValueBegin";
            this.R2ValueBegin.Size = new System.Drawing.Size(96, 21);
            this.R2ValueBegin.TabIndex = 1;
            // 
            // R2FactorBegin
            // 
            this.R2FactorBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.R2FactorBegin.FormattingEnabled = true;
            this.R2FactorBegin.Items.AddRange(new object[] {
            "Units Ohm",
            "Tens of Ohm",
            "Hundreds of Ohm",
            "Units kOhm",
            "Tens of kOhm",
            "Hundreds of kOhm",
            "Units MOhm"});
            this.R2FactorBegin.Location = new System.Drawing.Point(6, 19);
            this.R2FactorBegin.Name = "R2FactorBegin";
            this.R2FactorBegin.Size = new System.Drawing.Size(96, 21);
            this.R2FactorBegin.TabIndex = 0;
            this.R2FactorBegin.SelectedIndexChanged += new System.EventHandler(this.R2FStartSelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DivU.Properties.Resources.bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(655, 391);
            this.Controls.Add(this.R2SelectBox);
            this.Controls.Add(this.R1SelectBox);
            this.Controls.Add(this.Solutions);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Controls.Add(this.Uout);
            this.Controls.Add(this.Uin);
            this.Controls.Add(this.R2Value);
            this.Controls.Add(this.R1Value);
            this.Controls.Add(this.UoutValue);
            this.Controls.Add(this.UinValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(671, 2000);
            this.MinimumSize = new System.Drawing.Size(671, 429);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voltage Divider";
            ((System.ComponentModel.ISupportInitialize)(this.Solutions)).EndInit();
            this.R1SelectBox.ResumeLayout(false);
            this.R1SelectMaxBox.ResumeLayout(false);
            this.R1SelectMinBox.ResumeLayout(false);
            this.R2SelectBox.ResumeLayout(false);
            this.R2SelectMaxBox.ResumeLayout(false);
            this.R2SelectMinBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UinValue;
        private System.Windows.Forms.TextBox UoutValue;
        private System.Windows.Forms.TextBox R1Value;
        private System.Windows.Forms.TextBox R2Value;
        private System.Windows.Forms.RadioButton Uin;
        private System.Windows.Forms.RadioButton Uout;
        private System.Windows.Forms.RadioButton R1;
        private System.Windows.Forms.RadioButton R2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.DataGridView Solutions;
        private System.Windows.Forms.GroupBox R1SelectBox;
        private System.Windows.Forms.GroupBox R1SelectMinBox;
        private System.Windows.Forms.ComboBox R1FactorBegin;
        private System.Windows.Forms.ComboBox R1ValueBegin;
        private System.Windows.Forms.GroupBox R1SelectMaxBox;
        private System.Windows.Forms.ComboBox R1ValueEnd;
        private System.Windows.Forms.ComboBox R1FactorEnd;
        private System.Windows.Forms.GroupBox R2SelectBox;
        private System.Windows.Forms.GroupBox R2SelectMaxBox;
        private System.Windows.Forms.ComboBox R2ValueEnd;
        private System.Windows.Forms.ComboBox R2FactorEnd;
        private System.Windows.Forms.GroupBox R2SelectMinBox;
        private System.Windows.Forms.ComboBox R2ValueBegin;
        private System.Windows.Forms.ComboBox R2FactorBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnError;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDiv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIOmax;
    }
}

