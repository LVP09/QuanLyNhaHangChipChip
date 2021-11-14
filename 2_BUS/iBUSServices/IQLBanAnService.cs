﻿using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.iBUSServices
{
    public interface IQLBanAnService
    {
        public string AddBanAn(BanAn BanAn);
        public string UpdateBanAn(BanAn BanAn);
        public string DeleteBanAn(BanAn BanAn);
        public List<BanAn> GetTablesFromDB();
        public string AddFloor(Floor Floor);
        public string UpdateFloor(Floor Floor);
        public string DeleteFloor(Floor Floor);
        public List<Floor> GetFloorsFromDB();
        public List<BanAn> LoadBanlist();
    }
}