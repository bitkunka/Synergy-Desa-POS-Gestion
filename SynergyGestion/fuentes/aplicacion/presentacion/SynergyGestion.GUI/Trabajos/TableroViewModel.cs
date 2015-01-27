namespace SynergyGestion.GUI.Trabajos
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Caliburn.Micro;

    #endregion

    public class TableroViewModel: Screen
    {
        private string title;
        private string legendTitle;
        private BindableCollection<KeyValuePair<string, int>> _data;

        #region Ctor

        public TableroViewModel()
        {
            this.init();
            this.title = "Estado de Stock";
            this.LegendTitle = "Movimientos";
        }

        #endregion

        #region Propiedades

        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.title = value;
                this.NotifyOfPropertyChange(() => this.title);
            }
        }

        public string LegendTitle
        {
            get
            {
                return this.legendTitle;
            }

            set
            {
                this.legendTitle = value;
                this.NotifyOfPropertyChange(() => this.legendTitle);
            }
        }

        public BindableCollection<KeyValuePair<string, int>> data
        {
            get { return _data; }
        }

        #endregion

        #region Metodos

        public void init()
        {
            _data = new BindableCollection<KeyValuePair<string, int>>();

            data.Add(new KeyValuePair<string, int>("Dog", 30));
            data.Add(new KeyValuePair<string, int>("Cat", 25));
            data.Add(new KeyValuePair<string, int>("Rat", 5));
            data.Add(new KeyValuePair<string, int>("Hampster", 8));
            data.Add(new KeyValuePair<string, int>("Rabbit", 12));
        }

        #endregion
    }
}
