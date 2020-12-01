using System;
using System.Numerics;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Data;

//namespace Spacecraft
//{
//    public class SpaceCraft : INotifyPropertyChanged
//    {
//        //vehile info
//        private int vehicle_id = -1;
//        private string vehicleName = String.Empty;
//        private int orbit_Info = -1;
//        private string vehicle_Stat = String.Empty;
//        //vehicle telemetry
//        private int vehicle_Altitude = -1;
//        private int vehicle_Longitude = -1;
//        private int vehicle_Latitude = -1;
//        private int vehicle_Temperature = -1;
//        private int vehicle_Time_to_Orbit = -1;


//        //payload info
//        private int payload_id = -1;
//        private string payloadName = String.Empty;
//        private string payloadType = String.Empty;
//        private string payload_Stat = String.Empty;
//        private string payloadData = String.Empty;
//        //payload telemetry
//        private int payload_Altitude = -1;
//        private int payload_Longitude = -1;
//        private int payload_Latitude = -1;
//        private int payload_Temperature = -1;
//        private int payload_Time_to_Orbit = -1;

//        public event PropertyChangedEventHandler PropertyChanged;

//        // This method is called by the Set accessor of each property.
//        // The CallerMemberName attribute that is applied to the optional propertyName
//        // parameter causes the property name of the caller to be substituted as an argument.
//        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
//        {
//            if (PropertyChanged != null)
//            {
//                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
//            }
//        }


//        //constructor for DSN(enforce the factory pattern)
//        private SpaceCraft() {
//            //DSN keep all memeber default
//        }
//        private static SpaceCraft CreateNewSC_DSN() {
//            return new SpaceCraft();
//        }

//        //constructor for real space craft(enforce the factory pattern)
//        private SpaceCraft(int i) {
//            vehicle_id = i;
//            vehicleName = "Vehicle" + i.ToString();
//            Random rnd1 = new Random();
//            int tempNum = rnd1.Next(2);
//            orbit_Info = rnd1.Next(160, 2000);
//            vehicle_Stat = "Waiting for launching";
//            vehicle_Altitude = 0;
//            vehicle_Longitude = 28;
//            vehicle_Latitude = 80;
//            vehicle_Temperature = 75;
//            vehicle_Time_to_Orbit = (orbit_Info / 3600) + 10;//in second

//            payload_id = i;
//            payloadName = "Payload" + i.ToString();
//            rnd1 = new Random();
//            tempNum = rnd1.Next(3);
//            if (tempNum == 0)
//            {
//                payloadType = "Scientific";
//                payloadData = "%Rain: " + rnd1.Next(100).ToString() + " %Humidity: " + rnd1.Next(100).ToString() + " %Snow: " + rnd1.Next(100).ToString();//update every 60s
//            }
//            else if (tempNum == 1)
//            {
//                payloadType = "Communication";
//                payloadData = "Uplink: " + rnd1.Next(100).ToString() + "Mbps" + " Downlink: " + rnd1.Next(50).ToString() + "Mbps";//update every 5s
//            }
//            else
//            {
//                payloadType = "Spy";
//                payloadData = "Image" + rnd1.Next(20).ToString() + ".jpg";//update every 10s
//            }
//            payload_Stat = "Undeployed";
//            payload_Altitude = 0;
//            payload_Longitude = 28;
//            payload_Latitude = 80;
//            payload_Temperature = 75;
//            payload_Time_to_Orbit = (orbit_Info / 3600) + 10;//in second


//        }
//        public int Vehicle_id
//        {
//            get
//            {
//                return this.vehicle_id;
//            }

//            set
//            {
//                if (value != this.vehicle_id)
//                {
//                    this.vehicle_id = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public string VehicleName
//        {
//            get
//            {
//                return this.vehicleName;
//            }

//            set
//            {
//                if (value != this.vehicleName)
//                {
//                    this.vehicleName = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Orbit_Info
//        {
//            get
//            {
//                return this.orbit_Info;
//            }

//            set
//            {
//                if (value != this.orbit_Info)
//                {
//                    this.orbit_Info = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public string Vehicle_Stat
//        {
//            get
//            {
//                return this.vehicle_Stat;
//            }

