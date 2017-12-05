#region Auto-generated classes for Banking database on 2017-12-04 20:44:21Z

//
//  ____  _     __  __      _        _
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from Banking on 2017-12-04 20:44:21Z
// Please visit http://linq.to/db for more information

#endregion

using System;
using System.Data;
using System.Data.Linq.Mapping;
using System.Diagnostics;
using System.Reflection;
using DbLinq.Data.Linq;
using DbLinq.Vendor;
using System.ComponentModel;

public partial class Banking : DataContext
{
	public Banking(IDbConnection connection)
	: base(connection, new DbLinq.MySql.MySqlVendor())
	{
	}

	public Banking(IDbConnection connection, IVendor vendor)
	: base(connection, vendor)
	{
	}

	public Table<Accounts> Accounts { get { return GetTable<Accounts>(); } }
	public Table<Customers> Customers { get { return GetTable<Customers>(); } }
	public Table<Transactions> Transactions { get { return GetTable<Transactions>(); } }

}

[Table(Name = "Banking.Accounts")]
public partial class Accounts : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region int AccountNo

	private int _accountNo;
	[DebuggerNonUserCode]
	[Column(Storage = "_accountNo", Name = "account_no", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
	public int AccountNo
	{
		get
		{
			return _accountNo;
		}
		set
		{
			if (value != _accountNo)
			{
				_accountNo = value;
				OnPropertyChanged("AccountNo");
			}
		}
	}

	#endregion

	#region string AccountType

	private string _accountType;
	[DebuggerNonUserCode]
	[Column(Storage = "_accountType", Name = "account_type", DbType = "char(1)")]
	public string AccountType
	{
		get
		{
			return _accountType;
		}
		set
		{
			if (value != _accountType)
			{
				_accountType = value;
				OnPropertyChanged("AccountType");
			}
		}
	}

	#endregion

	#region decimal Balance

	private decimal _balance;
	[DebuggerNonUserCode]
	[Column(Storage = "_balance", Name = "balance", DbType = "decimal")]
	public decimal Balance
	{
		get
		{
			return _balance;
		}
		set
		{
			if (value != _balance)
			{
				_balance = value;
				OnPropertyChanged("Balance");
			}
		}
	}

	#endregion

	#region ctor

	public Accounts()
	{
	}

	#endregion

}

[Table(Name = "Banking.Customers")]
public partial class Customers : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region int AccountNo

	private int _accountNo;
	[DebuggerNonUserCode]
	[Column(Storage = "_accountNo", Name = "account_no", DbType = "int")]
	public int AccountNo
	{
		get
		{
			return _accountNo;
		}
		set
		{
			if (value != _accountNo)
			{
				_accountNo = value;
				OnPropertyChanged("AccountNo");
			}
		}
	}

	#endregion

	#region string Address

	private string _address;
	[DebuggerNonUserCode]
	[Column(Storage = "_address", Name = "address", DbType = "varchar(256)")]
	public string Address
	{
		get
		{
			return _address;
		}
		set
		{
			if (value != _address)
			{
				_address = value;
				OnPropertyChanged("Address");
			}
		}
	}

	#endregion

	#region int CustomerID

	private int _customerID;
	[DebuggerNonUserCode]
	[Column(Storage = "_customerID", Name = "customer_id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
	public int CustomerID
	{
		get
		{
			return _customerID;
		}
		set
		{
			if (value != _customerID)
			{
				_customerID = value;
				OnPropertyChanged("CustomerID");
			}
		}
	}

	#endregion

	#region string FirstName

	private string _firstName;
	[DebuggerNonUserCode]
	[Column(Storage = "_firstName", Name = "first_name", DbType = "varchar(100)")]
	public string FirstName
	{
		get
		{
			return _firstName;
		}
		set
		{
			if (value != _firstName)
			{
				_firstName = value;
				OnPropertyChanged("FirstName");
			}
		}
	}

	#endregion

	#region string LastName

	private string _lastName;
	[DebuggerNonUserCode]
	[Column(Storage = "_lastName", Name = "last_name", DbType = "varchar(100)")]
	public string LastName
	{
		get
		{
			return _lastName;
		}
		set
		{
			if (value != _lastName)
			{
				_lastName = value;
				OnPropertyChanged("LastName");
			}
		}
	}

	#endregion

	#region string Password

	private string _password;
	[DebuggerNonUserCode]
	[Column(Storage = "_password", Name = "password", DbType = "varchar(256)")]
	public string Password
	{
		get
		{
			return _password;
		}
		set
		{
			if (value != _password)
			{
				_password = value;
				OnPropertyChanged("Password");
			}
		}
	}

	#endregion

	#region string PhoneNo

	private string _phoneNo;
	[DebuggerNonUserCode]
	[Column(Storage = "_phoneNo", Name = "phone_no", DbType = "char(10)")]
	public string PhoneNo
	{
		get
		{
			return _phoneNo;
		}
		set
		{
			if (value != _phoneNo)
			{
				_phoneNo = value;
				OnPropertyChanged("PhoneNo");
			}
		}
	}

	#endregion

	#region string UserName

	private string _userName;
	[DebuggerNonUserCode]
	[Column(Storage = "_userName", Name = "username", DbType = "varchar(256)")]
	public string UserName
	{
		get
		{
			return _userName;
		}
		set
		{
			if (value != _userName)
			{
				_userName = value;
				OnPropertyChanged("UserName");
			}
		}
	}

	#endregion

	#region ctor

	public Customers()
	{
	}

	#endregion

}

[Table(Name = "Banking.Transactions")]
public partial class Transactions : INotifyPropertyChanged
{
	#region INotifyPropertyChanged handling

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual void OnPropertyChanged(string propertyName)
	{
		if (PropertyChanged != null)
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	#endregion

	#region int AccountNo

	private int _accountNo;
	[DebuggerNonUserCode]
	[Column(Storage = "_accountNo", Name = "account_no", DbType = "int")]
	public int AccountNo
	{
		get
		{
			return _accountNo;
		}
		set
		{
			if (value != _accountNo)
			{
				_accountNo = value;
				OnPropertyChanged("AccountNo");
			}
		}
	}

	#endregion

	#region decimal Amount

	private decimal _amount;
	[DebuggerNonUserCode]
	[Column(Storage = "_amount", Name = "amount", DbType = "decimal")]
	public decimal Amount
	{
		get
		{
			return _amount;
		}
		set
		{
			if (value != _amount)
			{
				_amount = value;
				OnPropertyChanged("Amount");
			}
		}
	}

	#endregion

	#region DateTime TRanSDate

	private DateTime _trAnSdAte;
	[DebuggerNonUserCode]
	[Column(Storage = "_trAnSdAte", Name = "trans_date", DbType = "datetime")]
	public DateTime TRanSDate
	{
		get
		{
			return _trAnSdAte;
		}
		set
		{
			if (value != _trAnSdAte)
			{
				_trAnSdAte = value;
				OnPropertyChanged("TRanSDate");
			}
		}
	}

	#endregion

	#region int TRanSID

	private int _trAnSid;
	[DebuggerNonUserCode]
	[Column(Storage = "_trAnSid", Name = "trans_id", DbType = "int", IsPrimaryKey = true, IsDbGenerated = true)]
	public int TRanSID
	{
		get
		{
			return _trAnSid;
		}
		set
		{
			if (value != _trAnSid)
			{
				_trAnSid = value;
				OnPropertyChanged("TRanSID");
			}
		}
	}

	#endregion

	#region string TRanSType

	private string _trAnStYpe;
	[DebuggerNonUserCode]
	[Column(Storage = "_trAnStYpe", Name = "trans_type", DbType = "char(1)")]
	public string TRanSType
	{
		get
		{
			return _trAnStYpe;
		}
		set
		{
			if (value != _trAnStYpe)
			{
				_trAnStYpe = value;
				OnPropertyChanged("TRanSType");
			}
		}
	}

	#endregion

	#region ctor

	public Transactions()
	{
	}

	#endregion

}
