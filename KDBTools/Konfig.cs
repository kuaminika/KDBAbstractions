using KDBTools.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
namespace KDBTools
{
    public class Konfigs:IKonfig
    {
        private IConfiguration config;
        private string connectionstringName;

        public Konfigs(IConfiguration config)
        {
            this.config = config;
            this.connectionstringName = config["connectionstringName"] ?? "default";
        }

        public string ConnectionString => config.GetConnectionString(this.connectionstringName);

        public int GetIntValue(string v) => int.Parse(this.config[v]);
    }
}