//            set
//            {
//                if (value != this.vehicle_Stat)
//                {
//                    this.vehicle_Stat = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Vehicle_Altitude
//        {
//            get
//            {
//                return this.vehicle_Altitude;
//            }

//            set
//            {
//                if (value != this.vehicle_Altitude)
//                {
//                    this.vehicle_Altitude = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Vehicle_Longitude
//        {
//            get
//            {
//                return this.vehicle_Longitude;
//            }

//            set
//            {
//                if (value != this.vehicle_Longitude)
//                {
//                    this.vehicle_Longitude = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Vehicle_Latitude
//        {
//            get
//            {
//                return this.vehicle_Latitude;
//            }

//            set
//            {
//                if (value != this.vehicle_Latitude)
//                {
//                    this.vehicle_Latitude = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Vehicle_Temperature
//        {
//            get
//            {
//                return this.vehicle_Temperature;
//            }

//            set
//            {
//                if (value != this.vehicle_Temperature)
//                {
//                    this.vehicle_Temperature = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Vehicle_Time_to_Orbit
//        {
//            get
//            {
//                return this.vehicle_Time_to_Orbit;
//            }

//            set
//            {
//                if (value != this.vehicle_Time_to_Orbit)
//                {
//                    this.vehicle_Time_to_Orbit = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Payload_id
//        {
//            get
//            {
//                return this.payload_id;
//            }

//            set
//            {
//                if (value != this.payload_id)
//                {
//                    this.payload_id = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public string PayloadName
//        {
//            get
//            {
//                return this.payloadName;
//            }

//            set
//            {
//                if (value != this.payloadName)
//                {
//                    this.payloadName = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public string PayloadType
//        {
//            get
//            {
//                return this.payloadType;
//            }

//            set
//            {
//                if (value != this.payloadType)
//                {
//                    this.payloadType = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public string Payload_Stat
//        {
//            get
//            {
//                return this.payload_Stat;
//            }

//            set
//            {
//                if (value != this.payload_Stat)
//                {
//                    this.payload_Stat = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public string PayloadData
//        {
//            get
//            {
//                return this.payloadData;
//            }

//            set
//            {
//                if (value != this.payloadData)
//                {
//                    this.payloadData = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Payload_Altitude
//        {
//            get
//            {
//                return this.payload_Altitude;
//            }

//            set
//            {
//                if (value != this.payload_Altitude)
//                {
//                    this.payload_Altitude = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Payload_Longitude
//        {
//            get
//            {
//                return this.payload_Longitude;
//            }

//            set
//            {
//                if (value != this.payload_Longitude)
//                {
//                    this.payload_Longitude = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Payload_Latitude
//        {
//            get
//            {
//                return this.payload_Latitude;
//            }

//            set
//            {
//                if (value != this.payload_Latitude)
//                {
//                    this.payload_Latitude = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Payload_Temperature
//        {
//            get
//            {
//                return this.payload_Temperature;
//            }

//            set
//            {
//                if (value != this.payload_Temperature)
//                {
//                    this.payload_Temperature = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//        public int Payload_Time_to_Orbit
//        {
//            get
//            {
//                return this.payload_Time_to_Orbit;
//            }

//            set
//            {
//                if (value != this.payload_Time_to_Orbit)
//                {
//                    this.payload_Time_to_Orbit = value;
//                    NotifyPropertyChanged();
//                }
//            }
//        }
//    }
//}
public class SpaceCraft : INotifyPropertyChanged
{
    //vehile info
    private int vehicle_id = -1;
    private string vehicleName = String.Empty;
    private int orbit_Info = -1;
    private string vehicle_Stat = String.Empty;
    //vehicle real data
    private int vehicle_Altitude1 = -1;
    private int vehicle_Longitude1 = -1;
    private int vehicle_Latitude1 = -1;
    private int vehicle_Temperature1 = -1;
    private int vehicle_Time_to_Orbit1 = -1;
    //vehicle telemetry
    private int vehicle_Altitude = -1;
    private int vehicle_Longitude = -1;
    private int vehicle_Latitude = -1;
    private int vehicle_Temperature = -1;
    private int vehicle_Time_to_Orbit = -1;


