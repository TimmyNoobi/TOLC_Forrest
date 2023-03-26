using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using Windows.Devices.Power;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ComponentModel;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Core;
using Windows.UI;
using System.IO.Ports;
using Windows.Devices.SerialCommunication;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;
using System.Threading;
using Windows.UI.Text;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml.Documents;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TOLC_Forrest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region color & brush
        public SolidColorBrush Transparent_brush = new SolidColorBrush(Color.FromArgb((byte)0, (byte)0, (byte)0, (byte)0));
        public SolidColorBrush white_button_brush = new SolidColorBrush(Color.FromArgb((byte)255, (byte)250, (byte)250, (byte)250));
        public SolidColorBrush Default_back_black_color_brush = new SolidColorBrush(Color.FromArgb((byte)255, (byte)32, (byte)32, (byte)32));
        public SolidColorBrush dark_grey_brush = new SolidColorBrush(Color.FromArgb((byte)150, (byte)169, (byte)169, (byte)169));
        public SolidColorBrush Sky_red_color = new SolidColorBrush(Color.FromArgb((byte)255, (byte)255, (byte)170, (byte)170));
        public SolidColorBrush green_bright_brush = new SolidColorBrush(Color.FromArgb((byte)255, (byte)10, (byte)250, (byte)10));
        public SolidColorBrush red_bright_brush = new SolidColorBrush(Color.FromArgb((byte)255, (byte)230, (byte)10, (byte)10));
        public SolidColorBrush Teal_color = new SolidColorBrush(Color.FromArgb((byte)250, (byte)0, (byte)139, (byte)139));
        public SolidColorBrush Orange_color = new SolidColorBrush(Color.FromArgb((byte)250, (byte)250, (byte)140, (byte)0));
        public SolidColorBrush Purple_color = new SolidColorBrush(Color.FromArgb((byte)250, (byte)138, (byte)43, (byte)226));
        public SolidColorBrush Light_blue_color = new SolidColorBrush(Color.FromArgb((byte)250, (byte)135, (byte)206, (byte)250));



        public SolidColorBrush W_Orange_1 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)240, (byte)248, (byte)255));
        public SolidColorBrush W_Orange_2 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)250, (byte)235, (byte)215));
        public SolidColorBrush W_Orange_3 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)222, (byte)184, (byte)135));
        public SolidColorBrush W_Orange_4 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)215, (byte)0));
        public SolidColorBrush W_Orange_5 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)165, (byte)0));
        public SolidColorBrush W_Orange_6 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)120, (byte)0));
        public SolidColorBrush W_Orange_7 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)60, (byte)0));
        public SolidColorBrush W_Orange_8 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)139, (byte)69, (byte)15));
        public SolidColorBrush W_Orange_9 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)128, (byte)0, (byte)0));

        public SolidColorBrush W_Blue_1 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)0, (byte)255, (byte)255));
        public SolidColorBrush W_Blue_2 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)135, (byte)206, (byte)250));
        public SolidColorBrush W_Blue_3 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)0, (byte)206, (byte)209));
        public SolidColorBrush W_Blue_4 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)30, (byte)144, (byte)255));
        public SolidColorBrush W_Blue_5 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)60, (byte)105, (byte)225));
        public SolidColorBrush W_Blue_6 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)0, (byte)0, (byte)139));

        public SolidColorBrush W_Green_1 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)127, (byte)255, (byte)212));
        public SolidColorBrush W_Green_2 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)173, (byte)255, (byte)47));
        public SolidColorBrush W_Green_3 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)144, (byte)238, (byte)144));
        public SolidColorBrush W_Green_4 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)0, (byte)255, (byte)0));
        public SolidColorBrush W_Green_5 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)50, (byte)205, (byte)50));
        public SolidColorBrush W_Green_6 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)0, (byte)128, (byte)0));
        public SolidColorBrush W_Green_7 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)46, (byte)139, (byte)87));
        public SolidColorBrush W_Green_8 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)40, (byte)79, (byte)79));

        public SolidColorBrush W_Red_1 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)182, (byte)193));
        public SolidColorBrush W_Red_2 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)238, (byte)130, (byte)238));
        public SolidColorBrush W_Red_3 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)105, (byte)180));
        public SolidColorBrush W_Red_4 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)0, (byte)255));
        public SolidColorBrush W_Red_5 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)199, (byte)21, (byte)112));
        public SolidColorBrush W_Red_6 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)255, (byte)0, (byte)0));
        public SolidColorBrush W_Red_7 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)220, (byte)20, (byte)60));
        public SolidColorBrush W_Red_8 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)75, (byte)0, (byte)130));
        public SolidColorBrush W_Red_9 = new SolidColorBrush(Color.FromArgb((byte)250, (byte)139, (byte)0, (byte)0));


        #endregion
        public MainPage()
        {
            this.InitializeComponent();
        }
        private Random rnd = new Random();


        private List<bool> sendFlag = new List<bool>();

        private TextBlock com_tb = new TextBlock();
        private List<Button> forrest_bt = new List<Button>();
        private Dictionary<Button, int> dic_bt_int = new Dictionary<Button, int>();
        private List<Image> forrest_i = new List<Image>();
        private List<Image> bear_i = new List<Image>();

        private Image tree1_i = new Image();
        private Image bear1_i = new Image();


        #region stage 1
        private Border stage1BG_bd = new Border();
        private Image stage1BG_bdi = new Image();

        private Border s1Titlef_bd = new Border();
        private Border s1Title1_bd = new Border();
        private Image s1Title1_bdi = new Image();
        private Border s1Title2_bd = new Border();
        private Border s1Title2_ibd = new Border();
        private Image s1Title2_bdi = new Image();
        private Image s1Title2_ibdi = new Image();

        private TextBox playerName_tb = new TextBox();
        private Button playGame_bt = new Button();
        private MediaPlayerElement stage1_me = new MediaPlayerElement();
        MediaElement PlayMusic;
        private string playerName = "";
        #endregion

        #region stage 2
        private Button run_bt = new Button();
        private Image run_i = new Image();
        private Image stop_i = new Image();

        private TextBlock timer_tb = new TextBlock();
        private TextBlock timerResult_tb = new TextBlock();

        private Border stage2BG_bd = new Border();
        private Image stage2BG_bdi = new Image();
        private Border s2f_bd = new Border();
        private Border s2bear_ibd = new Border();
        private Image s2bear_ibdi = new Image();
        private List<Border> bearFootprint_bd = new List<Border>();
        private List<Image> bearFootprint_bdi = new List<Image>();
        private Border s2_runbear_bd = new Border();
        private Image s2_runbear_bdi = new Image();

        private Border s2_church_bd = new Border();
        private Image s2_church_bdi = new Image();

        private List<Border> fruit_bd = new List<Border>();
        private List<Image> fruit_bdi = new List<Image>();

        private Button s2_god_bt = new Button();
        private Image s2_god_bti = new Image();

        private Button add_fruit_bt = new Button();
        private Image add_fruit_bti = new Image();
        private Button min_fruit_bt = new Button();

        #region stage 3
        private TextBlock treasure_tb = new TextBlock();
        private Border stage3BG_bd = new Border();
        private Image stage3BG_bdi = new Image();

        private Button home_bt = new Button();
        private Image home_bti = new Image();
        #endregion

        MediaElement PM_321;
        MediaElement PM_run1;
        MediaElement PM_run2;
        MediaElement PM_run3;
        MediaElement PM_amazing;
        MediaElement PM_win;
        MediaElement PM_cheer;
        private int numFoortprint = 18;
        #endregion
        private int numFruit = 1;
        #region stage 1 control
        private void stage1Setup()
        {

            playGame_bt = new Button()
            {
                Background = Default_back_black_color_brush,
                FontSize = 24,
                FontFamily = new FontFamily("Comic Sans MS"),
                Content = "Time to RUN!!!",
                Foreground = red_bright_brush,
                BorderBrush = Light_blue_color,
                CornerRadius = new CornerRadius(8,8,8,8),
                BorderThickness = new Thickness(5,5,5,5),
                FontWeight = FontWeights.ExtraBold
            };
            playGame_bt.SetValue(Grid.ColumnProperty, 115);
            playGame_bt.SetValue(Grid.ColumnSpanProperty, 40);
            playGame_bt.SetValue(Grid.RowProperty, 90);
            playGame_bt.SetValue(Grid.RowSpanProperty, 10);
            playGame_bt.Click += PlayGame_bt_Click;
            Canvas.SetZIndex(playGame_bt, 4);
            MainGrid.Children.Add(playGame_bt);


            playerName_tb = new TextBox() { 
                Background = Default_back_black_color_brush,
                Foreground = white_button_brush,
                FontSize = 24,
                FontFamily = new FontFamily("Caveat"),
                Text = "Bear",
                FontWeight = FontWeights.ExtraBold
            };

            playerName_tb.SetValue(Grid.ColumnProperty, 60);
            playerName_tb.SetValue(Grid.ColumnSpanProperty, 50);
            playerName_tb.SetValue(Grid.RowProperty, 90);
            playerName_tb.SetValue(Grid.RowSpanProperty, 10);
            Canvas.SetZIndex(playerName_tb, 4);
            MainGrid.Children.Add(playerName_tb);

            s1Title2_ibdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bearRun.gif", UriKind.RelativeOrAbsolute))
            };
            s1Title2_ibd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                CornerRadius = new CornerRadius(10, 10, 10, 10)
            };

            s1Title2_ibd.Child = s1Title2_ibdi;
            s1Title2_ibd.SetValue(Grid.ColumnProperty, 60);
            s1Title2_ibd.SetValue(Grid.ColumnSpanProperty, 20);
            s1Title2_ibd.SetValue(Grid.RowProperty, 60);
            s1Title2_ibd.SetValue(Grid.RowSpanProperty, 20);
            Canvas.SetZIndex(s1Title2_ibd, 4);
            MainGrid.Children.Add(s1Title2_ibd);





            s1Title1_bd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                CornerRadius = new CornerRadius(10,10,10,10)
            };
            s1Title1_bdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/titleIcon1.png", UriKind.RelativeOrAbsolute))
            };
            s1Title1_bd.Child = s1Title1_bdi;
            s1Title1_bd.SetValue(Grid.ColumnProperty, 60);
            s1Title1_bd.SetValue(Grid.ColumnSpanProperty, 80);
            s1Title1_bd.SetValue(Grid.RowProperty, 20);
            s1Title1_bd.SetValue(Grid.RowSpanProperty, 40);
            Canvas.SetZIndex(s1Title1_bd, 4);
            MainGrid.Children.Add(s1Title1_bd);

            
            s1Title2_bd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                CornerRadius = new CornerRadius(10, 10, 10, 10)
            };
            s1Title2_bdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/titleIcon2.png", UriKind.RelativeOrAbsolute))
            };
            s1Title2_bd.Child = s1Title2_bdi;
            s1Title2_bd.SetValue(Grid.ColumnProperty, 80);
            s1Title2_bd.SetValue(Grid.ColumnSpanProperty, 40);
            s1Title2_bd.SetValue(Grid.RowProperty, 60);
            s1Title2_bd.SetValue(Grid.RowSpanProperty, 20);
            Canvas.SetZIndex(s1Title2_bd, 4);
            MainGrid.Children.Add(s1Title2_bd);

            s1Titlef_bd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                BorderBrush = Light_blue_color,
                BorderThickness = new Thickness(7, 7, 7, 7),
                CornerRadius = new CornerRadius(10, 10, 10, 10)
            };

            s1Titlef_bd.SetValue(Grid.ColumnProperty, 50);
            s1Titlef_bd.SetValue(Grid.ColumnSpanProperty, 100);
            s1Titlef_bd.SetValue(Grid.RowProperty, 15);
            s1Titlef_bd.SetValue(Grid.RowSpanProperty, 100);
            Canvas.SetZIndex(s1Titlef_bd, 3);
            MainGrid.Children.Add(s1Titlef_bd);



            stage1BG_bd = new Border() { 
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                
                VerticalAlignment = VerticalAlignment.Stretch
            };
            stage1BG_bdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment= VerticalAlignment.Stretch,
                Stretch = Stretch.UniformToFill,
                Source = new BitmapImage(new Uri("ms-appx://HA_SoftwarePlatform_GUI/Assets/ForrestBG2.jpg", UriKind.RelativeOrAbsolute))
            };
            
            stage1BG_bd.Child = stage1BG_bdi;
            stage1BG_bd.SetValue(Grid.ColumnProperty, 0);
            stage1BG_bd.SetValue(Grid.ColumnSpanProperty, 200);
            stage1BG_bd.SetValue(Grid.RowProperty, 0);
            stage1BG_bd.SetValue(Grid.RowSpanProperty, 150);
            MainGrid.Children.Add(stage1BG_bd);
            PlayMusic = new MediaElement()
            {
                IsLooping = true,
                Volume = 100,
                AutoPlay = true,

            };
            MainGrid.Children.Add(PlayMusic);
            PlayMusic.Source = new Uri("ms-appx://TOLC_Forrest/Assets/rainforestSong.mp3");
            resetStage2();
        }

        private void PlayGame_bt_Click(object sender, RoutedEventArgs e)
        {
            hideAll();
            showStage2();
            playerName = playerName_tb.Text;
        }

        private void stage1PlayMusic()
        {

            PlayMusic.Play();
        }
        private void stage1StopMusic()
        {
            PlayMusic.Stop();
        }
        #endregion
        #region stage 2 control
        private void stage2Setup()
        {
            add_fruit_bti = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/grapeIcon.png", UriKind.RelativeOrAbsolute))
            };
            add_fruit_bt = new Button()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                Content = add_fruit_bti,
                Background = Default_back_black_color_brush
            };
            add_fruit_bt.SetValue(Grid.ColumnProperty, 165);
            add_fruit_bt.SetValue(Grid.ColumnSpanProperty, 20);
            add_fruit_bt.SetValue(Grid.RowProperty, 20);
            add_fruit_bt.SetValue(Grid.RowSpanProperty, 20);
            Canvas.SetZIndex(add_fruit_bt, 6);
            add_fruit_bt.Click += Add_fruit_bt_Click;
            MainGrid.Children.Add(add_fruit_bt);


            s2_god_bti = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/godIcon.jpg", UriKind.RelativeOrAbsolute))
            };
            s2_god_bt = new Button()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                CornerRadius = new CornerRadius(10, 10, 10, 10)
            };

            s2_god_bt.Content = s2_god_bti;
            s2_god_bt.SetValue(Grid.ColumnProperty, 165);
            s2_god_bt.SetValue(Grid.ColumnSpanProperty, 20);
            s2_god_bt.SetValue(Grid.RowProperty, 70);
            s2_god_bt.SetValue(Grid.RowSpanProperty, 20);
            s2_god_bt.Click += S2_god_bt_Click;
            Canvas.SetZIndex(s2_god_bt, 10);
            MainGrid.Children.Add(s2_god_bt);

            s2_church_bdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/churchLogo.jpg", UriKind.RelativeOrAbsolute))
            };
            s2_church_bd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                CornerRadius = new CornerRadius(10, 10, 10, 10)
            };

            s2_church_bd.Child = s2_church_bdi;
            s2_church_bd.SetValue(Grid.ColumnProperty, 17);
            s2_church_bd.SetValue(Grid.ColumnSpanProperty, 25);
            s2_church_bd.SetValue(Grid.RowProperty, 90);
            s2_church_bd.SetValue(Grid.RowSpanProperty, 25);

            Canvas.SetZIndex(s2_church_bd, 6);
            MainGrid.Children.Add(s2_church_bd);







            s2bear_ibdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bearRun.gif", UriKind.RelativeOrAbsolute))
            };
            s2bear_ibd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                CornerRadius = new CornerRadius(10, 10, 10, 10)
            };

            s2bear_ibd.Child = s2bear_ibdi;
            s2bear_ibd.SetValue(Grid.ColumnProperty, 40);
            s2bear_ibd.SetValue(Grid.ColumnSpanProperty, 15);
            s2bear_ibd.SetValue(Grid.RowProperty, 90);
            s2bear_ibd.SetValue(Grid.RowSpanProperty, 20);
            Canvas.SetZIndex(s2bear_ibd, 6);
            MainGrid.Children.Add(s2bear_ibd);

            for (int idx = 0; idx < numFoortprint; idx++)
            {
                bearFootprint_bdi.Add(new Image()
                {
                    Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bearFootprint_Icon.jpg", UriKind.RelativeOrAbsolute))
                });
                bearFootprint_bd.Add(new Border()
                {
                    Background = Default_back_black_color_brush,
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch
                });

                bearFootprint_bd[bearFootprint_bd.Count - 1].Child = bearFootprint_bdi[bearFootprint_bdi.Count - 1];
                bearFootprint_bd[bearFootprint_bd.Count - 1].SetValue(Grid.ColumnProperty, 40 + 7 * idx);
                bearFootprint_bd[bearFootprint_bd.Count - 1].SetValue(Grid.ColumnSpanProperty, 7);
                bearFootprint_bd[bearFootprint_bd.Count - 1].SetValue(Grid.RowProperty, 100);
                bearFootprint_bd[bearFootprint_bd.Count - 1].SetValue(Grid.RowSpanProperty, 10);
                MainGrid.Children.Add(bearFootprint_bd[bearFootprint_bd.Count - 1]);
                Canvas.SetZIndex(bearFootprint_bd[bearFootprint_bd.Count - 1], 5);
                bearFootprint_bd[bearFootprint_bd.Count - 1].Visibility = Visibility.Collapsed;
            }





            run_i = new Image()
            {
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/run_icon.png", UriKind.RelativeOrAbsolute))
            };
            stop_i = new Image()
            {
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/goal_icon.png", UriKind.RelativeOrAbsolute))
            };


            stage2BG_bdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Stretch = Stretch.UniformToFill,
                Source = new BitmapImage(new Uri("ms-appx://HA_SoftwarePlatform_GUI/Assets/ForrestBG2.jpg", UriKind.RelativeOrAbsolute))
            };
            stage2BG_bd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,

                VerticalAlignment = VerticalAlignment.Stretch
            };
            stage2BG_bd.Child = stage2BG_bdi;
            stage2BG_bd.SetValue(Grid.ColumnProperty, 0);
            stage2BG_bd.SetValue(Grid.ColumnSpanProperty, 200);
            stage2BG_bd.SetValue(Grid.RowProperty, 0);
            stage2BG_bd.SetValue(Grid.RowSpanProperty, 150);
            MainGrid.Children.Add(stage2BG_bd);

            s2f_bd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                BorderBrush = Light_blue_color,
                BorderThickness = new Thickness(7, 7, 7, 7),
                CornerRadius = new CornerRadius(10, 10, 10, 10)
            };

            s2f_bd.SetValue(Grid.ColumnProperty, 15);
            s2f_bd.SetValue(Grid.ColumnSpanProperty, 175);
            s2f_bd.SetValue(Grid.RowProperty, 15);
            s2f_bd.SetValue(Grid.RowSpanProperty, 120);
            Canvas.SetZIndex(s2f_bd, 3);
            MainGrid.Children.Add(s2f_bd);



            timer_tb = new TextBlock()
            {
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                TextAlignment = TextAlignment.Center,
                FontFamily = new FontFamily("Comic Sans MS"),
                Text = "0:00",
                FontSize = 120,
                Foreground = white_button_brush,
                FontWeight = FontWeights.ExtraBold,

            };
            timer_tb.SetValue(Grid.ColumnProperty, 35);
            timer_tb.SetValue(Grid.ColumnSpanProperty, 130);
            timer_tb.SetValue(Grid.RowProperty, 30);
            timer_tb.SetValue(Grid.RowSpanProperty, 35);
            Canvas.SetZIndex(timer_tb, 4);
            MainGrid.Children.Add(timer_tb);

            timerResult_tb = new TextBlock()
            {
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                TextAlignment = TextAlignment.Center,
                FontFamily = new FontFamily("Comic Sans MS"),
                Text = "",
                FontSize = 40,
                Foreground = white_button_brush,
                FontWeight = FontWeights.ExtraBold,

            };
            timerResult_tb.SetValue(Grid.ColumnProperty, 35);
            timerResult_tb.SetValue(Grid.ColumnSpanProperty, 130);
            timerResult_tb.SetValue(Grid.RowProperty, 30);
            timerResult_tb.SetValue(Grid.RowSpanProperty, 35);
            Canvas.SetZIndex(timerResult_tb, 10);
            MainGrid.Children.Add(timerResult_tb);

            run_bt = new Button()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalContentAlignment = HorizontalAlignment.Stretch,
                VerticalContentAlignment = VerticalAlignment.Center,
                Content = run_i,
                Background = Default_back_black_color_brush
            };
            run_bt.SetValue(Grid.ColumnProperty, 20);
            run_bt.SetValue(Grid.ColumnSpanProperty, 20);
            run_bt.SetValue(Grid.RowProperty, 20);
            run_bt.SetValue(Grid.RowSpanProperty, 20);
            Canvas.SetZIndex(run_bt, 4);
            run_bt.Click += Run_bt_Click;
            MainGrid.Children.Add(run_bt);

            PM_321 = new MediaElement()
            {
                IsLooping = false,
                Volume = 0.5,
                AutoPlay = false

            };
            MainGrid.Children.Add(PM_321);
            PM_321.Source = new Uri("ms-appx://TOLC_Forrest/Assets/countdown1.mp3");
            PM_321.Stop();


            
            PM_run1 = new MediaElement()
            {
                IsLooping = false,
                Volume = 0.5,
                AutoPlay = false

            };
            MainGrid.Children.Add(PM_run1);
            PM_run1.Source = new Uri("ms-appx://TOLC_Forrest/Assets/run1Sound.mp3");
            PM_run1.Stop();


            PM_win = new MediaElement()
            {
                IsLooping = false,
                Volume = 1,
                AutoPlay = false

            };
            MainGrid.Children.Add(PM_win);
            PM_win.Source = new Uri("ms-appx://TOLC_Forrest/Assets/buzz.mp3");
            PM_win.Stop();

            PM_cheer = new MediaElement()
            {
                IsLooping = false,
                Volume = 1,
                AutoPlay = false

            };
            MainGrid.Children.Add(PM_cheer);
            PM_cheer.Source = new Uri("ms-appx://TOLC_Forrest/Assets/cheerSong.mp3");
            PM_cheer.Stop();
        }

        private void S2_god_bt_Click(object sender, RoutedEventArgs e)
        {
            hideAll();
            showStage3();
            PM_amazing.Play();
        }

        private async void Add_fruit_bt_Click(object sender, RoutedEventArgs e)
        {
            numFruit++;

            fruit_bdi.Add(new Image()
            {
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/grapeIcon.png", UriKind.RelativeOrAbsolute))
            });
            fruit_bd.Add(new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            });

            fruit_bd[fruit_bd.Count - 1].Child = fruit_bdi[fruit_bdi.Count - 1];
            fruit_bd[fruit_bd.Count - 1].SetValue(Grid.ColumnProperty, 40 + (numFoortprint - (int)nowIdx) * 7);
            fruit_bd[fruit_bd.Count - 1].SetValue(Grid.ColumnSpanProperty, 15);
            fruit_bd[fruit_bd.Count - 1].SetValue(Grid.RowProperty, 70);
            fruit_bd[fruit_bd.Count - 1].SetValue(Grid.RowSpanProperty, 20);
            MainGrid.Children.Add(fruit_bd[fruit_bd.Count - 1]);
            Canvas.SetZIndex(fruit_bd[fruit_bd.Count - 1], 7);
            PM_cheer.Stop();
            await Task.Delay(100);
            PM_cheer.Play();

        }
        #endregion
        private void resetStage2()
        {

        }
        private void hideStage1()
        {

            stage1BG_bd.Visibility = Visibility.Collapsed;
            s1Titlef_bd.Visibility = Visibility.Collapsed;
            s1Title1_bd.Visibility = Visibility.Collapsed;
            s1Title2_bd.Visibility = Visibility.Collapsed;
            s1Title2_ibd.Visibility = Visibility.Collapsed;
            playerName_tb.Visibility = Visibility.Collapsed;
            playGame_bt.Visibility = Visibility.Collapsed;
        }
        private void showStage1()
        {

            stage1BG_bd.Visibility = Visibility.Visible;
            s1Titlef_bd.Visibility = Visibility.Visible;
            s1Title1_bd.Visibility = Visibility.Visible;
            s1Title2_bd.Visibility = Visibility.Visible;
            s1Title2_ibd.Visibility = Visibility.Visible;
            playerName_tb.Visibility = Visibility.Visible;
            playGame_bt.Visibility = Visibility.Visible;
        }
        private void hideStage2()
        {

            for (int idx = 0; idx < fruit_bd.Count; idx++)
            {
                MainGrid.Children.Remove(fruit_bd[idx]);
            }
            fruit_bd = new List<Border>();
            for (int idx = 0; idx < bearFootprint_bd.Count; idx++)
            {
                bearFootprint_bd[idx].Visibility = Visibility.Collapsed;
            }
            min_fruit_bt.Visibility = Visibility.Collapsed;
            add_fruit_bt.Visibility = Visibility.Collapsed;
            stage2BG_bd.Visibility = Visibility.Collapsed;
            s2f_bd.Visibility= Visibility.Collapsed;
            s2bear_ibd.Visibility = Visibility.Collapsed;
            s2_runbear_bd.Visibility = Visibility.Collapsed;
            s2_god_bt.Visibility = Visibility.Collapsed;
            s2_church_bd.Visibility = Visibility.Collapsed;
            run_bt.Visibility = Visibility.Collapsed;
            timer_tb.Visibility = Visibility.Collapsed;
            timerResult_tb.Visibility = Visibility.Collapsed;
            run_bt.Content = run_i;
            timer_tb.Text = "0:00";
            timer_tb.Foreground = white_button_brush;
            s2bear_ibd.SetValue(Grid.ColumnProperty, 40);
            s2bear_ibd.SetValue(Grid.ColumnSpanProperty, 15);
            s2bear_ibd.SetValue(Grid.RowProperty, 90);
            s2bear_ibd.SetValue(Grid.RowSpanProperty, 20);
        }
        private void showStage2()
        {
            min_fruit_bt.Visibility = Visibility.Visible;
            add_fruit_bt.Visibility = Visibility.Visible;
            stage2BG_bd.Visibility = Visibility.Visible;
            s2f_bd.Visibility = Visibility.Visible;
            s2bear_ibd.Visibility = Visibility.Visible;
            s2_runbear_bd.Visibility = Visibility.Visible;
            s2_god_bt.Visibility = Visibility.Visible;
            s2_church_bd.Visibility = Visibility.Visible;
            run_bt.Visibility = Visibility.Visible;
            timer_tb.Visibility = Visibility.Visible;
        }

        private void stage3Setup()
        {
            stage3BG_bd = new Border()
            {
                Background = Default_back_black_color_brush,
                HorizontalAlignment = HorizontalAlignment.Stretch,

                VerticalAlignment = VerticalAlignment.Stretch
            };
            stage3BG_bdi = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Stretch = Stretch.UniformToFill,
                Source = new BitmapImage(new Uri("ms-appx://HA_SoftwarePlatform_GUI/Assets/heaven.jpg", UriKind.RelativeOrAbsolute))
            };

            stage3BG_bd.Child = stage3BG_bdi;
            stage3BG_bd.SetValue(Grid.ColumnProperty, 0);
            stage3BG_bd.SetValue(Grid.ColumnSpanProperty, 200);
            stage3BG_bd.SetValue(Grid.RowProperty, 0);
            stage3BG_bd.SetValue(Grid.RowSpanProperty, 150);
            MainGrid.Children.Add(stage3BG_bd);

            home_bti = new Image()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/churchLogo.jpg", UriKind.RelativeOrAbsolute))
            };
            home_bt = new Button()
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
                CornerRadius = new CornerRadius(15,15,15,15),
                BorderBrush = dark_grey_brush,
                BorderThickness = new Thickness(4,4,4,4),
                Content = home_bti,
                Background = Default_back_black_color_brush
            };
            home_bt.SetValue(Grid.ColumnProperty, 175);
            home_bt.SetValue(Grid.ColumnSpanProperty, 20);
            home_bt.SetValue(Grid.RowProperty, 5);
            home_bt.SetValue(Grid.RowSpanProperty, 20);
            Canvas.SetZIndex(home_bt, 6);
            home_bt.Click += Home_bt_Click;
            MainGrid.Children.Add(home_bt);


            PM_amazing = new MediaElement()
            {
                IsLooping = true,
                Volume = 60,
                AutoPlay = false

            };
            MainGrid.Children.Add(PM_amazing);
            PM_amazing.Source = new Uri("ms-appx://TOLC_Forrest/Assets/amazing.mp3");
            PM_amazing.Stop();
            treasure_tb = new TextBlock()
            {
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                TextAlignment = TextAlignment.Center,
                FontFamily = new FontFamily("Comic Sans MS"),
                Text = "Treasures In Heaven",
                FontSize = 60,
                Foreground = Orange_color,
                FontWeight = FontWeights.ExtraBold,

            };
            treasure_tb.SetValue(Grid.ColumnProperty, 25);
            treasure_tb.SetValue(Grid.ColumnSpanProperty, 130);
            treasure_tb.SetValue(Grid.RowProperty, 5);
            treasure_tb.SetValue(Grid.RowSpanProperty, 20);
            Canvas.SetZIndex(treasure_tb, 4);
            MainGrid.Children.Add(treasure_tb);
            
            for (int idx = 0; idx < 4; idx++)
            {
                forrest_i.Add(new Image()
                {
                    Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/Tree1.png", UriKind.RelativeOrAbsolute))
                });
                if (idx <= 1)
                {
                    bear_i.Add(new Image()
                    {
                        Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/Bear1.png", UriKind.RelativeOrAbsolute))
                    });
                }else
                {
                    bear_i.Add(new Image()
                    {
                        Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bear2.jpg", UriKind.RelativeOrAbsolute))
                    });
                }


                forrest_bt.Add(new Button()
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    HorizontalContentAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    Content = forrest_i[forrest_i.Count - 1],
                    Background = Default_back_black_color_brush,
                    BorderThickness = new Thickness(3, 3, 3, 3),
                    BorderBrush = green_bright_brush
                });
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.ColumnProperty, 20 + 40 * idx);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.ColumnSpanProperty, 25);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.RowProperty, 30);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.RowSpanProperty, 30);
                forrest_bt[forrest_bt.Count - 1].Click += MainPage_Click;
                MainGrid.Children.Add(forrest_bt[forrest_bt.Count - 1]);
                dic_bt_int[forrest_bt[forrest_bt.Count - 1]] = forrest_bt.Count - 1;
                sendFlag.Add(false);
            }
            for (int idx = 0; idx < 4; idx++)
            {
                forrest_i.Add(new Image()
                {
                    Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/Tree2.png", UriKind.RelativeOrAbsolute))
                });
                if (idx <= 1)
                {
                    bear_i.Add(new Image()
                    {
                        Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bear3.png", UriKind.RelativeOrAbsolute))
                    });
                }
                else
                {
                    bear_i.Add(new Image()
                    {
                        Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bear4.png", UriKind.RelativeOrAbsolute))
                    });
                }


                forrest_bt.Add(new Button()
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    HorizontalContentAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    Content = forrest_i[forrest_i.Count - 1],
                    Background = Default_back_black_color_brush,
                    BorderThickness = new Thickness(3, 3, 3, 3),
                    BorderBrush = green_bright_brush
                });
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.ColumnProperty, 20 + 40 * idx);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.ColumnSpanProperty, 25);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.RowProperty, 70);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.RowSpanProperty, 30);
                forrest_bt[forrest_bt.Count - 1].Click += MainPage_Click;
                MainGrid.Children.Add(forrest_bt[forrest_bt.Count - 1]);
                dic_bt_int[forrest_bt[forrest_bt.Count - 1]] = forrest_bt.Count - 1;
                sendFlag.Add(false);
            }

            for (int idx = 0; idx < 4; idx++)
            {
                forrest_i.Add(new Image()
                {
                    Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/Tree3.png", UriKind.RelativeOrAbsolute))
                });
                if (idx <= 1)
                {
                    bear_i.Add(new Image()
                    {
                        Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bear5.jpg", UriKind.RelativeOrAbsolute))
                    });
                }
                else
                {
                    bear_i.Add(new Image()
                    {
                        Source = new BitmapImage(new Uri("ms-appx://TOLC_Forrest/Assets/bear6.png", UriKind.RelativeOrAbsolute))
                    });
                }

                forrest_bt.Add(new Button()
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    HorizontalContentAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Center,
                    Content = forrest_i[forrest_i.Count - 1],
                    Background = Default_back_black_color_brush,
                    BorderThickness = new Thickness(3, 3, 3, 3),
                    BorderBrush = green_bright_brush
                });
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.ColumnProperty, 20 + 40 * idx);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.ColumnSpanProperty, 25);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.RowProperty, 110);
                forrest_bt[forrest_bt.Count - 1].SetValue(Grid.RowSpanProperty, 30);
                forrest_bt[forrest_bt.Count - 1].Click += MainPage_Click;
                MainGrid.Children.Add(forrest_bt[forrest_bt.Count - 1]);
                dic_bt_int[forrest_bt[forrest_bt.Count - 1]] = forrest_bt.Count - 1;
                sendFlag.Add(false);
            }


            
        }

        private void Home_bt_Click(object sender, RoutedEventArgs e)
        {
            hideAll();
            playerName_tb.Text = "Bear";
            showStage1();
            stage1PlayMusic();
        }

        private void hideStage3()
        {
            for (int idx = 0; idx < forrest_bt.Count; idx++)
            {
                forrest_bt[idx].Visibility = Visibility.Collapsed;
            }
            treasure_tb.Visibility = Visibility.Collapsed;
            stage1BG_bd.Visibility = Visibility.Collapsed;
            home_bt.Visibility = Visibility.Collapsed;
            stage3BG_bd.Visibility = Visibility.Collapsed;
            PM_amazing.Stop();
        }
        private void showStage3()
        {
            treasure_tb.Visibility = Visibility.Visible;
            if (numFruit >= 4)
            {
                for (int idx = 0; idx < forrest_bt.Count; idx++)
                {
                    forrest_bt[idx].Visibility = Visibility.Visible;
                }
            }else if(numFruit >= 3)
            {
                for (int idx = 0; idx < forrest_bt.Count; idx++)
                {
                    forrest_bt[idx].Visibility = Visibility.Visible;
                }
            }
            else if (numFruit >= 1)
            {
                for (int idx = 0; idx < 8; idx++)
                {
                    forrest_bt[idx].Visibility = Visibility.Visible;
                }
            }
            stage1BG_bd.Visibility = Visibility.Visible;
            home_bt.Visibility = Visibility.Visible;
            stage3BG_bd.Visibility = Visibility.Visible;
        }

        private void hideAll()
        {
            hideStage1();
            hideStage2();
            hideStage3();
        }

        DataReader dataReaderObject = null;
        private async void MainPage_loaded(object sender, RoutedEventArgs e)
        {      

            stage1Setup();
            stage2Setup();
            stage3Setup();

            stage1PlayMusic();
            com_tb = new TextBlock() { 
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Text = "Com",
                FontSize = 12,
                Foreground = white_button_brush
            
            };
            com_tb.SetValue(Grid.ColumnProperty, 180);
            com_tb.SetValue(Grid.ColumnSpanProperty, 20);
            com_tb.SetValue(Grid.RowProperty, 0);
            com_tb.SetValue(Grid.RowSpanProperty, 150);
            //MainGrid.Children.Add(com_tb);

            string qFilter = SerialDevice.GetDeviceSelector("COM5");
            DeviceInformationCollection devices = await DeviceInformation.FindAllAsync(qFilter);
            com_tb.Text += "    "  + devices.Count.ToString();
            if (devices.Any())
            {
                string deviceId = devices.First().Id;
                com_tb.Text += "    " + deviceId;
                await OpenPort(deviceId);
            }

            count_down();

            hideAll();
            showStage1();
            //showStage2();
            //showStage3();
        }
        bool runflag = false;
        int raceTime = 31;
        int lastRunIdx = -1;
        double nowIdx = 0;
        private async void count_down()
        {
            bool firstflag = true ;
            string timerstr = "";
            int lastdigit = 0;
            int firstdigit = raceTime;
            timer_tb.Text = firstdigit.ToString() + " : " + lastdigit.ToString();
            while (true)
            {
                if(runflag)
                {
                    if(firstflag)
                    {
                        numFruit = 1;
                        timer_tb.Visibility = Visibility.Visible;
                        timerResult_tb.Visibility = Visibility.Collapsed;
                        nowIdx = 0;
                        await C321();
                        lastdigit = 0;
                        firstdigit = raceTime;
                        firstflag = false;
                        lastRunIdx = -1;
                        for(int idx = 0; idx < fruit_bd.Count; idx++)
                        {
                            MainGrid.Children.Remove(fruit_bd[idx]);
                        }
                        fruit_bd = new List<Border>();
                        fruit_bdi = new List<Image>();
                    }
                    else
                    {
                        lastdigit--;
                        if(lastdigit <= 0)
                        {
                            lastdigit = 100;
                            firstdigit--;
                        }

                        if(firstdigit > 20)
                        {
                            timer_tb.Foreground = green_bright_brush;
                        }else if(firstdigit > 10)
                        {
                            timer_tb.Foreground = Orange_color;
                        }else if(firstdigit > -10)
                        {
                            timer_tb.Foreground = red_bright_brush;
                        }
                        timer_tb.Text = firstdigit.ToString() + " : " + lastdigit.ToString();
                        if (firstdigit <= -1)
                        {
                            lastdigit = 0;
                            firstdigit = 0;
                            runflag = false;
                            stopAllPM();
                            soundFinish();

                            timerResult_tb.Visibility = Visibility.Visible;

                            timerResult_tb.Inlines.Clear();

                            timerResult_tb.Inlines.Add(new Run()
                            {
                                Foreground = Purple_color,
                                Text =" What a Fruitful Journey! \r\n\r\n"
                            });

                            timerResult_tb.Inlines.Add(new Run()
                            {
                                Foreground = white_button_brush,
                                Text = playerName 
                            });

                            timerResult_tb.Inlines.Add(new Run()
                            {
                                Foreground = Light_blue_color,
                                Text =" BEARs "
                            });

                            timerResult_tb.Inlines.Add(new Run()
                            {
                                FontSize = 60,
                                Foreground = red_bright_brush,
                                Text = numFruit.ToString()
                            });

                            timerResult_tb.Inlines.Add(new Run()
                            {
                                Foreground = Orange_color,
                                Text = " Fruit ! ! \r\n"
                            });
                            timer_tb.Visibility = Visibility.Collapsed;
                        }
                        nowIdx = ((double)firstdigit / (double)raceTime) * (double)numFoortprint;

                        if(nowIdx != lastRunIdx)
                        {
                            bearFootprint_bd[bearFootprint_bd.Count - (int)nowIdx - 1].Visibility = Visibility.Visible;
                            s2bear_ibd.SetValue(Grid.ColumnProperty, 40 + (numFoortprint - (int)nowIdx) * 7);
                            s2bear_ibd.SetValue(Grid.ColumnSpanProperty, 15);
                            s2bear_ibd.SetValue(Grid.RowProperty, 90);
                            s2bear_ibd.SetValue(Grid.RowSpanProperty, 20);
                        }

                    }
                }
                else
                {
                    firstflag = true;

                }

                await Task.Delay(10);
            }
        }


        private async void playPM_run1()
        {

            PM_run1.Play();
        }
        private void stopAllPM()
        {
            PM_run1.Stop();
            //PM_run2.Stop();
            //PM_run3.Stop();
        }
        private void soundFinish()
        {
            PM_win.Play();
        }
        private async Task C321()
        {
            PM_321.Play();
            timer_tb.Foreground = Orange_color;
            timer_tb.Text = "3!";
            await Task.Delay(1000);
            timer_tb.Text = "2!";
            await Task.Delay(1000);
            timer_tb.Text = "1!";
            await Task.Delay(1000);
            timer_tb.Text = "GO !!!";
            await Task.Delay(1000);
            PM_321.Stop();
            playPM_run1();
        }
        private void Run_bt_Click(object sender, RoutedEventArgs e)
        {
            Button foo = sender as Button;

            stage1StopMusic();

            if(foo.Content == run_i)
            {
                foo.Content = stop_i;
                runflag = true;
            }
            else
            {
                foo.Content = run_i;
                runflag = false;
            }
        }


        private async void MainPage_Click(object sender, RoutedEventArgs e)
        {
            Button foo = sender as Button;
            int idx = dic_bt_int[foo];

            if(idx < 8)
            {
                for(int treeIdx = 0; treeIdx < 8; treeIdx++)
                {
                    if(idx != treeIdx)
                    {
                        forrest_bt[treeIdx].Visibility = Visibility.Collapsed;
                    }
                }
            }
            else
            {
                for (int treeIdx = 8; treeIdx < forrest_bt.Count; treeIdx++)
                {
                    if (idx != treeIdx)
                    {
                        forrest_bt[treeIdx].Visibility = Visibility.Collapsed;
                    }
                }
            }


            if (foo.Content==bear_i[idx])
            {
                sendFlag[idx] = !sendFlag[idx];
                foo.Content = forrest_i[idx];

                //dataWriter.WriteString("close" + idx.ToString());
                
                
                dataWriter.WriteByte((byte)(idx + 100));
                await dataWriter.StoreAsync();
                
                
                
                //await dataWriter.FlushAsync();
                //hideAll();
                //showStage1();
                numFruit = 1;
                //stage1PlayMusic();
            }
            else
            {
                sendFlag[idx] = !sendFlag[idx];
                foo.Content = bear_i[idx];
                //dataWriter.WriteString("0");
                
                
                dataWriter.WriteByte((byte)(idx));
                await dataWriter.StoreAsync();
                
                
                //await dataWriter.FlushAsync();
            }
        }


        private void MainPage_sizechange(object sender, SizeChangedEventArgs e)
        {

        }
        private SerialDevice serialPort = null;

        DataWriter dataWriter;
        private async Task OpenPort(string deviceId)
        {
            serialPort = await SerialDevice.FromIdAsync(deviceId);
            com_tb.Text += serialPort.PortName.ToString();
            if (serialPort != null)
            {
                serialPort.WriteTimeout = TimeSpan.FromMilliseconds(1000);
                serialPort.ReadTimeout = TimeSpan.FromMilliseconds(1000);
                serialPort.BaudRate = 9600;
                serialPort.Parity = SerialParity.None;
                serialPort.StopBits = SerialStopBitCount.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = SerialHandshake.None;

                com_tb.Text += " \r\n Found Device\r\n";

                dataWriter = new DataWriter(serialPort.OutputStream);
            }
        }
        public async Task ShowDialog(string x, string y)
        {
            TextBlock svt = new TextBlock()
            {
                FontSize = 10,
                Text = y,
                Width = 500,
                Height = 300,
                TextWrapping = TextWrapping.Wrap
            };
            ScrollViewer sv = new ScrollViewer()
            {
                Width = 1000
            };
            sv.Content = svt;
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = x,
                Content = sv,
                CloseButtonText = "Ok"
            };



            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
    }
}
