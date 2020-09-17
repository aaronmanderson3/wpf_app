using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	public class Vehicle : INotifyPropertyChanged
	{

		#region Fields

		private int _cylinders;
		private int _horsepower;
		private string _make;
		private string _model;

		#endregion Fields

		#region Constructors

		public Vehicle(string make, string model, int cylinders, int horsepower)
		{
			_make = make;
			_model = model;
			_cylinders = cylinders;
			_horsepower = horsepower;
		}

		#endregion Constructors

		#region Events

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion Events

		#region Properties

		public int Cylinders
		{
			get => _cylinders;
			set
			{
				_cylinders = value;
				OnPropertyChanged();
			}
		}
		public int Horsepower
		{
			get => _horsepower;
			set
			{
				_horsepower = value;
				OnPropertyChanged();
			}
		}
		public string Make
		{
			get => _make;
			set
			{
				_make = value;
				OnPropertyChanged();
			}
		}
		public string Model
		{
			get => _model;
			set
			{
				_model = value;
				OnPropertyChanged();
			}
		}

		#endregion Properties

		#region Methods

		public override string ToString()
		{
			return $"{Make} {Model} with {Cylinders} cylinders and {Horsepower}HP";
		}
		protected void OnPropertyChanged([CallerMemberName] string propertySource = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertySource));
		}

		#endregion Methods
	}
}