﻿// This file is part of CycloneDX Library for .NET
//
// Licensed under the Apache License, Version 2.0 (the “License”);
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an “AS IS” BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SPDX-License-Identifier: Apache-2.0
// Copyright (c) OWASP Foundation. All Rights Reserved.

using System.Xml.Serialization;

namespace CycloneDX.Models.v1_2
{

    public class LicenseChoice
    {
        [XmlElement("license")]
        public License License { get; set; }
        [XmlElement("expression")]
        public string Expression { get; set; }

        public LicenseChoice() {}

        public LicenseChoice(v1_1.LicenseChoice licenseChoice)
        {
            if (licenseChoice.License != null)
            {
                License = new License(licenseChoice.License);
            }
            else if (licenseChoice.Expression != null)
            {
                Expression = licenseChoice.Expression;
            }
        }

        public LicenseChoice(v1_3.LicenseChoice licenseChoice)
        {
            if (licenseChoice.License != null)
            {
                License = new License(licenseChoice.License);
            }
            else if (licenseChoice.Expression != null)
            {
                Expression = licenseChoice.Expression;
            }
        }
    }
}
