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
namespace ConsoleGame
{
    /// <summary>
    /// Menu.
    /// 
    /// Do I need to make each possible Menu an object or just a function within this Class that gets initialized upon game start?
    /// </summary>
    public class Menu
    {
        public Menu ()
        {
            Instantiate ("MainMenu", "Options");
        }

        void Instantiate (params String[] menus)
        {
            foreach (String menu in menus)
            {
                //TODO: Add Menu in a Dictionary or smth simliar to call them when neccesary
                //TODO: Shall I do a new Class for each? And change this class name to MenuHandler or smth simliar?
                switch (menu)
                {
                    case "MainMenu":
                    {
                        // TODO: Instantiate Main Menu!
                        break;
                    }
                    case "Options":
                    {
                        //TODO: Instantiate Options Menu!
                        break;
                    }
                }
            }
        }

        public void DisplayMenu()
        {
            // TODO: Send relevant Data to FrameBuffer-Class
        }
    }
}

