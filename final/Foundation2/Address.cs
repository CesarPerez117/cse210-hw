using System;
using Microsoft.VisualBasic;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isInUSA;
    private string _address;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
        _isInUSA = false;
    }

    public void IsInUSA()
    {
        if (_country == "USA")
        {
            _isInUSA = true;
        }
        else
        {
            _isInUSA = false;
        }
    }

    public string GetAddress()
    {   
        //_address = $"{_street}, {_city}, {_state}, {_country}";
        //return _address;
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}