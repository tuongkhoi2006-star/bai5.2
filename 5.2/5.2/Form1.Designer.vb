<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblCategory = New Label()
        cboCategory = New ComboBox()
        lblAvailable = New Label()
        lstAvailableServices = New ListBox()
        lblSelected = New Label()
        lstSelectedServices = New ListBox()
        btnSelect = New Button()
        btnRemove = New Button()
        btnClearAll = New Button()
        grpPayment = New GroupBox()
        lblSubTotal = New Label()
        txtSubTotal = New TextBox()
        lblDiscount = New Label()
        txtDiscount = New TextBox()
        lblPercent = New Label()
        lblTotal = New Label()
        txtTotal = New TextBox()
        grpPayment.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(20, 22)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(165, 37)
        lblCategory.TabIndex = 0
        lblCategory.Text = "Loại dịch vụ:"
        ' 
        ' cboCategory
        ' 
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategory.Location = New Point(178, 22)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(240, 45)
        cboCategory.TabIndex = 0
        ' 
        ' lblAvailable
        ' 
        lblAvailable.AutoSize = True
        lblAvailable.Location = New Point(20, 65)
        lblAvailable.Name = "lblAvailable"
        lblAvailable.Size = New Size(229, 37)
        lblAvailable.TabIndex = 1
        lblAvailable.Text = "Dịch vụ khả dụng:"
        ' 
        ' lstAvailableServices
        ' 
        lstAvailableServices.FormattingEnabled = True
        lstAvailableServices.IntegralHeight = False
        lstAvailableServices.Location = New Point(4, 92)
        lstAvailableServices.Name = "lstAvailableServices"
        lstAvailableServices.Size = New Size(315, 230)
        lstAvailableServices.TabIndex = 1
        ' 
        ' lblSelected
        ' 
        lblSelected.AutoSize = True
        lblSelected.Location = New Point(400, 65)
        lblSelected.Name = "lblSelected"
        lblSelected.Size = New Size(213, 37)
        lblSelected.TabIndex = 6
        lblSelected.Text = "Dịch vụ đã chọn:"
        ' 
        ' lstSelectedServices
        ' 
        lstSelectedServices.FormattingEnabled = True
        lstSelectedServices.IntegralHeight = False
        lstSelectedServices.Location = New Point(391, 92)
        lstSelectedServices.Name = "lstSelectedServices"
        lstSelectedServices.Size = New Size(309, 230)
        lstSelectedServices.TabIndex = 2
        ' 
        ' btnSelect
        ' 
        btnSelect.Location = New Point(325, 130)
        btnSelect.Name = "btnSelect"
        btnSelect.Size = New Size(60, 36)
        btnSelect.TabIndex = 3
        btnSelect.Text = ">"
        btnSelect.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(325, 176)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(60, 36)
        btnRemove.TabIndex = 4
        btnRemove.Text = "<"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnClearAll
        ' 
        btnClearAll.Location = New Point(325, 222)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(60, 36)
        btnClearAll.TabIndex = 5
        btnClearAll.Text = "<<"
        btnClearAll.UseVisualStyleBackColor = True
        ' 
        ' grpPayment
        ' 
        grpPayment.Controls.Add(lblSubTotal)
        grpPayment.Controls.Add(txtSubTotal)
        grpPayment.Controls.Add(lblDiscount)
        grpPayment.Controls.Add(txtDiscount)
        grpPayment.Controls.Add(lblPercent)
        grpPayment.Controls.Add(lblTotal)
        grpPayment.Location = New Point(20, 345)
        grpPayment.Name = "grpPayment"
        grpPayment.Size = New Size(680, 160)
        grpPayment.TabIndex = 6
        grpPayment.TabStop = False
        grpPayment.Text = "Tính tiền"
        ' 
        ' lblSubTotal
        ' 
        lblSubTotal.AutoSize = True
        lblSubTotal.Location = New Point(20, 36)
        lblSubTotal.Name = "lblSubTotal"
        lblSubTotal.Size = New Size(267, 37)
        lblSubTotal.TabIndex = 0
        lblSubTotal.Text = "Tổng tiền chưa giảm:"
        ' 
        ' txtSubTotal
        ' 
        txtSubTotal.Location = New Point(281, 30)
        txtSubTotal.Name = "txtSubTotal"
        txtSubTotal.ReadOnly = True
        txtSubTotal.Size = New Size(200, 43)
        txtSubTotal.TabIndex = 0
        txtSubTotal.TabStop = False
        txtSubTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Location = New Point(20, 76)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(206, 37)
        lblDiscount.TabIndex = 1
        lblDiscount.Text = "Tỷ lệ chiết khấu:"
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(224, 76)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(80, 43)
        txtDiscount.TabIndex = 1
        txtDiscount.Text = "0"
        txtDiscount.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblPercent
        ' 
        lblPercent.AutoSize = True
        lblPercent.Location = New Point(305, 82)
        lblPercent.Name = "lblPercent"
        lblPercent.Size = New Size(39, 37)
        lblPercent.TabIndex = 2
        lblPercent.Text = "%"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(20, 116)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(284, 37)
        lblTotal.TabIndex = 3
        lblTotal.Text = "Thành tiền thanh toán:"
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        txtTotal.Location = New Point(325, 467)
        txtTotal.Name = "txtTotal"
        txtTotal.ReadOnly = True
        txtTotal.Size = New Size(200, 43)
        txtTotal.TabIndex = 2
        txtTotal.TabStop = False
        txtTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(15.0F, 37.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 525)
        Controls.Add(lblCategory)
        Controls.Add(cboCategory)
        Controls.Add(lblAvailable)
        Controls.Add(lstAvailableServices)
        Controls.Add(btnSelect)
        Controls.Add(btnRemove)
        Controls.Add(txtTotal)
        Controls.Add(btnClearAll)
        Controls.Add(lblSelected)
        Controls.Add(lstSelectedServices)
        Controls.Add(grpPayment)
        Font = New Font("Segoe UI", 10.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bảng tính tiền dịch vụ và chiết khấu đơn hàng"
        grpPayment.ResumeLayout(False)
        grpPayment.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents lblAvailable As Label
    Friend WithEvents lstAvailableServices As ListBox
    Friend WithEvents lblSelected As Label
    Friend WithEvents lstSelectedServices As ListBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClearAll As Button
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox

End Class
