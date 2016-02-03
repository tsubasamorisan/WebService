﻿using System;
using System.Collections.Generic;
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

using ApplicationWPF.ViewModel;

namespace ApplicationWPF.Frames
{
    /// <summary>
    /// Interaction logic for GestionTournament.xaml
    /// </summary>
    public partial class GestionTournament : Page
    {
        public GestionTournament()
        {
            InitializeComponent();
            //récupération des Jedis
            BusinessLayer.JediTournamentManager j = new BusinessLayer.JediTournamentManager();
            IList<EntitiesLayer.Jedi> jedis = j.getJedis();
            //Initialisation du view Model
            ViewModel.Jedi.JedisModelView jvm = new ViewModel.Jedi.JedisModelView(jedis);


        }

        private void ButtonSoft_Loaded(object sender, RoutedEventArgs e)
        {
            //passage à la page newJedi depuis le boutton Ajouter
            Uri uri = new Uri("Frames/NewJediPagexaml.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
