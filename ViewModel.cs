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
		private Vehicle _selectedVehicle = null;
		private List<Vehicle> _vehicles = new List<Vehicle>()
		{
			new Vehicle("Dodge", "Charger", 8, 400),
			new Vehicle("Ford", "F-150", 8, 350),
			new Vehicle("Honda", "Fit", 4, 120)
		};

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

		public List<Vehicle> AllVehicles
		{
			get => _vehicles;
			set
			{
				_vehicles = value;
				OnPropertyChanged();
			}
		}
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
		public Vehicle SelectedVehicle
		{
			get => _selectedVehicle;
			set
			{
				_selectedVehicle = value;
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