<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label3 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        cmbitem = New ComboBox()
        txtharga = New TextBox()
        txtjumlah = New TextBox()
        txtsubtotal = New TextBox()
        btnsubtotal = New Button()
        txtdiskon = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        txttotal = New TextBox()
        btntotal = New Button()
        txtbayar = New TextBox()
        txtkembali = New TextBox()
        btnreset = New Button()
        btnclose = New Button()
        cmbvoucher = New ComboBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 125)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(310, 31)
        Label3.TabIndex = 1
        Label3.Text = "APLIKASI KASIR RESTORAN"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gray
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(524, 34)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(238, 36)
        Panel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(51, 7)
        Label2.Name = "Label2"
        Label2.Size = New Size(27, 31)
        Label2.TabIndex = 1
        Label2.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 38)
        Label1.TabIndex = 0
        Label1.Text = "Rp."
        ' 
        ' cmbitem
        ' 
        cmbitem.FormattingEnabled = True
        cmbitem.Items.AddRange(New Object() {"Ayam Bakar", "Ayam Goreng", "Pecel Ayam", "Soto Ayam"})
        cmbitem.Location = New Point(146, 169)
        cmbitem.Name = "cmbitem"
        cmbitem.Size = New Size(176, 28)
        cmbitem.TabIndex = 1
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(148, 203)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(174, 27)
        txtharga.TabIndex = 2
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(148, 236)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(174, 27)
        txtjumlah.TabIndex = 3
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.Location = New Point(148, 270)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.Size = New Size(174, 27)
        txtsubtotal.TabIndex = 4
        ' 
        ' btnsubtotal
        ' 
        btnsubtotal.Location = New Point(146, 303)
        btnsubtotal.Name = "btnsubtotal"
        btnsubtotal.Size = New Size(94, 29)
        btnsubtotal.TabIndex = 5
        btnsubtotal.Text = "Sub Total"
        btnsubtotal.UseVisualStyleBackColor = True
        ' 
        ' txtdiskon
        ' 
        txtdiskon.Location = New Point(146, 349)
        txtdiskon.Name = "txtdiskon"
        txtdiskon.Size = New Size(125, 27)
        txtdiskon.TabIndex = 6
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(146, 382)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(174, 27)
        txttotal.TabIndex = 7
        ' 
        ' btntotal
        ' 
        btntotal.Location = New Point(146, 415)
        btntotal.Name = "btntotal"
        btntotal.Size = New Size(94, 29)
        btntotal.TabIndex = 8
        btntotal.Text = "Total"
        btntotal.UseVisualStyleBackColor = True
        ' 
        ' txtbayar
        ' 
        txtbayar.Location = New Point(542, 349)
        txtbayar.Name = "txtbayar"
        txtbayar.Size = New Size(178, 27)
        txtbayar.TabIndex = 9
        ' 
        ' txtkembali
        ' 
        txtkembali.Location = New Point(543, 382)
        txtkembali.Name = "txtkembali"
        txtkembali.Size = New Size(178, 27)
        txtkembali.TabIndex = 10
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(388, 489)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(94, 29)
        btnreset.TabIndex = 11
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' btnclose
        ' 
        btnclose.Location = New Point(524, 489)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(94, 29)
        btnclose.TabIndex = 12
        btnclose.Text = "Close"
        btnclose.UseVisualStyleBackColor = True
        ' 
        ' cmbvoucher
        ' 
        cmbvoucher.FormattingEnabled = True
        cmbvoucher.Items.AddRange(New Object() {"AKHIRPEKAN", "AKHIRBULAN", "AKHIRTAHUN", "TIDAK ADA"})
        cmbvoucher.Location = New Point(542, 202)
        cmbvoucher.Name = "cmbvoucher"
        cmbvoucher.Size = New Size(178, 28)
        cmbvoucher.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(33, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 25)
        Label4.TabIndex = 14
        Label4.Text = "Menu"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(33, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 25)
        Label5.TabIndex = 15
        Label5.Text = "Harga"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(33, 239)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 25)
        Label6.TabIndex = 16
        Label6.Text = "Jumlah"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(33, 272)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 25)
        Label7.TabIndex = 17
        Label7.Text = "Sub Total"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(33, 352)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 25)
        Label8.TabIndex = 18
        Label8.Text = "Diskon"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(33, 385)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 25)
        Label9.TabIndex = 19
        Label9.Text = "Total"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(552, 169)
        Label10.Name = "Label10"
        Label10.Size = New Size(151, 25)
        Label10.TabIndex = 20
        Label10.Text = "KODE VOUCHER"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(388, 352)
        Label11.Name = "Label11"
        Label11.Size = New Size(111, 25)
        Label11.TabIndex = 21
        Label11.Text = "Uang Bayar"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(388, 385)
        Label12.Name = "Label12"
        Label12.Size = New Size(131, 25)
        Label12.TabIndex = 22
        Label12.Text = "Uang Kembali"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(800, 557)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(cmbvoucher)
        Controls.Add(btnclose)
        Controls.Add(btnreset)
        Controls.Add(txtkembali)
        Controls.Add(txtbayar)
        Controls.Add(btntotal)
        Controls.Add(txttotal)
        Controls.Add(txtdiskon)
        Controls.Add(btnsubtotal)
        Controls.Add(txtsubtotal)
        Controls.Add(txtjumlah)
        Controls.Add(txtharga)
        Controls.Add(cmbitem)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbitem As ComboBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents btnsubtotal As Button
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btntotal As Button
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents txtkembali As TextBox
    Friend WithEvents btnreset As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents cmbvoucher As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
