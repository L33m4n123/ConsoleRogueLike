//
//  Author:
//    Patrick 'Leeman' Lehmann lehmann.s.patrick@gmail.com
//
//  Copyright (c) 2016, Leeman
//
//  All rights reserved.
//
//  Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in
//       the documentation and/or other materials provided with the distribution.
//     * Neither the name of the [ORGANIZATION] nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
//  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
//  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
//  A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
//  CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
//  EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
//  PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
//  LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
//  NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//
using System;
using System.Collections.Generic;

namespace ConsoleRogueLike
{
    /// <summary>
    /// Keeps a Log of all the Events that happened, so you can
    /// go back and read them like a diary. However it'll only
    /// display the last ~3 (Subject to change upon building the Game Screen)
    /// Messages on your Screen in the Main game Screen
    /// </summary>
    public class Log
    {
        
        #region private Fields
        static Log _instance;
        List<String> _logList;
        #endregion

        #region

        public static Log Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Log();
                return _instance;
            }
        }

        public List<String> LogList
        {
            get
            {
                return this._logList;
            }                
        }

        #endregion

        public Log()
        {
            // TODO: initialize the log
            this._logList = new List<String>();
        }

        public void AddLog(String log)
        {
            _logList.Add(log);
        }

        public List<String> GetCompleteLog()
        {
            return _logList;
        }

        public List<String> GetLastEntrys(int ammount)
        {
            return _logList.GetRange(_logList.Count - ammount, ammount);
        }
    }
}

