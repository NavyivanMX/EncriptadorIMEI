Public Class frmSemilla
    Private Sub frmSemilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = frmPrincipal.Icon
        OPVisualizacionForm(Me)
        TXTSEMILLA.Text = My.Settings.Semilla
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BDEjecutarSql("UPDATE VERSIONES SET SEMILLA='" + TXTSEMILLA.Text + "' WHERE SISTEMA='APP'", "Data Source=structureserver2.noip.me,1433;Network Library=DBMSSOCN;Initial Catalog=MAQUISA;User ID=MAROSILOCAL;Password=Loco*1234")
        BDEjecutarSql("UPDATE VERSIONES SET SEMILLA='" + TXTSEMILLA.Text + "' WHERE SISTEMA='APP'", "Data Source=structureserver2.noip.me,1433;Network Library=DBMSSOCN;Initial Catalog=MAQUISAP;User ID=MAROSILOCAL;Password=Loco*1234")
        My.Settings.Semilla = TXTSEMILLA.Text
        My.Settings.Save()
        My.Settings.Reload()
        MessageBox.Show("Semilla guardada")
    End Sub
End Class