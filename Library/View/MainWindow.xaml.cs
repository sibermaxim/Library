using Library.ViewModel;
using System.Windows;

namespace Library.View
{
    /*********************************************
     *  MainWindow - модель представления каталога
     * 
     * 
     * ******************************************/

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
        }
    }

    /*
     * <GridViewColumn Header="Автор">
                         <GridViewColumn.CellTemplate>
                            <DataTemplate>
                                <TextBlock Text="{Binding Author}" local:GridViewSort.PropertyName="Author"></TextBlock>
                            </DataTemplate>
                        </GridViewColumn.CellTemplate>
                   </GridViewColumn>
                    
                    <GridViewColumn Header="Название">
                        <GridViewColumn.CellTemplate>
                            <DataTemplate>
                                <TextBlock Text="{Binding Title}" ></TextBlock>
                            </DataTemplate>
                        </GridViewColumn.CellTemplate>
                    </GridViewColumn>
                    
                    <GridViewColumn Header="Тематика">
                         <GridViewColumn.CellTemplate>
                            <DataTemplate>
                                <TextBlock Text="{Binding Tematika}" ></TextBlock>
                            </DataTemplate>
                        </GridViewColumn.CellTemplate>
                   </GridViewColumn>
                    
                    <GridViewColumn Header="Год издания">
                         <GridViewColumn.CellTemplate>
                            <DataTemplate>
                                <TextBlock Text="{Binding Year}" ></TextBlock>
                            </DataTemplate>
                        </GridViewColumn.CellTemplate>
                    </GridViewColumn>*/
}
