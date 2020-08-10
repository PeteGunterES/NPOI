﻿/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
==================================================================== */
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
    public abstract class StringValue : Value
    {
        // ElectricSquare: 'new' added to decalare intention to hide base implementation
        public new CellType GetType()
        {
            return CellType.String;
        }
        //We cannot introduce a new type CellType.RICH_TEXT because the types are public so we have to make rich text as a type of string
        public abstract bool IsRichText(); // using the POI style which seems to avoid "instanceof".
    }
}
