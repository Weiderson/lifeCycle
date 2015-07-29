using GalaSoft.MvvmLight;
using MvvmLifeStyle.Model;

namespace MvvmLifeStyle.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;       
        public const string WelcomeTitlePropertyName = "Seja bem Vindo";
        public const string WelcomeTitlePropertyMensagem1 = "Mensagem";

        private string _mensagem0 = string.Empty;
        private string _mensagem1 = string.Empty;


        public string Mensagem0
        {
            get { return _mensagem0; }

            set {
                if (_mensagem0 == value)
                    {
                        return;
                    }
                    _mensagem0 = value;
                    RaisePropertyChanged(WelcomeTitlePropertyName);
                }
        }

        public string Mensagem1
        {
            get { return _mensagem1; }

            set
            {
                if (_mensagem1 == value)
                {
                    return;
                }
                _mensagem1 = value;
                RaisePropertyChanged(WelcomeTitlePropertyMensagem1);
            }
        }

        
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    _mensagem0 = item.Title;
                    _mensagem1 = item.Title;

                });
        }
       
    }
}