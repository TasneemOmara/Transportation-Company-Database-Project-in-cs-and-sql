using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
        public int CheckPassword_Basic(string username, string password)
        {

            //Query the DB to check for username/password
            string query = "SELECT Privelege from Login where User_Name = '" + username + "' and Password='" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return Convert.ToInt32(p);
        }

        public int SignUp_newUser(string User, string password, int priv)
        {
            string query = " SELECT User_Name from Login Where User_Name = '" + User + "' ";
            object check = dbMan.ExecuteScalar(query);
            if (check == null)
            {
                string query_add = "INSERT INTO Login (User_Name, Password, Privelege) VALUES (" +
                    "'" + User + "', " +
                    "'" + password + "', " +
                    "" + priv + ")";
                return dbMan.ExecuteNonQuery(query_add);
            }
            else {
                return -1;
            }
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        //By-Zidan
        public int AddPaidMoney(decimal Money)
        {
            string query = "UPDATE Department " +
                "SET Sales = Sales + " + Money +
                "WHERE Name = 'Finance' ";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetReservedSeats(int number)
        {
            string query = "select Seats "
                + "from Busses "
                + "where Number = " + number;
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetTrackPrice(int id)
        {
            string query = "Select Price "
                + "from Tracks "
                + "where ID = " + id;
            return dbMan.ExecuteReader(query);
        }

        public int UpdateTrackPrice(decimal price, int id)
        {
            string query = "UPDATE Tracks "
                + "SET Price = " + price
                + "where ID = " + id;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetCustomerData(int phone)
        {
            string query = "Select Phone, Fname, Lname, Frequency, Promo_Codes "
                + "From Customer "
                + "Where Phone = " + phone;
            return dbMan.ExecuteReader(query);
        }

        public int UpdatePromo(string promo, int phone)
        {
            string query = "UPDATE Customer "
                + "SET Promo_Codes = '" + promo + "'"
                + "where phone = " + phone;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetTrackData(int id)
        {
            string query = "Select ID, Departure_Time, Price "
                + "From Tracks "
                + "Where ID = " + id;
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDepartureTime(int id)
        {
            string query = "Select Departure_Time "
                + "From Tracks "
                + "Where ID = " + id;
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetCustomerDataWithFrequency(int frequency, int radio)
        {
            string query = null;
            if (radio == 2)
            {
                query = "Select Phone, Fname, Lname "
                + "From Customer "
                + "Where Frequency = " + frequency;
            }
            else if (radio == 1)
            {
                query = "Select Phone, Fname, Lname "
                    + "From Customer "
                    + "Where Frequency > " + frequency;
            }
            else if (radio == 3)
            {
                query = "Select Phone, Fname, Lname "
                    + "From Customer "
                    + "Where Frequency < " + frequency;
            }
            return dbMan.ExecuteReader(query);

        }

        public DataTable GetEmployeeData(string fname)
        {
            string query = "Select SSN, Fname, Lname, Address, Gender, Salary, Dno, Super_SSN "
                + "From Employee "
                + "Where Fname = '" + fname + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDepartureByName(string fname, string lname)
        {
            string query = "Select Departure_Time "
                + "From Employee as E, Drives as D , Busses as B , [Tracks Busses Relation] as TBR, Tracks as T "
                + "Where E.Fname = '" + fname + "' and E.Lname = '" + lname + "' and E.SSN = D.Driver_SSN and D.Bus_Number = B.Number "
                + " and B.Number = TBR.Bus_Number and TBR.Track_ID = T.ID ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetScheduleByName(string fname,  string lname)
        {
            string query = " Select TSR.Station_Location , TSR.Track_ID , TSR.[Order] , TSR.Arrival_Time "
                + " From Employee as E, Drives as D , Busses as B , [Tracks Busses Relation] as TBR, Tracks as T , [Track Station Relation] as TSR "
                + " Where E.Fname = '" + fname + "' and E.Lname = '" + lname + "' and E.SSN = D.Driver_SSN and D.Bus_Number = B.Number "
                + " and B.Number = TBR.Bus_Number and TBR.Track_ID = T.ID and T.ID = TSR.Track_ID "
                + " Order By TSR.[Order] ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable CheckBoardingPass(int boarding_pass , string fname , string lname)
        {
            string query = "Select R.Boarding_Pass "
                + " From Employee as E ,  Drives as D , Busses as B , Rides as R "
                + " Where E.Fname = '" + fname + "' and E.Lname = '" + lname + "' and E.SSN = D.Driver_SSN and D.Bus_Number = B.Number "
                + " and B.Number = R.Bus_Num and R.Boarding_Pass = " + boarding_pass ;
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetReservedSeatsByName(string fname , string lname)
        {
            string query = "Select B.Seats "
                + "From Employee as E, Drives as D , Busses as B "
                + "Where E.Fname = '" + fname + "' and E.Lname = '" + lname + "' and E.SSN = D.Driver_SSN and D.Bus_Number = B.Number ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetStationArrivalTime(string location)
        {
            string query = "Select TSR.Arrival_Time "
                + "From Stations as S , [Track Station Relation] as TSR "
                + "Where S.Location = '" + location + "' and S.Location = TSR.Station_Location ";
            return dbMan.ExecuteReader(query);
        }


        public int SearchForCustomerByNumber(int phone)
        {
            string query = "INSERT INTO Customer (Phone) VALUES ("
                            + phone
                            + ")";

            //failed to insert (already a customer)
            if (dbMan.ExecuteNonQuery(query) == 0)
            {
                return 0;
            }

            //not a customer, should signup
            else
            {
                query = "Delete From Customer Where Phone = "
                            + phone
                            + "";
                dbMan.ExecuteNonQuery(query);
                return 1;
            }
        }

        public int CustomerSignUp(int phone, string fn, string ln)
        {
            string query = "INSERT INTO Customer (Phone, Fname, Lname) VALUES (" +
                "" + phone + " , " +
                "'" + fn + "' , " +
                "'" + ln + "'"
                + ")";

            //failed to insert (already a customer)
            if (dbMan.ExecuteNonQuery(query) == 0)
            {
                return 0;
            }

            else
            {
                return 1;
            }
        }

        public DataTable TracksSearchByDate(DateTime searchdate)
        {
            string query = "SELECT [Track_ID], [Order], [Station_Location], [Price], [Departure_Time], [Arrival_Time] FROM Tracks INNER JOIN [Track Station Relation] ON [Tracks].[ID] = [Track Station Relation].[Track_ID] WHERE Convert(DATE, Departure_Time) = '" + searchdate + "'" + "Order by ID ASC, [Order] ASC";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SearchRoutes(DateTime searchdate ,string pickup, string dropoff)
        {
            string query = "SELECT * FROM (SELECT [Track_ID], [Order], [Station_Location], [Price], [Departure_Time], [Arrival_Time] FROM Tracks INNER JOIN [Track Station Relation] ON [Tracks].[ID] = [Track Station Relation].[Track_ID] WHERE Convert(DATE, Departure_Time) = '" + searchdate + "') AS NarrowedDown WHERE [Station_Location] = '" + dropoff + "' AND [Order] > 1";
            return dbMan.ExecuteReader(query);
        }

        public DataTable NarrowDownOptionsByDate(DateTime searchdate)
        {
            string query = "Select Distinct [Station_Location] From [Track Station Relation] WHERE Convert(DATE, [Arrival_Time]) = '" + searchdate + "'";
            return dbMan.ExecuteReader(query);
        }



        public DataTable CheckSeats(int TrackID)
        {
            string query = "Select [Seats] from [Busses] WHERE [Number] = (Select [Bus_Number] From [Tracks Busses Relation] WHERE [Track_ID] = " + TrackID + ")";
            return dbMan.ExecuteReader(query);
        }

        public int BookRide(int TrackID, int CustomerNumber)
        {
            string query = "Insert Into [Rides] ([Bus_Num], [Customer_Phone])"
                         + "Values "
                         + "((Select[Bus_Number] From[Tracks Busses Relation] WHERE[Track_ID] = " + TrackID + "),"  + CustomerNumber + ")";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable GetBoardingPass(int CustomerNumber)
        {
            string query = "Select [Boarding_Pass] From [Rides] WHERE [Customer_Phone] = " + CustomerNumber + "";
            return dbMan.ExecuteReader(query);
        }

        public int IfBookedBefore(int CustomerNumber)
        {
            string query = "Select [Boarding_Pass] From [Rides] WHERE [Customer_Phone] =" + CustomerNumber + "";
            DataTable dtBP = dbMan.ExecuteReader(query);

            if (dtBP == null)
                return 0;

            else
                return int.Parse(dtBP.Rows[0][0].ToString());
        }


        public int PreviousPromoChecker(int CustomerNumber)
        {
            string query = "Select [Promo_Codes] From [Customer] WHERE [Phone] =" + CustomerNumber + "";
            DataTable dtpc = dbMan.ExecuteReader(query);

            string check = (dtpc.Rows[0][0].ToString());
            if (string.IsNullOrWhiteSpace(check))
                return 0;

            else
                return 1;
        }

        public void UpdateUserPromo(string newpromo, int CustomerNumber)
        {
            string query = "UPDATE [Customer] Set [Promo_Codes] = '" + newpromo + "' Where [Phone] =" + CustomerNumber + "";
            dbMan.ExecuteReader(query);
        }

        public DataTable GetCustomerNameByPhone(int CustomerNumber)
        {
            string query = "Select [Fname] From [Customer] WHERE [Phone] = " + CustomerNumber + "";
            return dbMan.ExecuteReader(query);
        }




        //Tasneem

        public DataTable SelectDepNum_and_Name()
        {
            string query = "SELECT ID,Name FROM Department;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmp_SSN()
        {
            string query = "SELECT SSN FROM Employee;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable SelectAllEmp()
        {
            string query = "SELECT * FROM Employee;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmp_fromSSN(long ssn)
        {
            string query = "SELECT * FROM Employee Where SSN=" + ssn;
            return dbMan.ExecuteReader(query);
        }

        public int InsertEmployee(long ssn, string fname, string lname, string address, string Gender, double salary, int dno, long super_ssn)
        {
            string query = "INSERT INTO Employee (SSN, Fname, Lname, Address, Gender, Salary, Dno, Super_SSN) VALUES (" +
                "" + ssn + "," +
                "'" + fname + "'," +
                "'" + lname + "'," +
                "'" + address + "'," +
                "'" + Gender + "'," +
                "" + salary + "," +
                "" + dno + "," +
                "" + super_ssn + ""
                + ")";

            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteEmployee(long ssn)
        {
            string query = "DELETE FROM Employee WHERE SSN=" + ssn;
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateEmployee(long ssn, string fname, string lname, string address, string Gender, double salary, int dno, long super_ssn)
        {
            string query = "UPDATE Employee SET " +
                "Fname='" + fname + "'," +
                "Lname='" + lname + "'," +
                "Address='" + address + "'," +
                "Gender='" + Gender + "'," +
                "Salary=" + salary + "," +
                "Dno=" + dno + "," +
                "Super_SSN=" + super_ssn +
                "WHERE SSN=" + ssn;
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectMonthsFromFinance()
        {
            string query = "SELECT Month FROM Finances";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectExpenses(int Month)
        {
            string query = "SELECT Expenses FROM Finances WHERE Month=" + Month;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectSales(int Month)
        {
            string query = "SELECT Sales FROM Finances WHERE Month=" + Month;
            return dbMan.ExecuteReader(query);
        }

        public int AddExpenses(int month, double expenses)
        {
            string query = "UPDATE Finances SET " + "Expenses=" + expenses + "WHERE Month=" + month;

            return dbMan.ExecuteNonQuery(query);
        }

        public int AddSales(int month, double sales)
        {
            string query = "UPDATE Finances SET " + "Sales=" + sales + "WHERE Month=" + month;

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectAllTracks()
        {
            string query = "SELECT * FROM Tracks, Busses, Stations, [Tracks Busses Relation] as TBR, [Track Station Relation] as TSR" +
            " WHERE Number = Bus_Number and TBR.Track_ID = ID and TSR.Station_Location  = Location";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectAllTracksBusses()
        {
            string query = "SELECT * FROM Tracks, Busses, [Tracks Busses Relation] " +
            " WHERE Number = Bus_Number and Track_ID = ID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectTracksID()
        {
            string query = "SELECT ID FROM Tracks;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectBussesNum(int TrackID)
        {
            string query = "SELECT Number FROM Busses, [Tracks Busses Relation] WHERE Bus_Number = Number and Track_ID= " + TrackID;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectStations(int ID)
        {
            string query = "SELECT Location FROM Stations, Tracks, [Track Station Relation]  WHERE  " +
                " Station_Location = Location and Track_ID = ID and Track_ID="+ ID;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectReservedSeats_TrackID_BusNumber(int ID, long BusNo)
        {
            string query = "Select Seats " +
            " from Busses, Tracks, [Tracks Busses Relation] " +
            " Where Number = Bus_Number and Track_ID = ID and " +
            " ID =" + ID + " and Number =" + BusNo;
            return dbMan.ExecuteReader(query);
        }

        public DataTable Select_DepartureTime_ID(int ID)
        {
            string query = "Select Departure_Time " +
            " from Tracks " +
            " Where ID =" + ID;
            return dbMan.ExecuteReader(query);
        }

        public DataTable Select_ArrivalTime_ID(int ID, string station)
        {
       
            string query = "Select Arrival_Time " +
            " from Tracks, [Track Station Relation] " +
            " Where Track_ID = ID and Station_Location = '" + station + "' and ID = " + ID;
            return dbMan.ExecuteReader(query);
        }

        
    }
}
