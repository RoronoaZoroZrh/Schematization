namespace Schematization
{
    partial class FormCreateTask
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
            this.PanelCreateTask = new DevComponents.DotNetBar.PanelEx();
            this.LabelTaskType = new DevComponents.DotNetBar.LabelX();
            this.LabelTaskName = new DevComponents.DotNetBar.LabelX();
            this.ComboBoxTaskType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.TextBoxTaskName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ButtonCertain = new DevComponents.DotNetBar.ButtonX();
            this.ButtonCancel = new DevComponents.DotNetBar.ButtonX();
            this.PanelCreateTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelCreateTask
            // 
            this.PanelCreateTask.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelCreateTask.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelCreateTask.Controls.Add(this.ButtonCancel);
            this.PanelCreateTask.Controls.Add(this.ButtonCertain);
            this.PanelCreateTask.Controls.Add(this.TextBoxTaskName);
            this.PanelCreateTask.Controls.Add(this.ComboBoxTaskType);
            this.PanelCreateTask.Controls.Add(this.LabelTaskName);
            this.PanelCreateTask.Controls.Add(this.LabelTaskType);
            this.PanelCreateTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCreateTask.Location = new System.Drawing.Point(0, 0);
            this.PanelCreateTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelCreateTask.Name = "PanelCreateTask";
            this.PanelCreateTask.Size = new System.Drawing.Size(449, 184);
            this.PanelCreateTask.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelCreateTask.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelCreateTask.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelCreateTask.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelCreateTask.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelCreateTask.Style.GradientAngle = 90;
            this.PanelCreateTask.TabIndex = 0;
            // 
            // LabelTaskType
            // 
            this.LabelTaskType.AutoSize = true;
            // 
            // 
            // 
            this.LabelTaskType.BackgroundStyle.Class = "";
            this.LabelTaskType.Location = new System.Drawing.Point(14, 25);
            this.LabelTaskType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelTaskType.Name = "LabelTaskType";
            this.LabelTaskType.Size = new System.Drawing.Size(68, 20);
            this.LabelTaskType.TabIndex = 0;
            this.LabelTaskType.Text = "任务类型：";
            // 
            // LabelTaskName
            // 
            this.LabelTaskName.AutoSize = true;
            // 
            // 
            // 
            this.LabelTaskName.BackgroundStyle.Class = "";
            this.LabelTaskName.Location = new System.Drawing.Point(14, 68);
            this.LabelTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelTaskName.Name = "LabelTaskName";
            this.LabelTaskName.Size = new System.Drawing.Size(68, 20);
            this.LabelTaskName.TabIndex = 1;
            this.LabelTaskName.Text = "任务名称：";
            // 
            // ComboBoxTaskType
            // 
            this.ComboBoxTaskType.DisplayMember = "Text";
            this.ComboBoxTaskType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxTaskType.FormattingEnabled = true;
            this.ComboBoxTaskType.ItemHeight = 17;
            this.ComboBoxTaskType.Location = new System.Drawing.Point(88, 24);
            this.ComboBoxTaskType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxTaskType.Name = "ComboBoxTaskType";
            this.ComboBoxTaskType.Size = new System.Drawing.Size(347, 23);
            this.ComboBoxTaskType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboBoxTaskType.TabIndex = 2;
            // 
            // TextBoxTaskName
            // 
            // 
            // 
            // 
            this.TextBoxTaskName.Border.Class = "TextBoxBorder";
            this.TextBoxTaskName.Location = new System.Drawing.Point(88, 67);
            this.TextBoxTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxTaskName.Name = "TextBoxTaskName";
            this.TextBoxTaskName.Size = new System.Drawing.Size(347, 23);
            this.TextBoxTaskName.TabIndex = 3;
            // 
            // ButtonCertain
            // 
            this.ButtonCertain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonCertain.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonCertain.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonCertain.Location = new System.Drawing.Point(14, 111);
            this.ButtonCertain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCertain.Name = "ButtonCertain";
            this.ButtonCertain.Size = new System.Drawing.Size(110, 54);
            this.ButtonCertain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonCertain.TabIndex = 4;
            this.ButtonCertain.Text = "确定";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ButtonCancel.Location = new System.Drawing.Point(325, 111);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(110, 54);
            this.ButtonCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "取消";
            // 
            // FormCreateTask
            // 
            this.AcceptButton = this.ButtonCertain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(449, 184);
            this.ControlBox = false;
            this.Controls.Add(this.PanelCreateTask);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "创建任务";
            this.PanelCreateTask.ResumeLayout(false);
            this.PanelCreateTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PanelCreateTask;
        private DevComponents.DotNetBar.LabelX LabelTaskType;
        private DevComponents.DotNetBar.LabelX LabelTaskName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxTaskType;
        private DevComponents.DotNetBar.Controls.TextBoxX TextBoxTaskName;
        private DevComponents.DotNetBar.ButtonX ButtonCancel;
        private DevComponents.DotNetBar.ButtonX ButtonCertain;
    }
}