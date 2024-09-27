namespace CRUD
{
    partial class Crud
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crud));
            TabControl = new TabControl();
            tabPage2 = new TabPage();
            DateTimePickerRegist = new DateTimePicker();
            label9 = new Label();
            LblImageRegisUser = new Label();
            imageList1 = new ImageList(components);
            dataGridView4 = new DataGridView();
            TxtNumTelf = new TextBox();
            TxtApellidos = new TextBox();
            TxtNombres = new TextBox();
            TxtCid = new TextBox();
            LblFecNac = new Label();
            LblNumTelf = new Label();
            LblApellido = new Label();
            LblCid = new Label();
            LblNombre = new Label();
            BtnRegistrar = new Button();
            tabPage3 = new TabPage();
            label10 = new Label();
            label11 = new Label();
            dataGridView3 = new DataGridView();
            TxtEliminarUsuario = new TextBox();
            label1 = new Label();
            BtnEliminarUsuario = new Button();
            tabPage1 = new TabPage();
            TxtFecNacActualizar = new TextBox();
            label14 = new Label();
            label15 = new Label();
            BtnSearch = new Button();
            label8 = new Label();
            TxtCidActualizar = new TextBox();
            label7 = new Label();
            TxtNumTelfActualizar = new TextBox();
            TxtApellidosActualizar = new TextBox();
            TxtNombresActualizar = new TextBox();
            TxtCidActualizarBusc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnActualizarUsuario = new Button();
            dataGridView1 = new DataGridView();
            TabControl.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(tabPage3);
            TabControl.Controls.Add(tabPage1);
            TabControl.Dock = DockStyle.Fill;
            TabControl.HotTrack = true;
            TabControl.Location = new Point(0, 0);
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1180, 632);
            TabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(DateTimePickerRegist);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(LblImageRegisUser);
            tabPage2.Controls.Add(dataGridView4);
            tabPage2.Controls.Add(TxtNumTelf);
            tabPage2.Controls.Add(TxtApellidos);
            tabPage2.Controls.Add(TxtNombres);
            tabPage2.Controls.Add(TxtCid);
            tabPage2.Controls.Add(LblFecNac);
            tabPage2.Controls.Add(LblNumTelf);
            tabPage2.Controls.Add(LblApellido);
            tabPage2.Controls.Add(LblCid);
            tabPage2.Controls.Add(LblNombre);
            tabPage2.Controls.Add(BtnRegistrar);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1172, 602);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registrar";
            // 
            // DateTimePickerRegist
            // 
            DateTimePickerRegist.CalendarFont = new Font("Manrope", 8.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePickerRegist.Cursor = Cursors.Hand;
            DateTimePickerRegist.Format = DateTimePickerFormat.Short;
            DateTimePickerRegist.Location = new Point(163, 376);
            DateTimePickerRegist.Name = "DateTimePickerRegist";
            DateTimePickerRegist.RightToLeft = RightToLeft.No;
            DateTimePickerRegist.Size = new Size(165, 24);
            DateTimePickerRegist.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Manrope", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(41, 140);
            label9.Name = "label9";
            label9.Size = new Size(264, 37);
            label9.TabIndex = 14;
            label9.Text = "Registrar Usuarios";
            // 
            // LblImageRegisUser
            // 
            LblImageRegisUser.ImageIndex = 4;
            LblImageRegisUser.ImageList = imageList1;
            LblImageRegisUser.Location = new Point(121, 40);
            LblImageRegisUser.Name = "LblImageRegisUser";
            LblImageRegisUser.RightToLeft = RightToLeft.Yes;
            LblImageRegisUser.Size = new Size(100, 100);
            LblImageRegisUser.TabIndex = 13;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "user-cancel.png");
            imageList1.Images.SetKeyName(1, "user-search.png");
            imageList1.Images.SetKeyName(2, "refresh.png");
            imageList1.Images.SetKeyName(3, "trash.png");
            imageList1.Images.SetKeyName(4, "user.png");
            // 
            // dataGridView4
            // 
            dataGridView4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView4.BackgroundColor = Color.White;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(351, 0);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(821, 602);
            dataGridView4.TabIndex = 11;
            // 
            // TxtNumTelf
            // 
            TxtNumTelf.Location = new Point(163, 339);
            TxtNumTelf.Name = "TxtNumTelf";
            TxtNumTelf.Size = new Size(165, 24);
            TxtNumTelf.TabIndex = 9;
            // 
            // TxtApellidos
            // 
            TxtApellidos.Location = new Point(163, 299);
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.Size = new Size(165, 24);
            TxtApellidos.TabIndex = 8;
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(163, 259);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(165, 24);
            TxtNombres.TabIndex = 7;
            // 
            // TxtCid
            // 
            TxtCid.Location = new Point(163, 219);
            TxtCid.Name = "TxtCid";
            TxtCid.Size = new Size(165, 24);
            TxtCid.TabIndex = 6;
            // 
            // LblFecNac
            // 
            LblFecNac.AutoSize = true;
            LblFecNac.BackColor = Color.White;
            LblFecNac.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFecNac.Location = new Point(20, 382);
            LblFecNac.Name = "LblFecNac";
            LblFecNac.Size = new Size(128, 17);
            LblFecNac.TabIndex = 5;
            LblFecNac.Text = "Fecha de Nacimiento";
            // 
            // LblNumTelf
            // 
            LblNumTelf.AutoSize = true;
            LblNumTelf.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNumTelf.Location = new Point(20, 342);
            LblNumTelf.Name = "LblNumTelf";
            LblNumTelf.Size = new Size(123, 17);
            LblNumTelf.TabIndex = 4;
            LblNumTelf.Text = "Número de Teléfono";
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblApellido.Location = new Point(20, 302);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(60, 17);
            LblApellido.TabIndex = 3;
            LblApellido.Text = "Apellidos";
            // 
            // LblCid
            // 
            LblCid.AutoSize = true;
            LblCid.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCid.Location = new Point(20, 222);
            LblCid.Name = "LblCid";
            LblCid.Size = new Size(121, 17);
            LblCid.TabIndex = 2;
            LblCid.Text = "Cédula de Identidad";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblNombre.Location = new Point(20, 262);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(61, 17);
            LblNombre.TabIndex = 1;
            LblNombre.Text = "Nombres";
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Cursor = Cursors.Hand;
            BtnRegistrar.Location = new Point(20, 430);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(115, 37);
            BtnRegistrar.TabIndex = 0;
            BtnRegistrar.Text = "Registrar Usuario";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(TxtEliminarUsuario);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(BtnEliminarUsuario);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1172, 604);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Manrope", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(53, 236);
            label10.Name = "label10";
            label10.Size = new Size(248, 37);
            label10.TabIndex = 16;
            label10.Text = "Eliminar Usuarios";
            // 
            // label11
            // 
            label11.ImageIndex = 0;
            label11.ImageList = imageList1;
            label11.Location = new Point(121, 136);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(100, 100);
            label11.TabIndex = 15;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(351, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(821, 594);
            dataGridView3.TabIndex = 8;
            // 
            // TxtEliminarUsuario
            // 
            TxtEliminarUsuario.Location = new Point(163, 308);
            TxtEliminarUsuario.Name = "TxtEliminarUsuario";
            TxtEliminarUsuario.Size = new Size(153, 24);
            TxtEliminarUsuario.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Manrope", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 311);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 6;
            label1.Text = "Cédula de Indentidad:";
            // 
            // BtnEliminarUsuario
            // 
            BtnEliminarUsuario.Cursor = Cursors.Hand;
            BtnEliminarUsuario.Location = new Point(28, 379);
            BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            BtnEliminarUsuario.Size = new Size(115, 37);
            BtnEliminarUsuario.TabIndex = 5;
            BtnEliminarUsuario.Text = "Eliminar Usuario";
            BtnEliminarUsuario.UseVisualStyleBackColor = true;
            BtnEliminarUsuario.Click += BtnEliminarUsuario_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(TxtFecNacActualizar);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(BtnSearch);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(TxtCidActualizar);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(TxtNumTelfActualizar);
            tabPage1.Controls.Add(TxtApellidosActualizar);
            tabPage1.Controls.Add(TxtNombresActualizar);
            tabPage1.Controls.Add(TxtCidActualizarBusc);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(BtnActualizarUsuario);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1172, 604);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Actualizar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // TxtFecNacActualizar
            // 
            TxtFecNacActualizar.Cursor = Cursors.IBeam;
            TxtFecNacActualizar.Location = new Point(165, 454);
            TxtFecNacActualizar.Name = "TxtFecNacActualizar";
            TxtFecNacActualizar.PlaceholderText = "Formato: yyyy-mm-dd";
            TxtFecNacActualizar.Size = new Size(165, 24);
            TxtFecNacActualizar.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Manrope", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(62, 112);
            label14.Name = "label14";
            label14.Size = new Size(235, 37);
            label14.TabIndex = 27;
            label14.Text = "Actualizar Datos";
            // 
            // label15
            // 
            label15.ImageIndex = 2;
            label15.ImageList = imageList1;
            label15.Location = new Point(121, 12);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(100, 100);
            label15.TabIndex = 26;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(22, 209);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(117, 37);
            BtnSearch.TabIndex = 25;
            BtnSearch.Text = "Buscar";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Manrope", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 284);
            label8.Name = "label8";
            label8.Size = new Size(193, 28);
            label8.TabIndex = 24;
            label8.Text = "Datos a Actualizar";
            // 
            // TxtCidActualizar
            // 
            TxtCidActualizar.Cursor = Cursors.IBeam;
            TxtCidActualizar.Location = new Point(165, 334);
            TxtCidActualizar.Name = "TxtCidActualizar";
            TxtCidActualizar.Size = new Size(165, 24);
            TxtCidActualizar.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Manrope", 8.999999F);
            label7.Location = new Point(22, 337);
            label7.Name = "label7";
            label7.Size = new Size(119, 17);
            label7.TabIndex = 22;
            label7.Text = "Cédula de Identidad";
            // 
            // TxtNumTelfActualizar
            // 
            TxtNumTelfActualizar.Cursor = Cursors.IBeam;
            TxtNumTelfActualizar.Location = new Point(165, 424);
            TxtNumTelfActualizar.Name = "TxtNumTelfActualizar";
            TxtNumTelfActualizar.Size = new Size(165, 24);
            TxtNumTelfActualizar.TabIndex = 20;
            // 
            // TxtApellidosActualizar
            // 
            TxtApellidosActualizar.Cursor = Cursors.IBeam;
            TxtApellidosActualizar.Location = new Point(165, 394);
            TxtApellidosActualizar.Name = "TxtApellidosActualizar";
            TxtApellidosActualizar.Size = new Size(165, 24);
            TxtApellidosActualizar.TabIndex = 19;
            // 
            // TxtNombresActualizar
            // 
            TxtNombresActualizar.Cursor = Cursors.IBeam;
            TxtNombresActualizar.Location = new Point(165, 364);
            TxtNombresActualizar.Name = "TxtNombresActualizar";
            TxtNombresActualizar.Size = new Size(165, 24);
            TxtNombresActualizar.TabIndex = 18;
            // 
            // TxtCidActualizarBusc
            // 
            TxtCidActualizarBusc.Cursor = Cursors.IBeam;
            TxtCidActualizarBusc.Location = new Point(165, 172);
            TxtCidActualizarBusc.Name = "TxtCidActualizarBusc";
            TxtCidActualizarBusc.Size = new Size(165, 24);
            TxtCidActualizarBusc.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Manrope", 8.999999F);
            label2.Location = new Point(22, 455);
            label2.Name = "label2";
            label2.Size = new Size(124, 17);
            label2.TabIndex = 16;
            label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Manrope", 8.999999F);
            label3.Location = new Point(22, 427);
            label3.Name = "label3";
            label3.Size = new Size(117, 17);
            label3.TabIndex = 15;
            label3.Text = "Número de Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Manrope", 8.999999F);
            label4.Location = new Point(22, 397);
            label4.Name = "label4";
            label4.Size = new Size(59, 17);
            label4.TabIndex = 14;
            label4.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Manrope", 8.999999F);
            label5.Location = new Point(22, 175);
            label5.Name = "label5";
            label5.Size = new Size(136, 17);
            label5.TabIndex = 13;
            label5.Text = "Buscar Usuario Cédula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Manrope", 8.999999F);
            label6.Location = new Point(22, 367);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 12;
            label6.Text = "Nombres";
            // 
            // BtnActualizarUsuario
            // 
            BtnActualizarUsuario.Cursor = Cursors.Hand;
            BtnActualizarUsuario.Location = new Point(22, 498);
            BtnActualizarUsuario.Name = "BtnActualizarUsuario";
            BtnActualizarUsuario.Size = new Size(117, 37);
            BtnActualizarUsuario.TabIndex = 11;
            BtnActualizarUsuario.Text = "Actualizar Usuario";
            BtnActualizarUsuario.UseVisualStyleBackColor = true;
            BtnActualizarUsuario.Click += BtnActualizarUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(351, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(821, 580);
            dataGridView1.TabIndex = 0;
            // 
            // Crud
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1180, 632);
            Controls.Add(TabControl);
            Font = new Font("Manrope", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Crud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD";
            TabControl.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button BtnRegistrar;
        private Label LblFecNac;
        private Label LblNumTelf;
        private Label LblApellido;
        private Label LblCid;
        private Label LblNombre;
        private TextBox TxtNumTelf;
        private TextBox TxtApellidos;
        private TextBox TxtNombres;
        private TextBox TxtCid;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView3;
        private TextBox TxtEliminarUsuario;
        private Label label1;
        private Button BtnEliminarUsuario;
        private DataGridView dataGridView4;
        private Label label8;
        private TextBox TxtCidActualizar;
        private Label label7;
        private TextBox TxtNumTelfActualizar;
        private TextBox TxtApellidosActualizar;
        private TextBox TxtNombresActualizar;
        private TextBox TxtCidActualizarBusc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnActualizarUsuario;
        private Button BtnSearch;
        private ImageList imageList1;
        private Label LblImageRegisUser;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label14;
        private Label label15;
        private DateTimePicker DateTimePickerRegist;
        private TextBox TxtFecNacActualizar;
    }
}
