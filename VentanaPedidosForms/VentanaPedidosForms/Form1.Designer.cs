namespace VentanaPedidosForms
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdConductor = new System.Windows.Forms.TextBox();
            this.txtLatitud = new System.Windows.Forms.TextBox();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.k = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdConductor
            // 
            this.txtIdConductor.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtIdConductor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIdConductor.Location = new System.Drawing.Point(285, 240);
            this.txtIdConductor.Name = "txtIdConductor";
            this.txtIdConductor.Size = new System.Drawing.Size(271, 38);
            this.txtIdConductor.TabIndex = 1;
            this.txtIdConductor.Text = "Id Conductor";
            this.txtIdConductor.Enter += new System.EventHandler(this.txtIdConductor_Enter);
            // 
            // txtLatitud
            // 
            this.txtLatitud.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLatitud.Location = new System.Drawing.Point(287, 301);
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.Size = new System.Drawing.Size(268, 38);
            this.txtLatitud.TabIndex = 2;
            this.txtLatitud.Text = "Latitud";
            this.txtLatitud.Enter += new System.EventHandler(this.txtLatitud_Enter);
            // 
            // txtLongitud
            // 
            this.txtLongitud.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtLongitud.Location = new System.Drawing.Point(286, 363);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(269, 38);
            this.txtLongitud.TabIndex = 3;
            this.txtLongitud.Text = "Longitud";
            this.txtLongitud.Enter += new System.EventHandler(this.txtLongitud_Enter);
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.k.Location = new System.Drawing.Point(123, 141);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(375, 32);
            this.k.TabIndex = 4;
            this.k.Text = "Ingrese los siguientes datos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 766);
            this.Controls.Add(this.k);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.txtLatitud);
            this.Controls.Add(this.txtIdConductor);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLatitud;
        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Label k;
        private System.Windows.Forms.TextBox txtIdConductor;
    }
}

