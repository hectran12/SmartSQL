using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSQL
{
    internal class sqllocaldb
    {
        static utils support = new utils();
        // get al instance in sqllocaldb
        public List<instance> getAllInstances()
        {
            List<instance> instances = new List<instance>();
            string res = support.ExecuteCommandToCMD("sqllocaldb i");
            foreach (string dbInstanceName in res.Split("\n"))
            {
                if (dbInstanceName == "") continue;
                instance objInstance = getInstanceInfo(dbInstanceName);
                instances.Add(objInstance);
            }

            return instances;
        }

        public bool deleteInstance (string instanceName)
        {
            // Message delete success: LocalDB instance "name_instace" deleted.
            string res = support.ExecuteCommandToCMD("sqllocaldb delete \"" + instanceName + "\"");
            if (res.Contains("LocalDB instance") && res.Contains("deleted"))
            {
                return true;
            }
            return false;
        }

        public bool createNewInstance (string instanceName)
        {
            string res = support.ExecuteCommandToCMD("sqllocaldb create \"" + instanceName + "\"");
            if (res.Contains("LocalDB instance") && res.Contains("created with version"))
            {
                return true;
            }
            return false;
        }

        public bool stopInstance (string instanceName)
        {
            // Message stop success: LocalDB instance "name_instance" stopped.
            string res = support.ExecuteCommandToCMD("sqllocaldb stop \"" + instanceName + "\"");

            if (res.Contains("LocalDB instance") && res.Contains("stopped"))
            {
                return true;
            }

            return false;

        }

        public bool startInstance (string instanceName)
        {
            // Message start instance: LocalDB instance "name_instance" started.
            string res = support.ExecuteCommandToCMD("sqllocaldb start \"" + instanceName + "\"");
            if (res.Contains("LocalDB instance") && res.Contains("started"))
            {
                return true;
            }

            return false;
        }

        public instance getInstanceInfo(string instanceName)
        {
            string res = support.ExecuteCommandToCMD("sqllocaldb i \"" + instanceName + "\"");
            instance obj = new instance();
            bool isValidInstance = false;

            // if instance automatic created by system
            if (res.Contains("The automatic instance") && res.Contains("is not created."))
            {
                obj.nameInstance = instanceName;
                obj.Owner = "Automatic created cannot get info";
                obj.lastStartTime = DateTime.Now;
                obj.state = "Automatic created cannot get info";
                obj.sharedName = instanceName;
                obj.autoCreated = true;
                obj.version = "Automatic created cannot get info";
                isValidInstance = true;
            } else
            {
               
                // parse string to obj instance
                foreach (string curValue in res.Split("\n"))
                {
                    if (curValue == "") continue;
                    if (curValue.Contains("Name")) obj.nameInstance = curValue.Split("Name:")[1].Trim();
                    if (curValue.Contains("Version")) obj.version = curValue.Split("Version:")[1].Trim();
                    if (curValue.Contains("Shared name:")) obj.sharedName = curValue.Split("Shared name:")[1].Trim();
                    if (curValue.Contains("Owner:")) obj.Owner = curValue.Split("Owner:")[1].Trim();
                    if (curValue.Contains("Auto-create:"))
                    {
                        string statusAutoCreated = curValue.Split("Auto-create:")[1].Trim();
                        if (statusAutoCreated == "No") obj.autoCreated = false;
                        else obj.autoCreated = true;
                        isValidInstance = true;
                    }
                    if (curValue.Contains("State:")) obj.state = curValue.Split("State:")[1].Trim();
                    if (curValue.Contains("Last start time:"))
                    {
                        string timeString = curValue.Split("Last start time:")[1].Trim();
                        DateTime dateTime = DateTime.ParseExact(timeString, "dd/MM/yyyy h:mm:ss tt",
                                                new CultureInfo("vi-VN"),
                                                DateTimeStyles.None);

                        obj.lastStartTime = dateTime;
                    }

                    if (curValue.Contains("Instance pipe name:")) obj.instancePipeName = curValue.Split("Instance pipe name:")[1].Trim();
                }
            }
            if (isValidInstance) return obj;
            obj.nameInstance = "ERR_TO_FETCH_INFO";
            return obj;
        }

        

    }
}