    //payload info
    private int payload_id = -1;
    private string payloadName = String.Empty;
    private string payloadType = String.Empty;
    private string payload_Stat = String.Empty;
    private string payloadData = String.Empty;
    //payload real data
    private string payloadData1 = String.Empty;
    private int payload_Altitude1 = -1;
    private int payload_Longitude1 = -1;
    private int payload_Latitude1 = -1;
    private int payload_Temperature1 = -1;
    private int payload_Time_to_Orbit1 = -1;
    //payload telemetry
    private int payload_Altitude = -1;
    private int payload_Longitude = -1;
    private int payload_Latitude = -1;
    private int payload_Temperature = -1;
    private int payload_Time_to_Orbit = -1;

    public event PropertyChangedEventHandler PropertyChanged;

    // This method is called by the Set accessor of each property.
    // The CallerMemberName attribute that is applied to the optional propertyName
    // parameter causes the property name of the caller to be substituted as an argument.
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    //constructor for DSN(enforce the factory pattern)
    private SpaceCraft()
    {
        //DSN keep all memeber default
    }
    public static SpaceCraft CreateNewSC_DSN()
    {
        return new SpaceCraft();
    }

    //constructor for real space craft(enforce the factory pattern)
    private SpaceCraft(int i)
    {
        vehicle_id = i;
        vehicleName = "Vehicle" + i.ToString();
        Random rnd1 = new Random();
        int tempNum;
        orbit_Info = rnd1.Next(160, 2000);
        vehicle_Stat = "Waiting for launching";
        vehicle_Altitude1 = 0;
        vehicle_Longitude1 = 28;
        vehicle_Latitude1 = 80;
        vehicle_Temperature1 = 75;
        vehicle_Time_to_Orbit1 = (orbit_Info / 3600) + 10;//in second

        payload_id = i;
        payloadName = "Payload" + i.ToString();
        rnd1 = new Random();
        tempNum = rnd1.Next(3);
        if (tempNum == 0)
        {
            payloadType = "Scientific";
            payloadData1 = "%Rain: " + rnd1.Next(100).ToString() + " %Humidity: " + rnd1.Next(100).ToString() + " %Snow: " + rnd1.Next(100).ToString();//update every 60s
        }
        else if (tempNum == 1)
        {
            payloadType = "Communication";
            payloadData1 = "Uplink: " + rnd1.Next(100).ToString() + "Mbps" + " Downlink: " + rnd1.Next(50).ToString() + "Mbps";//update every 5s
        }
        else
        {
            payloadType = "Spy";
            payloadData1 = "Image" + rnd1.Next(20).ToString() + ".jpg";//update every 10s
        }
        payload_Stat = "Undeployed";
        payload_Altitude1 = 0;
        payload_Longitude1 = 28;
        payload_Latitude1 = 80;
        payload_Temperature1 = 75;
        payload_Time_to_Orbit1 = (orbit_Info / 3600) + 10;//in second

    }
    public static SpaceCraft CreateNewSC(int i)
    {
        return new SpaceCraft(i);
    }
    public int Vehicle_id
    {
        get
        {
            return this.vehicle_id;
        }

        set
        {
            if (value != this.vehicle_id)
            {
                this.vehicle_id = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string VehicleName
    {
        get
        {
            return this.vehicleName;
        }

        set
        {
            if (value != this.vehicleName)
            {
                this.vehicleName = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Orbit_Info
    {
        get
        {
            return this.orbit_Info;
        }

        set
        {
            if (value != this.orbit_Info)
            {
                this.orbit_Info = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string Vehicle_Stat
    {
        get
        {
            return this.vehicle_Stat;
        }

        set
        {
            if (value != this.vehicle_Stat)
            {
                this.vehicle_Stat = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Altitude
    {
        get
        {
            return this.vehicle_Altitude;
        }

        set
        {
            if (value != this.vehicle_Altitude)
            {
                this.vehicle_Altitude = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Longitude
    {
        get
        {
            return this.vehicle_Longitude;
        }

        set
        {
            if (value != this.vehicle_Longitude)
            {
                this.vehicle_Longitude = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Latitude
    {
        get
        {
            return this.vehicle_Latitude;
        }

        set
        {
            if (value != this.vehicle_Latitude)
            {
                this.vehicle_Latitude = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Temperature
    {
        get
        {
            return this.vehicle_Temperature;
        }

        set
        {
            if (value != this.vehicle_Temperature)
            {
                this.vehicle_Temperature = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Time_to_Orbit
    {
        get
        {
            return this.vehicle_Time_to_Orbit;
        }

        set
        {
            if (value != this.vehicle_Time_to_Orbit)
            {
                this.vehicle_Time_to_Orbit = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Altitude1
    {
        get
        {
            return this.vehicle_Altitude1;
        }

        set
        {
            if (value != this.vehicle_Altitude1)
            {
                this.vehicle_Altitude1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Longitude1
    {
        get
        {
            return this.vehicle_Longitude1;
        }

        set
        {
            if (value != this.vehicle_Longitude1)
            {
                this.vehicle_Longitude1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Latitude1
    {
        get
        {
            return this.vehicle_Latitude1;
        }

        set
        {
            if (value != this.vehicle_Latitude1)
            {
                this.vehicle_Latitude1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Temperature1
    {
        get
        {
            return this.vehicle_Temperature1;
        }

        set
        {
            if (value != this.vehicle_Temperature1)
            {
                this.vehicle_Temperature1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Vehicle_Time_to_Orbit1
    {
        get
        {
            return this.vehicle_Time_to_Orbit1;
        }

        set
        {
            if (value != this.vehicle_Time_to_Orbit1)
            {
                this.vehicle_Time_to_Orbit1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_id
    {
        get
        {
            return this.payload_id;
        }

        set
        {
            if (value != this.payload_id)
            {
                this.payload_id = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string PayloadName
    {
        get
        {
            return this.payloadName;
        }

        set
        {
            if (value != this.payloadName)
            {
                this.payloadName = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string PayloadType
    {
        get
        {
            return this.payloadType;
        }

        set
        {
            if (value != this.payloadType)
            {
                this.payloadType = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string Payload_Stat
    {
        get
        {
            return this.payload_Stat;
        }

        set
        {
            if (value != this.payload_Stat)
            {
                this.payload_Stat = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string PayloadData
    {
        get
        {
            return this.payloadData;
        }

        set
        {
            if (value != this.payloadData)
            {
                this.payloadData = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Altitude
    {
        get
        {
            return this.payload_Altitude;
        }

        set
        {
            if (value != this.payload_Altitude)
            {
                this.payload_Altitude = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Longitude
    {
        get
        {
            return this.payload_Longitude;
        }

        set
        {
            if (value != this.payload_Longitude)
            {
                this.payload_Longitude = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Latitude
    {
        get
        {
            return this.payload_Latitude;
        }

        set
        {
            if (value != this.payload_Latitude)
            {
                this.payload_Latitude = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Temperature
    {
        get
        {
            return this.payload_Temperature;
        }

        set
        {
            if (value != this.payload_Temperature)
            {
                this.payload_Temperature = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Time_to_Orbit
    {
        get
        {
            return this.payload_Time_to_Orbit;
        }

        set
        {
            if (value != this.payload_Time_to_Orbit)
            {
                this.payload_Time_to_Orbit = value;
                NotifyPropertyChanged();
            }
        }
    }
    public string PayloadData1
    {
        get
        {
            return this.payloadData1;
        }

        set
        {
            if (value != this.payloadData1)
            {
                this.payloadData1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Altitude1
    {
        get
        {
            return this.payload_Altitude1;
        }

        set
        {
            if (value != this.payload_Altitude1)
            {
                this.payload_Altitude1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Longitude1
    {
        get
        {
            return this.payload_Longitude1;
        }

        set
        {
            if (value != this.payload_Longitude1)
            {
                this.payload_Longitude1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Latitude1
    {
        get
        {
            return this.payload_Latitude1;
        }

        set
        {
            if (value != this.payload_Latitude1)
            {
                this.payload_Latitude1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Temperature1
    {
        get
        {
            return this.payload_Temperature1;
        }

        set
        {
            if (value != this.payload_Temperature1)
            {
                this.payload_Temperature1 = value;
                NotifyPropertyChanged();
            }
        }
    }
    public int Payload_Time_to_Orbit1
    {
        get
        {
            return this.payload_Time_to_Orbit1;
        }

        set
        {
            if (value != this.payload_Time_to_Orbit1)
            {
                this.payload_Time_to_Orbit1 = value;
                NotifyPropertyChanged();
            }
        }
    }
}