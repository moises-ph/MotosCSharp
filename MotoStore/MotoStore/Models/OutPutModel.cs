using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MotoStore.Models;
using System.Data.SqlClient;

namespace MotoStore.Data
{
    public class OutPutModel
    {
        public bool Error { get; set; }
        public string Message { get; set; }
    }
}