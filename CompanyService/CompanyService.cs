﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService {
        public string GetConfidentialInfo() {
            return "This is public information and available over HTTP to the public";
        }

        public string GetPublicInfo() {
            return "This is confidential info and available over TCP to the company employees";
        }
    }
}
