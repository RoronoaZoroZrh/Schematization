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
            this.SuspendLayout();
            // 
            // PanelCreateTask
            // 
            this.PanelCreateTask.CanvasColor = System.Drawing.SystemColors.Control;
            this.PanelCreateTask.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.PanelCreateTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCreateTask.Location = new System.Drawing.Point(0, 0);
            this.PanelCreateTask.Name = "PanelCreateTask";
            this.PanelCreateTask.Size = new System.Drawing.Size(385, 240);
            this.PanelCreateTask.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.PanelCreateTask.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PanelCreateTask.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.PanelCreateTask.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PanelCreateTask.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PanelCreateTask.Style.GradientAngle = 90;
            this.PanelCreateTask.TabIndex = 0;
            // 
            // FormCreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 240);
            this.ControlBox = false;
            this.Controls.Add(this.PanelCreateTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreateTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "创建任务";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx PanelCreateTask;
    }
}