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

namespace ConsoleRogueLike
{
    // Name Idea blatanly copied from Quill18. Ch(aracter p)ixel
    public class Chixel
    {
        char _character;
        ConsoleColor _fg_color;
        ConsoleColor _bg_color;

        public char Character
        {
            get
            {
                return _character;
            }
            set
            { 
                if (this._character != value)
                {
                    this._character = value;
                    this.HasChanged = true;
                }

            }
        }

        public ConsoleColor ForegroundColor
        {
            get
            {
                return _fg_color;
            }
            set
            { 
                if (this._fg_color != value)
                {
                    this._fg_color = value;
                    this.HasChanged = true;
                }

            }
        }

        public ConsoleColor BackgroundColor
        {
            get
            {
                return _bg_color;
            }
            set
            { 
                if (this._bg_color != value)
                {
                    this._bg_color = value;
                    this.HasChanged = true;
                }

            }
        }

        public bool HasChanged { get; private set; }

        public Chixel(char character, ConsoleColor fg_color, ConsoleColor bg_color)
        {
            this.Character = character;
            this.ForegroundColor = fg_color;
            this.BackgroundColor = bg_color;
        }
    }
}