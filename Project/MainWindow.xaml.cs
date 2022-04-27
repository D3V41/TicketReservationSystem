using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Seat> seats = new List<Seat>();
        String[] allSeats = {"A1","A2","A3","A4","A5","A6", "B1", "B2", "B3", "B4", "B5", "B6",
        "C1","C2","C3","C4","C5","C6","D1","D2","D3","D4","D5","D6"};

        public MainWindow()
        {
            InitializeComponent();
            gridBT.Visibility = Visibility.Visible;
            gridSB.Visibility = Visibility.Hidden;
            btnBookTicket.Background = Brushes.White;

            txtName.IsEnabled = false;
            btnConfirm.Visibility = Visibility.Hidden;

            getSelectedSeats(seats);
        }

        private void btnBookTicket_Click(object sender, RoutedEventArgs e)
        {
            gridBT.Visibility = Visibility.Visible;
            gridSB.Visibility = Visibility.Hidden;
            btnBookTicket.Background = Brushes.White;
            btnShowBooking.Background = Brushes.Transparent;
            unSelectSeats();
            getSelectedSeats(seats);
        }

        private void btnShowBooking_Click(object sender, RoutedEventArgs e)
        {
            gridBT.Visibility = Visibility.Hidden;
            gridSB.Visibility = Visibility.Visible;
            btnBookTicket.Background = Brushes.Transparent;
            btnShowBooking.Background = Brushes.White;
            txtSeatNo.Text = "";
            txtName.Text = "";
        }

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void D1_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void D2_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void D3_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void D4_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void A5_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void D5_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void A6_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void C6_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void D6_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            Button btn = (Button)sender;
            doBooking(btn.Name, seats);
            getSelectedSeats(seats);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            unSelectSeats();
            seats.Clear();
            getSelectedSeats(seats);
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text != "" && txtSeatNo.Text != "")
            {
                seats.Add(new Seat() { id = txtSeatNo.Text, name = txtName.Text });
                txtSeatNo.Text = "";
                txtName.Text = "";
                MessageBoxResult result = MessageBox.Show("Seat is booked successfully...", "Success");

            }
            bool flag = checkReseverd();
            if (flag)
            {
                lblReserved.Visibility = Visibility.Visible;
            }
            else
            {
                lblReserved.Visibility = Visibility.Hidden;
            }

        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            var fileContent = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "Text file (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                var fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    fileStream.Close();
                }
            }
            seats.Clear();
            seats = JsonConvert.DeserializeObject<List<Seat>>(fileContent);
            unSelectSeats();
            getSelectedSeats(seats);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string seatsJson = JsonConvert.SerializeObject(seats);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.FileName = "Seatingplan";
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, seatsJson);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            getBooking(seats);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            deleteBooking(seats);
        }

        void getBooking(List<Seat> seats)
        {
            foreach (Seat seat in seats)
            {
                if (txtSearchBox.Text == seat.id || txtSearchBox.Text == seat.name)
                {
                    Console.WriteLine(txtSearchBox.Text);
                    txtblockSeat.Text = "Id: " + seat.id + Environment.NewLine + "Name: " + seat.name;
                    btnDelete.Visibility = Visibility.Visible;
                    txtblockSeat.Visibility = Visibility.Visible;
                    return;
                }
                else
                {
                    Console.WriteLine("hi");
                    txtblockSeat.Text = "No Result.......";
                    btnDelete.Visibility = Visibility.Hidden;
                    txtblockSeat.Visibility = Visibility.Visible;
                }
            }
        }

        void deleteBooking(List<Seat> seats)
        {
            Seat s = null;
            foreach (Seat seat in seats)
            {
                if (txtSearchBox.Text == seat.id || txtSearchBox.Text == seat.name)
                {
                    s = seat;
                    btnDelete.Visibility = Visibility.Hidden;
                    txtblockSeat.Visibility = Visibility.Hidden;
                    MessageBoxResult result = MessageBox.Show("Deleted Successfully....", "Success");
                }
            }
            seats.Remove(s);
        }

        void getSelectedSeats(List<Seat> seats)
        {
            foreach (Seat seat in seats)
            {
                Button button = (Button)this.FindName(seat.id);
                var bc = new BrushConverter();
                button.Background = (Brush)bc.ConvertFrom("#FF2B2B72");
            }
            bool flag = checkReseverd();
            if (flag)
            {
                lblReserved.Visibility = Visibility.Visible;
            }
            else
            {
                lblReserved.Visibility = Visibility.Hidden;
            }
        }

        void unSelectSeats()
        {
            foreach (String seat in allSeats)
            {
                Button button = (Button)this.FindName(seat);
                var bc = new BrushConverter();
                button.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }
        }

        void addFiveSeats(List<Seat> seats)
        {
            seats.Add(new Seat() { id = "A4", name = "Deval" });
            seats.Add(new Seat() { id = "B2", name = "John" });
            seats.Add(new Seat() { id = "C6", name = "Happy" });
            seats.Add(new Seat() { id = "D4", name = "Max" });
            seats.Add(new Seat() { id = "B3", name = "Harry" });
            return;
        }

        void doBooking(String id, List<Seat> seats)
        {
            txtSeatNo.Text = id;
            txtSeatNo.IsEnabled = false;
            txtName.IsEnabled = false;
            btnConfirm.Visibility = Visibility.Hidden;

            foreach (Seat seat in seats)
            {
                if (seat.id == id)
                {
                    Console.WriteLine("Reserved");
                    txtName.Text = seat.name;
                    return;
                }
            }
            Button button = (Button)this.FindName(id);
            var bc = new BrushConverter();
            button.Background = (Brush)bc.ConvertFrom("#FF2B2B72");
            txtName.Text = "";
            txtName.IsEnabled = true;
            btnConfirm.Visibility = Visibility.Visible;
            Console.WriteLine("Not Reserved");
            return;
        }

        bool checkReseverd()
        {
            string[] row = { "A", "B", "C", "D" };
            string[] column = { "1", "2", "3", "4", "5", "6" };

            foreach (string r in row)
            {
                foreach (string c in column)
                {
                    var s = seats.FirstOrDefault(x => x.id == (r + c).ToString());
                    if (s == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        
    }
}
