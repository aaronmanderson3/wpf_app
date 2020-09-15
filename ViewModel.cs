using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace WpfApp1
{
	public class ViewModel : INotifyPropertyChanged
	{

		#region Fields

		private bool _checked = false;
		private string _message;
		private int _outNumber = 0;

		#endregion Fields

		#region Constructors

		public ViewModel(string message)
		{
			_message = message;
		}

		public ViewModel()
		{
			_message = "Default message";
		}

		#endregion Constructors

		#region Events

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion Events

		#region Properties

		public bool Checked
		{
			get => _checked;
			set
			{
				_checked = value;
				OnPropertyChanged();
			}
		}
		public String Message
		{
			get => _message;
			set
			{
				_message = value;
				OnPropertyChanged();
			}
		}
		public int OutNumber
		{
			get => _outNumber;
			set
			{
				_outNumber = value;
				OnPropertyChanged();
			}
		}

		#endregion Properties

		#region Methods

		protected void OnPropertyChanged([CallerMemberName] string propertySource = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertySource));
		}

		#endregion Methods

	}
}