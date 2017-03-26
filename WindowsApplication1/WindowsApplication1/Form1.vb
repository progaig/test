Public Class Form1
    Dim table As DataTable = GetTable()

    Function GetTable() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        ' Create four typed columns in the DataTable.
        table.Columns.Add("TeamTitle", GetType(String))
        table.Columns.Add("PercentageRange", GetType(String))
        table.Columns.Add("Amount", GetType(Integer))


        ' Add five rows with those columns filled in the DataTable.
        table.Rows.Add("Parts Sales", "0 - 89.99%", 0)
        table.Rows.Add("Parts Sales", "90 - 90.99%", 250)
        table.Rows.Add("Parts Sales", "91 - 99.99%", 275)
        table.Rows.Add("Parts Sales", "100 - 119.99%", 350)
        table.Rows.Add("Parts Sales", "120 - 500%", 500)

        table.Rows.Add("Inventory Controller", "0 - 89.99%", 0)
        table.Rows.Add("Inventory Controller", "90 - 90.99%", 250)
        table.Rows.Add("Inventory Controller", "91 - 99.99%", 275)
        table.Rows.Add("Inventory Controller", "100 - 119.99%", 350)
        table.Rows.Add("Inventory Controller", "120 - 500%", 500)

        table.Rows.Add("CPD Picker", "0 - 89.99%", 0)
        table.Rows.Add("CPD Picker", "90 - 90.99%", 199)
        table.Rows.Add("CPD Picker", "91 - 99.99%", 225)
        table.Rows.Add("CPD Picker", "100 - 119.99%", 300)
        table.Rows.Add("CPD Picker", "120 - 500%", 400)

        table.Rows.Add("CPD Supervisor", "0 - 89.99%", 0)
        table.Rows.Add("CPD Supervisor", "90 - 90.99%", 250)
        table.Rows.Add("CPD Supervisor", "91 - 99.99%", 275)
        table.Rows.Add("CPD Supervisor", "100 - 119.99%", 350)
        table.Rows.Add("CPD Supervisor", "120 - 500%", 500)

        table.Rows.Add("Parts & Inventory Manager", "0 - 89.99%", 0)
        table.Rows.Add("Parts & Inventory Manager", "90 - 90.99%", 1000)
        table.Rows.Add("Parts & Inventory Manager", "91 - 99.99%", 1250)
        table.Rows.Add("Parts & Inventory Manager", "100 - 119.99%", 1500)
        table.Rows.Add("Parts & Inventory Manager", "120 - 500%", 2000)

        Return table
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.DataSource = table

    End Sub
End Class
