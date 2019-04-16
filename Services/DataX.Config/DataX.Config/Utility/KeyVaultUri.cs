﻿// *********************************************************************
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License
// *********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DataX.Config.Utility
{
   public static class KeyVaultUri
    {
        private static Regex _Reg = new Regex(@"^((keyvault:?):\/\/)?([^:\/\s]+)(\/)(.*)?", RegexOptions.IgnoreCase);

        public static string ComposeUri(string keyvaultName, string secretName)
        {
            return $"keyvault://{keyvaultName}/{secretName}";
        }       

        public static bool IsSecretUri(string str)
        {
            return _Reg.IsMatch(str);
        }
    }
}
