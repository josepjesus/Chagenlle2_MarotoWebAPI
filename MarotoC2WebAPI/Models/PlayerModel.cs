using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MarotoC2WebAPI.Models
{
    public class PlayerModel
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nickname;
        public string Nickname
        {
            get { return _nickname; }
            set { _nickname = value; }
        }

        private string _date;
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}