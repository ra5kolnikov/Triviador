using System;
using System.ComponentModel;
using Triviador.Models;

namespace Triviador.ViewModels
{
	public class LobbyViewModel : INotifyPropertyChanged
    {
        private Player _currentPlayer;

        public Player CurrentPlayer
        {
            get { return _currentPlayer; }
            set
            {
                if (_currentPlayer != value)
                {
                    _currentPlayer = value;
                    OnPropertyChanged("CurrentPlayer");
                }
            }
        }

        public LobbyViewModel()
        {
            CurrentPlayer = new Player();
        }

        public void UpdatePlayer(Player player)
        {
            CurrentPlayer = player;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

