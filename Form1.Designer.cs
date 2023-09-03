namespace Ejercicio12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CD_1 = new System.Windows.Forms.ColorDialog();
            this.BTN_Color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_Color
            // 
            this.BTN_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Color.Location = new System.Drawing.Point(165, 84);
            this.BTN_Color.Name = "BTN_Color";
            this.BTN_Color.Size = new System.Drawing.Size(75, 23);
            this.BTN_Color.TabIndex = 0;
            this.BTN_Color.Text = "button1";
            this.BTN_Color.UseVisualStyleBackColor = true;
            this.BTN_Color.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 205);
            this.Controls.Add(this.BTN_Color);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog CD_1;
        private System.Windows.Forms.Button BTN_Color;
    }
}

