using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MySpectrumApp.ViewModels
{
    public class ConverterViewModel : INotifyPropertyChanged
    {
        #region Fields and Properties

        BlockChainViewModel option1 = new BlockChainViewModel
        {
            Forename = "Include",
            MiddleName = "USD",
            Surname = "Crypto Currencies",
            IsOver16 = true,
            HasPassedTest = false,
            IsSuspended = false
        };

        BlockChainViewModel option2 = new BlockChainViewModel
        {
            Forename = "Include",
            MiddleName = "GB",
            Surname = "Crypto Currencies",
            IsOver16 = true,
            HasPassedTest = true,
            IsSuspended = false
        };

        BlockChainViewModel option3 = new BlockChainViewModel
        {
            Forename = "Market Cap",
            MiddleName = "Over ",
            Surname = "1 Million",
            IsOver16 = true,
            HasPassedTest = true,
            IsSuspended = false
        };

        BlockChainViewModel option4 = new BlockChainViewModel
        {
            Forename = "Price",
            MiddleName = "Under",
            Surname = "$1.00",
            IsOver16 = false,
            HasPassedTest = true,
            IsSuspended = false
        };

        BlockChainViewModel option5 = new BlockChainViewModel
        {
            Forename = "Include",
            MiddleName = "Rouge",
            Surname = "Exchanges",
            IsOver16 = true,
            HasPassedTest = false,
            IsSuspended = false,
            IsMonarch = true
        };

        public BlockChainViewModel Option1
        {
            get => option1;
            set
            {
                option1 = value;
                OnPropertyChanged();
            }
        }

        public BlockChainViewModel Option2
        {
            get => option2;
            set
            {
                option2 = value;
                OnPropertyChanged();
            }
        }

        public BlockChainViewModel Option3
        {
            get => option3;
            set
            {
                option3 = value;
                OnPropertyChanged();
            }
        }

        public BlockChainViewModel Option4
        {
            get => option4;
            set
            {
                option4 = value;
                OnPropertyChanged();
            }
        }

        public BlockChainViewModel Option5
        {
            get => option5;
            set
            {
                option5 = value;
                OnPropertyChanged();
            }
        }

        public BlockChainViewModel Option6
        {
            get => null;
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
