namespace Module4
{
    partial class Arithmetic
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        # region Windows Form Designer generated code

        // <summary>
        //  Required method for Designer support - do not modify
        //  the contents of this method with the code editor.
        // </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arithmetic));
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.lblSecondNum = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstNum
            // 
            resources.ApplyResources(this.lblFirstNum, "lblFirstNum");
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Click += new System.EventHandler(this.lblFirstNum_Click);
            // 
            // lblSecondNum
            // 
            resources.ApplyResources(this.lblSecondNum, "lblSecondNum");
            this.lblSecondNum.Name = "lblSecondNum";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtFirstNum, "txtFirstNum");
            this.txtFirstNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFirstNum.Name = "txtFirstNum";
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.txtSecondNum, "txtSecondNum");
            this.txtSecondNum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSecondNum.Name = "txtSecondNum";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnSub, "btnSub");
            this.btnSub.ForeColor = System.Drawing.Color.White;
            this.btnSub.Name = "btnSub";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnMul, "btnMul");
            this.btnMul.ForeColor = System.Drawing.Color.Transparent;
            this.btnMul.Name = "btnMul";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnDiv, "btnDiv");
            this.btnDiv.ForeColor = System.Drawing.Color.Transparent;
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.txtResult, "txtResult");
            this.txtResult.ForeColor = System.Drawing.Color.Red;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // Arithmetic
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.lblSecondNum);
            this.Controls.Add(this.lblFirstNum);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBox = false;
            this.Name = "Arithmetic";
            this.Load += new System.EventHandler(this.Arithmetic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        #endregion

        private Label lblFirstNum;
        private Label lblSecondNum;
        private TextBox txtFirstNum;
        private TextBox txtSecondNum;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private TextBox txtResult;
    }
}