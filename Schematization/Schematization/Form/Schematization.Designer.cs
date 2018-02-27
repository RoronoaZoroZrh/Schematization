namespace Schematization
{
    partial class FormSchematization
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelSchematization = new DevComponents.DotNetBar.PanelEx();
            this.ButtonFinishTask = new DevComponents.DotNetBar.ButtonX();
            this.ButtonDelTask = new DevComponents.DotNetBar.ButtonX();
            this.ButtonAddTask = new DevComponents.DotNetBar.ButtonX();
            this.AdvTreeTask = new DevComponents.AdvTree.AdvTree();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ComboBoxTask = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboBoxType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.BarMenu = new DevComponents.DotNetBar.Bar();
            this.ButtonItemMenu = new DevComponents.DotNetBar.ButtonItem();
            this.FormStyleManager = new DevComponents.DotNetBar.StyleManager();
            this.PanelSchematization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvTreeTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSchematization
            // 
            this.PanelSchematization.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelSchematization.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelSchematization.Controls.Add(this.ButtonFinishTask);
            this.PanelSchematization.Controls.Add(this.ButtonDelTask);
            this.PanelSchematization.Controls.Add(this.ButtonAddTask);
            this.PanelSchematization.Controls.Add(this.AdvTreeTask);
            this.PanelSchematization.Controls.Add(this.ComboBoxTask);
            this.PanelSchematization.Controls.Add(this.ComboBoxType);
            this.PanelSchematization.Controls.Add(this.BarMenu);
            this.PanelSchematization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSchematization.Location = new System.Drawing.Point(0, 0);
            this.PanelSchematization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelSchematization.Name = "PanelSchematization";
            this.PanelSchematization.Size = new System.Drawing.Size(677, 636);
            this.PanelSchematization.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelSchematization.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelSchematization.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelSchematization.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelSchematization.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelSchematization.Style.GradientAngle = 90;
            this.PanelSchematization.TabIndex = 0;
            // 
            // ButtonFinishTask
            // 
            this.ButtonFinishTask.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonFinishTask.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonFinishTask.Location = new System.Drawing.Point(546, 561);
            this.ButtonFinishTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonFinishTask.Name = "ButtonFinishTask";
            this.ButtonFinishTask.Size = new System.Drawing.Size(117, 58);
            this.ButtonFinishTask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonFinishTask.TabIndex = 6;
            this.ButtonFinishTask.Text = "完成任务";
            // 
            // ButtonDelTask
            // 
            this.ButtonDelTask.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonDelTask.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonDelTask.Location = new System.Drawing.Point(280, 561);
            this.ButtonDelTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonDelTask.Name = "ButtonDelTask";
            this.ButtonDelTask.Size = new System.Drawing.Size(117, 58);
            this.ButtonDelTask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonDelTask.TabIndex = 5;
            this.ButtonDelTask.Text = "删除任务";
            // 
            // ButtonAddTask
            // 
            this.ButtonAddTask.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonAddTask.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonAddTask.Location = new System.Drawing.Point(14, 561);
            this.ButtonAddTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddTask.Name = "ButtonAddTask";
            this.ButtonAddTask.Size = new System.Drawing.Size(117, 58);
            this.ButtonAddTask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonAddTask.TabIndex = 4;
            this.ButtonAddTask.Text = "添加任务";
            this.ButtonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // AdvTreeTask
            // 
            this.AdvTreeTask.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.AdvTreeTask.AllowDrop = true;
            this.AdvTreeTask.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.AdvTreeTask.BackgroundStyle.Class = "TreeBorderKey";
            this.AdvTreeTask.Location = new System.Drawing.Point(14, 85);
            this.AdvTreeTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdvTreeTask.Name = "AdvTreeTask";
            this.AdvTreeTask.NodesConnector = this.nodeConnector1;
            this.AdvTreeTask.NodeStyle = this.elementStyle1;
            this.AdvTreeTask.PathSeparator = ";";
            this.AdvTreeTask.Size = new System.Drawing.Size(649, 454);
            this.AdvTreeTask.Styles.Add(this.elementStyle1);
            this.AdvTreeTask.TabIndex = 3;
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ComboBoxTask
            // 
            this.ComboBoxTask.DisplayMember = "Text";
            this.ComboBoxTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxTask.FormattingEnabled = true;
            this.ComboBoxTask.ItemHeight = 17;
            this.ComboBoxTask.Location = new System.Drawing.Point(162, 47);
            this.ComboBoxTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxTask.Name = "ComboBoxTask";
            this.ComboBoxTask.Size = new System.Drawing.Size(500, 23);
            this.ComboBoxTask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxTask.TabIndex = 2;
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.DisplayMember = "Text";
            this.ComboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.ItemHeight = 17;
            this.ComboBoxType.Location = new System.Drawing.Point(14, 47);
            this.ComboBoxType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(140, 23);
            this.ComboBoxType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxType.TabIndex = 1;
            // 
            // BarMenu
            // 
            this.BarMenu.AccessibleDescription = "BarMenu(BarMenu)";
            this.BarMenu.AccessibleName = "BarMenu";
            this.BarMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.BarMenu.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.BarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.BarMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ButtonItemMenu});
            this.BarMenu.Location = new System.Drawing.Point(0, 0);
            this.BarMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarMenu.Name = "BarMenu";
            this.BarMenu.Size = new System.Drawing.Size(677, 27);
            this.BarMenu.Stretch = true;
            this.BarMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BarMenu.TabIndex = 0;
            this.BarMenu.TabStop = false;
            // 
            // ButtonItemMenu
            // 
            this.ButtonItemMenu.Name = "ButtonItemMenu";
            this.ButtonItemMenu.Text = "菜单";
            // 
            // FormStyleManager
            // 
            this.FormStyleManager.ManagerColorTint = System.Drawing.Color.DimGray;
            this.FormStyleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            // 
            // FormSchematization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 636);
            this.Controls.Add(this.PanelSchematization);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSchematization";
            this.Text = "任务规划";
            this.PanelSchematization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvTreeTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PanelSchematization;
        private DevComponents.DotNetBar.Bar BarMenu;
        private DevComponents.DotNetBar.ButtonItem ButtonItemMenu;
        private DevComponents.DotNetBar.StyleManager FormStyleManager;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxTask;
        private DevComponents.AdvTree.AdvTree AdvTreeTask;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.ButtonX ButtonAddTask;
        private DevComponents.DotNetBar.ButtonX ButtonFinishTask;
        private DevComponents.DotNetBar.ButtonX ButtonDelTask;
    }
}

