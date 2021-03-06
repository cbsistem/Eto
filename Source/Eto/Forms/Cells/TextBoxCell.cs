using System;


namespace Eto.Forms
{
	/// <summary>
	/// Cell for a text box in a <see cref="Grid"/>.
	/// </summary>
	[Handler(typeof(IHandler))]
	public class TextBoxCell : SingleValueCell<string>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Eto.Forms.TextBoxCell"/> class binding to the specified <paramref name="column"/>.
		/// </summary>
		/// <param name="column">Column in the data source to get/set the data.</param>
		public TextBoxCell(int column)
		{
			Binding = new ColumnBinding<string>(column);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Eto.Forms.TextBoxCell"/> class binding the text value to the specified <paramref name="property"/> of the data store.
		/// </summary>
		/// <param name="property">Name of the property to bind to in the data store.</param>
		public TextBoxCell(string property)
		{
			Binding = Eto.Forms.Binding.Property<string>(property);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Eto.Forms.TextBoxCell"/> class.
		/// </summary>
		public TextBoxCell()
		{
		}

		/// <summary>
		/// Handler interface for the <see cref="TextBoxCell"/>.
		/// </summary>
		public new interface IHandler : SingleValueCell<string>.IHandler
		{
		}
	}
}

