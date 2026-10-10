Imports System.Globalization

Public Class Form1

    ' Dịch vụ: tên + đơn giá
    Private Class ServiceItem
        Public Property Name As String
        Public Property Price As Decimal

        Public Sub New(name As String, price As Decimal)
            Me.Name = name
            Me.Price = price
        End Sub

        Public Overrides Function ToString() As String
            Return $"{Name} - {Price.ToString("N0", _vi)} đ"
        End Function
    End Class

    Private Shared ReadOnly _vi As New CultureInfo("vi-VN")

    ' Nguồn dữ liệu dịch vụ theo từng loại
    Private ReadOnly _services As New Dictionary(Of String, List(Of ServiceItem)) From {
        {"Khám bệnh", New List(Of ServiceItem) From {
            New ServiceItem("Khám tổng quát", 150000D),
            New ServiceItem("Khám nội khoa", 120000D),
            New ServiceItem("Khám ngoại khoa", 120000D),
            New ServiceItem("Khám chuyên khoa", 200000D)
        }},
        {"Xét nghiệm", New List(Of ServiceItem) From {
            New ServiceItem("Xét nghiệm máu", 80000D),
            New ServiceItem("Xét nghiệm nước tiểu", 60000D),
            New ServiceItem("Xét nghiệm sinh hóa", 180000D)
        }},
        {"Chụp X-Quang", New List(Of ServiceItem) From {
            New ServiceItem("X-Quang ngực", 100000D),
            New ServiceItem("X-Quang xương", 120000D),
            New ServiceItem("X-Quang kỹ thuật số", 250000D)
        }},
        {"Vắc-xin", New List(Of ServiceItem) From {
            New ServiceItem("Vắc-xin cúm", 300000D),
            New ServiceItem("Vắc-xin viêm gan B", 350000D),
            New ServiceItem("Vắc-xin uốn ván", 200000D)
        }}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCategory.Items.AddRange(_services.Keys.Cast(Of Object)().ToArray())
        cboCategory.SelectedIndex = 0
        RecalculatePayment()
    End Sub

    ' 1. Đổi loại dịch vụ -> nạp lại danh sách dịch vụ khả dụng
    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        Dim category = TryCast(cboCategory.SelectedItem, String)
        If category Is Nothing Then Return
        lstAvailableServices.Items.Clear()
        For Each svc In _services(category)
            lstAvailableServices.Items.Add(svc)
        Next
    End Sub

    ' 2. Chuyển dịch vụ được chọn sang danh sách đã chọn
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim svc = TryCast(lstAvailableServices.SelectedItem, ServiceItem)
        If svc Is Nothing Then Return
        lstSelectedServices.Items.Add(svc)
        RecalculatePayment()
    End Sub

    ' Double click vào dịch vụ khả dụng cũng chuyển sang danh sách đã chọn
    Private Sub lstAvailableServices_DoubleClick(sender As Object, e As EventArgs) Handles lstAvailableServices.DoubleClick
        btnSelect_Click(sender, e)
    End Sub

    ' Bỏ bớt dịch vụ khỏi danh sách đã chọn
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstSelectedServices.SelectedItem Is Nothing Then Return
        lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem)
        RecalculatePayment()
    End Sub

    ' Xóa toàn bộ dịch vụ đã chọn
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        lstSelectedServices.Items.Clear()
        RecalculatePayment()
    End Sub

    ' Tính lại khi tỷ lệ chiết khấu thay đổi
    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        RecalculatePayment()
    End Sub

    ' 3. Tự động tính tổng tiền và thành tiền thanh toán
    Private Sub RecalculatePayment()
        Dim subTotal As Decimal = 0
        For Each item In lstSelectedServices.Items
            subTotal += DirectCast(item, ServiceItem).Price
        Next

        Dim discount As Decimal = 0
        Decimal.TryParse(txtDiscount.Text, discount)
        discount = Math.Clamp(discount, 0D, 100D)

        Dim total = subTotal * (1 - discount / 100)
        txtSubTotal.Text = subTotal.ToString("N0", _vi) & " đ"
        txtTotal.Text = total.ToString("N0", _vi) & " đ"
    End Sub

    Private Sub txtSubTotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged

    End Sub
End Class
