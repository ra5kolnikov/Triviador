using System;
using System.ComponentModel;

namespace Triviador.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _nickname;
        public int Id { get; set; }
        public int Score { get; set; }
        public string ColorName { get; set; }
        public Player()
        {

        }
        public Player(string name, int score = 0)
        {
            _nickname = name;
            Score = score;
        }
        public Player(int id, string name, string colorName, int score = 0)
        {
            Id = id;
            _nickname = name;
            Score = score;
            ColorName = colorName;
        }
        public string Nickname
        {
            get { return _nickname; }
            set
            {
                if (_nickname != value)
                {
                    _nickname = value;
                    OnPropertyChanged("Nickname");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

